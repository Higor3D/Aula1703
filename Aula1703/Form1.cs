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

        }

        void color() {
            Random sorteio = new Random();

           var o = new Point(sorteio.Next(1,7));

            switch (o)
            {
                case 1:

                    break;
            }
        }
    }
}
