namespace passoparola
{
    public partial class Form1 : Form

    {
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        int dogru = 0, yanlis = 0, soruno = 0;
        int sayi = 10;
        

        private void button22_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Bu soruyu cevapladiniz!!");
            }
            else
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "adil")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;

                        }
                        else
                        {
                            button1.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol=false;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bit")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button2.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cadi")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button3.BackColor=Color.Red;
                            yanlis++;
                            label6.Text =yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 4:
                        if(textBox1.Text == "dakika")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button4.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol=false;
                        }
                        break ;
                    case 5:
                        if (textBox1.Text == "etamin")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button5.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 6:
                        if(textBox1.Text == "fakulte")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label4.Text =dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button6.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 7:
                        if(textBox1.Text == "gaf")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button7.BackColor=Color.Red;
                            yanlis++;
                            label6.Text =yanlis.ToString();
                            kontrol=false;
                        }
                        break;
                    case 8:
                        if(textBox1.Text == "hacer")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button8.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 9:
                        if(textBox1.Text == "I")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button9.BackColor=Color.Red;
                            yanlis++;
                            label6.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "jelatin")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button10.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol=false;
                        }
                        break;
                    case 11:
                        if(textBox1.Text == "kul")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button11.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 12:
                        if(textBox1.Text == "ladin")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button12.BackColor=Color.Red;
                            yanlis++;
                            label6.Text =yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 13:
                        if(textBox1.Text == "maya")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button13.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol=false;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Notre Dame'ýn kamburu")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button14.BackColor=Color.Red;
                            yanlis++;
                            label6.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "obruk")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button15.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString() ;
                            kontrol = false;
                        }
                        break;
                    case 16:
                        if(textBox1.Text == "pabuc")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol= false;
                        }
                        else
                        {
                            button16.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "raportor")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button17.BackColor=Color.Red;
                            yanlis++;
                            label6.Text = yanlis.ToString();
                            kontrol = false;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ses")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString();
                            kontrol = false;
                        }
                        else
                        {
                            button18.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString() ;
                            kontrol=false;
                        }
                        break;
                    case 19:
                        if(textBox1.Text == "us")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label4.Text=dogru.ToString() ;
                            kontrol = false;
                        }
                        else
                        {
                            button19.BackColor=Color.Red;
                            yanlis++;
                            label6.Text=yanlis.ToString();
                            kontrol=false;
                        }
                        break ;
                    case 20:
                        if(textBox1.Text == "yurt")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label4.Text= dogru.ToString() ;
                            kontrol = false;

                        }
                        else
                        {
                            button20.BackColor=Color.Red;
                            yanlis++;
                            label6.Text = yanlis.ToString();
                            kontrol=!false;
                        }
                        break;





                }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

         
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            _ticks++;
            button23.Text = _ticks.ToString();
            if (_ticks == 10)
            {
                button21.PerformClick();
              
                yanlis++;
                _ticks = 0;



            }

        }

        bool kontrol = true;

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = "Sonraki";
            soruno++;
            kontrol=true;
            this.Text = "Soru" + soruno;
            if (soruno == 1)
            {
                richTextBox1.Text = "Adalete uygun";
                button1.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "Asalak bir bocek";
                button2.BackColor = Color.Yellow;
                textBox1.Text = "";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Buyucu";
                button3.BackColor = Color.Yellow;
                textBox1.Text = "";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Saatin altmista biri";
                button4.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Seyrek dokunmus delikli kumas";
                button5.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Dekan tarafindan yonetilen bolum";
                button6.BackColor = Color.Yellow;
                textBox1.Text = "";

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Pot";
                button7.BackColor= Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Tas,kaya parcasi";
                button8.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if(soruno == 9)
            {
                richTextBox1.Text = "Iyotun simgesi";
                button9.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Toz veya tabaka seklinde kivam verici";
                button10.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Atesten arta kalan";
                button11.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Kerestesi ve recinesi cok begenilen orman agaci";
                button12.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Disi deve";
                button13.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Victor Hugo tarafinndan yazilan unlu roman";
                button14.BackColor = Color.Yellow;
                textBox1.Text = "";

            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Icine su biriken dogal cukur";
                button15.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if(soruno == 16)
            {
                richTextBox1.Text = "Farscada ayakkabi";
                button16.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Sozcu";
                button17.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Kulagin duyabildigi titresim";
                button18.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Akil kelimesinin en anlamlisi";
                button19.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Memleket";
                button20.BackColor = Color.Yellow;
                textBox1.Text = "";
            }
        }
    }
}