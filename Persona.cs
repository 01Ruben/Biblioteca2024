using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2024
{
    public class Persona
    {

        protected string nombre;
        protected string  apellido;
        protected int edad;
        protected string direccion;
        protected int numero_dni;
        protected string correo_electronico;
        protected int numero_telefono;
        //se usa protected para que las clases hija puedan acceder las variables de la calse padre

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Numero_dni
        {
            get { return numero_dni; }
            set { numero_dni = value; }

        }
        
        
        public string Correo_electronico
        {
            get { return correo_electronico; }
            set { correo_electronico = value; }
        }
        public int Numero_telefono
        {
            get { return numero_telefono;}
            set { numero_telefono = value;}

        }
        

        public Persona (string nombre,string apellido,int edad,
            string direccion,int numero_dni,
            string correo_electronico, int numero_telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            
            this.edad = edad;
            this.direccion= direccion;
            this.numero_dni= numero_dni;
            this.correo_electronico = correo_electronico;
            this.numero_telefono = numero_telefono;


        }

    }
}
