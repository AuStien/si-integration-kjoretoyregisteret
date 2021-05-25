using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KTR.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class KjoretoyId
    {
        public string kjennemerke { get; set; }
        public string understellsnummer { get; set; }
    }

    public class Forstegangsregistrering
    {
        public string registrertForstegangNorgeDato { get; set; }
    }

    public class Kjennemerketype
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Kjennemerke
    {
        public DateTime fomTidspunkt { get; set; }
        public string kjennemerke { get; set; }
        public string kjennemerkekategori { get; set; }
        public Kjennemerketype kjennemerketype { get; set; }
    }

    public class KjoringensArt
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Registreringsstatus
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Registrering
    {
        public DateTime fomTidspunkt { get; set; }
        public KjoringensArt kjoringensArt { get; set; }
        public Registreringsstatus registreringsstatus { get; set; }
        public DateTime registrertForstegangPaEierskap { get; set; }
    }

    public class Importland
    {
        public string landNavn { get; set; }
        public string landkode { get; set; }
    }

    public class Bruktimport
    {
        public Importland importland { get; set; }
        public int kilometerstand { get; set; }
        public string tidligereUtenlandskKjennemerke { get; set; }
        public string tidligereUtenlandskVognkortNummer { get; set; }
    }

    public class FortollingOgMva
    {
        public string beskrivelse { get; set; }
        public string fortollingsreferanse { get; set; }
        public int linje { get; set; }
    }

    public class Godkjenningsundertype
    {
        public string kodeNavn { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class ForstegangsGodkjenning
    {
        public Bruktimport bruktimport { get; set; }
        public string forstegangRegistrertDato { get; set; }
        public FortollingOgMva fortollingOgMva { get; set; }
        public string godkjenningsId { get; set; }
        public Godkjenningsundertype godkjenningsundertype { get; set; }
        public string gyldigFraDato { get; set; }
        public DateTime gyldigFraDatoTid { get; set; }
        public List<object> unntak { get; set; }
    }

    public class Kjoretoymerknad
    {
        public string merknad { get; set; }
        public string merknadtypeKode { get; set; }
    }

    public class Registreringsbegrensninger
    {
        public List<object> registreringsbegrensning { get; set; }
    }

    public class Typegodkjenningnummer
    {
        public string direktiv { get; set; }
        public string land { get; set; }
        public string serie { get; set; }
        public string utvidelse { get; set; }
    }

    public class EfTypegodkjenning
    {
        public string typegodkjenningNrTekst { get; set; }
        public Typegodkjenningnummer typegodkjenningnummer { get; set; }
        public string variant { get; set; }
        public string versjon { get; set; }
    }

    public class KjoretoyAvgiftsKode
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class NasjonalGodkjenning
    {
        public string nasjonaltGodkjenningsAr { get; set; }
        public string nasjonaltGodkjenningsHovednummer { get; set; }
        public string nasjonaltGodkjenningsUndernummer { get; set; }
    }

    public class TekniskKode
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class TekniskUnderkode
    {
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Kjoretoyklassifisering
    {
        public string beskrivelse { get; set; }
        public EfTypegodkjenning efTypegodkjenning { get; set; }
        public KjoretoyAvgiftsKode kjoretoyAvgiftsKode { get; set; }
        public NasjonalGodkjenning nasjonalGodkjenning { get; set; }
        public string spesielleKjennetegn { get; set; }
        public TekniskKode tekniskKode { get; set; }
        public TekniskUnderkode tekniskUnderkode { get; set; }
        public bool iSamsvarMedTypegodkjenning { get; set; }
    }

    public class Kravomrade
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Kravoppfyllelse
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Krav
    {
        public Kravomrade kravomrade { get; set; }
        public Kravoppfyllelse kravoppfyllelse { get; set; }
    }

    public class Aksel
    {
        public int antallHjul { get; set; }
        public bool drivAksel { get; set; }
        public int fordelingAvTillattTotalvektAkselMaks { get; set; }
        public int fordelingAvTillattTotalvektAkselMin { get; set; }
        public int id { get; set; }
        public int maksimalSporvidde { get; set; }
        public int minAvstandTilNesteAksling { get; set; }
        public int minimalSporvidde { get; set; }
        public string plasseringAksel { get; set; }
        public bool styreAksel { get; set; }
        public int tekniskTillattAkselLast { get; set; }
    }

    public class AkselListe
    {
        public List<Aksel> aksel { get; set; }
    }

    public class AkselGruppe
    {
        public AkselListe akselListe { get; set; }
        public int fordelingAvTillattTotalvektAkselGruppeMaks { get; set; }
        public int fordelingAvTillattTotalvektAkselGruppeMin { get; set; }
        public int id { get; set; }
        public string plasseringAkselGruppe { get; set; }
        public int tekniskTillattAkselGruppeLast { get; set; }
    }

    public class Akslinger
    {
        public List<AkselGruppe> akselGruppe { get; set; }
        public int antallAksler { get; set; }
    }

    public class Bremser
    {
        public bool abs { get; set; }
        public List<object> tilhengerBremseforbindelse { get; set; }
    }

    public class AkselDekkOgFelg
    {
        public int akselId { get; set; }
        public string belastningskodeDekk { get; set; }
        public string dekkdimensjon { get; set; }
        public string felgdimensjon { get; set; }
        public string hastighetskodeDekk { get; set; }
        public string innpress { get; set; }
        public bool tvilling { get; set; }
    }

    public class AkselDekkOgFelgKombinasjon
    {
        public List<AkselDekkOgFelg> akselDekkOgFelg { get; set; }
    }

    public class DekkOgFelgSidevogn
    {
    }

    public class DekkOgFelg
    {
        public List<AkselDekkOgFelgKombinasjon> akselDekkOgFelgKombinasjon { get; set; }
        public DekkOgFelgSidevogn dekkOgFelgSidevogn { get; set; }
    }

    public class Dimensjoner
    {
        public int bredde { get; set; }
        public int hoyde { get; set; }
        public int lengde { get; set; }
        public int maksimalHoyde { get; set; }
    }

    public class Fabrikant
    {
        public string fabrikantNavn { get; set; }
    }

    public class Merke
    {
        public string merke { get; set; }
        public string merkeKode { get; set; }
    }

    public class Generelt
    {
        public List<Fabrikant> fabrikant { get; set; }
        public List<string> handelsbetegnelse { get; set; }
        public List<Merke> merke { get; set; }
        public TekniskKode tekniskKode { get; set; }
        public string typebetegnelse { get; set; }
    }

    public class Karosseritype
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class KjennemerketypeBak
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class KjennemerkestorrelseBak
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class KjennemerketypeForan
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class KjennemerkestorrelseForan
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class PlasseringAvDorer
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class PlasseringFabrikasjonsplate
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class PlasseringUnderstellsnummer
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class RFarge
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class KarosseriOgLasteplan
    {
        public List<int> antallDorer { get; set; }
        public List<object> dorUtforming { get; set; }
        public Karosseritype karosseritype { get; set; }
        public KjennemerketypeBak kjennemerketypeBak { get; set; }
        public KjennemerkestorrelseBak kjennemerkestorrelseBak { get; set; }
        public KjennemerketypeForan kjennemerketypeForan { get; set; }
        public KjennemerkestorrelseForan kjennemerkestorrelseForan { get; set; }
        public string oppbygningUnderstellsnummer { get; set; }
        public PlasseringAvDorer plasseringAvDorer { get; set; }
        public List<PlasseringFabrikasjonsplate> plasseringFabrikasjonsplate { get; set; }
        public List<PlasseringUnderstellsnummer> plasseringUnderstellsnummer { get; set; }
        public List<RFarge> rFarge { get; set; }
    }

    public class EuroKlasse
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class DrivstoffKodeMiljodata
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class StoyMalingOppgittAv
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Lyd
    {
        public int kjorestoy { get; set; }
        public StoyMalingOppgittAv stoyMalingOppgittAv { get; set; }
    }

    public class MiljoOgdrivstoffGruppe
    {
        public DrivstoffKodeMiljodata drivstoffKodeMiljodata { get; set; }
        public Lyd lyd { get; set; }
    }

    public class Miljodata
    {
        public EuroKlasse euroKlasse { get; set; }
        public List<MiljoOgdrivstoffGruppe> miljoOgdrivstoffGruppe { get; set; }
    }

    public class Girkassetype
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class HybridKategori
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Arbeidsprinsipp
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class DrivstoffKode
    {
        public string kodeBeskrivelse { get; set; }
        public string kodeNavn { get; set; }
        public string kodeTypeId { get; set; }
        public string kodeVerdi { get; set; }
        public List<object> tidligereKodeVerdi { get; set; }
    }

    public class Drivstoff
    {
        public DrivstoffKode drivstoffKode { get; set; }
        public double maksEffektPrTime { get; set; }
        public double spenning { get; set; }
    }

    public class Motor
    {
        public Arbeidsprinsipp arbeidsprinsipp { get; set; }
        public List<Drivstoff> drivstoff { get; set; }
        public string motorKode { get; set; }
    }

    public class MotorOgDrivverk
    {
        public int antallGir { get; set; }
        public Girkassetype girkassetype { get; set; }
        public List<object> girutvekslingPrGir { get; set; }
        public bool hybridElektriskKjoretoy { get; set; }
        public HybridKategori hybridKategori { get; set; }
        public List<int> maksimumHastighet { get; set; }
        public List<object> maksimumHastighetMalt { get; set; }
        public List<Motor> motor { get; set; }
    }

    public class Sitteplass
    {
        public bool beltestrammer { get; set; }
        public bool frontairbag { get; set; }
        public bool kneairbag { get; set; }
        public string posisjon { get; set; }
        public int rad { get; set; }
    }

    public class SitteplassListe
    {
        public List<Sitteplass> sitteplass { get; set; }
    }

    public class Persontall
    {
        public SitteplassListe sitteplassListe { get; set; }
        public int sitteplasserForan { get; set; }
        public int sitteplasserTotalt { get; set; }
    }

    public class Tilhengerkopling
    {
        public List<object> kopling { get; set; }
    }

    public class Vekter
    {
        public int egenvekt { get; set; }
        public int egenvektMinimum { get; set; }
        public int nyttelast { get; set; }
        public int tillattTaklast { get; set; }
        public int tillattTilhengervektMedBrems { get; set; }
        public int tillattTilhengervektUtenBrems { get; set; }
        public int tillattTotalvekt { get; set; }
        public int tillattVertikalKoplingslast { get; set; }
        public int tillattVogntogvekt { get; set; }
        public List<object> vogntogvektAvhBremsesystem { get; set; }
    }

    public class TekniskeData
    {
        public Akslinger akslinger { get; set; }
        public Bremser bremser { get; set; }
        public DekkOgFelg dekkOgFelg { get; set; }
        public Dimensjoner dimensjoner { get; set; }
        public Generelt generelt { get; set; }
        public KarosseriOgLasteplan karosseriOgLasteplan { get; set; }
        public Miljodata miljodata { get; set; }
        public MotorOgDrivverk motorOgDrivverk { get; set; }
        public List<object> ovrigeTekniskeData { get; set; }
        public Persontall persontall { get; set; }
        public Tilhengerkopling tilhengerkopling { get; set; }
        public Vekter vekter { get; set; }
    }

    public class TekniskGodkjenning
    {
        public string godkjenningsId { get; set; }
        public Godkjenningsundertype godkjenningsundertype { get; set; }
        public string gyldigFraDato { get; set; }
        public DateTime gyldigFraDatoTid { get; set; }
        public Kjoretoyklassifisering kjoretoyklassifisering { get; set; }
        public List<Krav> krav { get; set; }
        public TekniskeData tekniskeData { get; set; }
        public List<object> unntak { get; set; }
    }

    public class Godkjenning
    {
        public ForstegangsGodkjenning forstegangsGodkjenning { get; set; }
        public List<Kjoretoymerknad> kjoretoymerknad { get; set; }
        public Registreringsbegrensninger registreringsbegrensninger { get; set; }
        public TekniskGodkjenning tekniskGodkjenning { get; set; }
        public List<object> tilleggsgodkjenninger { get; set; }
    }

    public class PeriodiskKjoretoyKontroll
    {
        public string kontrollfrist { get; set; }
    }

    public class KjoretoydataListe
    {
        public KjoretoyId kjoretoyId { get; set; }
        public Forstegangsregistrering forstegangsregistrering { get; set; }
        public List<Kjennemerke> kjennemerke { get; set; }
        public Registrering registrering { get; set; }
        public Godkjenning godkjenning { get; set; }
        public PeriodiskKjoretoyKontroll periodiskKjoretoyKontroll { get; set; }
    }

    public class KjoretoyRoot
    {
        public List<KjoretoydataListe> kjoretoydataListe { get; set; }
    }




}
