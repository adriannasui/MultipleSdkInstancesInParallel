using Microsoft.Extensions.Logging;
using SampleSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleSdkSeparateSettings
{
    public class Service3
    {
        SampleSdkClient _sampleSdkClient;
        public Service3(SampleSdkClient sampleSdkClient)
        {
            _sampleSdkClient = sampleSdkClient;
        }
        public string GetSetting1()
        {
            return _sampleSdkClient.GetSetting1();
        }
    }
}
