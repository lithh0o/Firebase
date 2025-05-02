using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using de firesharp & firebase.Database
//ambos necesarios para conectar a firebase y trafico de datos
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Firebase.Database;
using Firebase.Database.Query;
using System.Reactive.Linq;


namespace appFirebase
{
    //clase dispControl, que hereda de UserControl
    public partial class DispControl : UserControl
    {
        //variables para almacenar el id del dispensario, el estado, el usuario y la estacion
        string usuario, noEstacion;
        int idDisp, estado, totalDisp;

        //configuracion de firebase, con la base de datos y el authSecret
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://appnube-nube-default-rtdb.firebaseio.com/",
            AuthSecret = "tWjG00NHaSXM8uJmTIO8ouIuutG4BFU8QIA6pgso"
        };
        IFirebaseClient client;

        //constructor de la clase, que recibe el id del dispensario, el usuario y el numero de dispensario
        public DispControl(string noEstacion, string usuario, int idDisp, int totalDisp)
        {
            // FirebaseClient para leer datos de Firebase
            var firebaseClient = new FirebaseClient("https://appnube-nube-default-rtdb.firebaseio.com");
            client = new FireSharp.FirebaseClient(config);

            //inicializa las variables
            this.idDisp = idDisp;
            this.noEstacion = noEstacion;
            this.usuario = usuario;
            this.totalDisp = totalDisp;
            InitializeComponent();

            //inicializa el dispensario con el id y el estado
            var Dispensario = new Dispensario(lblDisp.Text, estado, 1);

            //llama a la funcion getDataFirebase para obtener los datos del dispensario
            getDataFirebase();
        }

        //metodo para actualizar el dispensario en firebase
        public async void setDataFirebase(string idDisp, int estado)
        {
            //actualiza el dispensario en firebase, con el id y el estado

            //clase dispensario, que contiene el id y el estado
            var dispensario = new Dispensario(lblDisp.Text, estado, 1);

            //actualiza el dispensario en firebase, con la clase dispensario
            SetResponse response = await client.SetTaskAsync("NUBE/USUARIOS/" + usuario + "/parent " + noEstacion + "/child " + idDisp, dispensario);
            if(response != null)
            {
                //actualiza el dispensario en la interfaz
                getDataFirebase();
            }
            else
            {
                //si no se actualiza, muestra un mensaje de error
                MessageBox.Show("Error updating data.");
            }
           
        }

        public async void getDataFirebase()
        {
            //Funcion para obtener los datos del dispensario de firebase, de tipo ASYNCRONA
            try
            {
                //obtiene el dispensario de firebase, con el id del dispensario y el estado
                FirebaseResponse response = await client.GetTaskAsync("NUBE/USUARIOS/" + usuario + "/parent " + noEstacion + "/child " + idDisp);
                Dispensario dispensario = response.ResultAs<Dispensario>();
                if (dispensario == null)
                {
                    // Si no se encuentra el dispensario, muestra un mensaje de error
                    MessageBox.Show("No data found for the given ID.");
                    return;
                }

                //actualiza el id y el estado del dispensario
                lblDisp.Text = dispensario.id;
                switch (dispensario.state)
                {
                    case 0:
                        // Si el estado es 0, muestra la imagen DESACTIVADA
                        estado = 0;
                        imgDisp.Image = Properties.Resources.gif_cero;
                        break;
                    case 1:
                        // Si el estado es 1, muestra la imagen ACTIVADA
                        estado = 1;
                        imgDisp.Image = Properties.Resources.gif_uno;
                        break;
                    case 2:
                        // Si el estado es 2, muestra la imagen ERROR
                        estado = 2;
                        imgDisp.Image = Properties.Resources.gif_dos;
                        break;
                }
            }
            catch (Exception ex)
            {
                // Si ocurre un error, muestra un mensaje de error
                MessageBox.Show("Error: " + ex.Message);
            }
           ;
        }

        //propiedades para el id del dispensario
        private string _idDisp;

        //propiedad para el id del dispensario
        public string IdDisp
        {
            get { return _idDisp; }
            set { _idDisp = value; }
        }

        //propiedad para el estado del dispensario
        private int _estado;

        private async void btnAct_Click(object sender, EventArgs e)
        {
            // Cambia el estado del dispensario a 1 (activado)
            // Update the state in Firebase
            var dispensario = new Dispensario(lblDisp.Text, 1, 1);
            SetResponse response = await client.SetTaskAsync("NUBE/USUARIOS/" + usuario + "/parent " + noEstacion + "/child " + idDisp, dispensario);
            if(response != null)
            {
                // Update the image and state in the UI
                getDataFirebase();
            }
            else if (response == null)
            {
                getDataFirebase();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }

        }

        private async void btnDes_Click(object sender, EventArgs e)
        {
            // Cambia el estado del dispensario a 0 (desactivado)
            var dispensario = new Dispensario(lblDisp.Text, 0, 1);
            SetResponse response = await client.SetTaskAsync("NUBE/USUARIOS/" + usuario + "/parent " + noEstacion + "/child " + idDisp, dispensario);
            if (response != null)
            {
                getDataFirebase();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }

        private async void btnError_Click(object sender, EventArgs e)
        {
            // Cambia el estado del dispensario a 2 (error)
            var dispensario = new Dispensario(lblDisp.Text, 2, 1);

            SetResponse response = await client.SetTaskAsync("NUBE/USUARIOS/" + usuario + "/parent " + noEstacion + "/child " + idDisp, dispensario);
            if (response != null)
            {
                getDataFirebase();
            }
            else
            {
                MessageBox.Show("Error updating data.");
            }
        }
    }
}
