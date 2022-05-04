using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Sistemi
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int paraeren = 1000;
        public static int parayaren = 1000;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Kullanıcı Bir
            if(maskedTextBox2.Text=="11111111111"&maskedTextBox1.Text=="1111")
            {
                
                for (int i=0; i<101;i++)
                {
                    progressBar1.Value = i;
                    if(i==100)
                    {
                        label1.Text = "Giriş Yapıldı";
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("Giriş Başarılı");
                        groupBox2.Visible = false;
                        groupBox1.Visible = true;
                        
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = true;
                        label12.Text = Convert.ToString(paraeren);
                        label8.Text = " Eren";
                        label9.Text = " ddddddd";
                        label10.Text = " 11111111111";
                    }
                    else if(maskedTextBox2.Text == "22222222222" & maskedTextBox1.Text == "2222")
                    {
                        label1.Text = "Giriş Yapıldı";
                        label1.ForeColor = Color.Green;
                        MessageBox.Show("Giriş Başarılı");
                        groupBox2.Visible = false;
                        groupBox1.Visible = true;

                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = true;
                        label12.Text = Convert.ToString(paraeren);
                        label8.Text = " Yaren";
                        label9.Text = " ddddddd";
                        label10.Text = " 22222222222";
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Kayıtlı Olmayan Bilgiler Yada Şifre Yanlış");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;


        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            //Kullanıcı 1
            
            if (label8.Text==" Eren")
            {
                int para_cek = Convert.ToInt32(textBox1.Text);
                if (para_cek < paraeren)
                {
                    paraeren = paraeren - para_cek ;
                    label12.Text = Convert.ToString(paraeren);
                    MessageBox.Show("Para Başarılı Bir Şekilde Çekildi Lütfen Paranızı Almayı Unutmayın", "Bank");
                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye");
                }
            }
            //Kullanıcı2
            else if(label8.Text == " Yaren")
            {
                int para_cek = Convert.ToInt32(textBox1.Text);
                if (para_cek < parayaren)
                {
                    parayaren = parayaren - para_cek;
                    label12.Text = Convert.ToString(paraeren);
                    MessageBox.Show("Para Başarılı Bir Şekilde Çekildi Lütfen Paranızı Almayı Unutmayın", "Bank");
                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Kullanıcı 1   <--
            int para_gönder = Convert.ToInt32(textBox2.Text);
            if (para_gönder < paraeren)
            {
                paraeren = paraeren - para_gönder ;
                label12.Text = Convert.ToString(paraeren);
                MessageBox.Show("Para Başarılı Bir Şekilde Gönderildi ","Para Gönder");
            }
            //Kullanıcı 2   <--
            else if (label8.Text == " Yaren")
            {
                int para_gönderr = Convert.ToInt32(textBox2.Text);
                if (para_gönderr < paraeren)
                {
                    parayaren = parayaren - para_gönderr;
                    label12.Text = Convert.ToString(paraeren);
                    MessageBox.Show("Para Başarılı Bir Şekilde Gönderildi ", "Para Gönder");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

      

        private void button7_Click_1(object sender, EventArgs e)
        {
            if(label8.Text == " Eren")
            {
                int para_yatir = Convert.ToInt32(textBox3.Text);
                paraeren = paraeren + para_yatir;
                _ = MessageBox.Show("Para Yatirildi", "Para Yatırma");
                label12.Text = Convert.ToString(paraeren);
            }
            //Kullanıcı 2   <--
            else if (label8.Text == " Yaren")
            {
                int para_yatir = Convert.ToInt32(textBox3.Text);
                parayaren = parayaren + para_yatir;
                _ = MessageBox.Show("Para Yatirildi", "Para Yatırma");
                label12.Text = Convert.ToString(parayaren);
            }
        }
    }
}
