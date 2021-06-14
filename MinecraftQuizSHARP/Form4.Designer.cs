namespace MinecraftQuizSHARP
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.picbox_objeto1 = new System.Windows.Forms.PictureBox();
            this.picbox_objeto2 = new System.Windows.Forms.PictureBox();
            this.picbox_objeto3 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::MinecraftQuizSHARP.Properties.Resources.crafting;
            this.PictureBox1.Location = new System.Drawing.Point(274, 75);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(450, 450);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // lbl_timer
            // 
            this.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_timer.Font = new System.Drawing.Font("Minecraft", 24F);
            this.lbl_timer.Location = new System.Drawing.Point(274, 26);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(449, 50);
            this.lbl_timer.TabIndex = 24;
            this.lbl_timer.Text = "20 s";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_right.CausesValidation = false;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Image = global::MinecraftQuizSHARP.Properties.Resources.right;
            this.btn_right.Location = new System.Drawing.Point(34, 219);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(116, 116);
            this.btn_right.TabIndex = 28;
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_left.CausesValidation = false;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Image = global::MinecraftQuizSHARP.Properties.Resources.left;
            this.btn_left.Location = new System.Drawing.Point(34, 396);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(116, 116);
            this.btn_left.TabIndex = 27;
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_down.CausesValidation = false;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down.Image = global::MinecraftQuizSHARP.Properties.Resources.down;
            this.btn_down.Location = new System.Drawing.Point(823, 404);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(116, 116);
            this.btn_down.TabIndex = 26;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_up.CausesValidation = false;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Image = global::MinecraftQuizSHARP.Properties.Resources.up;
            this.btn_up.Location = new System.Drawing.Point(823, 225);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(116, 116);
            this.btn_up.TabIndex = 25;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = global::MinecraftQuizSHARP.Properties.Resources.espada;
            this.PictureBox2.Location = new System.Drawing.Point(12, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(166, 166);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 29;
            this.PictureBox2.TabStop = false;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Minecraft", 24F);
            this.btn_ok.Location = new System.Drawing.Point(825, 49);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(88, 88);
            this.btn_ok.TabIndex = 30;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // picbox_objeto1
            // 
            this.picbox_objeto1.BackColor = System.Drawing.Color.Transparent;
            this.picbox_objeto1.Image = global::MinecraftQuizSHARP.Properties.Resources.stick;
            this.picbox_objeto1.Location = new System.Drawing.Point(577, 234);
            this.picbox_objeto1.Name = "picbox_objeto1";
            this.picbox_objeto1.Size = new System.Drawing.Size(130, 130);
            this.picbox_objeto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_objeto1.TabIndex = 31;
            this.picbox_objeto1.TabStop = false;
            // 
            // picbox_objeto2
            // 
            this.picbox_objeto2.BackColor = System.Drawing.Color.Transparent;
            this.picbox_objeto2.Image = global::MinecraftQuizSHARP.Properties.Resources.diamante;
            this.picbox_objeto2.Location = new System.Drawing.Point(577, 234);
            this.picbox_objeto2.Name = "picbox_objeto2";
            this.picbox_objeto2.Size = new System.Drawing.Size(130, 130);
            this.picbox_objeto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_objeto2.TabIndex = 32;
            this.picbox_objeto2.TabStop = false;
            // 
            // picbox_objeto3
            // 
            this.picbox_objeto3.BackColor = System.Drawing.Color.Transparent;
            this.picbox_objeto3.Image = global::MinecraftQuizSHARP.Properties.Resources.diamante;
            this.picbox_objeto3.Location = new System.Drawing.Point(577, 234);
            this.picbox_objeto3.Name = "picbox_objeto3";
            this.picbox_objeto3.Size = new System.Drawing.Size(130, 130);
            this.picbox_objeto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_objeto3.TabIndex = 33;
            this.picbox_objeto3.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 3000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.wallpaper2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 561);
            this.Controls.Add(this.picbox_objeto3);
            this.Controls.Add(this.picbox_objeto2);
            this.Controls.Add(this.picbox_objeto1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_objeto3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lbl_timer;
        internal System.Windows.Forms.Button btn_right;
        internal System.Windows.Forms.Button btn_left;
        internal System.Windows.Forms.Button btn_down;
        internal System.Windows.Forms.Button btn_up;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Button btn_ok;
        internal System.Windows.Forms.PictureBox picbox_objeto1;
        internal System.Windows.Forms.PictureBox picbox_objeto2;
        internal System.Windows.Forms.PictureBox picbox_objeto3;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Timer Timer2;
    }
}