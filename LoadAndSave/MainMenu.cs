using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSave
{
    class MainMenu
    {
        public Datahandler dataHandler;
        public MainMenu()
        {

        }

        public MainMenu(Datahandler dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        public void InitializeMainMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = ShowMainMenu();
            }
        }


        private bool ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Syötä uusi henkilö");
            Console.WriteLine("2) Tarkastele listaa");
            Console.WriteLine("3) Tallenna henkilöt");
            Console.WriteLine("4) Exit");
            Console.Write("\nValitse vaihtoehto: ");

            switch (Console.ReadLine())
            {
                case "1":
                    dataHandler.AddPersonToList();
                    return true;

                case "2":
                    dataHandler.PersonList();
                    break;


                case "3":
                    
                    break;

                case "4":
                    return false;

                default:
                    return true;
            }
            Console.WriteLine("\nEnter jatkaaksesi");
            Console.ReadKey();
            return true;
        }
    }
}
