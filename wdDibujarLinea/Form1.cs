using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Autor: Brayan Alexander Patiño Vélez
/// Fecha: 08/03/2022
/// Descripcion: Dibujo de lineas
/// </summary>

namespace wdDibujarLinea
{
    public partial class Form1 : Form
    {
        Graphics grafico;
        public Form1()
        {
            InitializeComponent();
            grafico = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                double Xi = double.Parse(txtXi.Text);
                double Yi = double.Parse(txtYi.Text);
                double Xf = double.Parse(txtXf.Text);
                double Yf = double.Parse(txtYf.Text);

                clsLinea linea = new clsLinea(Xi, Yi, Xf, Yf);

                Pen BlackPen = new Pen(Color.Black, 3);

                PointF point1 = new PointF(linea.obtenXi(), linea.obtenYi());
                PointF point2 = new PointF(linea.obtenXf(), linea.obtenYf());

                grafico.DrawLine(BlackPen, point1, point2);

                txtCantidad.Text = Convert.ToString(clsLinea.obtencuenta());
            }

            catch (Exception)
            {
                MessageBox.Show("Digite valores de tipo numerico");
            }
        }
    }
}
