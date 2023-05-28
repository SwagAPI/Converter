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
namespace Converter
{
    public partial class Form1 : Form
    {
        public string selectedFile = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedFile != "")
            {

            
            if(comboBox2.Text != "")
            {
                    string desiredFormat = comboBox2.Text;
                    bool success = ConvertFile(selectedFile, desiredFormat);
                    if (success)
                    {
                        MessageBox.Show("File conversion successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("File conversion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }            }
            else
            {
                MessageBox.Show("Please Select Something");
            }
            }
            else
            {
                MessageBox.Show("Select File !");
            }
        }

        private bool ConvertFile(string filePath, string desiredFormat)
        {
            try
            {
                string convertedFilePath = Path.ChangeExtension(filePath, desiredFormat.ToLower());
                File.Copy(filePath, convertedFilePath);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Supported Formats Files|*.png;*.jpg;*.jpeg";
            openFileDialog.ShowDialog();
            selectedFile = openFileDialog.FileName;
        }
    }
}
