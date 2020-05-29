using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MultipleSdkSeparateSettings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        Service1 _service1;
        Service2 _service2;
        Service3 _service3;

        public TestController(Service1 service1, Service2 service2, Service3 service3)
        {
            _service1 = service1;
            _service2 = service2;
            _service3 = service3;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = new
            {
                Service1_Setting1 = _service1.GetSetting1(),
                Service2_Setting1 = _service2.GetSetting1(),
                Service3_Setting1 = _service3.GetSetting1(),
            };
            return Ok(result);
        }
    }
}
