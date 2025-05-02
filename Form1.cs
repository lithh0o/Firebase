
//using de firesharp & firebase.Database
//ambos necesarios para conectar a firebase y trafico de datos
using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace appFirebase
{
    public partial class Form1 : Form
    {
        //Clases para leer y escribir
        String usuario;
        DispControl[] lists;
        Estacion estacion = new Estacion();
        int totalDisp;
        //Configuracion de firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://appnube-nube-default-rtdb.firebaseio.com/",
            AuthSecret = "tWjG00NHaSXM8uJmTIO8ouIuutG4BFU8QIA6pgso"
        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

            // Conectarse a databaseFirebasse
            var firebaseClient = new FirebaseClient("https://appnube-nube-default-rtdb.firebaseio.com");

            //Subscribirse a los cambios en firebase
            leerFirebase(firebaseClient);
        }

        private async void populateItems()
        {
            // Limpiar los controles existentes en el FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear(); 
            try
            {
                // configurar la clase estacion
                if (txtDisp.Text != "")
                {                    
                    estacion.count = Convert.ToInt32(txtDisp.Text);
                    estacion.id = txtEst.Text;
                }
            }
            catch (Exception ex)
            {
                return;
            }
            // Crear instancias de DispControl y agregarlas al FlowLayoutPanel
            lists = new DispControl[estacion.count]; // Assuming you want to create 5 DispControl instances
            for (int i = 0; i < lists.Length; i++)
            {
                // Crear una nueva instancia de DispControl para cada dispensario
                lists[i] = new DispControl(txtEst.Text, txtUser.Text, i + 1, totalDisp);
                lists[i].IdDisp = (i + 1).ToString();

                //Agregar al panel el dispensario
                flowLayoutPanel1.Controls.Add(lists[i]);

            }

            //obtener el usuario
            String usuario = txtUser.Text; 
            try
            {
                // Conectar a Firebase
                client = new FireSharp.FirebaseClient(config);

                // Obtener la información de Firebase de la estacion
                FirebaseResponse response = await client.GetTaskAsync("NUBE/SET/" + usuario + "/parent " + estacion.id);

                // Obtener la información de Firebase de la estacion
                // se guarda en una nueva classe de tipo Estacion
                Estacion est = response.ResultAs<Estacion>();
                if (est == null)
                {
                    // Si no se encontró la estación, mostrar un mensaje de error
                    return;
                }
                else
                {
                    // Si se encontró la estación, actualizar la información de la estacion
                    estacion.state = est.state;
                }
            }
            catch (Exception ex)
            {
                // Si no se pudo conectar a Firebase, mostrar un mensaje de error
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnFirebaseClick(object sender, EventArgs e)
        {
            //ir al tab de dispensarios
            tabControl1.SelectedTab = tabDisp;
            usuario = txtUser.Text;
            totalDisp = Convert.ToInt32(txtDisp.Text);
            lblEstacion.Text = txtEst.Text + " " + txtUser.Text;
            //cargar los dispensarios en el tab
            populateItems();

            // Conectarse a databaseFirebasse
            var firebaseClient = new FirebaseClient("https://appnube-nube-default-rtdb.firebaseio.com");
            leerFirebase(firebaseClient);

        }

        private async void btnActivar(object sender, EventArgs e)
        {
            //Activar dispensarios mediante una funcion ASYNCRONA
            for (int i = 0; i < lists.Length; i++)
            {
                //Gif para indicar que se espera respuesta
                lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                //en este apartado se mandaria a activar, desactivar el dispensario 
                //Agregando lo necesario para esperar respuesta
                //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase 
                //conforme ah la respuesta obtenida

                //Mensaje que simula envio activar y espera la respuesta
                MessageBox.Show("Activando dispensario " + lists[i].IdDisp);

                //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                int respuesta = 1;

                //se le manda a firebase la informacion
                lists[i].setDataFirebase(lists[i].IdDisp, respuesta);
            }
            try
            {
                //Decirle a la firebase que ya termino de activar
                //y que ya no espera respuesta, y esta libre para activar oh desactivar 

                //usuario que se mandara a firebase
                String usuario = txtUser.Text;

                //se le dira a firebase que lo ultimo que se mando fue activado
                estacion.state = 1;

                //se le dire a firebase que ya no espera respuesta
                estacion.to = "free";

                //se le manda a firebase la informacion
                SetResponse response = await client.SetTaskAsync("NUBE/SET/" + usuario + "/parent " + estacion.id, estacion);
                if (response != null)
                {
                    //Se actualizo la informacion correctamente
                    estacion.state = 1;
                }
            }
            catch (Exception ex)
            {
                //Si no se actualizo la informacion correctamente
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private async void btnDesactivar(object sender, EventArgs e)
        {
            //Desactivar dispensarios mediante una funcion ASYNCRONA
            for (int i = 0; i < lists.Length; i++)
            {
                //Gif para indicar que se espera respuesta
                lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                //en este apartado se mandaria a activar, desactivar el dispensario
                //Agregando lo necesario para esperar respuesta
                //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase
                //conforme ah la respuesta obtenida

                //Mensaje que simula envio activar y espera la respuesta
                MessageBox.Show("Desactivando dispensario " + lists[i].IdDisp);

                //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                int respuesta = 0;

                //se le manda a firebase la informacion
                lists[i].setDataFirebase(lists[i].IdDisp, 0);
            }

            try
            {
                //Decirle a la firebase que ya termino de activar
                //y que ya no espera respuesta, y esta libre para activar oh desactivar 

                //usuario que se mandara a firebase
                String usuario = txtUser.Text;

                //se le dira a firebase que lo ultimo que se mando fue desactivado
                estacion.state = 0;

                //se le dire a firebase que ya no espera respuesta
                estacion.to = "free";

                //se le manda a firebase la informacion
                SetResponse response = await client.SetTaskAsync("NUBE/SET/" + usuario + "/parent " + estacion.id, estacion);
                if (response != null)
                {
                    //Se actualizo la informacion correctamente
                    estacion.state = 0;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                //Si no se actualizo la informacion correctamente
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void leerFirebase(FirebaseClient firebaseClient)
        {
            //Leer firebase siempre
            //para saber que se mando activar oh desactivar desde la app

            //usuario que se mandara a firebase
            usuario = txtUser.Text;
            //escuchador de firebase en la tabla set del usuario
            var observable = firebaseClient
                .Child("NUBE") //Base de datos
                .Child("SET")  //tabla para configurar si activar oh desactivar
                .Child(usuario)  //relacion del usuario
                .AsObservable<Estacion>().Subscribe(async est => 
                {
                    try
                    {
                        //obtener la estacion
                        if (est.Object != null)
                        {
                            //si la estacion es igual a la que se esta configurando
                            //se manda a activar oh desactivar
                            if (est.Key == "parent " + txtEst.Text)
                                switch (est.Object.to)
                                {
                                    case "onon":
                                        //Activar dispensarios cuando estan activados
                                        for (int i = 0; i < lists.Length; i++)
                                        {
                                            //Gif para indicar que se espera respuesta
                                            lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                                            //en este apartado se mandaria a activar, desactivar el dispensario 
                                            //Agregando lo necesario para esperar respuesta
                                            //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase 
                                            //conforme ah la respuesta obtenida

                                            //pausa para ver que se esta activando y se espera una respuesta
                                            Thread.Sleep(Convert.ToInt32(txtTime.Text));

                                            //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                                            int respuesta = 1;

                                            //se le manda a firebase la informacion
                                            lists[i].setDataFirebase(lists[i].IdDisp, respuesta);
                                        }
                                        break;
                                    case "onoff":
                                        //Activar dispensarios cuando estan desactivados
                                        for (int i = 0; i < lists.Length; i++)
                                        {
                                            //Gif para indicar que se espera respuesta
                                            lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                                            //en este apartado se mandaria a activar, desactivar el dispensario 
                                            //Agregando lo necesario para esperar respuesta
                                            //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase 
                                            //conforme ah la respuesta obtenida

                                            //pausa para ver que se esta activando y se espera una respuesta
                                            Thread.Sleep(Convert.ToInt32(txtTime.Text));

                                            //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                                            int respuesta = 1;

                                            //se le manda a firebase la informacion
                                            lists[i].setDataFirebase(lists[i].IdDisp, respuesta);
                                        }
                                        break;
                                    case "offon":
                                        //Desactivar dispensarios cuando estan activados
                                        for (int i = 0; i < lists.Length; i++)
                                        {
                                            //Gif para indicar que se espera respuesta
                                            lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                                            //en este apartado se mandaria a activar, desactivar el dispensario 
                                            //Agregando lo necesario para esperar respuesta
                                            //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase 
                                            //conforme ah la respuesta obtenida

                                            //pausa para ver que se esta activando y se espera una respuesta
                                            Thread.Sleep(Convert.ToInt32(txtTime.Text));

                                            //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                                            int respuesta = 0;

                                            //se le manda a firebase la informacion
                                            lists[i].setDataFirebase(lists[i].IdDisp, respuesta);
                                        }
                                        break;
                                    case "offoff":
                                        //Desactivar dispensarios cuando estan desactivados
                                        for (int i = 0; i < lists.Length; i++)
                                        {
                                            //Gif para indicar que se espera respuesta
                                            lists[i].imgDisp.Image = Properties.Resources.gifBlack;

                                            //en este apartado se mandaria a activar, desactivar el dispensario 
                                            //Agregando lo necesario para esperar respuesta
                                            //Despues de obtrener la respuesta se cambia el gif y se actualiza el firebase 
                                            //conforme ah la respuesta obtenida

                                            //pausa para ver que se esta activando y se espera una respuesta
                                            Thread.Sleep(Convert.ToInt32(txtTime.Text));

                                            //respuesta obtenida, 1=activado, 0=desactivado, 2=error
                                            int respuesta = 0;

                                            //se le manda a firebase la informacion
                                            lists[i].setDataFirebase(lists[i].IdDisp, respuesta);
                                        }
                                        break;

                                    default:
                                        break;
                                }

                            //se le dira a firebase que termino de activar o desactivar
                            //se le dira a firebase que ya no espera respuesta
                            //se le manda a firebase la informacion

                            //usuario que se mandara a firebase
                            String usuario = txtUser.Text;

                            //se le dire a firebase que ya no espera respuesta
                            estacion.to = "free";
                            try
                            {
                                //se le manda a firebase la informacion
                                SetResponse response = await client.SetTaskAsync("NUBE/SET/" + usuario + "/parent " + estacion.id, estacion);
                                if (response != null)
                                {
                                    //Se actualizo la informacion correctamente
                                }
                                else
                                {
                                    //Si no se actualizo la informacion correctamente
                                }
                            }
                            catch (Exception ex) { }      
                            }
                        else
                        {
                            //Si no se actualizo la informacion correctamente
                        }
                    }
                    catch
                    {
                        //Si no se actualizo la informacion correctamente
                    }
                });
        }

    }
} 






