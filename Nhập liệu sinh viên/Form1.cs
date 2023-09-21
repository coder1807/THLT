using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhập_liệu_sinh_viên
{
    public partial class Form1 : Form
    {
        private DataGridView dvg;
        List<Students> studentList = new List<Students>();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(DataGridView dvg, int index = -1)
        {
            InitializeComponent();
            this.dvg = dvg;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(dvgQLSV,studentList);
            f.ShowDialog();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(dvgQLSV,studentList);
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không ?","Thoát",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question); 
            if(rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.GetType().ToString());
            ToolStripTextBox toolStripTextBox = sender as ToolStripTextBox;
            if(toolStripTextBox.Text.Length == 0)
            {
                dvgQLSV.DataSource = null;
                dvgQLSV.DataSource = studentList;
            }
            else
            {
                dvgQLSV.DataSource = null;
                List<Students> std = new List<Students>();
                std = studentList.Where(s => s.Name.Contains(toolStripTextBox.Text)).ToList();
                if(std.Count > 0)
                {
                    dvgQLSV.DataSource = null;
                    dvgQLSV.DataSource = std;
                }
            }
        }
    }
}
