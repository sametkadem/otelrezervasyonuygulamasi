using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class Form2 : Form
    {
        public int total_person2 { get; set; }
        public int yetiskin_2 { get; set; }
        public int cocuk_2 { get; set; }
        public Form2()
        {
            
             InitializeComponent();
        }
        private void Form2_load(object sender,EventArgs e)
        {
            label10.Text = total_person2.ToString();
        }

      

        class Customer
        {

            public string firstname { get; set; }
            public string lastname { get; set; }
            public string phone_number { get; set; }
            public string cinsiyet { get; set; }
            public string dogum_tarihi { get; set; }
            public string mail { get; set; }

            public string passport { get; set; }
            public string vatandaslik { get; set; }


        };
        

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Customer cst = new Customer();
            if(radioButton7.Checked == false && radioButton8.Checked == false)
            {
                MessageBox.Show("Lütfen kişi türü seçiniz...");
                return;

            }
            
            
            if(yetiskin_2 != 0 || cocuk_2 != 0)
            {
                if(radioButton8.Checked == true) /// yetişkin
                {
                   if(yetiskin_2 == 0)
                    {
                        MessageBox.Show("Tüm yetişikinler kayıt edildi, çocukların kaydını tamamlayınız...");

                        return;
                    }

                    cst.firstname = textBox1.Text;
                    cst.lastname = textBox2.Text;
                    cst.phone_number = maskedTextBox1.Text;
                    if (radioButton3.Checked == true)
                    {
                        cst.cinsiyet = "Erkek";
                    }
                    else if (radioButton4.Checked == true)
                    {
                        cst.cinsiyet = "Kadın";
                    }
                    else if (radioButton3.Checked == false && radioButton4.Checked == false)
                    {
                        MessageBox.Show("Lütfen Cinsiyet Seçiniz");
                    }
                    cst.dogum_tarihi = maskedTextBox2.Text;
                    cst.mail = textBox4.Text;

                    if (radioButton6.Checked == true)
                    {
                        cst.vatandaslik = "Türk";
                        cst.passport = maskedTextBox3.Text;
                    }
                    else if (radioButton5.Checked == true)
                    {

                        label7.Text = "Pasaport Numarası";
                        cst.vatandaslik = Convert.ToString(comboBox1.SelectedIndex);
                    }
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" || maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
                    {
                        MessageBox.Show("Lütfen boşlukları doldurunuz...");
                        return;
                    }
                    else
                    {
                        listBox1.Items.Add(cst.firstname + " " + cst.lastname + " " + "\n" + "Telefon Numarası : " + cst.phone_number + "\n" + "Cinsiyet : " + cst.cinsiyet + "\n" + "Dogum Tarihi : " + cst.dogum_tarihi + "\n" + "Vatandaşlık : " + cst.vatandaslik + "\n" + "Kimlik /Pasaport Numarası : " + cst.passport + "\n" + "Mail : " + cst.mail);
                        yetiskin_2 = yetiskin_2 - 1;
                    }
                }
                if(radioButton7.Checked == true) /// çocuk 
                {
                    if (cocuk_2 == 0)
                    {
                        MessageBox.Show("Tüm cocuklar kayıt edildi, yetişkinlerin kaydını tamamlayınız...");

                        return;
                    }

                    cst.firstname = textBox1.Text;
                    cst.lastname = textBox2.Text;
                   
                    if (radioButton3.Checked == true)
                    {
                        cst.cinsiyet = "Erkek";
                    }
                    else if (radioButton4.Checked == true)
                    {
                        cst.cinsiyet = "Kadın";
                    }
                    else if (radioButton3.Checked == false && radioButton4.Checked == false)
                    {
                        MessageBox.Show("Lütfen Cinsiyet Seçiniz");
                    }
                    cst.dogum_tarihi = maskedTextBox2.Text;
                    cst.mail = textBox4.Text;

                    if (radioButton6.Checked == true)
                    {
                        cst.vatandaslik = "Türk";
                        cst.passport = maskedTextBox3.Text;
                    }
                    else if (radioButton5.Checked == true)
                    {

                        label7.Text = "Pasaport Numarası";
                        cst.vatandaslik = Convert.ToString(comboBox1.SelectedIndex);
                    }
                    if (textBox1.Text == "" || textBox2.Text == "" ||  maskedTextBox2.Text == "" || maskedTextBox3.Text == "")
                    {
                        MessageBox.Show("Lütfen boşlukları doldurunuz...");
                        return;
                    }
                    else
                    {
                        listBox1.Items.Add("**" + "\n" + cst.firstname + " " + cst.lastname +  "\n" + "Cinsiyet : " + cst.cinsiyet + "\n" + "Dogum Tarihi : " + cst.dogum_tarihi + "\n" + "Vatandaşlık : " + cst.vatandaslik + "\n" + "Kimlik /Pasaport Numarası : " + cst.passport);
                        cocuk_2 = cocuk_2 - 1;
                    }


                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox4.Text = null;
                    maskedTextBox1.Text = null;
                    maskedTextBox2.Text = null;
                    maskedTextBox3.Text = null;

                }
            }
            if (yetiskin_2 == 0 && cocuk_2 == 0)
            {
                MessageBox.Show("Tüm misafirlerin bilgileri kayıt edildi...");
                return;
            }
            
            

            textBox1.Text = null;
            textBox2.Text = null;
            textBox4.Text = null;
            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;
            maskedTextBox3.Text = null;








        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label8.Visible = true;
                comboBox1.Visible = true;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.SelectedItem));


                

        }

        private void button3_Click(object sender, EventArgs e)
        {
          foreach (string item in listBox1.Items)
            {
                if (item.ToLower().Contains("**"))
                {
                    cocuk_2 = cocuk_2 + 1;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    return;
                }
                
            }
            yetiskin_2 = yetiskin_2 + 1;
            listBox1.Items.Remove(listBox1.SelectedItem);


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void kişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yetişkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void kişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
                      

        }

        private void yetişkinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = Convert.ToString(yetiskin_2 + " yetişkin, " + cocuk_2+" çocuk");


        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
         
            label3.Enabled = false;
            label3.Visible = false; /// telefon numarası
            maskedTextBox1.Enabled = false;
            maskedTextBox1.Visible = false;
            

            label4.Enabled = false;
            label4.Visible = false; /// mail
            textBox4.Enabled = false;
            textBox4.Visible = false;
            


        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label3.Enabled =true;
            label3.Visible = true; /// telefon numarası
            maskedTextBox1.Enabled = true;
            maskedTextBox1.Visible = true;


            label4.Enabled = true;
            label4.Visible = true; /// mail
            textBox4.Enabled = true;
            textBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
