using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gender_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void liste1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(liste1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yüklendi");
        }

        private void gender_btn_MouseHover(object sender, EventArgs e)
        {
            gender_btn.Size = new Size(200, 50);
        }

        private void gender_btn_MouseLeave(object sender, EventArgs e)
        {
            gender_btn.Size = new Size(100, 30);
        }
    }
}
