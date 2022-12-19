using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacchinaCaffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Macchinetta del caffè di Verzeri");
            Console.WriteLine("inserisci 1 per vedere la selezione dei caffè");
            Console.WriteLine("inserisci 2 per selezionare che caffè vuoi");
            Console.WriteLine("inserisci 3 per ricaricare il credito");
            Console.WriteLine("inserisci 4 per ricaricare la quantità di caffè");
            int numero=int.Parse(Console.ReadLine());
            switch (numero) { 
                case 1:
                    break;  
            }
        }
    }
}
