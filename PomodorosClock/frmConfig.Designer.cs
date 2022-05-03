namespace PomodorosClock
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.cbxMiliStyle = new System.Windows.Forms.CheckBox();
            this.Configuraciones = new System.Windows.Forms.GroupBox();
            this.btnAccept = new PomodorosClock.CustomAssets.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rjButton1 = new PomodorosClock.CustomAssets.RJButton();
            this.Configuraciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMiliStyle
            // 
            this.cbxMiliStyle.AutoSize = true;
            this.cbxMiliStyle.Location = new System.Drawing.Point(24, 43);
            this.cbxMiliStyle.Name = "cbxMiliStyle";
            this.cbxMiliStyle.Size = new System.Drawing.Size(142, 24);
            this.cbxMiliStyle.TabIndex = 0;
            this.cbxMiliStyle.Text = "Estilo Mili Lamas";
            this.cbxMiliStyle.UseVisualStyleBackColor = true;
            // 
            // Configuraciones
            // 
            this.Configuraciones.BackColor = System.Drawing.Color.Transparent;
            this.Configuraciones.Controls.Add(this.cbxMiliStyle);
            this.Configuraciones.Location = new System.Drawing.Point(31, 12);
            this.Configuraciones.Name = "Configuraciones";
            this.Configuraciones.Size = new System.Drawing.Size(250, 78);
            this.Configuraciones.TabIndex = 2;
            this.Configuraciones.TabStop = false;
            this.Configuraciones.Text = "Parametros";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Gray;
            this.btnAccept.BackgroundColor = System.Drawing.Color.Gray;
            this.btnAccept.BorderColor = System.Drawing.Color.Gray;
            this.btnAccept.BorderRadius = 15;
            this.btnAccept.BorderSize = 5;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(101, 265);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(105, 37);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.TextColor = System.Drawing.Color.White;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Estilo Mili Lamas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Crimson;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 5;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(90, 257);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(129, 45);
            this.rjButton1.TabIndex = 3;
            this.rjButton1.Text = "Aceptar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(312, 314);
            this.ControlBox = false;
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Configuraciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion";
            this.Configuraciones.ResumeLayout(false);
            this.Configuraciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox cbxMiliStyle;
        private GroupBox Configuraciones;
        private CustomAssets.RJButton btnAccept;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private CustomAssets.RJButton rjButton1;
    }
}