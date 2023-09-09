using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_generator
{

    public partial class Form1 : Form
    {

        int ticks; 
        public Form1()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Value = trackBar1.Value;
            label_strip.Text = trackBar1.Value.ToString();
        }

        public void checkBox_auto_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_auto.Checked == true)
            {
                checkBox_letters.Enabled = false;
                checkBox_letters.Checked = true;
                checkBox_symbols.Enabled = false;
                checkBox_symbols.Checked = true;
                trackBar1.Value = 8;
                label_strip.Text = trackBar1.Value.ToString();
                trackBar1.Enabled = false;

            }

            else
            {
                checkBox_letters.Enabled = true;
                checkBox_letters.Checked = false;
                checkBox_symbols.Enabled = true;
                checkBox_symbols.Checked = false;
                trackBar1.Enabled = true;

            }
            

        }

        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Generator cond = new Generator();
                cond.symbolCount = trackBar1.Value;
                cond.isAuto = checkBox_auto.Checked;
                cond.isLetters = checkBox_letters.Checked;
                cond.isSymbols = checkBox_symbols.Checked;

                Generator password = new Generator();
                textBox_password.Text = password.Create(checkBox_auto.Checked, checkBox_letters.Checked, checkBox_symbols.Checked, trackBar1.Value);




        }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так");
            }


}

        public void button_copy_Click(object sender, EventArgs e)
        {
            try
            {
                
                Clipboard.SetText(textBox_password.Text);
                timer1.Start();
                ticks = 10;
                


            }
            catch (Exception)
            {
                MessageBox.Show("Поле не должно быть пустым");

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label_isCopy.Text = "Скопировано!";
            ticks -= 1;
            if (ticks == 0)
            {
                label_isCopy.Text = "";
                
                timer1.Stop();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
