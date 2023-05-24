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

namespace DirectoryExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Clicked(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("temp");

            if (!Directory.Exists("temp"))
            {
                DirectoryInfo dir = new DirectoryInfo("temp");
                dir.Create();
                MessageBox.Show("Folder Was Created");
            }
            else
            {
                MessageBox.Show("Folder Already Exists");     
            }
        }

        private void Move_Clicked(object sender, EventArgs e)
        {
            Directory.Move("temp", @"C:\temp");
            MessageBox.Show("Folder Moved!");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            Directory.Delete("temp");
            MessageBox.Show("Folder Deleted!");
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
