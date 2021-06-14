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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pontos_craft = Module1.pontos_craft;
            int pontos_reds = Module1.pontos_reds;


            lbl_crafting.BackColor = Color.FromArgb(198, 198, 198);
            lbl_redstone.BackColor = Color.FromArgb(198, 198, 198);
            lbl_crafting.Text = Convert.ToString(pontos_craft) + "/5";
            lbl_redstone.Text = Convert.ToString(pontos_reds) + "/5";

            this.Hide();
            Form f = new Form13();
            f.Closed += (s, args) => this.Close();
            f.Show();

            if ((pontos_craft == 5) && (pontos_reds == 5))
            {
                new Form12().ShowDialog();
                this.Dispose();

            }

        }

        private void lbl_crafting_Click(object sender, EventArgs e)
        {
        }

        private void btn_crafting_Click(object sender, EventArgs e)
        {
            Module1.pontos_craft = 0;
            this.Hide();
            Form f = new Form2();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_redstone_Click(object sender, EventArgs e)
        {
            Module1.pontos_reds = 0;
            this.Hide();
            Form f = new Form7();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
