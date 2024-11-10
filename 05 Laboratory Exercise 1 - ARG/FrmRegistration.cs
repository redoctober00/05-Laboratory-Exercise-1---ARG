using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace _05_Laboratory_Exercise_1___ARG
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            comboBox1.Items.Add("BS Information Technology");
            comboBox1.Items.Add("BS Computer Science");

            comboBox2.Items.Add("Male");
            comboBox2.Items.Add("Female");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            string studentNumber = textBox1.Text;
            string lastName = textBox2.Text;
            string age = textBox3.Text;
            string firstName = textBox5.Text;
            string middleInitial = textBox6.Text;
            string contactNo = textBox7.Text;
            string program = comboBox1.SelectedItem.ToString();
            string gender = comboBox2.SelectedItem.ToString();
            DateTime birthday = dateTimePicker1.Value;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, studentNumber + ".txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine("Student No : " + studentNumber);
                outputFile.WriteLine("FullName   : " + lastName + ", " + firstName + " " + middleInitial + ".");
                outputFile.WriteLine("Program    : " + program);
                outputFile.WriteLine("Gender     : " + gender);
                outputFile.WriteLine("Age        : " + age);
                outputFile.WriteLine("Birthday   : " + birthday.ToShortDateString());
                outputFile.WriteLine("Contact No : " + contactNo);

            }

        
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
