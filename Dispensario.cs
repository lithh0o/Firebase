using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFirebase
{
    //clase dispensario, que contiene el id y el estado del dispensario
    class Dispensario
    {
        // Propiedades del dispensario
        public string id { get; set; }
        public int state { get; set; }
        public int order { get; set; }

        public int totalDisp { get; set; } // Total de dispensarios

        // Constructor que inicializa el dispensario con un id y un estado
        public Dispensario(string id, int state, int order)
        {
            this.id = id;
            this.state = state;
            this.order = order;
        }       
        
        public Dispensario()
        {
            // Constructor vacío ok
        }
    }
}
