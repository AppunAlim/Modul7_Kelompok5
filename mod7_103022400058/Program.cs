using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace mod7_103022400058
{
    public class FilmFavorit_103022400126
    {
        public class film
        {

            public string title { get; set; }
            public string director { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public int rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
        }

        public void readJSON()
        {
            string filepath = "D:\\CODE\\Modul7_Kelompok5\\mod7_103022400058\\jurnal7_1_103022400126.json";

            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine($"File {filepath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filepath);
                film film = JsonSerializer.Deserialize<film>(jsonString);
                Console.WriteLine($"Judul : {film.title} \nDirector : {film.director} \nTahun : {film.year} \nGenre : {film.genre}" +
                    $"\nRating : {film.rating} \nLama Film : {film.durationMinutes} \nSudah Ditonton? : {film.isWatched}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public class ListFavorit_103022400126
        {
            public class watchList
            {
                public string watchListName { get; set; }
                public string createdBy { get; set; }
                public List<movie> movies { get; set; }
            }
            public class movie
            {

                public string id { get; set; }
                public string title { get; set; }
                public int year { get; set; }
                public string genre { get; set; }
                public double rating { get; set; }
            }

            public void readJSON()
            {
                string filepath = "D:\\CODE\\Modul7_Kelompok5\\mod7_103022400058\\jurnal7_2_103022400126.json";

                try
                {
                    if (!File.Exists(filepath))
                    {
                        Console.WriteLine($"File {filepath} tidak ditemukan!");
                        return;
                    }

                    string jsonString = File.ReadAllText(filepath);
                    watchList film = JsonSerializer.Deserialize<watchList>(jsonString);
                    Console.WriteLine($"WatchList name : {film.watchListName} \nCreated BY : {film.createdBy} \nMovies : ");
                    for (int i = 0; i < film.movies.Count; i++)
                    {
                        Console.WriteLine(film.movies[i].id + " " + film.movies[i].title + " " + film.movies[i].genre + " (" + film.movies[i].year + " - " + film.movies[i].rating + ")");

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
        public class program
        {
            public static void Main(String[] args)
            {
                FilmFavorit_103022400126 film = new FilmFavorit_103022400126();
                film.readJSON();
                ListFavorit_103022400126 favorit_103022400126 = new ListFavorit_103022400126();
                favorit_103022400126.readJSON();
            }
        }
    }
}

