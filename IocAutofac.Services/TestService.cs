using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocAutofac.Services
{
    public class TestService
    {
        public async Task<string> GetPing()
        {
            return "pong";
        }
    }
}
