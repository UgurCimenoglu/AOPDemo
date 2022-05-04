using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    internal class BusinessModule : IBusinessModule
    {
        public void Add()
        {
            Console.WriteLine("Added...");
        }
    }
}
