using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transito
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM = 0;
            int AUX = 0;
            int POS = 0;
            int I = 0;
            string[] VEC = new string[21];
            string DAT;
            string linea;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Wilkin Castillo");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("16-SIIN-1-118");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Seccion 0463");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("DIGITE UN NÚMERO:");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            // PROCESO
            POS = 1;
            while ((NUM != 99))
            {
                AUX = NUM;
                switch (AUX)
                {
                    case 0:
                        DAT = "Azul";
                        break;
                    case 1:
                        DAT = "Amarilla";
                        break;
                    case 2:
                        DAT = "Amarilla";
                        break;
                    case 3:
                        DAT = "Rosa";
                        break;
                    case 4:
                        DAT = "Rosa";
                        break;
                    case 5:
                        DAT = "Roja";
                        break;
                    case 6:
                        DAT = "Roja";
                        break;
                    case 7:
                        DAT = "Verde";
                        break;
                    case 8:
                        DAT = "Verde";
                        break;
                    case 9:
                        DAT = "Azul";
                        break;
                    default:
                        DAT = AUX.ToString();
                        break;
                }
                VEC[POS] = DAT;
                POS = POS + 1;
                for (I = POS; I >= 1; I += -1)
                {
                     Console.Write(VEC[I] + " ");
                 }
                 Console.WriteLine();
                 Console.Write("Pulse una Tecla:");
                 Console.ReadLine();
            }
        }
    }
}
