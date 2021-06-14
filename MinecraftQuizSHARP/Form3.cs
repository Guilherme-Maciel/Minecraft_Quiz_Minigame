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
    public partial class Form3 : Form
    {

        int objeto = 1;
        int timer = 20;
        int ordem = 1;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            picbox_objeto1.BackColor = Color.FromArgb(190, 190, 190);
            picbox_objeto2.BackColor = Color.FromArgb(190, 190, 190);
            picbox_objeto3.BackColor = Color.FromArgb(190, 190, 190);
            picbox_objeto4.BackColor = Color.FromArgb(190, 190, 190);

            picbox_objeto2.Visible = false;
            picbox_objeto3.Visible = false;
            picbox_objeto4.Visible = false;

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

            if (objeto == 4)
            {
                if (picbox_objeto4.Left > 293)
                {
                    picbox_objeto4.Left = picbox_objeto4.Left - 142;
                    ordem = 4;
                }
                else
                {
                    picbox_objeto4.Left = picbox_objeto4.Left;
                    ordem = 4;
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

            if (objeto == 4)
            {
                if (picbox_objeto4.Left < 577)
                {
                    picbox_objeto4.Left = picbox_objeto4.Left + 142;
                    ordem = 4;
                }
                else
                {
                    picbox_objeto4.Left = picbox_objeto4.Left;
                    ordem = 4;
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

            if (objeto == 4)
            {
                if (picbox_objeto4.Top > 92)
                {
                    picbox_objeto4.Top = picbox_objeto4.Top - 142;
                    ordem = 4;
                }
                else
                {
                    picbox_objeto4.Top = picbox_objeto4.Top;
                    ordem = 4;
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

            if (objeto == 4)
            {
                if (picbox_objeto4.Top < 376)
                {
                    picbox_objeto4.Top = picbox_objeto4.Top + 142;
                    ordem = 4;
                }
                else
                {
                    picbox_objeto4.Top = picbox_objeto4.Top;
                    ordem = 4;
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if ((objeto == 1) && (ordem == 1))
            {
                if ((picbox_objeto1.Top == 234) && ((picbox_objeto1.Left == 435) || (picbox_objeto1.Left == 293) || (picbox_objeto1.Left == 577)))
                {
                    picbox_objeto2.Visible = true;
                    objeto = 2;
                }

                else if ((picbox_objeto1.Top == 376) && ((picbox_objeto1.Left == 435) || (picbox_objeto1.Left == 293) || (picbox_objeto1.Left == 577)))
                {
                    picbox_objeto2.Visible = true;
                    objeto = 2;
                }
            }

            if ((objeto == 2) && (ordem == 2))
            {
                if (((picbox_objeto1.Top == 234) && (picbox_objeto1.Left == 293)) && ((picbox_objeto2.Top == 376) && (picbox_objeto2.Left == 293)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }
                else if (((picbox_objeto1.Top == 234) && (picbox_objeto1.Left == 435)) && ((picbox_objeto2.Top == 376) && (picbox_objeto2.Left == 435)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }
                else if (((picbox_objeto1.Top == 234) && (picbox_objeto1.Left == 577)) && ((picbox_objeto2.Top == 376) && (picbox_objeto2.Left == 577)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }

                else if (((picbox_objeto1.Top == 376) && (picbox_objeto1.Left == 293)) && ((picbox_objeto2.Top == 234) && (picbox_objeto2.Left == 293)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }

                else if (((picbox_objeto1.Top == 376) && (picbox_objeto1.Left == 435)) && ((picbox_objeto2.Top == 234) && (picbox_objeto2.Left == 435)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }

                else if (((picbox_objeto1.Top == 376) && (picbox_objeto1.Left == 577)) && ((picbox_objeto2.Top == 234) && (picbox_objeto2.Left == 577)))
                {
                    picbox_objeto3.Visible = true;
                    objeto = 3;
                }
            }

            if ((objeto == 3) && (ordem == 3))
            {
                if ((picbox_objeto2.Left == 293) && ((picbox_objeto3.Top == 92) && ((picbox_objeto3.Left == 293) || (picbox_objeto3.Left == 435))))
                {
                    picbox_objeto4.Visible = true;
                    objeto = 4;
                }

                else if ((picbox_objeto2.Left == 435) && ((picbox_objeto3.Top == 92) && ((picbox_objeto3.Left == 435) || (picbox_objeto3.Left == 293) || (picbox_objeto3.Left == 577))))
                {
                    picbox_objeto4.Visible = true;
                    objeto = 4;
                }
                else if ((picbox_objeto2.Left == 577) && ((picbox_objeto3.Top == 92) && ((picbox_objeto3.Left == 577) || (picbox_objeto3.Left == 435))))
                {
                    picbox_objeto4.Visible = true;
                    objeto = 4;

                }
            }

            if ((objeto == 4) && (ordem == 4))
            {
                if (((picbox_objeto3.Left == 293) || (picbox_objeto3.Left == 577)) && (picbox_objeto4.Top == 92) && (picbox_objeto4.Left == 435))
                {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form4();
                    Timer1.Enabled = false;
                    f.Closed += (s, args) => this.Close();
                    f.Show();

                }

                else if ((picbox_objeto3.Left == 435) && (picbox_objeto4.Top == 92) && ((picbox_objeto4.Left == 577) || (picbox_objeto4.Left == 293)))
                {
                    Module1.pontos_craft = Module1.pontos_craft + 1;
                    this.Hide();
                    Form f = new Form4();
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
                picbox_objeto4.Visible = true;



                picbox_objeto1.Top = 376;
                picbox_objeto1.Left = 435;
                picbox_objeto2.Top = 234;
                picbox_objeto2.Left = 435;
                picbox_objeto3.Top = 92;
                picbox_objeto3.Left = 577;
                picbox_objeto4.Top = 92;
                picbox_objeto4.Left = 435;
                objeto = 0;
                Timer2.Enabled = true;
                lbl_timer.Text = "Tempo Esgotado !!! :(";

            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Form4();
            Timer2.Enabled = false;
            f.Closed += (s, args) => this.Close();
            f.Show();

        }

    }
}
