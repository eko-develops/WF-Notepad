namespace WF_Notepad
{
    class Dialog
    {
        public static void SaveAs(MainForm mainForm, string text)
        {
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

                mainForm.Text = saveFileDialog.FileName;
            }
        }

        public static void OpenFile(MainForm mainForm, RichTextBox mainText)
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
                mainForm.Text = openFileDialog.SafeFileName;    // set the window name

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
