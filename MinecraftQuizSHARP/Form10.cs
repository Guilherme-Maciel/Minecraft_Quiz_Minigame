using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftQuizSHARP
{
    public partial class Form10 : Form
    {
        int sele = 0;
        int timer = 10;

        public Form10()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (sele == 0)
            {
                btn_select.BackgroundImage = Properties.Resources.select_on;
                sele = 1;
            }
            else
            {
                btn_select.BackgroundImage = Properties.Resources.select_off;
                sele = 0;
            }
        }

        private void btn_pedra_Click(object sender, EventArgs e)
        {
            if (sele == 1)
            {
                picbox_challe.BackgroundImage = Properties.Resources.reds4_pedra;
                btn_select.Visible = false;
                Timer2.Enabled = true;
                timer_crono.Enabled = false;
                Module1.pontos_reds = Module1.pontos_reds + 1;
                sele = 0;
                lbl_msg.Text = "Mandou bem! :D";
            }
        }

        private void btn_rept_Click(object sender, EventArgs e)
        {
            if (sele == 1)
            {
                picbox_challe.BackgroundImage = Properties.Resources.reds4_ambos;
                btn_select.Visible = false;
                Timer2.Enabled = true;
                timer_crono.Enabled = false;
                sele = 0;
                lbl_msg.Text = "Hoje não!";
            }
        }

        private void btn_redstone_Click(object sender, EventArgs e)
        {
            if (sele ==1)
            {
                picbox_challe.BackgroundImage = Properties.Resources.reds4_ambos;
                btn_select.Visible = false;
                Timer2.Enabled = true;
                timer_crono.Enabled = false;
                sele = 0;
                lbl_msg.Text = "A redstone funcionou mal :(";
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form11();
            Timer2.Enabled = false;
            timer_crono.Enabled = false;
            Timer2.Enabled = false;
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void timer_crono_Tick(object sender, EventArgs e)
        {
            if (timer != 0)
            {
                timer = timer - 1;
                lbl_timer.Text = Convert.ToString(timer) + "s";
            }
            else
            {
                timer_crono.Enabled = false;
                Timer2.Enabled = true;
                picbox_challe.BackgroundImage = Properties.Resources.reds4_pedra;
                btn_select.Visible = false;
                sele = 0;
                lbl_msg.Text = "Tempo Esgotado !!! :(";
            }
        }
    }
}
