using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEleve;

namespace AppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // A COMPLETER

            Eleve eleve = new Eleve("Hertz", "Lou", 2003, "Marseille");
            Console.WriteLine(eleve.ObtenirDescription());

            eleve.Demenager("Lyon");
            Console.WriteLine(eleve.ObtenirDescription());

            eleve.AjouterAbsence(4);
            Console.WriteLine(eleve.ObtenirDescription());

            eleve.AjouterNote(14);
            eleve.AjouterNote(6.5);
            eleve.AjouterNote(17);
            eleve.AjouterNote(11.5);
            eleve.AjouterNote(18);

           Console.WriteLine(eleve.CalculerMoyenne());

            Console.ReadLine();
        }
    }
}
