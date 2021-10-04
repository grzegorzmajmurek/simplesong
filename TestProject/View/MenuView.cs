using System;
using SimpleSong.Controller.MenuManager;
using static System.Console;

namespace SimpleSong.View
{
    public class MenuView : IView
    {
        public void Display()
        {
            WriteLine("1. Add Song\n2. Delete Song\n3. Display All Songs\n4. Display Specyfic Song");
            
            int option = Convert.ToInt32(ReadLine());
            ReadLine();

            switch (option)
            {
                case 1:
                    new AddNewSong().AddSong();
                    Clear();
                    break;
                case 2:
                    new DeleteSong().DeleteOneSong();
                    Clear();
                    break;
                case 3:
                    new DisplaySong().GetAllSongsList();
                    Clear();
                    break;
                case 4:
                    new GetSongByAlbum().ShowSongsByAlbum();
                    Clear();
                    break;
                default:
                    break;
            }
        }

    }
}
