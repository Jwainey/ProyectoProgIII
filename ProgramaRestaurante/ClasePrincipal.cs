﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ProgramaRestaurante.Consultas;


namespace ProgramaRestaurante
{
    public partial class ClasePrincipal : Form
    {
        public ClasePrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void ClasePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            PanelBttnMant.Visible = !PanelBttnMant.Visible;
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            ConsultaTipoMoneda venta = new ConsultaTipoMoneda();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PanelBttnCons.Visible = !PanelBttnCons.Visible;
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBttnCons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelBttnMant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton24_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            PanelBttnProc.Visible = !PanelBttnProc.Visible;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ConsultaAlimento venta = new ConsultaAlimento();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ConsultaDepartamentos venta = new ConsultaDepartamentos();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton33_Click(object sender, EventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton24_Click_1(object sender, EventArgs e)
        {
            ConsultaCliente venta = new ConsultaCliente();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton22_Click(object sender, EventArgs e)
        {
            ConsultaSalas venta = new ConsultaSalas();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton21_Click(object sender, EventArgs e)
        {
            ConsultaMesas venta = new ConsultaMesas();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton19_Click(object sender, EventArgs e)
        {
            ConsultaImpuestos venta = new ConsultaImpuestos();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton18_Click(object sender, EventArgs e)
        {
            ConsultaProveedores venta = new ConsultaProveedores();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            ConsultaMedidas venta = new ConsultaMedidas();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios venta = new ConsultaUsuarios();
            venta.Show();
            this.BringToFront();
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            ConsultaProductos venta = new ConsultaProductos();
            venta.Show();
            this.BringToFront();
        }
    }
}
