using System.Windows.Forms;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Dialog.Save();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            mainText.Cut();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            mainText.Undo();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            mainText.Copy();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            mainText.Paste();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            mainText.SelectedText = "";
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            mainText.SelectAll();
        }

        private void buttonTimeDate_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            mainText.Text += now;
        }

        private void buttonWordWrap_Click(object sender, EventArgs e)
        {
            if (mainText.WordWrap)
            {
                mainText.WordWrap = false;
                //buttonWordWrap.Checked = false;
            } else
            {
                //buttonWordWrap.Checked = true;
                mainText.WordWrap = true;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            if (dialogFont.ShowDialog() == DialogResult.OK)
            {
                mainText.Font = dialogFont.Font;
            }
        }
    }
}