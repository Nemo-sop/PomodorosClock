namespace PomodorosClock
{
    public partial class frmStart : Form
    {

        int[] configOptions = new int[1];
        //frmConfig configStyle = new frmConfig();

        public frmStart()
        {
            InitializeComponent();

            configOptions[0] = 0;

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            
            
          
            
            
            if (cbxMili.Checked)
            {
                frmClock clock = new frmClock(true);
                clock.ShowDialog();
            }
            else
            {
                frmClock clock = new frmClock(false);
                clock.ShowDialog();
            }
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configStyle.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }
    }
}