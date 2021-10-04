using System;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;
using SimpleSong.View;

namespace SimpleSong.Controller.MenuManager
{
    public class AddNewSong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();

        public void GoBack()
        {
            Console.ReadLine();
            Console.Clear();
            menuView.Display();
        }
        public void AddSong()
        {
            Song song = new Song();
            Console.WriteLine("Get song title");
            var title = Console.ReadLine();
            while (!IsNotEmptyString(title))
            {
                Console.WriteLine("You provide wrong format! Try again!");
                Console.WriteLine("Get song title");
                title = Console.ReadLine();
            }
            song.Title = title;
            Console.WriteLine("Get song author");
            var author = Console.ReadLine();
            while (!IsNotEmptyString(author))
            {
                Console.WriteLine("You provide wrong format! Try again!");
                Console.WriteLine("Get song author");
                author = Console.ReadLine();
            }
            song.Author = author;
            Console.WriteLine("Get song album");
            var album = Console.ReadLine();
            while (!IsNotEmptyString(album))
            {
                Console.WriteLine("You provide wrong format! Try again!");
                Console.WriteLine("Get song album");
                album = Console.ReadLine();
            }
            song.AlbumName = album;
            Console.WriteLine("Get song length");
            var length = Console.ReadLine();
            while (!IsCorrectLengthFormat(length))
            {
                Console.WriteLine("You provide wrong format! Try again!");
                Console.WriteLine("Get song length");
                length = Console.ReadLine();
            }
            song.Length = Convert.ToDouble(length);
            SongDao.AddSong(song);
            GoBack();
        }

        public bool IsCorrectLengthFormat(string lengthAsString)
        {
            double songLength;
            return double.TryParse(lengthAsString, out songLength);
        }

        public bool IsNotEmptyString(string param)
        {
            return !String.IsNullOrEmpty(param);
        }
    }
}
