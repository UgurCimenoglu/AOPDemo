using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    internal class BusinessModuleProxy : IBusinessModule
    {
        private readonly BusinessModule _businessModule;

        public BusinessModuleProxy()
        {
            _businessModule = new BusinessModule();
        }

        public void Add()
        {

            Console.WriteLine("Metot başlamadan önce yapılacak işlemler...");
            try
            {
                _businessModule.Add();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hataya Düştüğü zaman yapılacak işlemler..." + ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Süreç bittiğinde her halükarda yapılacak işlemler...");
            }
        }
    }
}
