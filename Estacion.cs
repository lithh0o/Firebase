using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFirebase
{
    //clase estacion, que contiene el id, el contador, el estado y la orden de la estacion
    class Estacion
    {
        //propiedades de la clase
        public string id { get; set; }
        public int count { get; set; }
        public int state { get; set; }
        public string to { get; set; }
        public int btn { get; set; } // Boton de la estacion



        //constructor que inicializa la estacion con un id, un contador, un estado y una orden
        public Estacion()
        {
            id = "";
            count = 0;
            state = 0; 
            to = "free";
        }

      
    }
}
