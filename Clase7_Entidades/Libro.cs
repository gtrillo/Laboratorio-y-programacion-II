using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7_Entidades
{
    internal class Libro
    {
        private List<string> paginas;
        public Libro()
        {
            paginas = new List<string>();
        }

        public string this [int index]
        {
            get { return paginas[index]; }
            //se agrega una nueva pagina en el caso de que el indice sea mayor al numero de paginas existente
            set { if (index > paginas.Count)
                {
                    paginas.Add (value);
                }
            //en el caso de que el indice se encuentre dentro de los limites de las paginas existente se insetar la pagina
                else if (index >= 0)
                {
                    this.paginas.Insert(index, value);
                }
                }
        }

    }
}
