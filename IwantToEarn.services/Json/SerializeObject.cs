using System;
using System.IO;
using System.Runtime.Serialization.Json;
using IwantToEarn.services.DbModel;

namespace IwantToEarn.services.Json
{
    public class SerializeObject
    {
        public object ConvertModelToJsonObject(JobModel _jobModel)
        {
            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JobModel));
            ser.WriteObject(stream1, _jobModel);
            return stream1;
        }
    }
}