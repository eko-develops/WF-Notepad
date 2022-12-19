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

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Save Note As..";
            saveFileDialog.FileName = "*.txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());

                writer.WriteLine(text);

                writer.Dispose();

                writer.Close();

            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open";

            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog.SafeFileName;    // set the window name

                // using the System.IO.File namespace to use the method to open, read, and close file
                // could look into StreamReader as well
                // mainText.Text = System.IO.File.ReadAllText(openFileDialog.FileName);

                StreamReader reader = new StreamReader(openFileDialog.FileName);

                mainText.Text = reader.ReadToEnd();

                reader.Dispose();

                reader.Close();
                
            }
        }

      
    }
}