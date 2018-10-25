using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema_JEGL.Models
{
 
       public class Pelicula
        {
            public string Nombre { get; set; }
            public DateTime FechaEstreno { get; set; }
            public string Genero { get; set; }
            public string Recomendacion { get; set; }
            public int Duracion { get; set; }
            public string Imagen { get; set; }
            //public Funcione[] Funciones { get; set; }
        }
    
}
