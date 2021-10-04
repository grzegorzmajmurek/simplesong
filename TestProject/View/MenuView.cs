using System;
using SimpleSong.Controller.MenuManager;

namespace SimpleSong.View
{
    public class MenuView : IView
    {
        public void Display()
        {
            Console.WriteLine("1. Add Song\n2. Delete Song\n3. Display All Songs\n4. Display Specyfic Song");
            
            int option = Convert.ToInt32(System.Console.ReadLine());
            Console.ReadLine();

            switch (option)
            {
                case 1:
                    new AddNewSong().AddSong();
                    Console.Clear();
                    break;
                case 2:
                    new DeleteSong().DeleteOneSong();
                    Console.Clear();
                    break;
                case 3:
                    new DisplaySong().GetAllSongsList();
                    Console.Clear();
                    break;
                case 4:
                    new GetSongByAlbum().ShowSongsByAlbum();
                    Console.Clear();
                    break;
                default:
                    break;
            }
        }

    }
}
