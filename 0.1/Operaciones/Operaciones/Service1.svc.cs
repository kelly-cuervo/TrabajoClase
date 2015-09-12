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

   

        public string Suma(int value, int value2)
        {
            return (value + value2).ToString();
        }

        public string Resta(int value, int value2)
        {
            return (value - value2).ToString();
        }

        public string Multiplicacion(int value, int value2)
        {
            return (value * value2).ToString();
        }

        public string Division(float value, float value2)
        {
            if(value2 !=0){
                return (value / value2).ToString();
            }
            else
            {
                return ("Indefinida");
            }
            
        }


               string IService1.Suma(int value1, int value2)
        {
            throw new NotImplementedException();
        }

        string IService1.Resta(int value1, int value2)
        {
            throw new NotImplementedException();
        }

        string IService1.Division(float value1, float value2)
        {
            throw new NotImplementedException();
        }

        string IService1.Multiplicacion(int value1, int value2)
        {
            throw new NotImplementedException();
        }

        string IService1.ConsultarUsuarios()
        {
            throw new NotImplementedException();

        }

        public List<Usuario> listaUsuario()
            return db.UsuarioSet().ToList;

        public Usuario Consultarusuarios(string nombre)
        {
            var usuariocon = db.UsuarionConjunto.Where(usuario => usuariocon.Login == nombre).First();
            return usuariocon;
        }

        public bool Agregarusuarios(string Persona_Id, string contraseña)
        {
            try
            {
                Usuario nuevo = new Usuario()
                {
                    Persona_Id = Persona_Id,
                    Contraseña = contraseña
                };
                db.UsuarioConjunto.Add(nuevo);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

         public bool Eliminarusuarios(string nombre)
        {
            try
            {
                db.UsuarioConjunto.Remove(Consultarusuarios(nombre));
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Modificarusuarios(string Persona_Id,string contraseña)
        {
            try
            {
                var consulta = db.UsuarioConjunto.Where(Usuario => Usuario.Login.StartsWith(Persona_Id));
                foreach (var Usuario in consulta)
                {
                    Usuario.Persona_Id = Usuario.Persona_Id.Replace(Usuario.Persona_Id, Persona_Id);
                    Usuario.contraseña = Usuario.contraseña.Replace(Usuario.contraseña, contraseña);
                }
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

    }

