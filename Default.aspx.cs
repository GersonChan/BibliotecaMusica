using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMusica
{
    public partial class _Default : Page
    {
        static List<Cancion> canciones = new List<Cancion>();
        static List<Album> albunes = new List<Album>();
        static List<Artista> artistas = new List<Artista>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                leer();
            }
        }

        protected void btnCancion_Click(object sender, EventArgs e)
        {
            Cancion cancionTemp = new Cancion();
            cancionTemp.nombre = txtNomCancion.Text;
            cancionTemp.tiempo = txtDuracion.Text;

            canciones.Add(cancionTemp);

            GridView1.DataSource = canciones;
            GridView1.DataBind();

            txtNomCancion.Text = "";
            txtDuracion.Text = "";
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/album.json");
            string json = JsonConvert.SerializeObject(artistas);
            System.IO.File.WriteAllText(archivo, json);
        }


        protected void btnAlbum_Click(object sender, EventArgs e)
        {
            Album albumTemp = new Album();
            albumTemp.titulo = txtTitulo.Text;
            albumTemp.canciones = canciones.ToArray().ToList();
            albumTemp.publicacion = CalendarFecha.SelectedDate;

            albunes.Add(albumTemp);
            canciones.Clear();

            txtTitulo.Text = "";
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/album.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            artistas = JsonConvert.DeserializeObject<List<Artista>>(json);
        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Artista artistaTemp = new Artista();
            artistaTemp.nombre = txtArtista.Text;
            artistaTemp.albunes = albunes.ToArray().ToList();

            artistas.Add(artistaTemp);
            guardar();
            albunes.Clear();
        }
    }
}