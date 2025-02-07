
namespace Music_App_for_Prelim
{
    public partial class ProgressForm : Form
    {
        public bool IsCanceled { get; private set; } = false;

        public ProgressForm()
        {
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            IsCanceled = true;
        }

        public void UpdateProgress(int value, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(value, message)));
            }
            else
            {
                progressBar.Value = value;
                lblStatus.Text = message;
            }
        }

    
    }
}
