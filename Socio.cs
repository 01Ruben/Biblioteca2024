using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca2024
{
    public class Socio : Persona
    {
        private int numero_socio;
        List<Libro> libros_prestados; 




        public int Numero_socio
        {
            get { return numero_socio; }
            set { numero_socio = value; }
        }
        public Socio(string nombre, string apellido, int edad,
                string direccion, int numero_dni,
                string correo_electronico, int numero_telefono,
                int numeroSocio )
                : base(nombre, apellido, edad, direccion, numero_dni, correo_electronico, numero_telefono)
        {
            this.numero_socio = numeroSocio;
            this.Apellido = apellido;

         libros_prestados= new List<Libro>(1);
        }
        
        public string  Mostrar_Datos()
        {
            return "nombre: " + nombre +
                              "apellido " + apellido +
                              "numero de socio " + numero_socio;
                  
        }

        
            

                
        
        //metodo libro prestado



    }   
}
