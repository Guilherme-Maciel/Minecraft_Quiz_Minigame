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
    public partial class Form4 : Form
    {
        int objeto = 1;
        int timer = 20;
        int ordem = 1;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            picbox_objeto1.BackColor = Color.FromArgb(190, 190, 190);
            picbox_objeto2.BackColor = Color.FromArgb(190, 190, 190);
            picbox_objeto3.BackColor = Color.FromArgb(190, 190, 190);


            picbox_objeto2.Visible = false;
            picbox_objeto3.Visible = false;
 

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (objeto == 1)
            {
                if (picbox_objeto1.Left > 293)
                {
                    picbox_objeto1.Left = picbox_objeto1.Left - 142;
                }
                else
                {
                    picbox_objeto1.Left = picbox_objeto1.Left;
                }
            }

            if (objeto == 2)
            {
                if (picbox_objeto2.Left > 293)
                {
                    picbox_objeto2.Left = picbox_objeto2.Left - 142;
                    ordem = 2;
                }
                else
                {
                    picbox_objeto2.Left = picbox_objeto2.Left;
                    ordem = 2;
                }
            }


            if (objeto == 3)
            {
                if (picbox_objeto3.Left > 293)
                {
                    picbox_objeto3.Left = picbox_objeto3.Left - 142;
                    ordem = 3;
                }
                else
                {
                    picbox_objeto3.Left = picbox_objeto3.Left;
                    ordem = 3;
                }
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (objeto == 1)
            {
                if (picbox_objeto1.Left < 577)
                {
                    picbox_objeto1.Left = picbox_objeto1.Left + 142;
                }
                else
                {
                    picbox_objeto1.Left = picbox_objeto1.Left;
                }
            }

            if (objeto == 2)
            {
                if (picbox_objeto2.Left < 577)
                {
                    picbox_objeto2.Left = picbox_objeto2.Left + 142;
                    ordem = 2;
                }
                else
                {
                    picbox_objeto2.Left = picbox_objeto2.Left;
                    ordem = 2;
                }
            }

            if (objeto == 3)
            {
                if (picbox_objeto3.Left < 577)
                {
                    picbox_objeto3.Left = picbox_objeto3.Left + 142;
                    ordem = 3;

                }
                else
                {
                    picbox_objeto3.Left = picbox_objeto3.Left;
                    ordem = 3;
                }
            }

          
        }

        private void btn_up_Click(object sender, EventArgs e)
        {

            if (objeto == 1)
            {
                if (picbox_objeto1.Top > 92)
                {
                    picbox_objeto1.Top = picbox_objeto1.Top - 142;
                }
                else
                {
                    picbox_objeto1.Top = picbox_objeto1.Top;
                }
            }

            if (objeto == 2)
            {
                if (picbox_objeto2.Top > 92)
                {
                    picbox_objeto2.Top = picbox_objeto2.Top - 142;
                    ordem = 2;
                }
                else
                {
                    picbox_objeto2.Top = picbox_objeto2.Top;
                    ordem = 2;
                }
            }

            if (objeto == 3)
            {
                if (picbox_objeto3.Top > 92)
                {
                    picbox_objeto3.Top = picbox_objeto3.Top - 142;
                    ordem = 3;
                }
                else
                {
                    picbox_objeto3.Top = picbox_objeto3.Top;
                    ordem = 3;
                }
            }

           
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (objeto == 1)
            {
                if (picbox_objeto1.Top < 376)
                {
                    picbox_objeto1.Top = picbox_objeto1.Top + 142;
                }
                else
                {
                    picbox_objeto1.Top = picbox_objeto1.Top;
                }
            }

            if (objeto == 2)
            {
                if (picbox_objeto2.Top < 376)
                {
                    picbox_objeto2.Top = picbox_objeto2.Top + 142;
                    ordem = 2;
                }
                else
                {
                    picbox_objeto2.Top = picbox_objeto2.Top;
                    ordem = 2;
                }
            }

            if (objeto == 3)
            {
                if (picbox_objeto3.Top < 376)
                {
                    picbox_objeto3.Top = picbox_objeto3.Top + 142;
                    ordem = 3;
                }
                else
                {
                    picbox_objeto3.Top = picbox_objeto3.Top;
                    ordem = 3;
                }
            }

           
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (objeto == 1 && ordem == 1)
            {
                if (picbox_objeto1.Top == 376 && (picbox_objeto1.Left == 435 || picbox_objeto1.Left == 293 || picbox_objeto1.Left == 577))
                {
                    picbox_objeto2.Visible = true;
                    objeto = 2;
                }
            }

            if (objeto == 2 && ordem == 2) {
                if (picbox_objeto1.Left == 293 && (picbox_objeto2.Top == 234 || picbox_objeto2.Top == 92) && picbox_objeto2.Left == 293) {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }


                else if (picbox_objeto1.Left == 435 && (picbox_objeto2.Top == 234 || picbox_objeto2.Top == 92) && picbox_objeto2.Left == 435) {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }

                else if (picbox_objeto1.Left == 577 && (picbox_objeto2.Top == 234 || picbox_objeto2.Top == 92) && picbox_objeto2.Left == 577){
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }
            }

            if (objeto == 3 && ordem == 3) {
                if ((picbox_objeto2.Top == 92 && picbox_objeto2.Left == 293) && (picbox_objeto3.Top == 234 && picbox_objeto3.Left == 293)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

                else if ((picbox_objeto2.Top == 92 && picbox_objeto2.Left == 435) && (picbox_objeto3.Top == 234 && picbox_objeto3.Left == 435)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

                else if ((picbox_objeto2.Top == 92 && picbox_objeto2.Left == 577) && (picbox_objeto3.Top == 234 && picbox_objeto3.Left == 577)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

                else if ((picbox_objeto2.Top == 234 && picbox_objeto2.Left == 293) && (picbox_objeto3.Top == 92 && picbox_objeto3.Left == 293)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

                else if ((picbox_objeto2.Top == 234 && picbox_objeto2.Left == 435) && (picbox_objeto3.Top == 92 && picbox_objeto3.Left == 435)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }

                else if ((picbox_objeto2.Top == 234 && picbox_objeto2.Left == 577) && (picbox_objeto3.Top == 92 && picbox_objeto3.Left == 577)) {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form5();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer != 0)
            {
                timer = timer - 1;
                lbl_timer.Text = Convert.ToString(timer) + "s";
            }
            else
            {
                Timer1.Enabled = false;
                picbox_objeto2.Visible = true;
                picbox_objeto3.Visible = true;



                picbox_objeto1.Top = 376;
                picbox_objeto1.Left = 435;
                picbox_objeto2.Top = 234;
                picbox_objeto2.Left = 435;
                picbox_objeto3.Top = 92;
                picbox_objeto3.Left = 435;

                objeto = 0;
                Timer2.Enabled = true;
                lbl_timer.Text = "Tempo Esgotado !!! :(";

            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form5();
            Timer2.Enabled = false;
            f.Closed += (s, args) => this.Close();
            f.Show();

        }
    }
}
