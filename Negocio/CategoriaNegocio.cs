using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria aux;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-IRCN5AN\\SQLEXPRESS; initial catalog=TP2_DbCorrionero; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT C.descripcion from Categoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    aux = new Categoria();
                    aux.Descripcion = lector["descripcion"].ToString();
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

            public void Agregar(Categoria categoria)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {

                conexion.ConnectionString = "data source=DESKTOP-IRCN5AN\\SQLEXPRESS; initial catalog=TP2_DbCorrionero; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into Categoria values ('" + categoria.Descripcion + "')";
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
