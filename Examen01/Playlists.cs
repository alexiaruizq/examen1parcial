using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> playlistdepeliculas { get; set; }

        public Playlist()
        {
            Titulo = "Sin titulo";
            Descripcion = "No disponible";
            playlistdepeliculas = new List<Pelicula>();
        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            playlistdepeliculas = new List<Pelicula>();
        }
    }
}
