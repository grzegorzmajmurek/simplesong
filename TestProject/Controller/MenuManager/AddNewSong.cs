using System;
using System.Collections.Generic;
using System.Text;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;

namespace SimpleSong.Controller.MenuManager
{
    public class AddNewSong
    {
        private ISongDao SongDao = new SongDao();

        public void AddSong()
        {
            Song song = new Song();
            Console.WriteLine("Get song title");
            song.Title = Console.ReadLine();
            Console.WriteLine("Get song author");
            song.Author = Console.ReadLine();
            Console.WriteLine("Get song album");
            song.AlbumName = Console.ReadLine();
            Console.WriteLine("Get song length");
            song.Length = Convert.ToDouble(Console.ReadLine());
            SongDao.AddSong(song);
        }
    }
}
