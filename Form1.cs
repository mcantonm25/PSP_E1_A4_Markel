using System.Diagnostics;

namespace PSP_E1_A4_Markel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Process p;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //"Itxi Notepad" botoia
        private void button2_Click(object sender, EventArgs e)
        {
            Process[] pr = Process.GetProcessesByName("notepad");

            foreach (Process proc in pr)
            {
                proc.Kill();
                proc.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // "Notepad" botoia
        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            p = Process.Start("notepad");

            // Behin Notepad hasita, labelean haren PID zenbakia agertu behar da.
            labelID.Text = "ID: " + p.Id;
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        // Sistemaren prozesuak botoia sakatzerakoan, alboan daukan ComboBox-ean sisteman exekutatzen ari diren prozesu guztien izenak kargatuko dira.
        private void buttonSistemarenProzesuak_Click(object sender, EventArgs e)
        {
            comboBoxProzesuak.Items.Clear();

            Process[] pr = Process.GetProcesses();

            foreach (Process proc in pr)
            {
                comboBoxProzesuak.Items.Add(proc.ProcessName);
            }
        }
    }
}
