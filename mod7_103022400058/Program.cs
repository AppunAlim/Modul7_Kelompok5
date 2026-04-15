using System.Text.Json;

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

    public class Program
    {
        public static void Main(string[] args)
        {
            FilmFavorit_103022400058 film = new FilmFavorit_103022400058();
            film.readJson();
        }
    }
}