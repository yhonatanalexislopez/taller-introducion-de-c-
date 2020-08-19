using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, suma, resultado;
            nota1 = double.Parse(txtnotauno.Text);
            nota2 = double.Parse(txtnotados.Text);
            nota3 = double.Parse(txtnotatres.Text);

            suma = nota1 + nota2 + nota3;

            resultado = suma / 3;
            lblresultado.Text = Convert.ToString(resultado);

            label5.Visible = true;
            lblresultado.Visible = true;
        }
    }
}
