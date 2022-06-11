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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static int total_person = 2;
        public static int gunlukUcret = 0;
        public static int toplamUcret = 0;
        public static int yetiskin = 2;
        public static int cocuk = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            TimeSpan konaklamaSuresi = cikisTarihi - girisTarihi;


            if (cikisTarihi < girisTarihi)
            {
                MessageBox.Show("Çıkış tarihiniz giriş tarihinizden daha erken olamaz...");
                return;
            }
            else if (cikisTarihi == girisTarihi)
            {
                MessageBox.Show("Giriş tarihiniz ile çıkış tarihiniz eşit olamaz...");
                return;
            }
            else if (konaklamaSuresi.TotalDays < 1)
            {
                MessageBox.Show("Otelimizde minimum 1 gece konaklamalısınız...");
                return;
            }



            if (numericUpDown2.Value == 1)
            {
                if(comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen çocuğunuzun yaşını giriniz...");
                    return;
                }
                
            }
            else if(numericUpDown2.Value == 2)
            {  if (comboBox4.SelectedItem == null || comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen çocuklarınızın yaşını giriniz...");
                    return;
                }
            }
            
            
            
            Form2 frm = new Form2();
            frm.total_person2 = total_person;
            frm.yetiskin_2 = yetiskin;
            frm.cocuk_2 = cocuk;
            frm.ShowDialog();

            
            



            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                groupBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;

            }


            if (numericUpDown2.Value == 1)
            {
                groupBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = false;

            }

            if (numericUpDown2.Value == 2)
            {
                groupBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;

            }
            cocuk = Convert.ToInt16(numericUpDown2.Value);
            total_person = Convert.ToInt16(numericUpDown1.Value);
            total_person = Convert.ToInt16(total_person + numericUpDown2.Value);
            label11.Text = total_person.ToString();


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            yetiskin = Convert.ToInt16(numericUpDown1.Value);
            total_person = Convert.ToInt16(numericUpDown2.Value);
            total_person = Convert.ToInt16(total_person + numericUpDown1.Value);
            label11.Text = total_person.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            TimeSpan konaklamaSuresi = cikisTarihi - girisTarihi;
                       
            
            if(cikisTarihi < girisTarihi)
            {
                MessageBox.Show("Çıkış tarihiniz giriş tarihinizden daha erken olamaz...");
                return;
            }
            else if(cikisTarihi == girisTarihi)
            {
                MessageBox.Show("Giriş tarihiniz ile çıkış tarihiniz eşit olamaz...");
                return;
            }
            else if(konaklamaSuresi.TotalDays < 1)
            {
                MessageBox.Show("Otelimizde minimum 1 gece konaklamalısınız...");
            }

            if(cocuk != 0)
            {
                if (radioButton1.Checked == true) /// Deniz manzaralı oda
                {
                    if (radioButton3.Checked == true) /// Herşey dahil
                    {
                        if (numericUpDown2.Value == 1) /// 1 çocuklu 
                        {
                            gunlukUcret = yetiskin * 500;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if(numericUpDown2.Value == 2) /// 2 çocuklu 
                        {
                            if(comboBox4.SelectedIndex <= 2) /// cocugun yaşı 0-2 
                            {
                                gunlukUcret = yetiskin * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else // cocugun yaşi cocugun yaşı > 2  
                            {
                                gunlukUcret = (yetiskin+1) * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        if (numericUpDown2.Value == 1) /// 1 cocuklu 
                        {
                            gunlukUcret = yetiskin * 300;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if (numericUpDown2.Value == 2) /// 2 cocuklu 
                        {
                            if (comboBox4.SelectedIndex <= 2) // 2.cocugun yaşı < 2
                            {
                                gunlukUcret = yetiskin * 300;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else /// 2.cocugun yaşı > 2
                            {
                                gunlukUcret = (yetiskin + 1) * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }

                }
                else if (radioButton2.Checked == true) /// kara manzaralı 
                {
                    
                        if (radioButton3.Checked == true) /// Herşey dahil
                        {
                            if (numericUpDown2.Value == 1) /// 1 çocuklu 
                            {
                                gunlukUcret = yetiskin * 400;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else if (numericUpDown2.Value == 2) /// 2 çocuklu 
                            {
                                if (comboBox4.SelectedIndex <= 2) /// cocugun yaşı 0-2 
                                {
                                    gunlukUcret = yetiskin * 400;
                                    toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                    label9.Text = gunlukUcret.ToString() + "₺";
                                    label10.Text = toplamUcret.ToString() + "₺";
                                    return;
                                }
                                else // cocugun yaşi cocugun yaşı > 2  
                                {
                                    gunlukUcret = (yetiskin + 1) * 400;
                                    toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                    label9.Text = gunlukUcret.ToString() + "₺";
                                    label10.Text = toplamUcret.ToString() + "₺";
                                    return;
                                }
                            }
                        }
                        else if (radioButton4.Checked == true) /// yarım pansiyon
                        {
                            if (numericUpDown2.Value == 1) /// 1 cocuklu 
                            {
                                gunlukUcret = yetiskin * 250;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else if (numericUpDown2.Value == 2) /// 2 cocuklu 
                            {
                                if (comboBox4.SelectedIndex <= 2) // 2.cocugun yaşı < 2
                                {
                                    gunlukUcret = yetiskin * 250;
                                    toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                    label9.Text = gunlukUcret.ToString() + "₺";
                                    label10.Text = toplamUcret.ToString() + "₺";
                                    return;
                                }
                                else /// 2.cocugun yaşı > 2
                                {
                                    gunlukUcret = (yetiskin + 1) * 250;
                                    toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                    label9.Text = gunlukUcret.ToString() + "₺";
                                    label10.Text = toplamUcret.ToString() + "₺";
                                    return;
                                }
                            }
                        }

                    
                }

            }
            else if(cocuk == 0) /// cocuk yok
            {
                if(radioButton1.Checked == true) {  /// deniz manzarali 
                    if(radioButton3.Checked == true) { /// herşey dahil
                        gunlukUcret = yetiskin * 500;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                    else if(radioButton4.Checked == true) /// yarım pansiyon
                    {
                        gunlukUcret = yetiskin * 300;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;                    
                    }
                
                }
            else if(radioButton2.Checked == true) /// kara manzaralı
                {
                    if (radioButton3.Checked == true) /// herşey dahil 
                    {
                        gunlukUcret = yetiskin * 400;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        gunlukUcret = yetiskin * 250;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                }
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            TimeSpan konaklamaSuresi = cikisTarihi - girisTarihi;
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTimePicker1.Value;
            DateTime cikisTarihi = dateTimePicker2.Value;
            TimeSpan konaklamaSuresi = cikisTarihi - girisTarihi;


           

            if (cocuk != 0)
            {
                if (radioButton1.Checked == true) /// Deniz manzaralı oda
                {
                    if (radioButton3.Checked == true) /// Herşey dahil
                    {
                        if (numericUpDown2.Value == 1) /// 1 çocuklu 
                        {
                            gunlukUcret = yetiskin * 500;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if (numericUpDown2.Value == 2) /// 2 çocuklu 
                        {
                            if (comboBox4.SelectedIndex <= 2) /// cocugun yaşı 0-2 
                            {
                                gunlukUcret = yetiskin * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else // cocugun yaşi cocugun yaşı > 2  
                            {
                                gunlukUcret = (yetiskin + 1) * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        if (numericUpDown2.Value == 1) /// 1 cocuklu 
                        {
                            gunlukUcret = yetiskin * 300;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if (numericUpDown2.Value == 2) /// 2 cocuklu 
                        {
                            if (comboBox4.SelectedIndex <= 2) // 2.cocugun yaşı < 2
                            {
                                gunlukUcret = yetiskin * 300;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else /// 2.cocugun yaşı > 2
                            {
                                gunlukUcret = (yetiskin + 1) * 500;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }

                }
                else if (radioButton2.Checked == true) /// kara manzaralı 
                {

                    if (radioButton3.Checked == true) /// Herşey dahil
                    {
                        if (numericUpDown2.Value == 1) /// 1 çocuklu 
                        {
                            gunlukUcret = yetiskin * 400;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if (numericUpDown2.Value == 2) /// 2 çocuklu 
                        {
                            if (comboBox4.SelectedIndex <= 2) /// cocugun yaşı 0-2 
                            {
                                gunlukUcret = yetiskin * 400;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else // cocugun yaşi cocugun yaşı > 2  
                            {
                                gunlukUcret = (yetiskin + 1) * 400;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        if (numericUpDown2.Value == 1) /// 1 cocuklu 
                        {
                            gunlukUcret = yetiskin * 250;
                            toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                            label9.Text = gunlukUcret.ToString() + "₺";
                            label10.Text = toplamUcret.ToString() + "₺";
                            return;
                        }
                        else if (numericUpDown2.Value == 2) /// 2 cocuklu 
                        {
                            if (comboBox4.SelectedIndex <= 2) // 2.cocugun yaşı < 2
                            {
                                gunlukUcret = yetiskin * 250;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                            else /// 2.cocugun yaşı > 2
                            {
                                gunlukUcret = (yetiskin + 1) * 250;
                                toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                                label9.Text = gunlukUcret.ToString() + "₺";
                                label10.Text = toplamUcret.ToString() + "₺";
                                return;
                            }
                        }
                    }


                }

            }
            else if (cocuk == 0) /// cocuk yok
            {
                if (radioButton1.Checked == true)
                {  /// deniz manzarali 
                    if (radioButton3.Checked == true)
                    { /// herşey dahil
                        gunlukUcret = yetiskin * 500;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        gunlukUcret = yetiskin * 300;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }

                }
                else if (radioButton2.Checked == true) /// kara manzaralı
                {
                    if (radioButton3.Checked == true) /// herşey dahil 
                    {
                        gunlukUcret = yetiskin * 400;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                    else if (radioButton4.Checked == true) /// yarım pansiyon
                    {
                        gunlukUcret = yetiskin * 250;
                        toplamUcret = Convert.ToInt16(konaklamaSuresi.TotalDays) * gunlukUcret;
                        label9.Text = gunlukUcret.ToString() + "₺";
                        label10.Text = toplamUcret.ToString() + "₺";
                        return;
                    }
                }
            }
        }

    }
}
    

