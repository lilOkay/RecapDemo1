using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
            new SqlServerCustomerDal(),
            new OracleServerCustumerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();//ikisinede değer eklemiş olduk eğer başka bir daha eklemek isteseydik artık bunu çok rahatlıkla yapabiliriz
            }
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal);
            //customerManager.Add(new OracleServerCustumerDal);
            Console.ReadLine();
        }
    }
}
