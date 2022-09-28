using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalDesign
{
    public partial class Form1 : Form
    {
        private int _numberOfLine;
        private bool _isCreate;
        public Form1()
        {
            Awake();
        }
        private void Awake()
        {
            try
            {
                InitializeComponent();
                InitializeTextLabels();
                InitializeStartButton();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void InitializeTextLabels()
        {
            HelpMessage.ReadOnly = true;
        }
        private void InitializeStartButton()
        {
            CreateButton.Click += ClickButton;
        }
        private void ClickButton(object sender, EventArgs e)
        {
            _numberOfLine = Convert.ToInt32(InputN.Text);

            if (_numberOfLine >= 10)
            {
                _numberOfLine = 9;
            }
            
            InputN.Enabled = InputN.Visible = false;
            HelpMessage.Enabled = HelpMessage.Visible = false;
            CreateButton.Enabled = CreateButton.Visible = false;
            
            CreateLines();
        }
        private void InputN_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void CreateLines()
        {
            if (_isCreate)
            {
                throw new Exception("Warning! You have already created the lines!");
            }

            _isCreate = true;


            for (int i = 0; i < _numberOfLine; ++i)
            {
                ushort numbersEven = 0, numbersOdd = 0;

                for (int j = 0; j < _numberOfLine; ++j)
                {
                    Button btn = new Button();
                    btn.Name = i + j.ToString();
                    btn.Location = new Point(Width / 4 + 40 * i, Height / 10 + j * 30);

                    if (PlaceRandomly() % 2 == 0)
                    {
                        btn.Size = new Size(10, 25);
                        numbersEven++;
                    }

                    else
                    {
                        numbersOdd++;
                        btn.Size = new Size(25, 10);
                    }

                    if (numbersEven * 2 >= _numberOfLine || numbersOdd * 2 >= _numberOfLine)
                        btn.Size = new Size(btn.Height, btn.Width);

                    panel1.Controls.Add(btn);
                    btn.Click += RotateLines;
                }
            }
        }
        private ushort PlaceRandomly()
        {
            var random = new Random();
            return (ushort)random.Next(999);
        }
        private void RotateLines(object sender, EventArgs e)
        {
            var button = (Button)sender;
            int i = int.Parse(button.Name[0].ToString());
            int j = int.Parse(button.Name[1].ToString());

            button.Size = new Size(button.Height, button.Width);
            for (int index = 0; index < _numberOfLine; ++index)
            {
                button = panel1.Controls[i.ToString() + index] as Button;
                if (button != null) button.Size = new Size(button.Height, button.Width);
                button = panel1.Controls[index.ToString() + j] as Button;
                if (button != null) button.Size = new Size(button.Height, button.Width);
            }

            ProcessRotation();
        }
        private void ProcessRotation()
        {
            for (int i = 0; i < _numberOfLine; ++i)
            {
                for (int j = 0; j < _numberOfLine-1; ++j)
                {
                    Button firstButton = panel1.Controls[i.ToString() + j] as Button;
                    Button secondButton = panel1.Controls[i.ToString() + (j+1)] as Button;
                    if (firstButton != null && secondButton != null && firstButton.Height != secondButton.Height)
                    {
                        return;
                    }
                }
            }

            MessageBox.Show("You win!!!");
            Application.Restart();
        }
    }
}