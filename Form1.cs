using System.IO;
namespace _3O_Practica05_ProgramacionAvanzada
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los controles después de guardar
            txtNombre.Clear();
            txtApellido.Clear();
            txtEstatura.Clear();
            txtTelefono.Clear();
            txtEdad.Clear();
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // obtener los datos de los TextBox

            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string edad = txtEdad.Text;
            string estatura = txtEstatura.Text;
            string telefono = txtTelefono.Text;
            string genero = "";

            if (rbtnHombre.Checked == true)
            {
                genero = "Hombre";

            }
            else if (rbtnMujer.Checked == true)
            {
                genero = "Mujer";
            }
            
            string datos = "Datos guardados con éxito: \nNombre : " + nombres + "\nApellido : " + apellidos + "\nEdad : " + edad + "\nEstatura : " + estatura + "\nTelefono : " + telefono + "\nGenero : " + genero + "\n";
            MessageBox.Show(datos);
            string rutaArchivo = "C:/Users/pooll/Documents/Datos.txt";
            bool archivoExiste = File.Exists(rutaArchivo);
            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine(datos);
                    }

                }
            }
          
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
           
                e.Handled = true;
            }
        }
    }
}