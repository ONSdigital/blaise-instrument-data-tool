using System;
using System.Collections.Generic;
using Blaise.Nuget.Api.Contracts.Models;

namespace Blaise.Questionnaire.Data.Helpers.Models
{
    public class CaseDataModel
    {
        public CaseDataModel(int primaryKey, Dictionary<string, string> sampleDataFields = null)
        {
            PrimaryKey = primaryKey.ToString();
            DataFields = InitialiseCaseDataFields(sampleDataFields);
        }

        public CaseModel ToCaseModel()
        {
           return new CaseModel(PrimaryKey, DataFields);
        }

        public Dictionary<string, string> InitialiseCaseDataFields(Dictionary<string, string> dataFields)
        {
            if (dataFields is null)
            {
                dataFields = new Dictionary<string, string>();
            }

            dataFields["qiD.Serial_Number"] = PrimaryKey;
            dataFields["qDataBag.TLA"] = "LMS";
            dataFields["qDataBag.Wave"] = "1";
            dataFields["qDataBag.TelNo"] = "0548584848";
            dataFields["qDataBag.TelNo2"] = "0548584848";
            dataFields["qDataBag.telNoAppt"] = "0548584848";
            dataFields["qDataBag.prem1"] = "10";
            dataFields["qDataBag.prem2"] = "Blaiseville";
            dataFields["qDataBag.prem3"] = "Newportio";
            dataFields["qDataBag.district"] = "Gwentish";
            dataFields["qDataBag.posttown"] = "Neeewwwpoort";
            dataFields["qDataBag.postcode"] = "N3V3R";

            dataFields["qhAdmin.HOut"] = "110";
            dataFields["qhAdmin.interviewer[1]"] = "Rich Ricecake";
            dataFields["dmhSize"] = "2";
            dataFields["dmName[1]"] = "Bart Edgar";
            dataFields["dmDteOfBth[1]"] = "01-01-1978";
            dataFields["dmName[2]"] = "Tina Pipes";
            dataFields["dmDteOfBth[2]"] = "01-01-1990";

            dataFields["qDataBag.UPRN_Latitude"] = "11112";
            dataFields["qDataBag.UPRN_Longitude"] = "33444";
            dataFields["qDataBag.Priority"] = "1";
            dataFields["qDataBag.FieldTeam"] = "blah";
            dataFields["hOut"] = "110";
            dataFields["qDataBag.FieldRegion"] = "Region 1";
            dataFields["qDataBag.WaveComDTE"] = "25-09-2022";
            dataFields["qRotate.RDMktnIND"] = "";
            dataFields["qRotate.RHOut"] = "";
            dataFields["qRotate.FieldCase"] = "";
            dataFields["qRotate.FieldCase"] = "";
            dataFields["qRotate.FieldCase"] = "";
            dataFields["dataModelName"] = "LMS";

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
