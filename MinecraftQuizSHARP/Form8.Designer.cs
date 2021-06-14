namespace MinecraftQuizSHARP
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.picbox_challe = new System.Windows.Forms.PictureBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.btn_pedra = new System.Windows.Forms.Button();
            this.btn_rept = new System.Windows.Forms.Button();
            this.btn_redstone = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer_crono = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_challe)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_challe
            // 
            this.picbox_challe.BackColor = System.Drawing.Color.Transparent;
            this.picbox_challe.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.reds1_lob;
            this.picbox_challe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_challe.Location = new System.Drawing.Point(227, 76);
            this.picbox_challe.Name = "picbox_challe";
            this.picbox_challe.Size = new System.Drawing.Size(546, 365);
            this.picbox_challe.TabIndex = 9;
            this.picbox_challe.TabStop = false;
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.Transparent;
            this.btn_select.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.select_off;
            this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.Transparent;
            this.btn_select.Location = new System.Drawing.Point(546, 155);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(44, 44);
            this.btn_select.TabIndex = 15;
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.Font = new System.Drawing.Font("Minecraft", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(12, 20);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(960, 35);
            this.lbl_msg.TabIndex = 16;
            this.lbl_msg.Text = "Acenda a luz !!!";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_pedra
            // 
            this.btn_pedra.BackColor = System.Drawing.Color.Transparent;
            this.btn_pedra.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.pedra;
            this.btn_pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pedra.FlatAppearance.BorderSize = 0;
            this.btn_pedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedra.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pedra.Location = new System.Drawing.Point(355, 456);
            this.btn_pedra.Name = "btn_pedra";
            this.btn_pedra.Size = new System.Drawing.Size(106, 104);
            this.btn_pedra.TabIndex = 19;
            this.btn_pedra.UseVisualStyleBackColor = false;
            this.btn_pedra.Click += new System.EventHandler(this.btn_pedra_Click);
            // 
            // btn_rept
            // 
            this.btn_rept.BackColor = System.Drawing.Color.Transparent;
            this.btn_rept.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.repetidor;
            this.btn_rept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rept.FlatAppearance.BorderSize = 0;
            this.btn_rept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rept.ForeColor = System.Drawing.Color.Transparent;
            this.btn_rept.Location = new System.Drawing.Point(553, 456);
            this.btn_rept.Name = "btn_rept";
            this.btn_rept.Size = new System.Drawing.Size(106, 104);
            this.btn_rept.TabIndex = 18;
            this.btn_rept.UseVisualStyleBackColor = false;
            this.btn_rept.Click += new System.EventHandler(this.btn_rept_Click);
            // 
            // btn_redstone
            // 
            this.btn_redstone.BackColor = System.Drawing.Color.Transparent;
            this.btn_redstone.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.redstone;
            this.btn_redstone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_redstone.FlatAppearance.BorderSize = 0;
            this.btn_redstone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redstone.ForeColor = System.Drawing.Color.Transparent;
            this.btn_redstone.Location = new System.Drawing.Point(453, 456);
            this.btn_redstone.Name = "btn_redstone";
            this.btn_redstone.Size = new System.Drawing.Size(106, 104);
            this.btn_redstone.TabIndex = 17;
            this.btn_redstone.UseVisualStyleBackColor = false;
            this.btn_redstone.Click += new System.EventHandler(this.btn_redstone_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_timer.Font = new System.Drawing.Font("Minecraft", 30.25F, System.Drawing.FontStyle.Bold);
            this.lbl_timer.ForeColor = System.Drawing.Color.Orange;
            this.lbl_timer.Location = new System.Drawing.Point(60, 511);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(83, 41);
            this.lbl_timer.TabIndex = 20;
            this.lbl_timer.Text = "10s";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Minecraft", 18.25F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label2.Location = new System.Drawing.Point(753, 495);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(201, 25);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Level 2 - Noob";
            // 
            // Timer2
            // 
            this.Timer2.Interval = 3000;
            this.Timer2.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer_crono
            // 
            this.timer_crono.Enabled = true;
            this.timer_crono.Interval = 1000;
            this.timer_crono.Tick += new System.EventHandler(this.timer_crono_Tick);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MinecraftQuizSHARP.Properties.Resources.wallpaper3;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.btn_pedra);
            this.Controls.Add(this.btn_rept);
            this.Controls.Add(this.btn_redstone);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.picbox_challe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_challe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picbox_challe;
        internal System.Windows.Forms.Button btn_select;
        internal System.Windows.Forms.Label lbl_msg;
        internal System.Windows.Forms.Button btn_pedra;
        internal System.Windows.Forms.Button btn_rept;
        internal System.Windows.Forms.Button btn_redstone;
        internal System.Windows.Forms.Label lbl_timer;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer timer_crono;
    }
}