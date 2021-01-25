using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("sql deletedé");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }
}
