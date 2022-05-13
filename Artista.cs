using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibliotecaMusica
{
    public class Artista
    {
        public string nombre { get; set; }
        public List<Album> albunes { get; set; }
    }
}