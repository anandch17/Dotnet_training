using Microsoft.VisualBasic;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            comboBox1.Items.Add(textBox2.Text);
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove();
            foreach (ListViewItem eachItem in listBox1.Items)
            {
                listBox1.Items.Remove(eachItem);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true || checkBox2.Checked) == true &&
            radioButton1.Checked == true)
            {
   
             MessageBox.Show("Hello Mr, you will be contacted by either USPSor email", "Information", MessageBoxButtons.OKCancel,
MessageBoxIcon.Information);
            }
            else if ((checkBox1.Checked == true || checkBox2.Checked) == true && radioButton2.Checked == true)
            {
                MessageBox.Show("Hello Mam, you will be contacted by either USPS or email", "Information", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);
            }
        }  









    }
}
