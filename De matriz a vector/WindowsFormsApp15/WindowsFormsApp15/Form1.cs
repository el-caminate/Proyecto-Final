using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Este programa esta bajo licencia MIT

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int A, B, C, D, E, F, G, H, I;

            if (textBox1.Text == ""|| textBox2.Text == "" ||
            textBox3.Text == "" || textBox4.Text == "" ||
            textBox5.Text == "" || textBox6.Text == "" ||
            textBox7.Text == "" || textBox8.Text == "" ||
            textBox9.Text == "")
                {

                MessageBox.Show("Por favor, no debe dejar casillas vacias en esta operación");
                return;
            }





            A = Convert.ToInt16(textBox1.Text); F = Convert.ToInt16(textBox6.Text);
            B = Convert.ToInt16(textBox2.Text); G = Convert.ToInt16(textBox7.Text);
            C = Convert.ToInt16(textBox3.Text); H = Convert.ToInt16(textBox8.Text);
            D = Convert.ToInt16(textBox4.Text); I = Convert.ToInt16(textBox9.Text);
            E = Convert.ToInt16(textBox5.Text);


            int[] V = { A, B, C, D, E, F, G, H, I };
            int[,] R = new int[3, 3]; //Este la matriz que recibirá los valores del vector.
            int W = -1;

            //De vector a matriz
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    W = W + 1;
                    R[fila, columna] = V[W];

                    textBox13.Text = Convert.ToString(R[0, 0]);
                    textBox14.Text = Convert.ToString(R[0, 1]);
                    textBox15.Text = Convert.ToString(R[0, 2]);

                    textBox17.Text = Convert.ToString(R[1, 0]);
                    textBox18.Text = Convert.ToString(R[1, 1]);
                    textBox19.Text = Convert.ToString(R[1, 2]);

                    textBox21.Text = Convert.ToString(R[2, 0]);
                    textBox22.Text = Convert.ToString(R[2, 1]);
                    textBox23.Text = Convert.ToString(R[2, 2]);

                    textBox1.Text = ""; textBox2.Text = "";
                    textBox3.Text = ""; textBox4.Text = "";
                    textBox5.Text = ""; textBox6.Text = "";
                    textBox7.Text = ""; textBox8.Text = "";
                    textBox9.Text = "";

                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int A, B, C, D, E, F, G, H, I;


            if (textBox13.Text == "" || textBox14.Text == "" ||
           textBox15.Text == "" || textBox21.Text == "" ||
           textBox17.Text == "" || textBox22.Text == "" ||
           textBox18.Text == "" || textBox23.Text == "" ||
           textBox19.Text == "")
            {

                MessageBox.Show("Por favor, no debe dejar casillas vacias en esta operación");
                return;
            }



            A = Convert.ToInt16(textBox13.Text); F = Convert.ToInt16(textBox19.Text);
            B = Convert.ToInt16(textBox14.Text); G = Convert.ToInt16(textBox21.Text);
            C = Convert.ToInt16(textBox15.Text); H = Convert.ToInt16(textBox22.Text);
            D = Convert.ToInt16(textBox17.Text); I = Convert.ToInt16(textBox23.Text);
            E = Convert.ToInt16(textBox18.Text);

            int[,] R = { { A, B, C }, { D, E, F }, { G, H, I } };
            int[] V = new int[9];
            int W = -1;

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    W = W + 1;
                     V[W] = R[fila, columna];

                    textBox1.Text = Convert.ToString(V[0]);
                    textBox2.Text = Convert.ToString(V[1]);
                    textBox3.Text = Convert.ToString(V[2]);

                    textBox4.Text = Convert.ToString(V[3]);
                    textBox5.Text = Convert.ToString(V[4]);
                    textBox6.Text = Convert.ToString(V[5]);

                    textBox7.Text = Convert.ToString(V[6]);
                    textBox8.Text = Convert.ToString(V[7]);
                    textBox9.Text = Convert.ToString(V[8]);

                    textBox13.Text = ""; textBox14.Text = "";
                    textBox15.Text = ""; textBox21.Text = "";
                    textBox17.Text = ""; textBox22.Text = "";
                    textBox18.Text = ""; textBox23.Text = "";
                    textBox19.Text = "";


                }

            }            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = "";
            textBox3.Text = ""; textBox4.Text = "";
            textBox5.Text = ""; textBox6.Text = "";
            textBox7.Text = ""; textBox8.Text = "";
            textBox9.Text = "";


            textBox13.Text = ""; textBox14.Text = "";
            textBox15.Text = ""; textBox17.Text = "";
            textBox18.Text = ""; textBox19.Text = "";
            textBox21.Text = ""; textBox22.Text = "";
            textBox23.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jose Luis Nuñez - Matricula: 00-MISN-1-198");
        }
        //Este programa esta bajo licencia MIT
    }
}
