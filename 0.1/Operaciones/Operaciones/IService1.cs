using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Operaciones
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
       
        
 
        [OperationContract]
        [WebInvoke(Method =  "GET", UriTemplate = "mostrarUsuarios", ResponseFormat = WebMessageFormat.Json)]
        List<Usuario> ConsultarUsuario();
       
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "mostrarUsuarios/{nombre}", ResponseFormat = WebMessageFormat.Json)]
        Usuario Consultarusuarios(string nombre);

        [OperationContract]
        [WebInvoke(Method =  "GET", UriTemplate = "agregarusuarios", ResponseFormat = WebMessageFormat.Json)]
        string AgregarUsuarios(string nombre, string contraseña);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "eliminarusuarios/{nombre}/{contraseña}", ResponseFormat = WebMessageFormat.Json)]
        string EliminarUsuarios(string nombre, string contraseña);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "modificarusuarios/{nombre}/{correctnom}/{correctpass}", ResponseFormat = WebMessageFormat.Json)]
        string ModificarUsuarios(string nombre, string contraseña);


       
        
        
        
        
        [DataContract]
        public class usuario
        {

            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Usuario { get; set; }

            [DataMember]
            public string Contraseña { get; set; }



            [OperationContract]
            List <Usuario> listaUsuarios();



        }


        

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    
}
