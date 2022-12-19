namespace WF_Notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            string text;

            text = mainText.Text.ToString();

            Dialog.SaveAs(this, text);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Dialog.OpenFile(this, mainText);
        }

        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }
    }
}