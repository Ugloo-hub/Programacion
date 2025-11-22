using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploads1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imageUploadDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageUploadDataSet.Image_Upload' table. You can move, or remove it, as needed.
            this.image_UploadTableAdapter.Fill(this.imageUploadDataSet.Image_Upload);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Images only. | *.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = openFD.ShowDialog();

            imgPictureBox.Image = Image.FromFile(openFD.FileName);

            imgpathLabel1.Text = openFD.FileName;
        }
    }
}
