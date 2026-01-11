using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class FilmLibrary: IFilmLibrary
    {
        private List<IFilm> _films = new List<IFilm>();     

        public void AddFilm(IFilm film)
        {
            _films.Add(film);
        }

        public bool RemoveFilm(string title)
        {

            var film = _films.FirstOrDefault(f =>
            f.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if(film != null)
            {
                _films.Remove(film);
                return true;
            }
            return false;
        }

        public List<IFilm> GetFilms()
        {
            return _films;
        }

        public List<IFilm> SearchFilms(string query)
        {
            query = query.ToLower();
            return _films
                .Where(f =>
                f.Title.ToLower().Contains(query) ||
                f.Director.ToLower().Contains(query))
                .ToList();
        }
        public int GetTotalFilmCount()
        {
            return _films.Count;
        }

    }
}
