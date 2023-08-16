using System;
using System.Collections.Generic;

namespace Blaise.Questionnaire.Data.Helpers.Models
{
    public class CaseDataModel
    {
        public CaseDataModel(int primaryKey, Dictionary<string, string> sampleDataFields = null)
        {
            PrimaryKey = primaryKey.ToString();
            DataFields = InitialiseCaseDataFields(sampleDataFields);
        }

        public Dictionary<string, string> InitialiseCaseDataFields(Dictionary<string, string> dataFields)
        {
            if (dataFields is null)
            {
                dataFields = new Dictionary<string, string>();
            }

            dataFields["qiD.Serial_Number"] = PrimaryKey;

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
