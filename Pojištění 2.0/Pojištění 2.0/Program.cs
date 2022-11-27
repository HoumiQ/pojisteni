// See https://aka.ms/new-console-template for more information

using Pojištění_2._0;

class Program
{
    static void Main(string[] args)
    {
        // Inicializace instancí 
        Menu menu = new Menu();
        Databaze db = new Databaze();

        // Základní Výpis Menu
        menu.VypisMenu();

        // Načtení uživatelské volby z menu a reakce
        bool PlatnaVolba = true;
        while (PlatnaVolba == true)
        {
            char volba = Console.ReadKey().KeyChar;
            switch (volba)
            {
                case '1':
                    menu.VypisMenu();
                    db.PridatKlienta();
                    menu.Pokracuj();
                    break;

                case '2':
                    menu.VypisMenu();
                    db.VypisKlientu();
                    menu.Pokracuj();
                    break;

                case '3':
                    menu.VypisMenu();
                    db.HledejKlienta();
                    menu.Pokracuj();
                    break;

                case '4':
                    db.Konec();
                    PlatnaVolba = false;
                    break;

                default:
                    Console.WriteLine("Neplatná Volba, zvol si prosím znovu");
                    break;
            }
        }

    }

}