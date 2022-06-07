using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoAgain
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri başarıyla sisteme eklendi.");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Müşteriler listelendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri sistemden başarıyla silindi.");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri bilgileri güncellendi.");
        }

    }
}
