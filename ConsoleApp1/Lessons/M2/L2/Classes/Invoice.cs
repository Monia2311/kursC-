using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.M2.L2.Classes
{
    public class Invoice
    {
        public int Id { get; set; } 
        public string CustomerName { get; set; }
        public int NIP { get; set; }

        public double BruttoAmount { get; set; }
        public double NettoAmount { get; set; }

        public void PresentInvoice()
        { 

            Console.WriteLine($"Invoice Id: {Id}");
            Console.WriteLine($"\t Customer name: {CustomerName}");
             Console.WriteLine($"\t Nip: {NIP}");
            Console.WriteLine($"\t Income (Brutto): {BruttoAmount}");
            Console.WriteLine($"\t Income (Netto): {NettoAmount}");
        }
    }
}
