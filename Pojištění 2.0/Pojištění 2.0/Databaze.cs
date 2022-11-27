using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojištění_2._0
{
    internal class Databaze
    {
        private List<Pojistenec> seznam { get; set; }
        public Databaze()
        {
            seznam = new List<Pojistenec>();
        }
        public void PridatKlienta()
        {
            // Načtení dat pro tvorbu instance pojištence

            Console.WriteLine("\nZadejte jméno pojištěného:");
            string Jmeno = "";
            while (string.IsNullOrEmpty(Jmeno))
            {
                Jmeno = Console.ReadLine().Trim();
            }

            Console.WriteLine("Zadejte příjmení pojištěného:");
            string Prijmeni = "";
            while (string.IsNullOrEmpty(Prijmeni))
            {
                Prijmeni = Console.ReadLine().Trim();
            }

            Console.WriteLine("Zadejte věk klienta:");
            int Vek;
            while (!int.TryParse(Console.ReadLine(), out Vek))
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            Console.WriteLine("Zadejte telefonní číslo pojištěnéh:");
            int TelCislo;
            while (!int.TryParse(Console.ReadLine(), out TelCislo))
                Console.WriteLine("Číslo neodpovídá, zadejte prosím znovu:");

            // Tvorba instance pojištěnce

            Pojistenec pojistenec = new Pojistenec(Jmeno, Prijmeni, TelCislo, Vek);
            seznam.Add(pojistenec);

            // Výpis vytvořeného pojištěnce

            Console.WriteLine("\nNový pojištěný který se jmenuje {0} {1}, kterému je {2} let a jeho telefonní číslo je {3}.", pojistenec.Jmeno, pojistenec.Prijmeni, pojistenec.Vek, pojistenec.Cislo);
        }
        public void VypisKlientu()
        {
            Console.WriteLine("\nVýpis všech klientů:");
            foreach (Pojistenec i in seznam)
            {
                Console.WriteLine(i);
            }
        }
        public void HledejKlienta()
        {
            // Načtení dat od uživatele pro hledání pojištěného člověka

            Console.WriteLine("\nZadejte jméno klienta:");
            string JmenoHledat = "";
            while (string.IsNullOrEmpty(JmenoHledat))
            {
                JmenoHledat = Console.ReadLine().Trim();
            }

            Console.WriteLine("Zadejte příjmení klienta:");
            string PrijmeniHledat = "";
            while (string.IsNullOrEmpty(PrijmeniHledat))
            {
                PrijmeniHledat = Console.ReadLine().Trim();
            }

            // Vyhledání pojištěného
            Pojistenec vysledek = seznam.Find(
                delegate (Pojistenec pojis)
                {
                    return pojis.Jmeno == JmenoHledat && pojis.Prijmeni == PrijmeniHledat;
                }
                );
            if (vysledek != null)
            {
                Console.WriteLine("\n" + vysledek);

            }
            else
            {
                Console.WriteLine("\nPojištěná osoba {0} neexistuje.", JmenoHledat);
            }

        }
        public void Konec()
        {
            Console.WriteLine("\nDěkuji za použití aplikace, s přáním pěkného dne se loučím, Filip Homolka.");

        }
    }
}
