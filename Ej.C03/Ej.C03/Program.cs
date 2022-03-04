using System;
using Biblioteca;

namespace Ej.C03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("MOVISTAR");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l2 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial p1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial p2 = new Provincial("Lanus", Provincial.Franja.Franja_3, 30, "Wilde");

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.ToString());

            Console.WriteLine("\n-----------------\n");
            
            c.Llamadas.Add(l2);
            Console.WriteLine(c.ToString());
           
            Console.WriteLine("\n-----------------\n");

            c.Llamadas.Add(p1);
            Console.WriteLine(c.ToString());
            
            Console.WriteLine("\n-----------------\n");
            c.Llamadas.Add(p2);
            Console.WriteLine(c.ToString());
            
            Console.WriteLine("\n-----------------\n");
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
        }
    }
}
