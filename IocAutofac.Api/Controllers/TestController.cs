﻿using IocAutofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace IocAutofac.Api.Controllers
{
    public class TestController : ApiController
    {
        private TestService _testService;
        public TestController(TestService testService)
        {
            _testService = testService;
        }

        [HttpGet]
        [Route("ping")]
        public async Task<HttpResponseMessage> GetPing()
        {
            var ping = await _testService.GetPing();
            //TODO - make some changes
            return Request.CreateResponse(HttpStatusCode.OK, ping);
        }
    }
}
