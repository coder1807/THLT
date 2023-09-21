using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI___MDI
{
    public partial class childForm : Form
    {
        public childForm()
        {
            InitializeComponent();
        }

        public childForm(string imageFile)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imageFile);
            this.Text = imageFile.Substring(imageFile.LastIndexOf("\\") + 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
