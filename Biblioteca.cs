using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca2024
{
    public class Biblioteca
    {
        string nombre_bibloteca;
        List<Libro> lista_libros;
        List<Socio> lista_socios;
        List<SocioLector> lista_lectores;

        public Biblioteca()
        {
            this.nombre_bibloteca = "uno";

        }
        public string AgregarLibro(Libro libro)
        {
            lista_libros.Add(libro);
            return "se agrego el libro: " + libro.Titulo(); //viene de titulo libro
        }
        public string EliminarLibro(int codigo)
        {
            foreach (Libro libro in lista_libros)
            {
                if (libro.Codigo() == codigo)
                {
                    lista_libros.Remove(libro);
                    return "se elimino el libro: " + libro.Titulo();
                }
                
            }
            return " el libro no se encuentra en la biblioteca";
        }
        public string AltaSocio(Socio socio)
        {
            lista_socios.Add(socio);
            return "se agrego un nuevo socio" + socio.Mostrar_Datos();
        }
        public string BajaSocio (int numero_socio)
        {
            foreach (Socio socio in lista_socios)
            {
                if (socio.Numero_socio == numero_socio)
                {
                    lista_socios.Remove(socio);
                    return "el socio fue eliminado exitosament";

                }

            }
            return "el socio no se encuentra inscripto";
        }
        public string AltaSocioLector(SocioLector socio)
        {
            lista_lectores.Add(socio);
            return "se agrego un nuevo socio" + socio.Mostrar_Datos();
        }
        public string BajaSocioLector(int numero_socio)
        {
            foreach (SocioLector socio in lista_lectores)
            {
                if (socio.Numero_socio == numero_socio)
                {
                    lista_lectores.Remove(socio);
                    return "el socio fue eliminado exitosament";

                }

            }
            return "el socio no se encuentra inscripto";
        }
        public string PrestamoLibro(int numeo_socio,int codigo)
        {
            Libro book;

            foreach (Libro libro in lista_libros)
            {
                if (libro.Codigo()  == codigo)
                {
                    book = libro; 
                }
            }
            foreach (Socio socio in lista_socios)
            {
                if (socio.Numero_socio == numeo_socio)
                {

                }
            }//TODO 
        }






    }
}
