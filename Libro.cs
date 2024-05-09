using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2024
{
    public class Libro
    {
        string titulo;
        private string autor;
        private int codigo;
        private string editorial;
        private string genero;
        private DateTime fecha_prestamo;
        private DateTime fecha_devolucion;
        private bool estado;
        private int dni_socio;
       
        
        public string Titulo( )
        {
            return titulo;
        }
        public int Codigo()
        {
            return codigo;

        }


        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }

        }
        public int Dni_socio
        {
            get { return dni_socio; }
            set { dni_socio = value; }
        }
        public DateTime Fecha_prestamo
        {
            get { return fecha_prestamo; }
            set { fecha_prestamo = value; }
        }
        public DateTime Fecha_devolucion
        {
            get { return fecha_devolucion; }
            set { fecha_devolucion = value; }
        }

        public Libro(string titulo, string autor, int codigo, string editorial, string genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.codigo = codigo;
            this.editorial = editorial;
            this.genero = genero;
            this.estado = true;


        }
    }

    
        
}
