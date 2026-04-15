using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace mod7_103022400058
{
    public class FilmFavorit_103022400086
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durasi { get; set; }
        public bool isWatched { get; set; }


        public void ReadJSON()
        {
            string filepath = "D:\\Modul7_Kelompok5\\mod7_103022400058\\jurnal7_1_103022400086.json";

            try
            {
                if (!File.Exists(filepath))
                {
                    Console.WriteLine($"File {filepath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filepath);
                FilmFavorit_103022400086 film = JsonSerializer.Deserialize<FilmFavorit_103022400086>(jsonString);
                Console.WriteLine($"judul : {film.title} \nDirector : {film.director} \nTahun : {film.year} \nGenre : {film.genre}\n " +
                    $"\n Rating : {film.rating} \nDurasi : {film.durasi} \nSudah Ditonton? : {film.isWatched}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }

    public class program
    {
        public static void Main(string[] args)
        {
            FilmFavorit_103022400086 film = new FilmFavorit_103022400086();
            film.ReadJSON();
        }
    }
}
