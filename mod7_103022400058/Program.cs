using System.Text.Json;


namespace mod7 {
    public class Watchlist_103022400064
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
        public void readJson()
            {
                string filepath = "D:\\Modul7_Kelompok5\\mod7_103022400058\\jurnal7_2_103022400064.json";
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
    public class FilmFavorit_103022400064
    {
        public class Film
        {
            public string title { get; set;  }
            public string director { get; set; }
            public string year { get; set;  }
            public string genre { get; set; }
            public int rating { get; set; }
            public int durationMinutes { get; set; }
            public bool isWatched { get; set; }
        }

        public void readJson()
        {
            string f = "D:\\Modul7_Kelompok5\\mod7_103022400058\\jurnal7_1_103022400064.json";
            if (!File.Exists(f))
            {
                Console.WriteLine($"File tidak ditemukan {f}");
            }
            string jsonstring = File.ReadAllText(f);
            Film data = JsonSerializer.Deserialize<Film>(jsonstring);

            Console.WriteLine($"{data.title} {data.director} {data.year} {data.genre} {data.rating} {data.durationMinutes} {data.isWatched}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            FilmFavorit_103022400064 film = new FilmFavorit_103022400064();
            film.readJson();
            Watchlist_103022400064 l = new Watchlist_103022400064();
            l.readJson();
        }
    }
}