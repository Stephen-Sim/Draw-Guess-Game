using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你画我猜.Drawer
{
    public partial class DrawerForm : Form
    {
        Pen pen;
        Graphics graphics;

        string[] fruits = {
            "苹果", // píngguǒ (Apple)
            "香蕉", // xiāngjiāo (Banana)
            "橙子", // chéngzi (Orange)
            "梨",   // lí (Pear)
            "西瓜", // xīguā (Watermelon)
            "葡萄", // pútáo (Grape)
            "草莓", // cǎoméi (Strawberry)
            "桃子", // táozi (Peach)
            "樱桃", // yīngtáo (Cherry)
            "柠檬", // níngméng (Lemon)
            "李子", // lǐzi (Plum)
            "猕猴桃", // míhóutáo (Kiwi)
            "哈密瓜", // hāmìguā (Cantaloupe)
            "荔枝", // lìzhī (Lychee)
            "芒果", // mángguǒ (Mango)
            "柿子", // shìzi (Persimmon)
            "火龙果", // huǒlóngguǒ (Dragon fruit)
            "杨梅", // yángméi (Bayberry)
            "山竹", // shānzhú (Mangosteen)
            "木瓜" // mùguā (Papaya)
        };

        string fruit;

        int cursorX = -1;
        int cursorY = -1;
        bool mouseMove = false;

        public DrawerForm()
        {
            InitializeComponent();
            NextButton.Select();

            sufferingFruit();
            graphics = Canvas.CreateGraphics();
            pen = new Pen(Color.Black, 7);
            PencilPictureBox.Location = new Point(PencilPictureBox.Location.X + 35, PencilPictureBox.Location.Y);
        }

        private void PencilPictureBox_Click(object sender, EventArgs e)
        {
            if (pen.Color == Color.Black)
            {
                return;
            }

            pen = new Pen(Color.Black, 7);
            PencilPictureBox.Location = new Point(PencilPictureBox.Location.X + 35, PencilPictureBox.Location.Y);
            EraserPictureBox.Location = new Point(EraserPictureBox.Location.X - 25, EraserPictureBox.Location.Y);
        }

        private void EraserPictureBox_Click(object sender, EventArgs e)
        {
            if (pen.Color == Color.White)
            {
                return;
            }

            pen = new Pen(Color.White, 30);
            PencilPictureBox.Location = new Point(PencilPictureBox.Location.X - 35, PencilPictureBox.Location.Y);
            EraserPictureBox.Location = new Point(EraserPictureBox.Location.X + 25, EraserPictureBox.Location.Y);
        }

        void sufferingFruit()
        {
            fruit = fruits[new Random().Next(0, fruits.Length - 1)];
            FruitLabel.Text = fruit;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            sufferingFruit();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            cursorX = e.X; cursorY = e.Y;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove && cursorX != -1 && cursorY != -1)
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes($"{fruit},{cursorX},{cursorY},{e.Location.X},{e.Location.Y}");
                graphics.DrawLine(pen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X; cursorY = e.Y;

                UdpClient udpClient = new UdpClient();
                udpClient.Connect("127.0.0.1", 8080);

                try
                {
                    udpClient.Send(sendBytes, sendBytes.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            Byte[] sendBytes = Encoding.UTF8.GetBytes($"clear");

            UdpClient udpClient = new UdpClient();
            udpClient.Connect("127.0.0.1", 8080);

            try
            {
                udpClient.Send(sendBytes, sendBytes.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
