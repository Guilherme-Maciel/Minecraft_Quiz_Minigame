namespace MinecraftQuizSHARP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_crafting = new System.Windows.Forms.Button();
            this.btn_redstone = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_redstone = new System.Windows.Forms.Label();
            this.lbl_crafting = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crafting
            // 
            this.btn_crafting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crafting.Font = new System.Drawing.Font("Minecraft", 27.75F);
            this.btn_crafting.Image = global::MinecraftQuizSHARP.Properties.Resources.button;
            this.btn_crafting.Location = new System.Drawing.Point(277, 195);
            this.btn_crafting.Margin = new System.Windows.Forms.Padding(2);
            this.btn_crafting.Name = "btn_crafting";
            this.btn_crafting.Size = new System.Drawing.Size(446, 99);
            this.btn_crafting.TabIndex = 2;
            this.btn_crafting.Text = "CRAFTING          ";
            this.btn_crafting.UseVisualStyleBackColor = true;
            this.btn_crafting.Click += new System.EventHandler(this.btn_crafting_Click);
            // 
            // btn_redstone
            // 
            this.btn_redstone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redstone.Font = new System.Drawing.Font("Minecraft", 27.75F);
            this.btn_redstone.Image = global::MinecraftQuizSHARP.Properties.Resources.button;
            this.btn_redstone.Location = new System.Drawing.Point(277, 314);
            this.btn_redstone.Margin = new System.Windows.Forms.Padding(2);
            this.btn_redstone.Name = "btn_redstone";
            this.btn_redstone.Size = new System.Drawing.Size(446, 99);
            this.btn_redstone.TabIndex = 3;
            this.btn_redstone.Text = "REDSTONE        ";
            this.btn_redstone.UseVisualStyleBackColor = true;
            this.btn_redstone.Click += new System.EventHandler(this.btn_redstone_Click);
            // 
            // btn_end
            // 
            this.btn_end.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.Image = global::MinecraftQuizSHARP.Properties.Resources.button;
            this.btn_end.Location = new System.Drawing.Point(277, 432);
            this.btn_end.Margin = new System.Windows.Forms.Padding(2);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(446, 99);
            this.btn_end.TabIndex = 4;
            this.btn_end.Text = "SAIR";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_redstone
            // 
            this.lbl_redstone.AutoSize = true;
            this.lbl_redstone.BackColor = System.Drawing.Color.Gray;
            this.lbl_redstone.Location = new System.Drawing.Point(580, 342);
            this.lbl_redstone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_redstone.Name = "lbl_redstone";
            this.lbl_redstone.Size = new System.Drawing.Size(65, 37);
            this.lbl_redstone.TabIndex = 6;
            this.lbl_redstone.Text = "/5";
            // 
            // lbl_crafting
            // 
            this.lbl_crafting.AutoSize = true;
            this.lbl_crafting.BackColor = System.Drawing.Color.Gray;
            this.lbl_crafting.Location = new System.Drawing.Point(580, 223);
            this.lbl_crafting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_crafting.Name = "lbl_crafting";
            this.lbl_crafting.Size = new System.Drawing.Size(65, 37);
            this.lbl_crafting.TabIndex = 7;
            this.lbl_crafting.Text = "/5";
            this.lbl_crafting.Click += new System.EventHandler(this.lbl_crafting_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::MinecraftQuizSHARP.Properties.Resources.hello;
            this.PictureBox1.Location = new System.Drawing.Point(581, 10);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(283, 182);
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox3.Image = global::MinecraftQuizSHARP.Properties.Resources.nether;
            this.PictureBox3.Location = new System.Drawing.Point(730, 343);
            this.PictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(259, 218);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 9;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = global::MinecraftQuizSHARP.Properties.Resources.overworld;
            this.PictureBox2.Location = new System.Drawing.Point(-6, 343);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(279, 218);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 10;
            this.PictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.wallpaper1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lbl_crafting);
            this.Controls.Add(this.lbl_redstone);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_redstone);
            this.Controls.Add(this.btn_crafting);
            this.Font = new System.Drawing.Font("Minecraft", 27.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Minecraft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btn_crafting;
        internal System.Windows.Forms.Button btn_redstone;
        internal System.Windows.Forms.Button btn_end;
        internal System.Windows.Forms.Label lbl_redstone;
        internal System.Windows.Forms.Label lbl_crafting;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
    }
}

