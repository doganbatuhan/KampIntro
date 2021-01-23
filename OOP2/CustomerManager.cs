using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // İş sınıfları - Business classes
    class CustomerManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Id: {0}, Müşteri No: {1}",musteri.Id,musteri.MusteriNo);
        }
    }
}
