using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1703
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonNao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNao_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNao_MouseEnter(object sender, EventArgs e)
        {
            buttonNao.BackColor = Color.Gold;
        }

        private void buttonNao_MouseLeave(object sender, EventArgs e)
        {
            buttonNao.BackColor = Color.Salmon;
        }

        private void buttonSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Então continue estudando bastante!!");
        }

        private void buttonSim_MouseEnter(object sender, EventArgs e)
        {
            Random sorteio = new Random();

            buttonSim.Location = new Point(sorteio.Next(1, this.Width), sorteio.Next(1, this.Height));
        }

        private void FormPrincipal_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void FormPrincipal_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void buttonCor_Click(object sender, EventArgs e)
        {
            colorido();
        }

        void colorido() {
            Random sort = new Random();

            int o = sort.Next(1,7);

            switch (o)
            {
                case 1:
                    labelPergunta.ForeColor = Color.Red;
                    break;
                case 2:
                    labelPergunta.ForeColor = Color.Blue;
                    break;
                case 3:
                    labelPergunta.ForeColor = Color.Green;
                    break;
                case 4:
                    labelPergunta.ForeColor = Color.Yellow;
                    break;
                case 5:
                    labelPergunta.ForeColor = Color.Brown;
                    break;
                case 6:
                    labelPergunta.ForeColor = Color.Pink;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
