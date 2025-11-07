using Guia_Examen_13.Models;

namespace Guia_Examen_13
{
    public partial class Form1 : Form
    {
        Sistema miEmpresa = new Sistema();
        int camionElegido;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarPaquete_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string cam in miEmpresa.CamionesCargados())
            {
                cbCamiones.Items.Add(cam);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (camionElegido > -1)
            {
                double peso = 12;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                string nombre = $"{camionElegido.ToString("000")}carga.csv";
                fs = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.Write);
                miEmpresa.RetirarCamion(fs,camionElegido);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
          
        }
    }
}
