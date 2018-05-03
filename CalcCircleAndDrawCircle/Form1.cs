using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCircleAndDrawCircle
{
    public partial class Form1 : Form
    {
        Circle circle1;
        Graphics myGraphics;

        public Form1()
        {
            InitializeComponent();
            circle1 = new Circle();

            

            radiusTextBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            diameterTextBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            circumferenceTextBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            areaTextBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            radiusTextBox.KeyUp += new KeyEventHandler(textBox_KeyUp);
            diameterTextBox.KeyUp += new KeyEventHandler(textBox_KeyUp);
            circumferenceTextBox.KeyUp += new KeyEventHandler(textBox_KeyUp);
            areaTextBox.KeyUp += new KeyEventHandler(textBox_KeyUp);

            //初始化
            radiusTextBox.Text = "200";
            circle1.setRadius(Convert.ToDecimal(radiusTextBox.Text));
            updateTextBox(radiusTextBox);
            //文字游標移到最後面
            radiusTextBox.Select(radiusTextBox.Text.Length, 0);

            //  drawCircle();
        }

        /* 點擊 drawCirleButton 時，畫圓 */
        private void clearCircleButton_Click(object sender, EventArgs e)
        {
            clearCircle();
        }

        /*鍵盤按下時，輸入數字到 textBox*/
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 13 確認鍵 Enter , 8 退格鍵 Backspace , 46 小數點 .
            if (e.KeyChar != 13 && e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            //只能輸入一個小數點
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        /*鍵盤放開時，更新 textBox*/
        private void textBox_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            /*檢查是否最後面為小數點*/
            TextBox textBox = sender as TextBox;
            //MessageBox.Show("textBox.Name : " + textBox.Name + "\n" +"textBox.text : " + textBox.Text);
            //MessageBox.Show("textBox.Text : " + textBox.Text);
            int dotPosition = textBox.Text.IndexOf('.');
            int textBoxTextLength = textBox.TextLength;
            bool textBoxLastIsDot = (dotPosition == textBoxTextLength - 1);

            //textBox 裡面有小數點且在最後面
            if (dotPosition > -1 && textBoxLastIsDot)
            {
                return;
            }

            /*設定圓的參數，更新 textBox*/
            if (textBox.Text != "")
            {

                switch (textBox.Name)
                {
                    case "radiusTextBox":
                        circle1.setRadius(Convert.ToDecimal(textBox.Text));
                        break;
                    case "diameterTextBox":
                        circle1.setDiameter(Convert.ToDecimal(textBox.Text));
                        break;
                    case "circumferenceTextBox":
                        circle1.setCircumference(Convert.ToDecimal(textBox.Text));
                        break;
                    case "areaTextBox":
                        circle1.setArea(Convert.ToDecimal(textBox.Text));
                        break;
                }
                
                updateTextBox(textBox);
                drawCircle();
            }
            else
            {
                clearTextBox();
            }
        }

        private void drawCircle()
        {
            //MessageBox.Show("畫圓");
            //myGraphics = base.CreateGraphics();
            myGraphics = panel1.CreateGraphics();
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            Pen myPen = new Pen(randomColor);
            SolidBrush mySolidBrush = new SolidBrush(Color.Red);
            Int32 diameter = Convert.ToInt32(circle1.Diameter);
            Point middlePoint = new Point((panel1.Width - diameter) / 2, (panel1.Height - diameter) / 2);
            myGraphics.DrawEllipse(myPen, middlePoint.X, middlePoint.Y, diameter, diameter);
        }

        private void clearCircle()
        {
            
            
            if (myGraphics != null)
            {
                radiusTextBox.Text = "0";
                circle1.setRadius(Convert.ToDecimal(radiusTextBox.Text));
                updateTextBox(radiusTextBox);

                myGraphics.Clear(Color.Transparent);
                panel1.Invalidate();

                radiusTextBox.Focus();
            }
        }

        /*更新 textBox 裡面的文字*/
        private void updateTextBox(TextBox textBox)
        {
            //顯示圓的半徑,直徑,圓周長,面積
            radiusTextBox.Text = Convert.ToString(circle1.Radius);
            //MessageBox.Show("updateTextBox diameter:" + Convert.ToString(circle1.Diameter));
            diameterTextBox.Text = Convert.ToString(circle1.Diameter);
            circumferenceTextBox.Text = Convert.ToString(circle1.Circumference);
            areaTextBox.Text = Convert.ToString(circle1.Area);
            //文字游標移到最後面
            // textBox.Select(textBox.Text.Length, 0);
        }

        /*清空 textBox 裡面的文字*/
        private void clearTextBox()
        {
            radiusTextBox.Text = "";
            diameterTextBox.Text = "";
            circumferenceTextBox.Text = "";
            areaTextBox.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawCircle();
        }
    }
}
