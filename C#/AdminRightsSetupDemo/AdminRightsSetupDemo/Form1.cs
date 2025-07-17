namespace AdminRightsSetupDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openCmd_Click(object sender, EventArgs e)
        {
            string homePath = Environment.GetEnvironmentVariable("HOMEPATH");
            string drive = Environment.GetEnvironmentVariable("HOMEDRIVE");
            string fullPath = drive + homePath;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "cmd.exe",
                WorkingDirectory = fullPath,
                Verb = "runas", // triggers UAC
                UseShellExecute = true
            });
        }
    }
}
