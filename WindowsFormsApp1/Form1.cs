using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string msnv;
        private string fullname;
        private decimal? luongcb;
   

        public Form1(string m, string k, decimal? c)
        {
            InitializeComponent();
            msnv = m;
            fullname = k;
            luongcb = c;
            if(m!=null && k!= null && c != null){
                dataGridView1.Rows.Add(m, k, c);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?","Thông báo",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void AddData(string msnv, string fullname, decimal? luongcb)
        {
            dataGridView1.Rows.Add(msnv, fullname, luongcb);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                var selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve values from the selected row
                string msnv = selectedRow.Cells[0].Value.ToString();
                string fullname = selectedRow.Cells[1].Value.ToString();
                decimal? luongcb = selectedRow.Cells[2].Value != null
                    ? (decimal?)Convert.ToDecimal(selectedRow.Cells[2].Value)
                    : null;

                // Create an instance of Form2 and call Sua method
                Form2 frm = new Form2(this);
                frm.Sua(msnv, fullname, luongcb);

                // Show the form
                frm.ShowDialog(); // Use ShowDialog to keep the focus on Form2
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng trong bảng để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                // Check if any row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Confirm deletion
                    DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        // Remove the selected row
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng trong bảng để xóa!");
                }
            }
        }
    }
}
