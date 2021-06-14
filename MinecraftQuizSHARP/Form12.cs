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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/folderview?id=1Q7y5g8X9VSzfiSGxijS7bOlyQIlJO27a");
            Application.Exit();
        }
    }
}
