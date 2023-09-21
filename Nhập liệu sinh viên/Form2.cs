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
    public partial class Form2 : Form
    {
        DataGridView fgrid;
        List<Students> studentList;
        public Form2(DataGridView fg, List<Students> studentList)
        {
            InitializeComponent();
            this.fgrid = fg;
            this.studentList = studentList;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Insert(int selectedRow)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMS.Text) || string.IsNullOrEmpty(txtDTB.Text))
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin !");
                }
                if(studentList.Where(s => s.Id == txtMS.Text).Count() > 0)
                {
                    throw new Exception("Mã số sinh viên đã bị trùng !");
                }
                studentList.Add(new Students() { Stt = studentList.Count() + 1, Id = txtMS.Text, Name = txtTen.Text, Faculty = cmbKhoa.Text, Score = int.Parse(txtDTB.Text)});
                fgrid.DataSource = null;
                fgrid.DataSource = studentList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            txtMS.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtDTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((float.Parse(txtDTB.Text)) > 10 || (float.Parse(txtDTB.Text)) < 0)
                {

                    throw new Exception("Nhập điểm trong phạm vi từ (0 - 10) ");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtMS_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }
