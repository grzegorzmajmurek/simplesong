using System.Linq;
using SimpleSong.Controller.DAO.DAOImpl;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.View;
using static System.Console;

namespace SimpleSong.Controller.MenuManager
{
    public class DisplaySong
    {
        private ISongDao SongDao = new SongDao();
        MenuView menuView = new MenuView();
        public void GoBack()
        {
            ReadLine();
            Clear();
            menuView.Display();
        }
        public void GetAllSongsList()
        {
            var sortedSong = SongDao.GetAllSongs().OrderBy(song => song.Title).ToList();
            sortedSong.ForEach(song => {
            WriteLine(song.SongId + " " + song.Title + " " + song.Author + " " + song.AlbumName + " " + song.Length);
            });
            GoBack();
        }
    }
}
