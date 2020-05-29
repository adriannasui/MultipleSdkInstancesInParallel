using Microsoft.Extensions.Logging;
using SampleSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleSdkSeparateSettings
{
    public class Service2
    {
        SampleSdkClient<Service2> _sampleSdkClient;
        public Service2(SampleSdkClient<Service2> sampleSdkClient)
        {
            _sampleSdkClient = sampleSdkClient;
        }

        public string GetSetting1()
        {
            return _sampleSdkClient.GetSetting1();
        }
    }
}
