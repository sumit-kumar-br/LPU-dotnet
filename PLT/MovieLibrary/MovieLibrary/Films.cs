using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Films: IFilm
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

    }
}
