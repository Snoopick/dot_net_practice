using System;
using System.Collections.Generic;
using System.Text;

namespace Task1 {
    class Song {
        public string songName = string.Empty;
        public double songLen = 0.0;
        public string songAuthor = string.Empty;
        public DateTime songDate = new DateTime();

        public object GetSongData(Song song) {
            var songData = new {
                Title = song.songName,
                Minutes = (song.songLen / 60),
                AlbumYear = song.songDate
            };

            return songData;
        }
    }
}
