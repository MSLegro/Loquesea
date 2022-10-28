using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        Stopwatch cro = new Stopwatch();
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
            Start();
            Ganar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "" & button2.Text == "")
            {
                button2.Text = button1.Text;
                button1.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button1.Text != "" & button5.Text == "")
                {
                    button5.Text = button1.Text;
                    button1.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "" & button1.Text == "")
            {
                button1.Text = button2.Text;
                button2.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button2.Text != "" & button3.Text == "")
                {
                    button3.Text = button2.Text;
                    button2.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button2.Text != "" & button6.Text == "")
                    {
                        button6.Text = button2.Text;
                        button2.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "" & button2.Text == "")
            {
                button2.Text = button3.Text;
                button3.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button3.Text != "" & button4.Text == "")
                {
                    button4.Text = button3.Text;
                    button3.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button3.Text != "" & button7.Text == "")
                    {
                        button7.Text = button3.Text;
                        button3.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "" & button3.Text == "")
            {
                button3.Text = button4.Text;
                button4.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button4.Text != "" & button8.Text == "")
                {
                    button8.Text = button4.Text;
                    button4.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "" & button1.Text == "")
            {
                button1.Text = button5.Text;
                button5.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button5.Text != "" & button9.Text == "")
                {
                    button9.Text = button5.Text;
                    button5.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button5.Text != "" & button6.Text == "")
                    {
                        button6.Text = button5.Text;
                        button5.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "" & button2.Text == "")
            {
                button2.Text = button6.Text;
                button6.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button6.Text != "" & button5.Text == "")
                {
                    button5.Text = button6.Text;
                    button6.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button6.Text != "" & button7.Text == "")
                    {
                        button7.Text = button6.Text;
                        button6.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                    else
                    {
                        if (button6.Text != "" & button10.Text == "")
                        {
                            button10.Text = button6.Text;
                            button6.Text = "";
                            txtcont.Text = (cont = cont + 1).ToString();
                            cro.Start();
                            timer1.Enabled = true;
                            Ganar();
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "" & button3.Text == "")
            {
                button3.Text = button7.Text;
                button7.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button7.Text != "" & button6.Text == "")
                {
                    button6.Text = button7.Text;
                    button7.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button7.Text != "" & button8.Text == "")
                    {
                        button8.Text = button7.Text;
                        button7.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                    else
                    {
                        if (button7.Text != "" & button11.Text == "")
                        {
                            button11.Text = button7.Text;
                            button7.Text = "";
                            txtcont.Text = (cont = cont + 1).ToString();
                            cro.Start();
                            timer1.Enabled = true;
                            Ganar();
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "" & button4.Text == "")
            {
                button4.Text = button8.Text;
                button8.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button8.Text != "" & button7.Text == "")
                {
                    button7.Text = button8.Text;
                    button8.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {

                    if (button8.Text != "" & button12.Text == "")
                    {
                        button12.Text = button8.Text;
                        button8.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "" & button5.Text == "")
            {
                button5.Text = button9.Text;
                button9.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button9.Text != "" & button10.Text == "")
                {
                    button10.Text = button9.Text;
                    button9.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true; Ganar();
                }
                else
                {
                    if (button9.Text != "" & button13.Text == "")
                    {
                        button13.Text = button9.Text;
                        button9.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true; Ganar();
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text != "" & button6.Text == "")
            {
                button6.Text = button10.Text;
                button10.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true; Ganar();
            }
            else
            {
                if (button10.Text != "" & button9.Text == "")
                {
                    button9.Text = button10.Text;
                    button10.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true; Ganar();
                }
                else
                {
                    if (button10.Text != "" & button11.Text == "")
                    {
                        button11.Text = button10.Text;
                        button10.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                    else
                    {
                        if (button10.Text != "" & button14.Text == "")
                        {
                            button14.Text = button10.Text;
                            button10.Text = "";
                            txtcont.Text = (cont = cont + 1).ToString();
                            cro.Start();
                            timer1.Enabled = true;
                            Ganar();
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text != "" & button7.Text == "")
            {
                button7.Text = button11.Text;
                button11.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button11.Text != "" & button10.Text == "")
                {
                    button10.Text = button11.Text;
                    button11.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button11.Text != "" & button12.Text == "")
                    {
                        button12.Text = button11.Text;
                        button11.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                    else
                    {
                        if (button11.Text != "" & button15.Text == "")
                        {
                            button15.Text = button11.Text;
                            button11.Text = "";
                            txtcont.Text = (cont = cont + 1).ToString();
                            cro.Start();
                            timer1.Enabled = true;
                            Ganar();
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text != "" & button8.Text == "")
            {
                button8.Text = button12.Text;
                button12.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button12.Text != "" & button11.Text == "")
                {
                    button11.Text = button12.Text;
                    button12.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button12.Text != "" & button16.Text == "")
                    {
                        button16.Text = button12.Text;
                        button12.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text != "" & button9.Text == "")
            {
                button9.Text = button13.Text;
                button13.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button13.Text != "" & button14.Text == "")
                {
                    button14.Text = button13.Text;
                    button13.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text != "" & button10.Text == "")
            {
                button10.Text = button14.Text;
                button14.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button14.Text != "" & button13.Text == "")
                {
                    button13.Text = button14.Text;
                    button14.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button14.Text != "" & button15.Text == "")
                    {
                        button15.Text = button14.Text;
                        button14.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text != "" & button11.Text == "")
            {
                button11.Text = button15.Text;
                button15.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();

            }
            else
            {
                if (button15.Text != "" & button14.Text == "")
                {
                    button14.Text = button15.Text;
                    button15.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
                else
                {
                    if (button15.Text != "" & button16.Text == "")
                    {
                        button16.Text = button15.Text;
                        button15.Text = "";
                        txtcont.Text = (cont = cont + 1).ToString();
                        cro.Start();
                        timer1.Enabled = true;
                        Ganar();
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text != "" & button12.Text == "")
            {
                button12.Text = button16.Text;
                button16.Text = "";
                txtcont.Text = (cont = cont + 1).ToString();
                cro.Start();
                timer1.Enabled = true;
                Ganar();
            }
            else
            {
                if (button16.Text != "" & button15.Text == "")
                {
                    button15.Text = button16.Text;
                    button16.Text = "";
                    txtcont.Text = (cont = cont + 1).ToString();
                    cro.Start();
                    timer1.Enabled = true;
                    Ganar();
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Juego en curso. \n ¿Desea empezar un nuevo juego?", "Nuevo juego", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                cro.Reset();
                txthora.Text = "00";
                txtmin.Text = "00";
                txtseg.Text = "00";
                cro.Start();
                txtcont.Text = (cont = cont - cont).ToString();

                int[] Lista = ListaRandom();

                button1.Text = Lista[0].ToString();
                button2.Text = Lista[1].ToString();
                button3.Text = Lista[2].ToString();
                button4.Text = Lista[3].ToString();
                button5.Text = Lista[4].ToString();
                button6.Text = Lista[5].ToString();
                button7.Text = Lista[6].ToString();
                button8.Text = Lista[7].ToString();
                button9.Text = Lista[8].ToString();
                button10.Text = Lista[9].ToString();
                button11.Text = Lista[10].ToString();
                button12.Text = Lista[11].ToString();
                button13.Text = Lista[12].ToString();
                button14.Text = Lista[13].ToString();
                button15.Text = Lista[14].ToString();
                button16.Text = Lista[15].ToString();

                if (Pause.Text == "Reanudar")
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    button12.Enabled = true;
                    button13.Enabled = true;
                    button14.Enabled = true;
                    button15.Enabled = true;
                    button16.Enabled = true;

                    cro.Start();
                }

                if (button1.Text == 0.ToString())
                {
                    button1.Text = "";
                }
                else
                {
                    if (button2.Text == 0.ToString())
                    {
                        button2.Text = "";
                    }
                    else
                    {
                        if (button3.Text == 0.ToString())
                        {
                            button3.Text = "";
                        }
                        else
                        {
                            if (button4.Text == 0.ToString())
                            {
                                button4.Text = "";
                            }
                            else
                            {
                                if (button5.Text == 0.ToString())
                                {
                                    button5.Text = "";
                                }
                                else
                                {
                                    if (button6.Text == 0.ToString())
                                    {
                                        button6.Text = "";
                                    }
                                    else
                                    {
                                        if (button7.Text == 0.ToString())
                                        {
                                            button7.Text = "";
                                        }
                                        else
                                        {
                                            if (button8.Text == 0.ToString())
                                            {
                                                button8.Text = "";
                                            }
                                            else
                                            {
                                                if (button9.Text == 0.ToString())
                                                {
                                                    button9.Text = "";
                                                }
                                                else
                                                {
                                                    if (button10.Text == 0.ToString())
                                                    {
                                                        button10.Text = "";
                                                    }
                                                    else
                                                    {
                                                        if (button11.Text == 0.ToString())
                                                        {
                                                            button11.Text = "";
                                                        }
                                                        else
                                                        {
                                                            if (button12.Text == 0.ToString())
                                                            {
                                                                button12.Text = "";
                                                            }
                                                            else
                                                            {
                                                                if (button13.Text == 0.ToString())
                                                                {
                                                                    button13.Text = "";
                                                                }
                                                                else
                                                                {
                                                                    if (button14.Text == 0.ToString())
                                                                    {
                                                                        button14.Text = "";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (button15.Text == 0.ToString())
                                                                        {
                                                                            button15.Text = "";
                                                                        }
                                                                        else
                                                                        {
                                                                            if (button16.Text == 0.ToString())
                                                                            {
                                                                                button16.Text = "";
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public int[] ListaRandom()
        {
            int[] lista = new int[16];
            Random r = new Random();
            int NumRandom;
            int i = 0;
            while (i < lista.Length)
            {
                Boolean resp = false;
                NumRandom = r.Next(0, 16);

                for (int j = 0; j < i; j++)
                {
                    if (NumRandom == lista[j])
                    {
                        resp = true;
                    }
                }
                if (resp != true)
                {
                    lista[i] = NumRandom;
                    i++;
                }
            }
            return lista;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)cro.ElapsedMilliseconds);

            txthora.Text = ts.Hours.ToString().Length < 2 ? "0" + ts.Hours.ToString() : ts.Hours.ToString();
            txtmin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtseg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void txtseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthora_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcont_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (Pause.Text == "Pausa")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;

                cro.Stop();

                Pause.Text = "Reanudar";
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;

                cro.Start();

                Pause.Text = "Pausa";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Start()
        {
            int[] Lista = ListaRandom();

            button1.Text = Lista[0].ToString();
            button2.Text = Lista[1].ToString();
            button3.Text = Lista[2].ToString();
            button4.Text = Lista[3].ToString();
            button5.Text = Lista[4].ToString();
            button6.Text = Lista[5].ToString();
            button7.Text = Lista[6].ToString();
            button8.Text = Lista[7].ToString();
            button9.Text = Lista[8].ToString();
            button10.Text = Lista[9].ToString();
            button11.Text = Lista[10].ToString();
            button12.Text = Lista[11].ToString();
            button13.Text = Lista[12].ToString();
            button14.Text = Lista[13].ToString();
            button15.Text = Lista[14].ToString();
            button16.Text = Lista[15].ToString();

            if (button1.Text == 0.ToString())
            {
                button1.Text = "";
            }
            else
            {
                if (button2.Text == 0.ToString())
                {
                    button2.Text = "";
                }
                else
                {
                    if (button3.Text == 0.ToString())
                    {
                        button3.Text = "";
                    }
                    else
                    {
                        if (button4.Text == 0.ToString())
                        {
                            button4.Text = "";
                        }
                        else
                        {
                            if (button5.Text == 0.ToString())
                            {
                                button5.Text = "";
                            }
                            else
                            {
                                if (button6.Text == 0.ToString())
                                {
                                    button6.Text = "";
                                }
                                else
                                {
                                    if (button7.Text == 0.ToString())
                                    {
                                        button7.Text = "";
                                    }
                                    else
                                    {
                                        if (button8.Text == 0.ToString())
                                        {
                                            button8.Text = "";
                                        }
                                        else
                                        {
                                            if (button9.Text == 0.ToString())
                                            {
                                                button9.Text = "";
                                            }
                                            else
                                            {
                                                if (button10.Text == 0.ToString())
                                                {
                                                    button10.Text = "";
                                                }
                                                else
                                                {
                                                    if (button11.Text == 0.ToString())
                                                    {
                                                        button11.Text = "";
                                                    }
                                                    else
                                                    {
                                                        if (button12.Text == 0.ToString())
                                                        {
                                                            button12.Text = "";
                                                        }
                                                        else
                                                        {
                                                            if (button13.Text == 0.ToString())
                                                            {
                                                                button13.Text = "";
                                                            }
                                                            else
                                                            {
                                                                if (button14.Text == 0.ToString())
                                                                {
                                                                    button14.Text = "";
                                                                }
                                                                else
                                                                {
                                                                    if (button15.Text == 0.ToString())
                                                                    {
                                                                        button15.Text = "";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (button16.Text == 0.ToString())
                                                                        {
                                                                            button16.Text = "";
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Ganar()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" &&
               button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
               button7.Text == "7" && button8.Text == "8" && button9.Text == "9" &&
               button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
               button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                cro.Stop();

                var op = MessageBox.Show("Su puntaje fue:\n" +
                    "Tiempo: " + "Horas: " + cro.Elapsed.Hours + " " + "Minutos: " + cro.Elapsed.Minutes + " " + "Segundos: " + cro.Elapsed.Seconds + "\n" +
                    "Movimientos:" + cont, "!HAZ GANADO¡", MessageBoxButtons.OK);

                if (op == DialogResult.OK)
                {
                    cro.Reset();
                    txthora.Text = "00";
                    txtmin.Text = "00";
                    txtseg.Text = "00";
                    txtcont.Text = (cont = cont - cont).ToString();
                    Start();

                }
            }
            if (button1.Text=="1")
            {
                button1.BackColor = Color.LightYellow;
            }
            else
            {
                button1.BackColor = SystemColors.ButtonHighlight;
            }

            if (button2.Text == "2")
            {
                button2.BackColor = Color.LightYellow;
            }
            else
            {
                button2.BackColor = SystemColors.ButtonHighlight;
            }

            if (button3.Text == "3")
            {
                button3.BackColor = Color.LightYellow;
            }
            else
            {
                button3.BackColor = SystemColors.ButtonHighlight;
            }

            if (button4.Text == "4")
            {
                button4.BackColor = Color.LightYellow;
            }
            else
            {
                button4.BackColor = SystemColors.ButtonHighlight;
            }

            if (button5.Text == "5")
            {
                button5.BackColor = Color.LightYellow;
            }
            else
            {
                button5.BackColor = SystemColors.ButtonHighlight;
            }

            if (button6.Text == "6")
            {
                button6.BackColor = Color.LightYellow;
            }
            else
            {
                button6.BackColor = SystemColors.ButtonHighlight;
            }

            if (button7.Text == "7")
            {
                button7.BackColor = Color.LightYellow;
            }
            else
            {
                button7.BackColor = SystemColors.ButtonHighlight;
            }

            if (button8.Text == "8")
            {
                button8.BackColor = Color.LightYellow;
            }
            else
            {
                button8.BackColor = SystemColors.ButtonHighlight;
            }

            if (button9.Text == "9")
            {
                button9.BackColor = Color.LightYellow;
            }
            else
            {
                button9.BackColor = SystemColors.ButtonHighlight;
            }

            if (button10.Text == "10")
            {
                button10.BackColor = Color.LightYellow;
            }
            else
            {
                button10.BackColor = SystemColors.ButtonHighlight;
            }

            if (button11.Text == "11")
            {
                button11.BackColor = Color.LightYellow;
            }
            else
            {
                button11.BackColor = SystemColors.ButtonHighlight;
            }

            if (button12.Text == "12")
            {
                button12.BackColor = Color.LightYellow;
            }
            else
            {
                button12.BackColor = SystemColors.ButtonHighlight;
            }

            if (button13.Text == "13")
            {
                button13.BackColor = Color.LightYellow;
            }
            else
            {
                button13.BackColor = SystemColors.ButtonHighlight;
            }

            if (button14.Text == "14")
            {
                button14.BackColor = Color.LightYellow;
            }
            else
            {
                button14.BackColor = SystemColors.ButtonHighlight;
            }

            if (button15.Text == "15")
            {
                button15.BackColor = Color.LightYellow;
            }
            else
            {
                button15.BackColor = SystemColors.ButtonHighlight;
            }

            //if (button16.Text == "16")
            //{
            //    button16.BackColor = Color.LightYellow;
            //}
            //else
            //{
            //    button16.BackColor = SystemColors.ButtonHighlight;
            //}

           

        }

        //private void button17_Click(object sender, EventArgs e)
        //{
        //    button1.Text = "1";
        //    button2.Text = "2";
        //    button3.Text = "3";
        //    button4.Text = "4";
        //    button5.Text = "5";
        //    button6.Text = "6";
        //    button7.Text = "7";
        //    button8.Text = "8";
        //    button9.Text = "9";
        //    button10.Text = "10";
        //    button11.Text = "11";
        //    button12.Text = "12";
        //    button13.Text = "13";
        //    button14.Text = "14";
        //    button15.Text = "15";
        //    button16.Text = "";

        //}
    }
}