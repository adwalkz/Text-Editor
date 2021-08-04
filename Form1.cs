using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace ADitor
{
    public partial class Aditor : Form
    {
        public Aditor()
        {
            InitializeComponent();

            NewFile();
        }

//--------------------------------------------------------------------------------------------------------------------------------      
        String FTypes = "text files (*.txt)|*.txt|python files (*.py)|*.py|c files (*.c)|*.c|cpp files (*.cpp)|*.cpp|java files (*.java)|*.java|html files (*.html)|*.html|all files (*.*)|*.*";
        String DefExt = "txt";
        const String DefFName = "TextFile.txt";
        
        SaveFileDialog sfd = new SaveFileDialog();
        OpenFileDialog ofd = new OpenFileDialog();
        PrintDialog pd = new PrintDialog();
        PrintDocument pdoc = new PrintDocument();

        StreamWriter sw;

        int SaveFlag = -1;
        String credits = "This is a Simple Text Editor\n\nDeveloped and Designed by ADITYA JAIN\n\nYou can create any kind (extension) of file using this Editor.";

        Stream fstream;
//--------------------------------------------------------------------------------------------------------------------------------


//--------------------------------------------------------------------------------------------------------------------------------
        void NewFile()
        {
            this.Text = "Aditor : TextEditor";

            sfd.FileName = "";
            ofd.FileName = "";

            WritingArea.ReadOnly = false;
            WritingArea.Text = "";

            SaveFlag = -1;
        }
        
        void SaveExistingFile()
        {
            fstream = File.Open(sfd.FileName, FileMode.Truncate);
            sw = new StreamWriter(fstream);

            sw.Write(WritingArea.Text);

            sw.Close();
            fstream.Close();

            SaveFlag = 1;
        }
        
        void SaveNewFile()
        {
            sfd.Title = "Aditor : Save New File";
            
            sfd.FileName = DefFName;
            sfd.DefaultExt = DefExt;
            sfd.Filter = FTypes;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fstream = File.Open(sfd.FileName, FileMode.Create);
                sw = new StreamWriter(fstream);

                sw.Write(WritingArea.Text);

                sw.Close();
                fstream.Close();

                SaveFlag = 1;
            }
        }

        void OpenFile()
        {
            ofd.Title = "Aditor : Open File";

            if (ofd.ShowDialog() == DialogResult.OK)
                WritingArea.Text = File.ReadAllText(ofd.FileName);

            SaveFlag = 0;

            sfd.FileName = ofd.FileName;
            this.Text = "Aditor : " + sfd.FileName;
        }

        void ExitApp()
        {
            if (WritingArea.Text != "" && (SaveFlag == -1 || SaveFlag == 0) && MessageBox.Show("save this file ?", "Save File ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveFlag == -1)
                    SaveNewFile();
                else
                    SaveExistingFile();
            }
        }
//--------------------------------------------------------------------------------------------------------------------------------

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WritingArea.Text != "" && (SaveFlag == -1 || SaveFlag == 0) && MessageBox.Show("You have some undone bussiness", "Save or Update File ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveFlag == -1)
                    SaveNewFile();
                else
                    SaveExistingFile();

                MessageBox.Show("This file is saved, press 'OK' for new file");
            }

            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (WritingArea.Text != "" && (SaveFlag == -1 || SaveFlag == 0) && MessageBox.Show("Wanna save or update this ?", "Save File ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (SaveFlag == -1)
                    SaveNewFile();

                if (SaveFlag == 0)
                {
                    sfd.FileName = ofd.FileName;
                    SaveExistingFile();
                }
                    
                MessageBox.Show("This file is saved, now open new file");
                SaveFlag = 1;

                OpenFile();
            }

            else
                OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WritingArea.Text == "")
                MessageBox.Show("You haven't wrote anything yet :/");
            else
            {
                if (SaveFlag == -1)
                    SaveNewFile();
                else
                    SaveExistingFile();
                
                this.Text = "Aditor : " + sfd.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();

            Application.Exit();
        }

        private void aboutThisEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();

            WritingArea.Text = credits;
            WritingArea.ReadOnly = true;
            saveToolStripMenuItem.Enabled = false;
            SaveFlag = 1;
        }

        private void WritingArea_TextChanged(object sender, EventArgs e)
        {
            if (sfd.FileName != "")
            {
                this.Text = "Aditor : " + sfd.FileName + "*";
                SaveFlag = 0;
            }
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingArea.BackColor = Color.Black;
            WritingArea.ForeColor = Color.White;
        }

        private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WritingArea.BackColor = Color.White;
            WritingArea.ForeColor = Color.Black;
        }
    }
}
