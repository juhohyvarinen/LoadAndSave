using System;

namespace LoadAndSave
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Datahandler dh = new Datahandler();


            MainMenu mainMenu = new MainMenu(dh);

            mainMenu.InitializeMainMenu();
            
        }

        
       

    }
}
