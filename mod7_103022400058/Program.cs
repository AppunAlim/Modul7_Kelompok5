using System.Text.Json;

namespace mod7 {
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
        }
    }
}