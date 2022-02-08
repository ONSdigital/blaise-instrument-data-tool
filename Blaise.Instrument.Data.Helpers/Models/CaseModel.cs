using System;
using System.Collections.Generic;

namespace Blaise.Instrument.Data.Helpers.Models
{
    public class CaseModel
    {
        public CaseModel(int primaryKey, Dictionary<string, string> sampleDataFields)
        {
            PrimaryKey = primaryKey.ToString();
            DataFields = InitialiseCaseDataFields(sampleDataFields);
        }

        public Dictionary<string, string> InitialiseCaseDataFields(Dictionary<string, string> dataFields)
        {
            dataFields["QID.Serial_Number"] = PrimaryKey;
            dataFields["QDataBag.uac1"] = Uac1;
            dataFields["QDataBag.uac2"] = Uac2;
            dataFields["QDataBag.uac3"] = Uac3;

            SetDefaultValueIfNull(dataFields, "QDataBag.TelNo", "07000000000");
            SetDefaultValueIfNull(dataFields, "QDataBag.TelNo2", "07000000000");

            //QSample.PostCode
            //QSample.TownName

            return dataFields;
        }

        private static void SetDefaultValueIfNull(IDictionary<string, string> dataFields, string fieldName, string defaultValue)
        {
            if (dataFields.ContainsKey(fieldName) && !string.IsNullOrWhiteSpace(dataFields[fieldName]))
            {
                return;
            }

            dataFields[fieldName] = defaultValue;
        }

        public string PrimaryKey { get; set; }

        public string Uac1 => GenerateRandomUac();

        public string Uac2 => GenerateRandomUac();

        public string Uac3 => GenerateRandomUac();

        public Dictionary<string, string> DataFields { get; }

        private static string GenerateRandomUac()
        {
            var random = new Random();
           return random.Next(1000, 9999).ToString();
        }
    }
}
