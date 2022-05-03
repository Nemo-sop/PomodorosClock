namespace PomodorosClock
{
    partial class frmClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            this.btnStop = new PomodorosClock.CustomAssets.RJButton();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pctbxState = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnStop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStop.BorderRadius = 15;
            this.btnStop.BorderSize = 5;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(312, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 37);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Terminar";
            this.btnStop.TextColor = System.Drawing.Color.White;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCronometro.Location = new System.Drawing.Point(12, 24);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(237, 74);
            this.lblCronometro.TabIndex = 2;
            this.lblCronometro.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pctbxState
            // 
            this.pctbxState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbxState.BackgroundImage")));
            this.pctbxState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctbxState.Location = new System.Drawing.Point(312, 1);
            this.pctbxState.Name = "pctbxState";
            this.pctbxState.Size = new System.Drawing.Size(111, 74);
            this.pctbxState.TabIndex = 9;
            this.pctbxState.TabStop = false;
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(423, 122);
            this.ControlBox = false;
            this.Controls.Add(this.pctbxState);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnStop);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClock";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomAssets.RJButton btnStop;
        private Label lblCronometro;
        private System.Windows.Forms.Timer timer;
        private PictureBox pctbxState;
    }
}