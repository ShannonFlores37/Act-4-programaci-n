using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Act_4_programación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Por favor, ingrese un nombre.", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            //2-obtener la opcion seleccionada del combobox
            List<string> Opcion = new List<string>();
            if (rbtnConsulta.Checked)
            {
                Opcion.Add("Motivo: consulta");
            }
            if (rbtnQueja.Checked)
            {
                Opcion.Add("Motivo: queja");
            }
            if (rbtnSugerencia.Checked)
            {
                Opcion.Add("Motivo: sugerencia");
            }
            if (cbxRespuesta.Checked)
            {
                Opcion.Add("Desea recibir respuesta");
            }
            //3-comprobar que se selecciono al menos una opcion
            if (Opcion.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, seleccione al menos una opcion.", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //5-crear el resumen}
            string resumen =
            "CONFIRMACIÓN\r\n" +
            "Nombre: " + txtNombre.Text + "\r\n" +
            "Opcion: " + string.Join(", ", Opcion) + "\r\n" +
            "Modalidad: " + Opcion;
            txtbConfirmacion.Text = resumen;
        }

        private void lllbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                    "Politica de privacidad: " +
                    txtNombre.Text +
                    " Al utilizar nuestro servicio, usted acepta nuestra politica de privacidad." +
                    "1- Solo solicitamos la información estrictamente necesaria "+
                    "2- Utilizamos tus datos exclusivamente para atender tus solicitudes"+
                    "3-No vendemos ni compartimos tu información personal con terceras empresas bajo ninguna circunstancia"
                    , "Validacion",
                        MessageBoxButtons.OK);
        }
    }
    }


