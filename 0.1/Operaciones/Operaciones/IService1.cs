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
        string Suma(int value1, int value2);

        [OperationContract]
        string Resta(int value1,int value2);

       

        [OperationContract]
        string Division(float value1, float value2);



        [OperationContract]
        string Multiplicacion(int value1, int value2);


        [OperationContract]
        Usuario ConsultarUsuarios(string Persona_Id);


        [OperationContract]
        Boolean AgregarUsuarios(string Persona_Id, string contraseña);


        [OperationContract]
        Boolean EliminarUsuarios(string Persona_Id, string contraseña);


        [OperationContract]
        Boolean ModificarUsuarios(string Persona_Id, string contraseña);


        [DataContract]
        public class Persona_
        {

            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Nombres { get; set; }

            [DataMember]
            public string Apellidos { get; set; }

            [DataMember]
            public string Telefono { get; set; }

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
