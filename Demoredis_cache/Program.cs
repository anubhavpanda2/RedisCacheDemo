using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Demoredis_cache
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer con = ConnectionMultiplexer.Connect("connectionstring");
            IDatabase cache = con.GetDatabase();
            //cache.StringSet("data","hello redis ccache");
            //Console.WriteLine("data written");
            string data = cache.StringGet("data");
            Console.WriteLine(data);
            Console.Read();
        }
    }
}
