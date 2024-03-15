using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 你画我猜.Guesser
{
    public partial class GuesserForm : Form
    {
        Graphics graphics;

        UdpClient listener;
        IPEndPoint groupEP;
        bool isPenMode;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;

        string answer;

        public GuesserForm()
        {
            InitializeComponent();

            listener = new UdpClient(8080);

            graphics = Canvas.CreateGraphics();
        }

        private async void GuesserForm_LoadAsync(object sender, EventArgs e)
        {
            await StartListener();
        }

        private async Task StartListener()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for broadcast");
                    UdpReceiveResult result = await listener.ReceiveAsync();

                    byte[] bytes = result.Buffer;
                    string receivedData = Encoding.UTF8.GetString(bytes, 0, bytes.Length);
                    Console.WriteLine($"Received broadcast from {result.RemoteEndPoint} : {receivedData}");

                    string[] data = receivedData.Split(',');

                    if (data[0] == "clear")
                    {
                        clear();
                    }
                    else
                    {
                        answer = data[0];
                        isPenMode = data[1] == "Pen";
                        num1 = int.Parse(data[2]);
                        num2 = int.Parse(data[3]);
                        num3 = int.Parse(data[4]);
                        num4 = int.Parse(data[5]);

                        if (isPenMode)
                        {
                            draw();
                        }
                        else
                        {
                            erase();
                        }

                    }
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                listener.Close();
            }
        }

        void draw()
        {
            graphics.DrawLine(new Pen(Color.Black, 7), new Point(num1, num2), new Point(num3, num4));
        }

        void erase()
        {
            graphics.DrawLine(new Pen(Color.White, 30), new Point(num1, num2), new Point(num3, num4));
        }

        void clear()
        {
            graphics.Clear(Color.White);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (guessTextBox.Text == answer)
            {
                MessageBox.Show("回答正确！！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("回答错误！！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            guessTextBox.Text = string.Empty;
        }
    }
}
