using System;
using System.Collections.Generic;
using System.Text;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;

namespace SimpleSong.Controller.MenuManager
{
    public class DeleteSong
    {
        private ISongDao SongDao = new SongDao();

        public void DeleteOneSong()
        {
            Console.WriteLine("Get song title to delete");
            var song = Console.ReadLine();
            SongDao.DeleteSong(song);
        }
    }
}
