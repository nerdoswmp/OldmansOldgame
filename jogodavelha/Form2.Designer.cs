namespace jogodavelha
{
    partial class Form2
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
            this.bt_regular = new System.Windows.Forms.Button();
            this.bt_super = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_regular
            // 
            this.bt_regular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.bt_regular.FlatAppearance.BorderSize = 0;
            this.bt_regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_regular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.bt_regular.Location = new System.Drawing.Point(51, 216);
            this.bt_regular.Name = "bt_regular";
            this.bt_regular.Size = new System.Drawing.Size(176, 46);
            this.bt_regular.TabIndex = 6;
            this.bt_regular.Text = "Regular";
            this.bt_regular.UseVisualStyleBackColor = false;
            this.bt_regular.Click += new System.EventHandler(this.bt_regular_Click);
            // 
            // bt_super
            // 
            this.bt_super.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(226)))), ((int)(((byte)(212)))));
            this.bt_super.FlatAppearance.BorderSize = 0;
            this.bt_super.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_super.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_super.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.bt_super.Location = new System.Drawing.Point(258, 216);
            this.bt_super.Name = "bt_super";
            this.bt_super.Size = new System.Drawing.Size(176, 46);
            this.bt_super.TabIndex = 7;
            this.bt_super.Text = "Super";
            this.bt_super.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(494, 472);
            this.Controls.Add(this.bt_super);
            this.Controls.Add(this.bt_regular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_regular;
        private System.Windows.Forms.Button bt_super;
    }
}