using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace Menu
{
    public partial class Form1 : Form
        
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public class PayingMethod
        {
            public string name;
            public string fam;
            public string tel;
            public string bank;
            public string payment;
            public string format;
            public string delivery;
            public string deliveryon;
            public PayingMethod(string name, string fam, string tel1, string payment, string format, string delivery,string deliveryon)
            {
                this.name = name;
                this.fam = fam;
                this.tel = tel;
                this.payment = payment;
                this.format = format;
                this.delivery = delivery;
                this.deliveryon = deliveryon;
            }


        }
      


        protected override void OnPaint(PaintEventArgs e)
        { Graphics g = e.Graphics; }
       
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Logo");

            fileItem.DropDownItems.Add("Shablon");
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Tekst"));
            g = pictureBox10.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;






        }
        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
            else if(MessageBox.Show("More samples?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile("");
                pictureBox10.Image = Image.FromFile("");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are selected MenuItem_1");
           
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are selected MenuItem_1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (toolStripMenuItem4.CanSelect == true)

            {
                
                pictureBox10.Image = Image.FromFile("animalworld.png");
                
            }



            if  (toolStripMenuItem4.CanSelect == false)

            {
                
                //pictureBox2.Image = Image.FromFile("comp1.png");
            }
           /* if(picture=true)
            {
                pictureBox2.Image = Image.FromFile("owl.png");

            }
            else
            {
                pictureBox2.Image = Image.FromFile("comp1.png");
            }
            */
            // textBox1.BackColor = this.BackColor;
            /* if (pictureBox1.Image == Image.FromFile("comp1.png"))

             {
                 pictureBox2.Image = Image.FromFile("comp1.png");
             }


            if( pictureBox1.Image == Image.FromFile("owl.png"))
             {
                 pictureBox2.Image = Image.FromFile("owl.png");
             }
             */








            //Size s = new Size(0, 0); s.Width = 900; s.Height = 600;
            //this.Size = s; int X = s.Width / 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Pen p; p = new Pen(Color.Aqua, 2);
            p.Color = Color.Red;
            //if (colorDialog1.ShowDialog == DialogResult.OK) p.Color = colorDialog1.Color;
            p.Width = 5;
            p.Alignment = PenAlignment.Center;
            p.Alignment = PenAlignment.Inset;
            p.Alignment = PenAlignment.Outset;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var izbran = comboBox1.Text;
            if (comboBox1.Text == "Ariel")
            {
                
                textBox1.Font = new Font(izbran, 14);
                // textBox1.Font = new
                //Font(comboBox1.Font.Name, textBox1.Font.Size);
                //textBox1.BackColor = comboBox1.BackColor;
            }
        if(comboBox1.Text=="Times New Roman")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
        if(comboBox1.Text=="Segoe Print")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
            if (comboBox1.Text == "Monotype Corsiva")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
            if (comboBox1.Text == "Georgia")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
            if (comboBox1.Text == "Elephant")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
            if (comboBox1.Text == "Comic Sans MS")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
            if (comboBox1.Text == "Cooper")
            {
                textBox1.Font = new Font(izbran, 14);
                //textBox1.Font = new Font(comboBox1.Font.Name, textBox1.Font.Size);

                //textBox1.BackColor = comboBox1.BackColor;
            }
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (Italic.CheckState == CheckState.Checked)

            {

                if (Bold.CheckState == CheckState.Checked)

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic | FontStyle.Bold);

                else

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);

            }

            else

            if (Bold.CheckState == CheckState.Checked)

            { textBox1.Font = new Font(textBox1.Font, FontStyle.Regular | FontStyle.Bold); }

            else

                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (Bold.CheckState == CheckState.Checked)

            {

                if (Italic.CheckState == CheckState.Checked)

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);

                else

                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }

            else

                if (Italic.CheckState == CheckState.Checked)

                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular | FontStyle.Italic);

            else

                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var size = comboBox2.Text;
            var izbran = comboBox1.Text;
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Ariel")
                {
                    //textBox1.Font = new Font(izbran, 70);
                     textBox1.Font = new
                    Font(izbran, 20);
                    
                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Ariel")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Ariel")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Ariel")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Monotype Corsiva")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Monotype Corsiva")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Monotype Corsiva")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Monotype Corsiva")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Times New Roman")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Times New Roman")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Times New Roman")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Times New Roman")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Segoe Print")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Segoe Print")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Segoe Print")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Segoe Print")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Cooper")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Cooper")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Cooper")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Cooper")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Comic Sans MS")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Comic Sans MS")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Comic Sans MS")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Comic Sans MS")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Elephant")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Elephant")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text == "Elephant")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Elephant")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }
            if (comboBox2.Text == "20")
            {
                if (comboBox1.Text == "Georgia")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 20);

                }
            }
            if (comboBox2.Text == "30")
            {
                if (comboBox1.Text == "Georgia")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 30);

                }
            }
            if (comboBox2.Text == "40")
            {
                if (comboBox1.Text =="Georgia")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 40);

                }
            }
            if (comboBox2.Text == "60")
            {
                if (comboBox1.Text == "Georgia")
                {
                    //textBox1.Font = new Font(izbran, 70);
                    textBox1.Font = new
                   Font(izbran, 60);

                }
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            

            StreamWriter w = new StreamWriter("paying.txt", false, Encoding.GetEncoding("Unicode"));
            string name1, fam1, tel1,payment1,delivery1;
            name1 = textBox2.Text;
            fam1 = textBox3.Text;
            tel1 = textBox4.Text;
            delivery1 = "";
           string delivery2 = "";
            if (checkBox2.Checked == true)
            {
                payment1 = comboBox3.Text;
            }
            else payment1 = "EasyPay с код:"+"  "+label1.Text;
            string format1="";
            if(checkBox5.Checked==true)
            {
                format1 = "png";
            }
           if (checkBox4.Checked == true)
            {
                format1 = "svg";
            }
             if (checkBox5.Checked == true || checkBox4.Checked == true)
            {
                format1 = "png и svg";
            }
           if(checkBox5.Checked==false||checkBox4.Checked==false)
            {
                format1 = "";
            }
            //bool a= button2.CanSelect;
            //switch (a)
            //{
            //    case true: delivery2 = "Animal world";break;
            //    case false: delivery2 = "Computer"; break;
            //        }
            //if (button16.CanSelect == true)
            //{
            //    delivery2 = "Computer";
            //}
            
            //if (toolStripMenuItem4.CanSelect == true)
            //{
            //    delivery1 = "Animal world";
            //}
            
            //if (button2.CanSelect==true)

            //{
            //    delivery2 = "  Animal world"+"\n";
                
            //}

            //else if(button16.CanSelect == true)

            //{
            //    delivery2 = "  Computer" + "\n" ;
               
            //}
            
                PayingMethod pm = new PayingMethod(name1,fam1,tel1,payment1,format1,delivery1,delivery2);
           

            w.WriteLine(pm.name + pm.fam+pm.tel+pm.payment+pm.format+pm.delivery+pm.delivery);
            w.Close();

            /*StreamReader r = new StreamReader("paying.txt", Encoding.GetEncoding("Unicode"));
            string line = "";
            while(line!=null)
            {
                line = r.ReadLine();
                richTextBox1.Text += line + "\n";
            }*/
            StreamReader r = new StreamReader("paying.txt", Encoding.GetEncoding("Unicode"));
            string line =r.ReadLine();
            int pos, next;
            PayingMethod pm1 = new PayingMethod(name1, fam1,tel1,payment1,format1,delivery1,delivery2);

            pos = 0;
            line += "";
            next = line.IndexOf("", pos);
            pm.name = line.Substring(pos, next - pos);
            pos = next + 1;
            next = line.IndexOf("", pos);
            pm.fam = line.Substring(pos, next - pos);
            next = line.IndexOf("", pos);
            pm.tel = line.Substring(pos, next - pos);
            next = line.IndexOf("", pos);
            pm.payment = line.Substring(pos, next - pos);
            next = line.IndexOf("", pos);
            pm.format = line.Substring(pos, next - pos);
            next = line.IndexOf("", pos);
            pm.delivery = line.Substring(pos, next - pos);


            richTextBox1.Text += "Справка" + "\n";
            richTextBox1.Text += "Име:\n"+"   "+name1 + "\n";
            richTextBox1.Text +="Фамилия:\n"+"   "+ fam1 + "\n";
            richTextBox1.Text += "Телефон\n"+"   "+tel1+ "\n";
            richTextBox1.Text += "Плащане\n "+"   " + payment1+ "\n";
            
            richTextBox1.Text += " Лого  " + delivery2+delivery1+ "\n" + "Формат  " + format1;





            //richTextBox1.Text += za porychkata*/
            // format


            r.Close();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            // pictureBox2.Image = Image.Equals(bm);
            //Brush b = new SolidBrush(Color.Red);
            //Point[] points = new Point[] { new Point(0, 0), new Point(0, 90),
            //new Point(90, 90), new Point(90, 0), new Point(45, 45) };
            // g.FillPolygon(b, points);
            //bm.Save("d:\\bm.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            Bitmap bm = new Bitmap("lion.jpg");
            Graphics g = this.CreateGraphics();
            g.DrawImage(bm, 1, 1, this.Width, this.Height);
            g.DrawIcon(SystemIcons.Question, 40, 40);

        }

        private PictureBox SaveFileDialog(Bitmap bm)
        {
            throw new NotImplementedException();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Pink;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }

        private void lionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("comp1.png");
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("owl.png");
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("balance.jpg");
        }

        private void girlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("girl.jfif");
        }

        private void womanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("woman.png");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
            {
                Random r = new Random();
                for(int i = 1;i<=10;i++)
                {
                    int number = r.Next() % 100 + 1;
                    label1.Text = number.ToString();
                }
            }
            if(checkBox3.Checked==true)
            {
                checkBox2.Visible = false;
                comboBox3.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                checkBox3.Visible = false;
                label1.Visible = false;
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Желаете ли помощ?", "ИНФОРМАЦИЯ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Изберете тема на логото в лентата. То ще се визуализира на екрана." +
                    " Можете да го изберете от малките бутони. Поставете и редактирайте текста, " +
                    "който сте избрали. Изтеглете вашето лого и попълнете информация за личните си данни " +
                    "в полетата.", "ИНФОРМАЦИЯ", MessageBoxButtons.OKCancel);
                



                
                    


            }
        }

        private void азToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Казвам се Деница и съм ученичка в 11в клас " +
                "на МГ Баба Тонка, паралелка Софтуерни и Хардуерни науки" +
                "", "Информация", MessageBoxButtons.OKCancel);
        }

        private void приложениетоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложението предоставя избор от шаблони за потребителя, като авторските права върху " +
                "тях са запазени. Може да запише своето лого в 2 формата,да редактира текст и да рисува върху логото." 
               , "Exit", MessageBoxButtons.OKCancel);
        }

        private void AnimalLover_Click(object sender, EventArgs e)
        {
            

            
        }

        private void HardwareRepair_Click(object sender, EventArgs e)
        {
            


        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Please Enter Name";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string PicName;
            PicName = "groupBox1";
            byte[] c = new byte[0];
            c = convertPicBoxImageToByte(pictureBox10);
            pictureBox10.ImageLocation = @"D:\Programming\" + PicName + ".png";
            pictureBox10.Image.Save(@"D:\Programming\" + PicName + ".png", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
        private byte[] convertPicBoxImageToByte(System.Windows.Forms.PictureBox pbImage)

        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                Bitmap bm = new Bitmap(groupBox1.Width, groupBox1.Height);
                Bitmap bm1 = new Bitmap(textBox1.Width, textBox1.Height);
                groupBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                textBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                bm.Save("GroupBoxImage.png", System.Drawing.Imaging.ImageFormat.Png);
                //bm.Save("textBox1.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            if(checkBox4.Checked==true)
            {
                Bitmap bm = new Bitmap(groupBox1.Width, groupBox1.Height);
                Bitmap bm1 = new Bitmap(textBox1.Width, textBox1.Height);
                groupBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                textBox2.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
                bm.Save("GroupBoxImage.png", System.Drawing.Imaging.ImageFormat.Jpeg);
                bm.Save("textBox1.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                pictureBox10.BackColor = Color.White;
                
                pictureBox5.BackColor = Color.Blue;
                pictureBox4.BackColor = Color.Yellow;
                pictureBox3.BackColor = Color.Red;
                pictureBox6.BackColor = Color.Magenta;
                pictureBox7.BackColor = Color.Blue;
                pictureBox8.BackColor = Color.Blue;
                pictureBox9.BackColor = Color.Blue;

            
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (computerToolStripMenuItem.CanSelect == true)

            {
                pictureBox10.Image = Image.FromFile("beauty1.png");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Purple;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(groupBox1.Width, groupBox1.Height);
            Bitmap bm1 = new Bitmap(textBox1.Width, textBox1.Height);
            groupBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            textBox1.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            bm.Save("GroupBoxImage.Jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            bm.Save("textBox1.Jpeg", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (computerToolStripMenuItem.CanSelect == true)

            {
                pictureBox1.Image = Image.FromFile("beauty1.png");
            }
        }

        private void animalWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.CanSelect == true)

            {
                pictureBox1.Image = Image.FromFile("animalworld.png");
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox10.Width, pictureBox10.Height);
            
            pictureBox10.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;
            bm.Save("PicboxImage.png", System.Drawing.Imaging.ImageFormat.Png);
            

            
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Graphics gr1 = panel1.CreateGraphics();
            //Bitmap bmp1 = new Bitmap(panel1.Width, panel1.Height);
            //panel1.DrawToBitmap(bmp1, new Rectangle(0, 0, panel1.Width, panel1.Height));
            //bmp1.Save("logopanel.bmp");

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
//            Bitmap theScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
//Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
//            //Graphics theGraphics = Graphics.FromImage(theScreenShot);
//            theScreenShot.Save("help.jpg", ImageFormat.Jpeg);
//            theScreenShot.Dispose();
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            button14.Text = "Помощ";
            groupBox2.Text = "Текстов редактор";
            button8.Text = "Отвори";
            groupBox1.Text = "Визуализация";
            label3.Text = "Име";
            label4.Text = "Презиме";
            label5.Text = "Телефонен номер";
            button17.Text = "Запази лого";
            checkBox2.Text = "С карта";
            button1.Text = "Изход";
            label2.Text = "Данни за плащане";

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            Bitmap theScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            //Graphics theGraphics = Graphics.FromImage(theScreenShot);
            theScreenShot.Save("help.jpg", ImageFormat.Jpeg);
            theScreenShot.Dispose();


            //Bitmap bmp = new Bitmap(this.pictureBox10.Width, this.pictureBox10.Height);

            //this.pictureBox10.DrawToBitmap(bmp, new Rectangle(0, 0, this.pictureBox10.Width, this.pictureBox10.Height));

            //bmp.Save("help1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //MemoryStream ms = new MemoryStream();
            //Bitmap bmp = new Bitmap(pictureBox10.Width, pictureBox10.Height);
            //pictureBox10.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, pictureBox10.Width, pictureBox10.Height));
            //bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //you could ave in BPM, PNG  etc format.
            //byte[] Pic_arr = new byte[ms.Length];
            //ms.Position = 0;
            //ms.Read(Pic_arr, 0, Pic_arr.Length);
            //ms.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            pictureBox11.Visible = false;
            button9.Visible = false;
            button9.Enabled = false;
        }
    }
    }
    
    


