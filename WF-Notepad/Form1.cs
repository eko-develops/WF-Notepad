using System.IO;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

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

            Dialog.SaveAs(text);

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Dialog.OpenFile(this, mainText);
        }

      
    }
}