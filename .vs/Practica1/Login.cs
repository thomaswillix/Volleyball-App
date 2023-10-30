using System;
using System.Drawing.Text;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Login : Form
    {
        //private string[] listaUsuariosNombre = new string[6];
        //private string[] listaUsuariosClave = new string[6];
        private string[,] matrizUsuarios = new string[6, 2];
        private int intentos = 0;
        

        public Login()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }    
        /*private void cargarUsuarios()
        {
            listaUsuariosNombre[0] = "root";
            listaUsuariosNombre[1] = "juan";
            listaUsuariosNombre[2] = "jaime";
            listaUsuariosNombre[3] = "jose";
            listaUsuariosNombre[4] = "javier";
            listaUsuariosNombre[5] = "jorge";
            listaUsuariosClave[0] = "1234";
            listaUsuariosClave[1] = "4321";
            listaUsuariosClave[2] = "4444";
            listaUsuariosClave[3] = "1111";
            listaUsuariosClave[4] = "2222";
            listaUsuariosClave[5] = "3333";
        }*/
        private void cargarUsuariosBetter()
        {
            matrizUsuarios[0, 0] = "root";
            matrizUsuarios[1, 0] = "juan";
            matrizUsuarios[2, 0] = "jaime";
            matrizUsuarios[3, 0] = "jose";
            matrizUsuarios[4, 0] = "javier";
            matrizUsuarios[5, 0] = "jorge";
            matrizUsuarios[0, 1] = "1234";
            matrizUsuarios[1, 1] = "4321";
            matrizUsuarios[2, 1] = "4444";
            matrizUsuarios[3, 1] = "1111";
            matrizUsuarios[4, 1] = "2222";
            matrizUsuarios[5, 1] = "3333";
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Has pulsado Aceptar");    
            string usuario = cuadroUsu.Text.ToLower();
            string contrasena = cuadroCont.Text.ToLower();
            if(validaLoginBetter(ref usuario, ref contrasena) == true){
                cuadroUsu.Clear();
                cuadroCont.Clear();
                Principal Form = new Principal();
                Form.Show();
                this.Close();
            }
            else
            {
                intentos++;
                cuadroUsu.Clear();
                cuadroCont.Clear();
                cuadroUsu.Focus();
                if (intentos >=3)
                {
                    MessageBox.Show("Llevas 3 intentos");
                    intentos = 0;
                    Application.Exit();
                }
            }
            // En la llamada es necesario pasarlo como ref | out
        }
       /* bool validaLogin(ref string user, ref string pass)
        // también se puede utilizar out
        {
            bool encontrado = false;
            for (int i = 0; i < listaUsuariosNombre.Length && !encontrado; i++)
            {
                if (user == listaUsuariosNombre[i])
                {
                    if (pass == listaUsuariosClave[i])
                    {
                       return true;
                    }
                    else
                    {
                        MessageBox.Show("Clave Incorrecta");
                        return false;
                    }
                }    
            }
            return false;
        }*/
        bool validaLoginBetter(ref string usuario, ref string clave)
        {
            for(int i = 0; i <= matrizUsuarios.GetUpperBound(0); i++)
            // el método GetUpperBound devuelve la última posición 
            // ocupada de una dimensión, en este caso quiero la primera, 
            // es decir la 0 y devolverá 5
            {
                if (matrizUsuarios[i, 0] == usuario.ToLower())
                {
                    if (matrizUsuarios[i, 1] == clave)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        return false;
                    }
                }
            }
            return false;

        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Has pulsado Cancelar");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void IblError_Click(object sender, System.EventArgs e)
        {

        }

        private void GestionaIES_Load(object sender, System.EventArgs e)
        {
            //cargarUsuarios();
            cargarUsuariosBetter();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            Label nuevaLbl = new Label();
            nuevaLbl.Text = "PRUEBA";
            nuevaLbl.Location = new System.Drawing.Point(100, 25);
            nuevaLbl.Size = new System.Drawing.Size(70, 20);
            this.Controls.Add(nuevaLbl);
        }
    }
}
