using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();
            Playlist playlists1 = new Playlist("1)Relajante", "Creada para hacer trabajos escolares");
            Playlist playlists2 = new Playlist("2)Terror", "Creada para jugar videojuegos");

            playlists.Add(playlists1);
            playlists.Add(playlists2);

            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia", "Sandra", "terror", "Mexico", "La puerta secreta de terror", 2005, 5, 1));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia1", "Sandra1", "aventura", "USA", "La puerta secreta aventurera", 2009, 3, 2));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia2", "Sandra2", "comedia", "Peru", "La puerta secreta comediante", 1997, 10, 2));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia3", "Sandra3", "comedia romantica", "Mexico", "La puerta secreta comediaromantica", 1942, 10, 4));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia4", "Sandra4", "suspenso", "Canada", "La puerta secreta de suspenso", 2015, 8, 8));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia5", "Sandra5", "religiosa", "Colombia", "La puerta secreta religiosa", 2008, 10, 6));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia6", "Sandra6", "trhiller", "Brasil", "La puerta secreta de thriller", 2001, 9, 4));
            playlists1.playlistdepeliculas.Add(new Pelicula("Alexia7", "Sandra7", "Romantica", "Chile", "La puerta secreta romantica", 1976, 6, 7));


            playlists2.playlistdepeliculas.Add(new Pelicula("Persona1", "Sandra1", "terror", "Mexico1", "La puerta secreta de terror", 2005, 5, 1)); 
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona2", "Sandra2", "aventrua", "USA1", "La puerta secreta de aventura", 2009, 3, 2));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona3", "Sandra3", "comedia", "Peru1", "La puerta secreta de comedia", 1997, 10, 1));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona4", "Sandra4", "comedia romantica", "Mexico2", "La puerta secreta de comedia romantica", 1942, 10, 4));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona5", "Sandra5", "suspenso", "Canada1", "La puerta secreta de suspenso", 2015, 9, 4));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona6", "Sandra6", "religiosa", "Colombia1", "La puerta secreta de religion", 2008, 5, 7));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona7", "Sandra7", "trhiller", "Brasil1", "La puerta secreta de brasil", 2001, 4, 9));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona8", "Sandra8", "romantica", "Chile1", "La puerta secreta de chile", 1958, 10, 2));
            playlists2.playlistdepeliculas.Add(new Pelicula("Persona9", "Sandra9", "mexicana", "Costa Rica", "La puerta secreta de costa rica", 2000, 9, 8));




            foreach (Playlist play in playlists)
            {
                Console.WriteLine("*" + play.Titulo + "-" + play.Descripcion);
                foreach(Pelicula peli in  play.playlistdepeliculas)
                {
                    Console.WriteLine("1) *" + peli.Titulo);

                    try
                    {
                        peli.Año = peli.Año;
                        Console.WriteLine("año:" + peli.Año);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("el año no es correcto");
                    }

                }
            }


            Console.Read();

        }
    }
}
