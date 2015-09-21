using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;



namespace Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        Model1Container12 db = new Model1Container12();



        public List<Usuario> ConsultarUsuario()
        {
            return db.UsuarioConjunto.Tolist();
           
        }

        public Usuario Consultarusuarios(string nombre)
        {
            var usuariocon = db.UsuarionConjunto.Where(usuario => usuariocon.Login == nombre).First();
            return usuariocon;
        }

        public string Agregarusuarios(string nombre, string contraseña)
        {
            try
            {
                Usuario nuevo = new Usuario()
                {
                    nombre = nombre,
                    Contraseña = contraseña
                };
                db.UsuarioConjunto.Add(nuevo);
                db.SaveChanges();
                return ("Perfect");
            }
            catch (Exception e)
            {
                return ("Error");
            }
        }

        public string EliminarUsuarios(string nombre, string contraseña)
        {
            try
            {
                db.UsuarioConjunto.Remove(Consultarusuarios(nombre));
                db.SaveChanges();
                return ("Perfect");
            }
            catch (Exception e)
            {
                return ("Error");
            }
        }

        public string ModificarUsuarios(string nombre, string correctnom, string correctpass)
        {
            try
            {
                var consulta = db.UsuarioConjunto.Where(Usuario => Usuario.Login.StartsWith(nombre));
                foreach (var Usuario in consulta)
                {
                    Usuario.nombre = Usuario.correctnom.Replace(Usuario.nombre, nombre);
                    Usuario.contraseña = Usuario.correctpass.Replace(Usuario.contraseña, contraseña);
                }
                db.SaveChanges();

                return ("Perfect");
            }
            catch (Exception e)
            {
                return ("Error");
            } throw new NotImplementedException();
        }


    }
}

