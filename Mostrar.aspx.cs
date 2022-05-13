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
    public partial class Mostrar : System.Web.UI.Page
    {
        static List<Artista> artistas = new List<Artista>();
        static string album;

        protected void Page_Load(object sender, EventArgs e)
        {
            leer();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            album = txtBuscar.Text;
            foreach (var i in artistas)
            {
                Artista ar = artistas.Find(c => c.nombre == album);
                if (ar != null)
                {
                    GridView1.DataSource = ar.albunes;
                    GridView1.DataBind();
                }
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
    }
}