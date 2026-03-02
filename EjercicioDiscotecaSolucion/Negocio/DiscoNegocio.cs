using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listarDisco()
        {
            List<Disco> listaDisco = new List<Disco>();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try
            {
                connection.ConnectionString = "server=.\\SQLEXPRESS01; database=DISCOS_DB; integrated security=true";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select D.Id, D.Titulo, D.CantidadCanciones, D.FechaLanzamiento, D.UrlImagenTapa, S.Descripcion Estilo, E.Descripcion Edicion from DISCOS D, ESTILOS S, TIPOSEDICION E where D.IdEstilo = S.Id and D.IdTipoEdicion = E.Id";
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Disco discoHelper = new Disco();
                    discoHelper.Id = (int)reader["Id"];
                    discoHelper.TitleAlbum = (string)reader["Titulo"];
                    discoHelper.Songs = (int)reader["CantidadCanciones"];
                    discoHelper.LaunchDate = (DateTime)reader["FechaLanzamiento"];
                    discoHelper.UrlCover = (string)reader["UrlImagenTapa"];
                    discoHelper.Style = new Estilo();
                    discoHelper.Style.Description = (string)reader["Estilo"];
                    discoHelper.Edition = new Edicion();
                    discoHelper.Edition.Description = (string)reader["Edicion"];
                    listaDisco.Add(discoHelper);
                }


                return listaDisco;

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
        }
    }
}
