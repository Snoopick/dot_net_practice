using System;

namespace Task1 {
    class Program {
        static void Main(string[] args) {
            Song song = new Song();
            song.songAuthor = "Song author";
            song.songLen = 231;
            song.songName = "Song 1";
            song.songDate = DateTime.Now;

            Console.WriteLine(song.GetSongData(song));
        }
    }
}
