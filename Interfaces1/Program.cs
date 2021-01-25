using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer1 = new Customer();
            customer1.FirstName = "okay";
            customer1.Address = "istanbull";

            Student student1 = new Student();
            student1.FirstName = "hasan";
            student1.Departman = "History";
            manager.Add(customer1);
            manager.Add(student1);
            Console.ReadLine();
        }
    }
}
