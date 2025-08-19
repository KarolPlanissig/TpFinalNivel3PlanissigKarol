using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesNegocio
{
    public class UsuarioNegocio
    {
        public bool validarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, email, pass, nombre, admin from USERS where email = @Email and pass = @Contraseña");
                datos.setearParametro("@Email", usuario.Email);
                datos.setearParametro("@Contraseña", usuario.Contraseña);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.Admin = (bool)datos.Lector["admin"];
                    if (datos.Lector["Nombre"] is DBNull)
                    {
                        usuario.Nombre = "--";
                    }
                    else
                    {
                        usuario.Nombre = (string)datos.Lector["Nombre"];

                    }
                    
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void insertarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into USERS (email, nombre, apellido, pass, admin) Values (@Email, @Nombre, @Apellido, @Pass, 0)");

                datos.setearParametro("@Email", usuario.Email);
                datos.setearParametro("@Nombre", usuario.Nombre);
                datos.setearParametro("@Apellido", usuario.Apellido); 
                datos.setearParametro("@Pass", usuario.Contraseña);

                datos.ejecutarAccion();
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }




        }

        public bool esAdmin(Usuario usuario)
        {
            if(usuario.Admin)
            {
                return true; 
            }
            return false; 
        }

        public void agregarFavorito (string IdArticulo, int IdUsuario)
        {

            AccesoDatos datos = new AccesoDatos();
          
            try
            {

                datos.setearConsulta("Insert into FAVORITOS (IdUser, IdArticulo) Values (@IdUser, @IdArticulo)");

                datos.setearParametro("@IdUser", IdUsuario);
                datos.setearParametro("@IdArticulo", IdArticulo);

                datos.ejecutarAccion(); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();    
            }
        }

    }

    
}
