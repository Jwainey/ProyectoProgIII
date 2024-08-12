using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProgramaRestaurante.Consultas
{
    public partial class MatenimientoProductos : Form
    {
        public MatenimientoProductos()
        {
            InitializeComponent();           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        private void iconSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar el filtro para mostrar solo archivos de imagen
            openFileDialog.Filter = "Archivos de imagen (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            // Mostrar el cuadro de diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string filePath = openFileDialog.FileName;

                // Aquí puedes cargar la imagen en un PictureBox, por ejemplo
                pictureBox.Image = Image.FromFile(filePath);
            }
        }
    }
}
