using Microsoft.Extensions.Logging;
using SampleSdk;

namespace MultipleSdkSeparateSettings
{
    public class Service1
    {
        SampleSdkClient<Service1> _sampleSdkClient;
        public Service1(SampleSdkClient<Service1> sampleSdkClient)
        {
            _sampleSdkClient = sampleSdkClient;
        }

        public string GetSetting1()
        {
            return _sampleSdkClient.GetSetting1();
        }
    }
}
