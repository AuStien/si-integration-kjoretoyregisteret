using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using KTR.Model;
using Newtonsoft.Json;

namespace KTR.Data
{
    public class VehicleData : IVehicleData
    {
        private string apiKey = "";
        public bool hasAPIKey = false;

        public VehicleData()
        {
            apiKey = Environment.GetEnvironmentVariable("KjoretoyRegisterApiNokkel");
            if (apiKey == null || apiKey == "") {
                Console.Error.WriteLine("Program needs environment key 'KjoretoyRegisterApiNokkel'");
                Environment.Exit(10);
            }   
        }

        // Henter all data fra KjøretøyRegisteret
        public KjoretoyRoot getVehicleByRegisterPlate(string registerPlate)
        {
            return Fetcher.GetVehicle(registerPlate, apiKey);
        }

        // Henter bare relevant data fra KjøretøyRegisteret
        public OutData getCarDescription(string registerPlate)
        {
            KjoretoyRoot ktr = getVehicleByRegisterPlate(registerPlate);
            if (ktr == null) return null;
            OutData result = new OutData(
                getCarBrandByObject(ktr),
                getVehicleTypeByObject(ktr),
                DateTime.Parse(getFirstTimeRegistrationByObject(ktr)),
                getFuelTypeByObject(ktr));

            return result;
        }

        // Returnerer bilmerke
        public string getCarBrandByObject(KjoretoyRoot ktr) {
            try
            {
                return ktr.kjoretoydataListe[0].godkjenning.tekniskGodkjenning.tekniskeData.generelt.merke[0].merke;
            }
            catch
            {
                return "Feil ved henting av merke. Pass på at skiltnummeret er riktig.";
            }
        }

        // Returnerer bilmerke
        public string getVehicleTypeByObject(KjoretoyRoot ktr)
        {
            try
            {
                return ktr.kjoretoydataListe[0].godkjenning.tekniskGodkjenning.kjoretoyklassifisering.beskrivelse;
            }
            catch
            {
                return "Feil ved henting av motorvogntype. Pass på at skiltnummeret er riktig.";
            }
        }

        // Returnerer førstegangsregistrering
        public string getFirstTimeRegistrationByObject(KjoretoyRoot ktr)
        {
            try
            {
                return ktr.kjoretoydataListe[0].forstegangsregistrering.registrertForstegangNorgeDato;
            }
            catch
            {
                return "Feil ved henting av førstegangsregistrering. Pass på at skiltnummeret er riktig.";
            }
        }

        // Returnerer drivstofftype
        public string getFuelTypeByObject(KjoretoyRoot ktr)
        {
            try
            {
                List<List<Drivstoff>> fules = ktr.kjoretoydataListe[0].godkjenning.tekniskGodkjenning.tekniskeData.motorOgDrivverk.motor.Where(m => m.drivstoff != null).Select(m => m.drivstoff).ToList();
                string result = fules
                    .Select(fs => fs.Select(f => f.drivstoffKode.kodeBeskrivelse)
                    .Aggregate((x,y) => x + ", " + y))
                    .Aggregate((x, y) => x + ", " + y);
                return result;
            }
            catch
            {
                return "Feil ved henting av drivstofftype. Pass på at skiltnummeret er riktig.";
            }
        }

        public static class Fetcher
        {
            // Henter kjøretøydata fra APIet til KjøretøyRegisteret
            public static KjoretoyRoot GetVehicle(string registerPlate, string apiKey)
            {
                string endPoint = "https://www.vegvesen.no/ws/no/vegvesen/kjoretoy/felles/datautlevering/enkeltoppslag/kjoretoydata?kjennemerke=";

                string url = string.Format(endPoint + registerPlate);
                WebRequest reqObj = WebRequest.Create(url);
                reqObj.Method = "GET";
                reqObj.Headers.Add("SVV-Authorization:" + apiKey);
                try
                {
                    HttpWebResponse resObj = (HttpWebResponse)reqObj.GetResponse();

                    string result = ""; 
                    using (Stream stream = resObj.GetResponseStream())
                    {
                        StreamReader sr = new StreamReader(stream);
                        result = sr.ReadToEnd();
                        sr.Close();
                    }
                    KjoretoyRoot match = JsonConvert.DeserializeObject<KjoretoyRoot>(result.Trim('[').Trim(']'));
                    return match;
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}
