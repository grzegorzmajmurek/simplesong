﻿using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSong.Controller.DAO.DAOInterface;
using SimpleSong.Model;
using TestProject;

namespace SimpleSong.Controller.DAO.DAOImpl
{
    class SongDao : ISongDao
    {
        public void DeleteSong(Song song)
        {
            using (var context = new SimpleSongContext())
            {
                context.Songs.Remove(song);
                context.SaveChanges();
            }
        }

        public List<Song> GetAllSongs()
        {
            using (var context = new SimpleSongContext())
            {
                return context.Songs.ToList();
            }
        }

        public Song GetSongById(int songId)
        {
            using (var context = new SimpleSongContext())
            {
                return context.Songs.Where(song => song.SongId == songId).FirstOrDefault<Song>();
            }
        }

        public void AddSong(Song song)
        {
            using (var context = new SimpleSongContext())
            {
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }
    }
}