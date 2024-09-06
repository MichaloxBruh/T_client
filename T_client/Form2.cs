using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_client
{
    public partial class Form2 : Form
    {

        public string folderpath = "C:/MF/MF_DZ/Nauczyciele";
        public string loginpath = "C:/MF/MF_DZ/Nauczyciele/Nauczycielelogin.txt";
        public string passpath = "C:/MF/MF_DZ/Nauczyciele/Nauczycielepass.txt";
        public Form2()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (Directory.Exists(folderpath))
            {
                if (File.Exists(loginpath))
                {
                    using (StreamWriter sw = File.AppendText(loginpath))
                    {
                        sw.WriteLine(textBox1.Text);
                        sw.Close();
                    }

                    if (File.Exists(passpath))
                    {
                        using (StreamWriter sw = File.AppendText(passpath))
                        {
                            sw.WriteLine(textBox1.Text);
                            sw.Close();
                        }

                        //this.Visible = false;
                        //Show();
                        MessageBox.Show("Konto Utworzone, Otwórz Program ponownie", "Konto Utworzone");
                        Close();
                    }
                    else
                    {
                        File.Create(passpath);
                        //return;

                    }
                }
                else
                {
                    File.Create(loginpath);
                    //return;

                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(folderpath);
                //return;
            }
        }  


        private void textBox1_TextChanged(object sender, EventArgs e) //login
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //pass
        {

        }
    }
}
