using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria_CSharp

// Definisco una nuova classe per poter istanziare e lavorare con oggetti di tipo Rettangolo
{
    internal class Rettangolo
    {
        //CARATTERISTICHE / PROPRIETA'  
        public int basee;
        public int altezza;

        //METODI
        public int AreaRettangolo()
        {
            int area = basee * altezza;
            return area;
        }

        public int PerimetroRettangolo()
        {
            int perimetro = (basee + altezza) * 2;
            return perimetro;
        }

        public void infoRettangolo()
        {
            Console.WriteLine("Base:\t" + basee);
            Console.WriteLine("Altezza:\t" + altezza);
            Console.WriteLine("Perimetro:\t" + PerimetroRettangolo());
            Console.WriteLine("Area:\t" + AreaRettangolo());
        }
    }
}
