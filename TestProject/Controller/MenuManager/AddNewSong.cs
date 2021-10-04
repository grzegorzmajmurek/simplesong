using System;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;
using SimpleSong.View;
using static System.Console;

namespace SimpleSong.Controller.MenuManager
{
    public class AddNewSong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();

        public void GoBack()
        {
            ReadLine();
            Clear();
            menuView.Display();
        }
        public void AddSong()
        {
            Song song = new Song();
            WriteLine("Get song title");
            var title = ReadLine();
            while (!IsNotEmptyString(title))
            {
                WriteLine("You provide wrong format! Try again!");
                WriteLine("Get song title");
                title = ReadLine();
            }
            song.Title = title;
            WriteLine("Get song author");
            var author = ReadLine();
            while (!IsNotEmptyString(author))
            {
                WriteLine("You provide wrong format! Try again!");
                WriteLine("Get song author");
                author = ReadLine();
            }
            song.Author = author;
            WriteLine("Get song album");
            var album = ReadLine();
            while (!IsNotEmptyString(album))
            {
                WriteLine("You provide wrong format! Try again!");
                WriteLine("Get song album");
                album = ReadLine();
            }
            song.AlbumName = album;
            WriteLine("Get song length");
            var length = ReadLine();
            while (!IsCorrectLengthFormat(length))
            {
                WriteLine("You provide wrong format! Try again!");
                WriteLine("Get song length");
                length = ReadLine();
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
