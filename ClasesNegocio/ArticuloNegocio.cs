using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace ClasesNegocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("Select A.Id, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio, A.Codigo, M.Id IdM, C.Id IdC from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdCategoria = C.Id and A.IdMarca = M.Id");
            datos.ejecutarLectura();

            try
            {
                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();

                    art.Id = (int)datos.Lector["Id"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    art.Marcas = new Marcas();
                    art.Marcas.Descripcion = (string)datos.Lector["Marca"];
                    art.Marcas.Id = (int)datos.Lector["IdM"];
                    art.Codigo = (string)datos.Lector["Codigo"];
                    art.Categoria = new Categorias();
                    art.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    art.Categoria.Id = (int)datos.Lector["IdC"];
                    if (datos.Lector["ImagenUrl"] is DBNull)
                    {
                        art.ImagenUrl = "https://cdn-icons-png.flaticon.com/512/85/85488.png";
                    }
                    else
                    {
                        art.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }
                    art.Precio = (decimal)datos.Lector["Precio"];

                    articulos.Add(art);
                }

                return articulos;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Marcas> listarMarcas()
        {
            List<Marcas> listaMarcas = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos(); //Nace con objetos ya que la clase
                                                   //tiene un constructor.
            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.Id = (int)datos.Lector["Id"];

                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(aux);
                }

                return listaMarcas;
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
        public List<Categorias> listarCategoria()
        {
            List<Categorias> listaCategoria = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategoria.Add(aux);

                }
                return listaCategoria;
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
        public void agregarArticulo(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @Imagen, @IdMarca, @IdCategoria, @Precio)");

                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Imagen", art.ImagenUrl);
                datos.setearParametro("@IdMarca",art.Marcas.Id);
                datos.setearParametro("@IdCategoria", art.Categoria.Id);
                datos.setearParametro("@Precio", art.Precio);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool modificarArticulo(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, ImagenUrl = @Imagen, Precio = @Precio Where Id = @Id");
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@Imagen", art.ImagenUrl);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@Id", art.Id);

                datos.ejecutarAccion();
                return true;

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Articulo> listarFavoritos(string id)
        {
            List<Articulo> favoritos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            datos.setearConsulta("Select A.Id, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C, FAVORITOS F where A.IdCategoria = C.Id and A.IdMarca = M.Id and F.IdArticulo = A.Id and F.IdUser = @IdUser");
            datos.setearParametro("@IdUser", id);
            datos.ejecutarLectura();

            try
            {

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo();

                    art.Id = (int)datos.Lector["Id"];
                    art.Nombre = (string)datos.Lector["Nombre"];
                    art.Descripcion = (string)datos.Lector["Descripcion"];
                    art.Marcas = new Marcas();
                    art.Marcas.Descripcion = (string)datos.Lector["Marca"];
                    art.Categoria = new Categorias();
                    art.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (datos.Lector["ImagenUrl"] is DBNull)
                    {
                        art.ImagenUrl = "https://cdn-icons-png.flaticon.com/512/85/85488.png";
                    }
                    else
                    {
                        art.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    }
                    art.Precio = (decimal)datos.Lector["Precio"];

                    favoritos.Add(art);

                }

                return favoritos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Articulo devolverArticulo(string id)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> articulos = negocio.listarArticulos();

            foreach (var articulo in articulos)
            {
                if (articulo.Id.ToString() == id)
                {
                    return articulo;
                }
            }
            return null;
        }

        public void eliminarArticulo(string id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
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
