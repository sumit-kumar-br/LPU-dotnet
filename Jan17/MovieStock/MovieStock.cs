using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieStock
{
    public class Movie
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Ratings { get; set; }
    }
    public class MovieStock
    {
        public static List<Movie> MovieList = new List<Movie>();

        public void AddMovie(string movieDetails)
        {
            var data = movieDetails.Split(',');
            MovieList.Add(new Movie
            {
                Title = data[0],
                Artist = data[1],
                Genre = data[2],
                Ratings = int.Parse(data[3])
            });
        }

        public List<Movie> ViewMoviesByGenre(string genre)
        {
            var listByGenre = MovieList
                .Where(m => m.Genre == genre)
                .ToList();

            if (listByGenre.Count == 0)
            {
                Console.WriteLine("No Movies found in genre " + genre);
            }
            return listByGenre;
        }

        public List<Movie> ViewMoviesRating()
        {
            return MovieList
                .OrderBy(m => m.Ratings)
                .ToList();
        }

        public static void Main()
        {
            MovieStock store = new MovieStock();

            Console.WriteLine("Enter number of movies:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter movie details (Title,Artist,Genre,Rating):");
                store.AddMovie(Console.ReadLine());
            }

            Console.WriteLine("Enter genre to search:");
            string genre = Console.ReadLine();

            var movies = store.ViewMoviesByGenre(genre);
            foreach (var m in movies)
            {
                Console.WriteLine(m.Title + "," + m.Artist);
            }

            Console.WriteLine("Movies sorted by rating:");
            foreach (var m in store.ViewMoviesRating())
            {
                Console.WriteLine(m.Title + "," + m.Ratings);
            }
        }
    }
}
