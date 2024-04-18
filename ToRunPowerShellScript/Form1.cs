using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace ToRunPowerShellScript
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();

            Pipeline pipeline = runspace.CreatePipeline();
            Command command = new Command(@"E:\Software Development\Development\PowerShellScript\ToRunPowerShellScript\ToRunPowerShellScript\Hello.ps1");
            pipeline.Commands.Add(command);

            pipeline.Invoke();
            runspace.Close();
            MessageBox.Show("Powershell script executed..");
        }
    }
}
