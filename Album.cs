using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMusica
{
    public class Album
    {
        public string titulo { get; set; }
        public List<Cancion> canciones { get; set; }
        public DateTime publicacion { get; set; }
    }
}