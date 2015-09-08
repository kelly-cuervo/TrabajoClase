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
        
        String var_cadenaconexion = (@"server=(localdb)\Projects;database=BD_GuiaPrueba;integrated security=true");
        SqlConnection var_conexion = new SqlConnection();
        SqlCommand var_comando = new SqlCommand();
        SqlDataAdapter var_adaptador = new SqlDataAdapter();

        private void abrirconexion()
        {
            var_conexion.ConnectionString = var_cadenaconexion;
            var_conexion.Open();

        }

        private void cerrarconexion()
        {
            var_conexion.Close();
        }


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


        public string ConsultarUsuarios()
        {
            abrirconexion();
            

            throw new NotImplementedException();
        }
    }
}
