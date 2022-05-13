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
    public partial class Update : System.Web.UI.Page
    {
        static List<Artista> artistas = new List<Artista>();
        static string album;

        protected void Page_Load(object sender, EventArgs e)
        {
            leer();
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/album.json");
            string json = JsonConvert.SerializeObject(artistas);
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            album = txtBuscar.Text;
            bool albumEncontrado = false;
            foreach (var i in artistas)
            {
                Album al = i.albunes.Find(c => c.titulo == album);
                if (al != null)
                {
                    txtNombre.Text = al.titulo;
                    Calendar1.SelectedDate = al.publicacion;
                    albumEncontrado = true;
                }
            }
            if (!albumEncontrado)
            {
                Response.Write("<script>alert('No se encotro al alumno')</script>");
                txtBuscar.Text = "";
                txtNombre.Text = "";                
            }
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/album.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            artistas = JsonConvert.DeserializeObject<List<Artista>>(json);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach (var i in artistas)
            {
                int actualizarAlbum = i.albunes.FindIndex(c => c.titulo == album);
                if (actualizarAlbum > -1)
                {
                    i.albunes[actualizarAlbum].titulo = txtNombre.Text;
                    i.albunes[actualizarAlbum].publicacion = Calendar1.SelectedDate;

                    guardar();
                }
            }
        }
    }
}