using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad4Me
{
    public partial class frmMain : Form
    {

        string OurFilename;

        string lastFindWord;
        bool lastFindDown;
        bool lastFindMatchCase;

        void DoSave(string filename)
        {
            OurFilename = filename;
            richTextBox1.SaveFile(filename);
        }
        
        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        bool CheckChanges()
        {

            return true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurFilename))
            {
                DoSaveAs(); 
            }
            else
            {
                DoSave(OurFilename);
            }
                
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFind find = new frmFind();
            find.Show(this);
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain parent_form = (frmMain)Owner;
            parent_form.Dofind(txtFindWhat.Text, rdoDown.Checked, chkMatchCase.Checked);
        }

        private void DoFind (string search,bool down, bool match_case)
        {
            lastFindWord = search;
            lastFindDown = down;
            lastFindMatchCase = match_case;

            if (down)
            {
                if (match_case)
                {
                    TextBox.Find(search, TextBox.SelectionStart + 1, RichTextBoxFinds.Match
                }
            }

        }
    }
}
