using System.Text.Json;
using static mod7.FilmFavorit_103022400058;
using static mod7.WatchList_103022400058;

namespace mod7
{
    public class FilmFavorit_103022400058
    {
        public class Film
        {
            public string title { get; set; }
            public string director { get; set; }
            public string year { get; set; }
            public string genre { get; set; }
            public int rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
        }


        public void readJson()
        {
            string f = "D:\\mod7_103022400058\\mod7_103022400058\\jurnal7_1_103022400058.json";
            if (!File.Exists(f))
            {
                Console.WriteLine($"File tidak ditemukan {f}");
            }
            string jsonstring = File.ReadAllText(f);
            Film data = JsonSerializer.Deserialize<Film>(jsonstring);

            Console.WriteLine($"Judul : {data.title} \nDirector : {data.director} \nTahun: {data.year} \nGenre : {data.genre} \nRating : {data.rating} \nDurasi : {data.durationMinutes}" +
                $" \nApakah Sudah Menonton ? {data.isWatched}");
        }
    }

    public class WatchList_103022400058
    {
        public class WatchList
        {
            public string watchListName { get; set; }
            public string createdBy { get; set; }
            public List<Movie> movies { get; set; }
        }
        public class Movie
        {

            public string id { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public string genre { get; set; }
            public double rating { get; set; }
        }

        public void ReadJson()
        {
            string filepath = "D:\\mod7_103022400058\\mod7_103022400058\\jurnal7_2_103022400058.json";
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine($"File {filepath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filepath);
                WatchList film = JsonSerializer.Deserialize<WatchList>(jsonString);
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
    public class GenreDictionary_103022400058
    {

        public void ReadJson()
        {
            string filepath = "D:\\mod7_103022400058\\mod7_103022400058\\jurnal7_3_103022400058.json";
            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine($"File {filepath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filepath);
                WatchList film = JsonSerializer.Deserialize<WatchList>(jsonString);
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

    public class Program
    {
        public static void Main(string[] args)
        {
            FilmFavorit_103022400058 film = new FilmFavorit_103022400058();
            film.readJson();
            Console.WriteLine("\nD");
            WatchList_103022400058 wl = new WatchList_103022400058();
            wl.ReadJson();
        }
    }
}