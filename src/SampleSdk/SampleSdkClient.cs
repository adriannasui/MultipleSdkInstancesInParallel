using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSdk
{
    public class SampleSdkClient<T> : SampleSdkClient
    {
        public SampleSdkClient(IOptions<SampleSdkConfig<T>> sampleSdkConfigOptions) : base(sampleSdkConfigOptions)
        {

        }
    }

    public class SampleSdkClient
    {
        SampleSdkConfig _config;
        public SampleSdkClient(IOptions<SampleSdkConfig> sampleSdkConfigOptions)
        {
            _config = sampleSdkConfigOptions.Value;
        }

        public string GetSetting1()
        {
            return _config.Setting1;
        }

    }
}
