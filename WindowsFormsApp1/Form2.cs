using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private Form1 _mainForm;

        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            this.BackColor = SystemColors.Control; // Set a default background color
            _mainForm = mainForm; // Store the reference to the main form
        }

        public void Sua(string m, string t, decimal? k)
        {
            txtmsnv.Text = m;
            txtfullname.Text = t;
            txtluongcb.Text = k.ToString();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            string msnv = txtmsnv.Text;
            string fullname = txtfullname.Text;
            decimal? luongcb = decimal.TryParse(txtluongcb.Text, out decimal value) ? (decimal?)value : null;

            // Call the method to add data to Form1
            _mainForm.AddData(msnv, fullname, luongcb);

            // Close Form2 after adding the data
            this.Close();
        }
    }
}
