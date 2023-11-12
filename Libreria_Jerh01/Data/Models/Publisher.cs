using Libreria_Jerh01.Data.Models;
using System.Collections.Generic;

namespace Libreria_Jerh01.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Propiedades de navegacion
        public List<Books> Books { get; set; }

        


    }
}
