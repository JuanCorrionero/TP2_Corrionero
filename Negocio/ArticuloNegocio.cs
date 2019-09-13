using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-IRCN5AN\\SQLEXPRESS; initial catalog=TP2_DbCorrionero; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.nombre, A.descripcion, A.precio from Articulos as A";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    aux = new Articulo();
                    aux.Nombre = lector.GetString(2); // lector["nombre"].ToString();
                    aux.Descripcion = lector.GetString(3); // lector["descripcion"].ToString();
                    aux.Precio = lector.GetDecimal(6);

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }

        public void agregar(Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {

                conexion.ConnectionString = "data source=DESKTOP-IRCN5AN\\SQLEXPRESS; initial catalog=TP2_DbCorrionero; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into Articulos values (@Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio, @Imagen)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Id);
                comando.Parameters.AddWithValue("IdMarca", articulo.Marca.Id);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                comando.Parameters.AddWithValue("@Imagen", articulo.Imagen);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.Close();
            }

        }

    }

        

}
