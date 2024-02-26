using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bize 64 tane buton lazım old. için bunu en mantıklı yol olan Çok boyutlu diziler yardımıyla yapacağız.

            DamaTahtası();
        }

        private void DamaTahtası()
        {
            Button[,] buttons = new Button[8, 8]; // 8 satır ve 8 sütundan oluşan dizi tanımı.
            int top = 0; //butonun en üst ile mesafesi.
            int left = 0; //butonun en sol ile mesafesi.


            for (int i = 0; i <= buttons.GetUpperBound(0); i++) //8 satırdan çıktı alma
            {

                for (int j = 0; j <= buttons.GetUpperBound(1); j++) //8 satırda bulunan her sütundan  çıktı alma
                {

                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50; // her butonun arasına yatayda 50 karakterlik boşluk bırak

                    if ((i + j) % 2 == 0) // Her butondan birinin sıyah bırının beyaz olmasını sağlayan algoritma.
                    {
                        buttons[i, j].BackColor = Color.Aqua;
                    }
                    else if ((i+j)%3==0)
                    {
                        buttons[i, j].BackColor = Color.DarkGreen;
                    }
                    else if ((i + j) % 5 == 0)
                    {
                        buttons[i, j].Text = "Erkan";
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.DarkBlue;
                    }
                    buttons[i, j].Top = top;


                    this.Controls.Add(buttons[i, j]);
                }
                top += 50; // her butonun arasına dikeyde 50 karakterlik boşluk bırak, alt alta yazdır. Nir satır bittiğinde alt satır için işlem başlar.
                left = 0;
            }


            
        }
    }
}
