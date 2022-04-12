namespace jogodavelha
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_off = new System.Windows.Forms.Button();
            this.bt_online = new System.Windows.Forms.Button();
            this.pb_pfp = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_rank = new System.Windows.Forms.Label();
            this.pb_team = new System.Windows.Forms.PictureBox();
            this.bt_other = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pfp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_team)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.lb_Title.Location = new System.Drawing.Point(12, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(195, 84);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Old Man\'s\r\nOld Game\r\n";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.bt_other);
            this.panel1.Controls.Add(this.bt_online);
            this.panel1.Controls.Add(this.bt_off);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 561);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.pb_team);
            this.panel2.Controls.Add(this.lb_rank);
            this.panel2.Controls.Add(this.lb_username);
            this.panel2.Controls.Add(this.pb_pfp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 89);
            this.panel2.TabIndex = 4;
            // 
            // bt_off
            // 
            this.bt_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.bt_off.FlatAppearance.BorderSize = 0;
            this.bt_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_off.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.bt_off.Location = new System.Drawing.Point(19, 115);
            this.bt_off.Name = "bt_off";
            this.bt_off.Size = new System.Drawing.Size(176, 46);
            this.bt_off.TabIndex = 5;
            this.bt_off.Text = "Offline";
            this.bt_off.UseVisualStyleBackColor = false;
            this.bt_off.Click += new System.EventHandler(this.bt_off_Click);
            // 
            // bt_online
            // 
            this.bt_online.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.bt_online.FlatAppearance.BorderSize = 0;
            this.bt_online.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_online.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_online.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.bt_online.Location = new System.Drawing.Point(19, 189);
            this.bt_online.Name = "bt_online";
            this.bt_online.Size = new System.Drawing.Size(176, 46);
            this.bt_online.TabIndex = 6;
            this.bt_online.Text = "Online";
            this.bt_online.UseVisualStyleBackColor = false;
            // 
            // pb_pfp
            // 
            this.pb_pfp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.pb_pfp.Location = new System.Drawing.Point(6, 6);
            this.pb_pfp.Name = "pb_pfp";
            this.pb_pfp.Size = new System.Drawing.Size(80, 80);
            this.pb_pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pfp.TabIndex = 0;
            this.pb_pfp.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.lb_username.Location = new System.Drawing.Point(183, 4);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(192, 42);
            this.lb_username.TabIndex = 7;
            this.lb_username.Text = "username\r\n";
            // 
            // lb_rank
            // 
            this.lb_rank.AutoSize = true;
            this.lb_rank.BackColor = System.Drawing.Color.Transparent;
            this.lb_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.lb_rank.Location = new System.Drawing.Point(183, 44);
            this.lb_rank.Name = "lb_rank";
            this.lb_rank.Size = new System.Drawing.Size(256, 39);
            this.lb_rank.TabIndex = 8;
            this.lb_rank.Text = "rank points idk";
            // 
            // pb_team
            // 
            this.pb_team.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.pb_team.Location = new System.Drawing.Point(97, 6);
            this.pb_team.Name = "pb_team";
            this.pb_team.Size = new System.Drawing.Size(80, 80);
            this.pb_team.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_team.TabIndex = 9;
            this.pb_team.TabStop = false;
            // 
            // bt_other
            // 
            this.bt_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.bt_other.FlatAppearance.BorderSize = 0;
            this.bt_other.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_other.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.bt_other.Location = new System.Drawing.Point(18, 265);
            this.bt_other.Name = "bt_other";
            this.bt_other.Size = new System.Drawing.Size(176, 46);
            this.bt_other.TabIndex = 7;
            this.bt_other.Text = "Other";
            this.bt_other.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(210, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 472);
            this.panel3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pfp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_other;
        private System.Windows.Forms.Button bt_online;
        private System.Windows.Forms.Button bt_off;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_team;
        private System.Windows.Forms.Label lb_rank;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_pfp;
        private System.Windows.Forms.Panel panel3;
    }
}

