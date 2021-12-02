using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4_2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
           
        }



        private void tbA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Int32.Parse(tbA.Text));
            }
        }
        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.setValueA(trackBarA.Value);
        }


        private void tbB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Int32.Parse(tbB.Text));
            }
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setValueB(trackBarB.Value);
        }



        private void tbC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(Int32.Parse(tbC.Text));
            }
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setValueC(trackBarC.Value);
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            tbA.Text = model.getValueA().ToString();
            numericUpDownA.Value = model.getValueA();
            trackBarA.Value = model.getValueA();

            tbB.Text = model.getValueB().ToString();
            numericUpDownB.Value = model.getValueB();
            trackBarB.Value = model.getValueB();

            tbC.Text = model.getValueC().ToString();
            numericUpDownC.Value = model.getValueC();
            trackBarC.Value = model.getValueC();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//сохранение значений
        {
            Properties.Settings.Default.A = model.getValueA();
            Properties.Settings.Default.B = model.getValueB();
            Properties.Settings.Default.C = model.getValueC();
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbA.Text = Properties.Settings.Default.A.ToString();
            numericUpDownA.Value = Properties.Settings.Default.A;
            trackBarA.Value = Properties.Settings.Default.A;

            tbB.Text = Properties.Settings.Default.B.ToString();
            numericUpDownA.Value = Properties.Settings.Default.B;
            trackBarB.Value = Properties.Settings.Default.B;

            tbC.Text = Properties.Settings.Default.C.ToString();
            numericUpDownC.Value = Properties.Settings.Default.C;
            trackBarC.Value = Properties.Settings.Default.C;
        }
    }


    public class Model
    {
        private int A, B, C;
        public System.EventHandler observers;

        public void setValueA(int _A)
        {
            if(_A<0)
            {
                A = 0;
            }
            else if(_A>100)
            {
                A = 100;
                B = 100;
                C = 100;
            }
            else if (_A<=C)
            {
                A = _A;
                if (_A > B)
                {
                    B = _A;
                }
            }
            else if (_A == C)
            {
                A = _A;
                B = _A;
            }
            else if (_A >= C)
            {
                A=_A;
                C = _A;
                B = _A;
            }

            observers.Invoke(this, null);
        }

        public void setValueB(int _B)
        {
            if (_B <= C)
            {
                if (_B >= A)
                {
                    B = _B;
                }
            }
            else if (_B > A)
            {

            }

            observers.Invoke(this, null);
        }

        public void setValueC(int _C)
        {
            if (_C < 0)
            {
                A = 0;
                B = 0;
                C = 0;
            }
            else if (_C > 100)
            {
                C = 100;
            }
            else if (_C<=A)
            {
                A = _C;
                B = _C;
                C = _C;
            }
            else if(_C>=A)
            {
                C = _C;
                if (_C<=B)
                {
                    B = _C;
                }
            }

            observers.Invoke(this, null);
        }
        public int getValueA()
        {
            return A;
        }
        public int getValueB()
        {
            return B;
        }
        public int getValueC()
        {
            return C;
        }
    }
}
