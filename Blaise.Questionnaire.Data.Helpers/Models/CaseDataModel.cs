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
            DataFields = sampleDataFields == null ? InitialiseCaseDataFields() : InitialiseCaseDataFieldsFromSample(sampleDataFields);
        }

        public CaseModel ToCaseModel()
        {
           return new CaseModel(PrimaryKey, DataFields);
        }

        public Dictionary<string, string> InitialiseCaseDataFields()
        {
            var dataFields = new Dictionary<string, string>
            {
                ["qid.serial_number"] = PrimaryKey,
                ["QDataBag.uac1"] = Uac1,
                ["QDataBag.uac2"] = Uac2,
                ["QDataBag.uac3"] = Uac3,

                ["qdatabag.tla"] = "tla",
                ["qdatabag.wave"] = "1",
                ["qdatabag.telno"] = "07000000000",
                ["qdatabag.telno2"] = "07000000000",
                ["qdatabag.telnoappt"] = "07000000000",
                ["qdatabag.prem1"] = "prem1",
                ["qdatabag.prem2"] = "prem2",
                ["qdatabag.prem3"] = "prem3",
                ["qdatabag.district"] = "district",
                ["qdatabag.posttown"] = "posttown",
                ["qdatabag.postcode"] = "np10 8xg",
                ["qdatabag.uprn_latitude"] = "51.566",
                ["qdatabag.uprn_longitude"] = "-3.026",
                ["qdatabag.samptitle"] = "samptitle",
                ["qdatabag.sampfname"] = "sampfname",
                ["qdatabag.sampsname"] = "sampsname",
                ["qdatabag.name"] = "name",
                ["qdatabag.fieldcase"] = "y",
                ["qdatabag.priority"] = "1",
                ["qdatabag.fieldteam"] = "fieldteam",
                ["qdatabag.fieldregion"] = "region 1",
                ["qdatabag.wavecomdte"] = "01-01-3000",
                ["qsample.orgname"] = "orgname",
                ["qsample.address1"] = "address1",
                ["qsample.address2"] = "address2",
                ["qsample.locality"] = "locality",
                ["qsample.townname"] = "townname",
                ["qsample.postcode"] = "postcode",
                ["qsample.telno"] = "07000000000",
                ["qsample.telno2"] = "07000000000",
                ["qhadmin.hout"] = "110",
                ["hout"] = "110",
                ["qhadmin.interviewer[1]"] = "interviewer1",
                ["dmhsize"] = "2",
                ["dmname[1]"] = "dmname1",
                ["dmdteofbth[1]"] = "01-01-2000",
                ["dmname[2]"] = "dmname2",
                ["dmdteofbth[2]"] = "01-01-2000",
                ["qhousehold.qhhold.person[1].title"] = "title",
                ["qhousehold.qhhold.person[1].fstnme"] = "fstnme",
                ["qhousehold.qhhold.person[1].surnme"] = "surnme",
                ["qrotate.rdmktnind"] = "",
                ["qrotate.rhout"] = "",
                ["catimana.caticall.regscalls[1].whomade"] = "whomade",
                ["catimana.caticall.regscalls[5].dialresult"] = "1",
                ["catimana.caticall.regscalls[1].whomade"] = "whomade",
                ["catimana.caticall.regscalls[5].dialresult"] = "1",
                ["datamodelname"] = "datamodelname",
                ["offlinecapi.towhom"] = "towhom",
            };

            return dataFields;
        }

        public Dictionary<string, string> InitialiseCaseDataFieldsFromSample(Dictionary<string, string> dataFields)
        {
            if (dataFields is null)
            {
                dataFields = new Dictionary<string, string>();
            }

            dataFields["qid.serial_number"] = PrimaryKey;
            dataFields["QDataBag.uac1"] = Uac1;
            dataFields["QDataBag.uac2"] = Uac2;
            dataFields["QDataBag.uac3"] = Uac3;


            return dataFields;
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
