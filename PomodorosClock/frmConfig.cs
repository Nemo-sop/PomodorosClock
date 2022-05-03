using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodorosClock
{
    public partial class frmConfig : Form
    {
        public bool MiliStyle { get; set; }

        public frmConfig()
        {
            InitializeComponent();
        }

        public int[] showAndReturn()
        {
            this.ShowDialog();
            int[] result = new int[1];
            if (cbxMiliStyle.Checked) { result[0] = 1; }
            else { result[0] = 0; };

            return result;
        }

        

        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbxMiliStyle.Checked) { MiliStyle = true; }
            else { MiliStyle = false; }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
