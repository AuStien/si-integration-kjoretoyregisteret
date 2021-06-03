using KTR.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTR.Data
{
    interface IVehicleData
    {
        public KjoretoyRoot getVehicleByRegisterPlate(string registerPlate);

        public OutData getCarDescription(string registerPlate);

        public string getCarBrandByObject(KjoretoyRoot ktr);

        public string getVehicleTypeByObject(KjoretoyRoot ktr);

        public string getFirstTimeRegistrationByObject(KjoretoyRoot ktr);

        public string getFuelTypeByObject(KjoretoyRoot ktr);
    }
}
