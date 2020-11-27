using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoflabel = comboBox1.Text;
            switch (textoflabel)
            {
                case "Select":
                    radiuslabel.Visible = false;
                    edge1label.Visible = false;
                    edge2label.Visible = false;
                    radiustextbox.Visible = false;
                    edge1textbox.Visible = false;
                    edge2textbox.Visible = false;
                    break;
                case "Circle":
                    radiuslabel.Visible = true;
                    edge1label.Visible = false;
                    edge2label.Visible = false;
                    radiustextbox.Visible = true;
                    edge1textbox.Visible = false;
                    edge2textbox.Visible = false;
                    break;
                case "Rectangle":
                    radiuslabel.Visible = false;
                    edge1label.Visible = true;
                    edge2label.Visible = true;
                    radiustextbox.Visible = false;
                    edge1textbox.Visible = true;
                    edge2textbox.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Circle")
            {
                CircleForm circle = new CircleForm(Convert.ToInt32(radiustextbox.Text));
                circle.Show();
            }
            else if (comboBox1.Text == "Rectangle")
            {
                RectangleForm rectangle = new RectangleForm(Convert.ToInt32(edge1textbox.Text), Convert.ToInt32(edge2textbox.Text));
                rectangle.Show();
            }
            else
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
