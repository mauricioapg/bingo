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
using System.Windows.Forms.Design;

namespace Bingo
{
    public partial class Form1 : Form
    {
        string atual = "";
        int numero;

        public Form1()
        {
            InitializeComponent();
        }

        private int retornaNumero(int numeroparametro)
        {
            int aux = Convert.ToInt32(txtNumero.Text);
            return aux;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    numero = Convert.ToInt32(txtNumero.Text);



                    if (numero >= 1 && numero <= 15)
                    {
                        //letrab.ForeColor = Color.Red;
                        //letraI.ForeColor = Color.Blue;
                        //letraN.ForeColor = Color.Blue;
                        //letraG.ForeColor = Color.Blue;
                        //letraO.ForeColor = Color.Blue;


                        if (txtNumero.Text == "1")
                        {
                            b1.ForeColor = Color.Black;
                            b1.Text = numero.ToString();
                            atual = "b1";
                        }
                        else if (txtNumero.Text == "2")
                        {
                            b2.ForeColor = Color.Black;
                            b2.Text = numero.ToString();
                            atual = "b2";
                        }
                        else if (txtNumero.Text == "3")
                        {
                            b3.ForeColor = Color.Black;
                            b3.Text = numero.ToString();
                            atual = "b3";
                        }
                        else if (txtNumero.Text == "4")
                        {
                            b4.ForeColor = Color.Black;
                            b4.Text = numero.ToString();
                            atual = "b4";
                        }
                        else if (txtNumero.Text == "5")
                        {
                            b5.ForeColor = Color.Black;
                            b5.Text = numero.ToString();
                            atual = "b5";
                        }
                        else if (txtNumero.Text == "6")
                        {
                            b6.ForeColor = Color.Black;
                            b6.Text = numero.ToString();
                            atual = "b6";
                        }
                        else if (txtNumero.Text == "7")
                        {
                            b7.ForeColor = Color.Black;
                            b7.Text = numero.ToString();
                            atual = "b7";
                        }
                        else if (txtNumero.Text == "8")
                        {
                            b8.ForeColor = Color.Black;
                            b8.Text = numero.ToString();
                            atual = "b8";
                        }
                        else if (txtNumero.Text == "9")
                        {
                            b9.ForeColor = Color.Black;
                            b9.Text = numero.ToString();
                            atual = "b9";
                        }
                        else if (txtNumero.Text == "10")
                        {
                            b10.ForeColor = Color.Black;
                            b10.Text = numero.ToString();
                            atual = "b10";
                        }
                        else if (txtNumero.Text == "11")
                        {
                            b11.ForeColor = Color.Black;
                            b11.Text = numero.ToString();
                            atual = "b11";
                        }
                        else if (txtNumero.Text == "12")
                        {
                            b12.ForeColor = Color.Black;
                            b12.Text = numero.ToString();
                            atual = "b12";
                        }
                        else if (txtNumero.Text == "13")
                        {
                            b13.ForeColor = Color.Black;
                            b13.Text = numero.ToString();
                            atual = "b13";
                        }
                        else if (txtNumero.Text == "14")
                        {
                            b14.ForeColor = Color.Black;
                            b14.Text = numero.ToString();
                            atual = "b14";
                        }
                        else if (txtNumero.Text == "15")
                        {
                            b15.ForeColor = Color.Black;
                            b15.Text = numero.ToString();
                            atual = "b15";
                        }
                    }
                    else if (numero >= 16 && numero <= 30)
                    {
                        //letrab.ForeColor = Color.Blue;
                        //letraI.ForeColor = Color.Red;
                        //letraN.ForeColor = Color.Blue;
                        //letraG.ForeColor = Color.Blue;
                        //letraO.ForeColor = Color.Blue;

                        if (txtNumero.Text == "16")
                        {
                            i1.ForeColor = Color.Black;
                            i1.Text = numero.ToString();
                            atual = "i1";
                        }
                        else if (txtNumero.Text == "17")
                        {
                            i2.ForeColor = Color.Black;
                            i2.Text = numero.ToString();
                            atual = "i2";
                        }
                        else if (txtNumero.Text == "18")
                        {
                            i3.ForeColor = Color.Black;
                            i3.Text = numero.ToString();
                            atual = "i3";
                        }
                        else if (txtNumero.Text == "19")
                        {
                            i4.ForeColor = Color.Black;
                            i4.Text = numero.ToString();
                            atual = "i4";
                        }
                        else if (txtNumero.Text == "20")
                        {
                            i5.ForeColor = Color.Black;
                            i5.Text = numero.ToString();
                            atual = "i5";
                        }
                        else if (txtNumero.Text == "21")
                        {
                            i6.ForeColor = Color.Black;
                            i6.Text = numero.ToString();
                            atual = "i6";
                        }
                        else if (txtNumero.Text == "22")
                        {
                            i7.ForeColor = Color.Black;
                            i7.Text = numero.ToString();
                            atual = "i7";
                        }
                        else if (txtNumero.Text == "23")
                        {
                            i8.ForeColor = Color.Black;
                            i8.Text = numero.ToString();
                            atual = "i8";
                        }
                        else if (txtNumero.Text == "24")
                        {
                            i9.ForeColor = Color.Black;
                            i9.Text = numero.ToString();
                            atual = "i9";
                        }
                        else if (txtNumero.Text == "25")
                        {
                            i10.ForeColor = Color.Black;
                            i10.Text = numero.ToString();
                            atual = "i10";
                        }
                        else if (txtNumero.Text == "26")
                        {
                            i11.ForeColor = Color.Black;
                            i11.Text = numero.ToString();
                            atual = "i11";
                        }
                        else if (txtNumero.Text == "27")
                        {
                            i12.ForeColor = Color.Black;
                            i12.Text = numero.ToString();
                            atual = "i12";
                        }
                        else if (txtNumero.Text == "28")
                        {
                            i13.ForeColor = Color.Black;
                            i13.Text = numero.ToString();
                            atual = "i13";
                        }
                        else if (txtNumero.Text == "29")
                        {
                            i14.ForeColor = Color.Black;
                            i14.Text = numero.ToString();
                            atual = "i14";
                        }
                        else if (txtNumero.Text == "30")
                        {
                            i15.ForeColor = Color.Black;
                            i15.Text = numero.ToString();
                            atual = "i15";
                        }
                    }
                    else if (numero >= 31 && numero <= 45)
                    {
                        //letrab.ForeColor = Color.Blue;
                        //letraI.ForeColor = Color.Blue;
                        //letraN.ForeColor = Color.Red;
                        //letraG.ForeColor = Color.Blue;
                        //letraO.ForeColor = Color.Blue;

                        if (txtNumero.Text == "31")
                        {
                            n1.ForeColor = Color.Black;
                            n1.Text = numero.ToString();
                            atual = "n1";
                        }
                        else if (txtNumero.Text == "32")
                        {
                            n2.ForeColor = Color.Black;
                            n2.Text = numero.ToString();
                            atual = "n2";
                        }
                        else if (txtNumero.Text == "33")
                        {
                            n3.ForeColor = Color.Black;
                            n3.Text = numero.ToString();
                            atual = "n3";
                        }
                        else if (txtNumero.Text == "34")
                        {
                            n4.ForeColor = Color.Black;
                            n4.Text = numero.ToString();
                            atual = "n4";
                        }
                        else if (txtNumero.Text == "35")
                        {
                            n5.ForeColor = Color.Black;
                            n5.Text = numero.ToString();
                            atual = "n5";
                        }
                        else if (txtNumero.Text == "36")
                        {
                            n6.ForeColor = Color.Black;
                            n6.Text = numero.ToString();
                            atual = "n6";
                        }
                        else if (txtNumero.Text == "37")
                        {
                            n7.ForeColor = Color.Black;
                            n7.Text = numero.ToString();
                            atual = "n7";
                        }
                        else if (txtNumero.Text == "38")
                        {
                            n8.ForeColor = Color.Black;
                            n8.Text = numero.ToString();
                            atual = "n8";
                        }
                        else if (txtNumero.Text == "39")
                        {
                            n9.ForeColor = Color.Black;
                            n9.Text = numero.ToString();
                            atual = "n9";
                        }
                        else if (txtNumero.Text == "40")
                        {
                            n10.ForeColor = Color.Black;
                            n10.Text = numero.ToString();
                            atual = "n10";
                        }
                        else if (txtNumero.Text == "41")
                        {
                            n11.ForeColor = Color.Black;
                            n11.Text = numero.ToString();
                            atual = "n11";
                        }
                        else if (txtNumero.Text == "42")
                        {
                            n12.ForeColor = Color.Black;
                            n12.Text = numero.ToString();
                            atual = "n12";
                        }
                        else if (txtNumero.Text == "43")
                        {
                            n13.ForeColor = Color.Black;
                            n13.Text = numero.ToString();
                            atual = "n13";
                        }
                        else if (txtNumero.Text == "44")
                        {
                            n14.ForeColor = Color.Black;
                            n14.Text = numero.ToString();
                            atual = "n14";
                        }
                        else if (txtNumero.Text == "45")
                        {
                            n15.ForeColor = Color.Black;
                            n15.Text = numero.ToString();
                            atual = "n15";
                        }
                    }
                    else if (numero >= 46 && numero <= 60)
                    {
                        //letrab.ForeColor = Color.Blue;
                        //letraI.ForeColor = Color.Blue;
                        //letraN.ForeColor = Color.Blue;
                        //letraG.ForeColor = Color.Red;
                        //letraO.ForeColor = Color.Blue;

                        if (txtNumero.Text == "46")
                        {
                            g1.ForeColor = Color.Black;
                            g1.Text = numero.ToString();
                            atual = "g1";
                        }
                        else if (txtNumero.Text == "47")
                        {
                            g2.ForeColor = Color.Black;
                            g2.Text = numero.ToString();
                            atual = "g2";
                        }
                        else if (txtNumero.Text == "48")
                        {
                            g3.ForeColor = Color.Black;
                            g3.Text = numero.ToString();
                            atual = "g3";
                        }
                        else if (txtNumero.Text == "49")
                        {
                            g4.ForeColor = Color.Black;
                            g4.Text = numero.ToString();
                            atual = "g4";
                        }
                        else if (txtNumero.Text == "50")
                        {
                            g5.ForeColor = Color.Black;
                            g5.Text = numero.ToString();
                            atual = "g5";
                        }
                        else if (txtNumero.Text == "51")
                        {
                            g6.ForeColor = Color.Black;
                            g6.Text = numero.ToString();
                            atual = "g6";
                        }
                        else if (txtNumero.Text == "52")
                        {
                            g7.ForeColor = Color.Black;
                            g7.Text = numero.ToString();
                            atual = "g7";
                        }
                        else if (txtNumero.Text == "53")
                        {
                            g8.ForeColor = Color.Black;
                            g8.Text = numero.ToString();
                            atual = "g8";
                        }
                        else if (txtNumero.Text == "54")
                        {
                            g9.ForeColor = Color.Black;
                            g9.Text = numero.ToString();
                            atual = "g9";
                        }
                        else if (txtNumero.Text == "55")
                        {
                            g10.ForeColor = Color.Black;
                            g10.Text = numero.ToString();
                            atual = "g10";
                        }
                        else if (txtNumero.Text == "56")
                        {
                            g11.ForeColor = Color.Black;
                            g11.Text = numero.ToString();
                            atual = "g11";
                        }
                        else if (txtNumero.Text == "57")
                        {
                            g12.ForeColor = Color.Black;
                            g12.Text = numero.ToString();
                            atual = "g12";
                        }
                        else if (txtNumero.Text == "58")
                        {
                            g13.ForeColor = Color.Black;
                            g13.Text = numero.ToString();
                            atual = "g13";
                        }
                        else if (txtNumero.Text == "59")
                        {
                            g14.ForeColor = Color.Black;
                            g14.Text = numero.ToString();
                            atual = "g14";
                        }
                        else if (txtNumero.Text == "60")
                        {
                            g15.ForeColor = Color.Black;
                            g15.Text = numero.ToString();
                            atual = "g15";
                        }

                    }
                    else if (numero >= 61 && numero <= 75)
                    {
                        //letrab.ForeColor = Color.Blue;
                        //letraI.ForeColor = Color.Blue;
                        //letraN.ForeColor = Color.Blue;
                        //letraG.ForeColor = Color.Blue;
                        //letraO.ForeColor = Color.Red;

                        if (txtNumero.Text == "61")
                        {
                            o1.ForeColor = Color.Black;
                            o1.Text = numero.ToString();
                            atual = "o1";
                        }
                        else if (txtNumero.Text == "62")
                        {
                            o2.ForeColor = Color.Black;
                            o2.Text = numero.ToString();
                            atual = "o2";
                        }
                        else if (txtNumero.Text == "63")
                        {
                            o3.ForeColor = Color.Black;
                            o3.Text = numero.ToString();
                            atual = "o3";
                        }
                        else if (txtNumero.Text == "64")
                        {
                            o4.ForeColor = Color.Black;
                            o4.Text = numero.ToString();
                            atual = "o4";
                        }
                        else if (txtNumero.Text == "65")
                        {
                            o5.ForeColor = Color.Black;
                            o5.Text = numero.ToString();
                            atual = "o5";
                        }
                        else if (txtNumero.Text == "66")
                        {
                            o6.ForeColor = Color.Black;
                            o6.Text = numero.ToString();
                            atual = "o6";
                        }
                        else if (txtNumero.Text == "67")
                        {
                            o7.ForeColor = Color.Black;
                            o7.Text = numero.ToString();
                            atual = "o7";
                        }
                        else if (txtNumero.Text == "68")
                        {
                            o8.ForeColor = Color.Black;
                            o8.Text = numero.ToString();
                            atual = "o8";
                        }
                        else if (txtNumero.Text == "69")
                        {
                            o9.ForeColor = Color.Black;
                            o9.Text = numero.ToString();
                            atual = "o9";
                        }
                        else if (txtNumero.Text == "70")
                        {
                            o10.ForeColor = Color.Black;
                            o10.Text = numero.ToString();
                            atual = "o10";
                        }
                        else if (txtNumero.Text == "71")
                        {
                            o11.ForeColor = Color.Black;
                            o11.Text = numero.ToString();
                            atual = "o11";
                        }
                        else if (txtNumero.Text == "72")
                        {
                            o12.ForeColor = Color.Black;
                            o12.Text = numero.ToString();
                            atual = "o12";
                        }
                        else if (txtNumero.Text == "73")
                        {
                            o13.ForeColor = Color.Black;
                            o13.Text = numero.ToString();
                            atual = "o13";
                        }
                        else if (txtNumero.Text == "74")
                        {
                            o14.ForeColor = Color.Black;
                            o14.Text = numero.ToString();
                            atual = "o14";
                        }
                        else if (txtNumero.Text == "75")
                        {
                            o15.ForeColor = Color.Black;
                            o15.Text = numero.ToString();
                            atual = "o15";
                        }

                    }
                }

                catch
                {
                    MessageBox.Show("Digite um número válido");
                }


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ApagarUltimo();
        }

        private void ApagarUltimo()
        {
            txtNumero.ResetText();
            if (atual == "b1")
            {
                b1.ResetText();
            }
            else if (atual == "b2")
            {
                b2.ResetText();
            }
            else if (atual == "b3")
            {
                b3.ResetText();
            }
            else if (atual == "b4")
            {
                b4.ResetText();
            }
            else if (atual == "b5")
            {
                b5.ResetText();
            }
            else if (atual == "b6")
            {
                b1.ResetText();
            }
            else if (atual == "b7")
            {
                b7.ResetText();
            }
            else if (atual == "b8")
            {
                b8.ResetText();
            }
            else if (atual == "b9")
            {
                b9.ResetText();
            }
            else if (atual == "b10")
            {
                b10.ResetText();
            }
            else if (atual == "b11")
            {
                b11.ResetText();
            }
            else if (atual == "b12")
            {
                b12.ResetText();
            }
            else if (atual == "b13")
            {
                b13.ResetText();
            }
            else if (atual == "b14")
            {
                b14.ResetText();
            }
            else if (atual == "b15")
            {
                b15.ResetText();
            }
            else if (atual == "i1")
            {
                i1.ResetText();
            }
            else if (atual == "i2")
            {
                i2.ResetText();
            }
            else if (atual == "i3")
            {
                i3.ResetText();
            }
            else if (atual == "i4")
            {
                i4.ResetText();
            }
            else if (atual == "i5")
            {
                i5.ResetText();
            }
            else if (atual == "i6")
            {
                i6.ResetText();
            }
            else if (atual == "i7")
            {
                i7.ResetText();
            }
            else if (atual == "i8")
            {
                i8.ResetText();
            }
            else if (atual == "i9")
            {
                i9.ResetText();
            }
            else if (atual == "i10")
            {
                i10.ResetText();
            }
            else if (atual == "i11")
            {
                i11.ResetText();
            }
            else if (atual == "i12")
            {
                i2.ResetText();
            }
            else if (atual == "i13")
            {
                i3.ResetText();
            }
            else if (atual == "i14")
            {
                i4.ResetText();
            }
            else if (atual == "i15")
            {
                i5.ResetText();
            }
            else if (atual == "n1")
            {
                n1.ResetText();
            }
            else if (atual == "n2")
            {
                n2.ResetText();
            }
            else if (atual == "n3")
            {
                n3.ResetText();
            }
            else if (atual == "n4")
            {
                n4.ResetText();
            }
            else if (atual == "n5")
            {
                n5.ResetText();
            }
            else if (atual == "n6")
            {
                n1.ResetText();
            }
            else if (atual == "n7")
            {
                n7.ResetText();
            }
            else if (atual == "n8")
            {
                n8.ResetText();
            }
            else if (atual == "n9")
            {
                n9.ResetText();
            }
            else if (atual == "n10")
            {
                n10.ResetText();
            }
            else if (atual == "n11")
            {
                n11.ResetText();
            }
            else if (atual == "n12")
            {
                n12.ResetText();
            }
            else if (atual == "n13")
            {
                n13.ResetText();
            }
            else if (atual == "n14")
            {
                n14.ResetText();
            }
            else if (atual == "n15")
            {
                n15.ResetText();
            }
            else if (atual == "g1")
            {
                g1.ResetText();
            }
            else if (atual == "g2")
            {
                g2.ResetText();
            }
            else if (atual == "g3")
            {
                g3.ResetText();
            }
            else if (atual == "g4")
            {
                g4.ResetText();
            }
            else if (atual == "g5")
            {
                g5.ResetText();
            }
            else if (atual == "g6")
            {
                g1.ResetText();
            }
            else if (atual == "g7")
            {
                g7.ResetText();
            }
            else if (atual == "g8")
            {
                g8.ResetText();
            }
            else if (atual == "g9")
            {
                g9.ResetText();
            }
            else if (atual == "g10")
            {
                g10.ResetText();
            }
            else if (atual == "g11")
            {
                g11.ResetText();
            }
            else if (atual == "g12")
            {
                g12.ResetText();
            }
            else if (atual == "g13")
            {
                g13.ResetText();
            }
            else if (atual == "g14")
            {
                g14.ResetText();
            }
            else if (atual == "g15")
            {
                g15.ResetText();
            }
            else if (atual == "o1")
            {
                o1.ResetText();
            }
            else if (atual == "o2")
            {
                o2.ResetText();
            }
            else if (atual == "o3")
            {
                o3.ResetText();
            }
            else if (atual == "o4")
            {
                o4.ResetText();
            }
            else if (atual == "o5")
            {
                o5.ResetText();
            }
            else if (atual == "o6")
            {
                o1.ResetText();
            }
            else if (atual == "o7")
            {
                o7.ResetText();
            }
            else if (atual == "o8")
            {
                o8.ResetText();
            }
            else if (atual == "o9")
            {
                o9.ResetText();
            }
            else if (atual == "o10")
            {
                o10.ResetText();
            }
            else if (atual == "o11")
            {
                o11.ResetText();
            }
            else if (atual == "o12")
            {
                o12.ResetText();
            }
            else if (atual == "o13")
            {
                o13.ResetText();
            }
            else if (atual == "o14")
            {
                o14.ResetText();
            }
            else if (atual == "o15")
            {
                o15.ResetText();
            }
        }

        private void LimparTudo()
        {
            //letrab.ForeColor = Color.Blue;
            //letraI.ForeColor = Color.Blue;
            //letraN.ForeColor = Color.Blue;
            //letraG.ForeColor = Color.Blue;
            //letraO.ForeColor = Color.Blue;
            txtNumero.ResetText();
            b1.ResetText();
            b2.ResetText();
            b3.ResetText();
            b4.ResetText();
            b5.ResetText();
            b6.ResetText();
            b7.ResetText();
            b8.ResetText();
            b9.ResetText();
            b10.ResetText();
            b11.ResetText();
            b12.ResetText();
            b13.ResetText();
            b14.ResetText();
            b15.ResetText();
            i1.ResetText();
            i2.ResetText();
            i3.ResetText();
            i4.ResetText();
            i5.ResetText();
            i6.ResetText();
            i7.ResetText();
            i8.ResetText();
            i9.ResetText();
            i10.ResetText();
            i11.ResetText();
            i12.ResetText();
            i13.ResetText();
            i14.ResetText();
            i15.ResetText();
            n1.ResetText();
            n2.ResetText();
            n3.ResetText();
            n4.ResetText();
            n5.ResetText();
            n6.ResetText();
            n7.ResetText();
            n8.ResetText();
            n9.ResetText();
            n10.ResetText();
            n11.ResetText();
            n12.ResetText();
            n13.ResetText();
            n14.ResetText();
            n15.ResetText();
            g1.ResetText();
            g2.ResetText();
            g3.ResetText();
            g4.ResetText();
            g5.ResetText();
            g6.ResetText();
            g7.ResetText();
            g8.ResetText();
            g9.ResetText();
            g10.ResetText();
            g11.ResetText();
            g12.ResetText();
            g13.ResetText();
            g14.ResetText();
            g15.ResetText();
            o1.ResetText();
            o2.ResetText();
            o3.ResetText();
            o4.ResetText();
            o5.ResetText();
            o6.ResetText();
            o7.ResetText();
            o8.ResetText();
            o9.ResetText();
            o10.ResetText();
            o11.ResetText();
            o12.ResetText();
            o13.ResetText();
            o14.ResetText();
            o15.ResetText();
        }

        private void buttonNovaRodada_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void BotoesB()
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, b1.Width, b1.Height);
            b1.Region = new Region(forma);
            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, b2.Width, b2.Height);
            b2.Region = new Region(forma2);
            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, b3.Width, b3.Height);
            b3.Region = new Region(forma3);
            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, b4.Width, b4.Height);
            b4.Region = new Region(forma4);
            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, b5.Width, b5.Height);
            b5.Region = new Region(forma5);
            GraphicsPath forma6 = new GraphicsPath();
            forma6.AddEllipse(0, 0, b6.Width, b6.Height);
            b6.Region = new Region(forma6);
            GraphicsPath forma7 = new GraphicsPath();
            forma7.AddEllipse(0, 0, b7.Width, b7.Height);
            b7.Region = new Region(forma7);
            GraphicsPath forma8 = new GraphicsPath();
            forma8.AddEllipse(0, 0, b8.Width, b8.Height);
            b8.Region = new Region(forma8);
            GraphicsPath forma9 = new GraphicsPath();
            forma9.AddEllipse(0, 0, b9.Width, b9.Height);
            b9.Region = new Region(forma9);
            GraphicsPath forma10 = new GraphicsPath();
            forma10.AddEllipse(0, 0, b10.Width, b10.Height);
            b10.Region = new Region(forma10);
            GraphicsPath forma11 = new GraphicsPath();
            forma11.AddEllipse(0, 0, b11.Width, b11.Height);
            b11.Region = new Region(forma11);
            GraphicsPath forma12 = new GraphicsPath();
            forma12.AddEllipse(0, 0, b12.Width, b12.Height);
            b12.Region = new Region(forma12);
            GraphicsPath forma13 = new GraphicsPath();
            forma13.AddEllipse(0, 0, b13.Width, b13.Height);
            b13.Region = new Region(forma13);
            GraphicsPath forma14 = new GraphicsPath();
            forma14.AddEllipse(0, 0, b14.Width, b14.Height);
            b14.Region = new Region(forma14);
            GraphicsPath forma15 = new GraphicsPath();
            forma15.AddEllipse(0, 0, b15.Width, b15.Height);
            b15.Region = new Region(forma15);
        }

        private void BotoesI()
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, i1.Width, i1.Height);
            i1.Region = new Region(forma);
            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, i2.Width, i2.Height);
            i2.Region = new Region(forma2);
            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, i3.Width, i3.Height);
            i3.Region = new Region(forma3);
            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, i4.Width, i4.Height);
            i4.Region = new Region(forma4);
            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, i5.Width, i5.Height);
            i5.Region = new Region(forma5);
            GraphicsPath forma6 = new GraphicsPath();
            forma6.AddEllipse(0, 0, i6.Width, i6.Height);
            i6.Region = new Region(forma6);
            GraphicsPath forma7 = new GraphicsPath();
            forma7.AddEllipse(0, 0, i7.Width, i7.Height);
            i7.Region = new Region(forma7);
            GraphicsPath forma8 = new GraphicsPath();
            forma8.AddEllipse(0, 0, i8.Width, i8.Height);
            i8.Region = new Region(forma8);
            GraphicsPath forma9 = new GraphicsPath();
            forma9.AddEllipse(0, 0, i9.Width, i9.Height);
            i9.Region = new Region(forma9);
            GraphicsPath forma10 = new GraphicsPath();
            forma10.AddEllipse(0, 0, i10.Width, i10.Height);
            i10.Region = new Region(forma10);
            GraphicsPath forma11 = new GraphicsPath();
            forma11.AddEllipse(0, 0, i11.Width, i11.Height);
            i11.Region = new Region(forma11);
            GraphicsPath forma12 = new GraphicsPath();
            forma12.AddEllipse(0, 0, i12.Width, i12.Height);
            i12.Region = new Region(forma12);
            GraphicsPath forma13 = new GraphicsPath();
            forma13.AddEllipse(0, 0, i13.Width, i13.Height);
            i13.Region = new Region(forma13);
            GraphicsPath forma14 = new GraphicsPath();
            forma14.AddEllipse(0, 0, i14.Width, i14.Height);
            i14.Region = new Region(forma14);
            GraphicsPath forma15 = new GraphicsPath();
            forma15.AddEllipse(0, 0, i15.Width, i15.Height);
            i15.Region = new Region(forma15);
        }

        private void BotoesN()
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, n1.Width, n1.Height);
            n1.Region = new Region(forma);
            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, n2.Width, n2.Height);
            n2.Region = new Region(forma2);
            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, n3.Width, n3.Height);
            n3.Region = new Region(forma3);
            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, n4.Width, n4.Height);
            n4.Region = new Region(forma4);
            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, n5.Width, n5.Height);
            n5.Region = new Region(forma5);
            GraphicsPath forma6 = new GraphicsPath();
            forma6.AddEllipse(0, 0, n6.Width, n6.Height);
            n6.Region = new Region(forma6);
            GraphicsPath forma7 = new GraphicsPath();
            forma7.AddEllipse(0, 0, n7.Width, n7.Height);
            n7.Region = new Region(forma7);
            GraphicsPath forma8 = new GraphicsPath();
            forma8.AddEllipse(0, 0, n8.Width, n8.Height);
            n8.Region = new Region(forma8);
            GraphicsPath forma9 = new GraphicsPath();
            forma9.AddEllipse(0, 0, n9.Width, n9.Height);
            n9.Region = new Region(forma9);
            GraphicsPath forma10 = new GraphicsPath();
            forma10.AddEllipse(0, 0, n10.Width, n10.Height);
            n10.Region = new Region(forma10);
            GraphicsPath forma11 = new GraphicsPath();
            forma11.AddEllipse(0, 0, n11.Width, n11.Height);
            n11.Region = new Region(forma11);
            GraphicsPath forma12 = new GraphicsPath();
            forma12.AddEllipse(0, 0, n12.Width, n12.Height);
            n12.Region = new Region(forma12);
            GraphicsPath forma13 = new GraphicsPath();
            forma13.AddEllipse(0, 0, n13.Width, n13.Height);
            n13.Region = new Region(forma13);
            GraphicsPath forma14 = new GraphicsPath();
            forma14.AddEllipse(0, 0, n14.Width, n14.Height);
            n14.Region = new Region(forma14);
            GraphicsPath forma15 = new GraphicsPath();
            forma15.AddEllipse(0, 0, n15.Width, n15.Height);
            n15.Region = new Region(forma15);
        }

        private void BotoesG()
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, g1.Width, g1.Height);
            g1.Region = new Region(forma);
            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, g2.Width, g2.Height);
            g2.Region = new Region(forma2);
            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, g3.Width, g3.Height);
            g3.Region = new Region(forma3);
            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, g4.Width, g4.Height);
            g4.Region = new Region(forma4);
            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, g5.Width, g5.Height);
            g5.Region = new Region(forma5);
            GraphicsPath forma6 = new GraphicsPath();
            forma6.AddEllipse(0, 0, g6.Width, g6.Height);
            g6.Region = new Region(forma6);
            GraphicsPath forma7 = new GraphicsPath();
            forma7.AddEllipse(0, 0, g7.Width, g7.Height);
            g7.Region = new Region(forma7);
            GraphicsPath forma8 = new GraphicsPath();
            forma8.AddEllipse(0, 0, g8.Width, g8.Height);
            g8.Region = new Region(forma8);
            GraphicsPath forma9 = new GraphicsPath();
            forma9.AddEllipse(0, 0, g9.Width, g9.Height);
            g9.Region = new Region(forma9);
            GraphicsPath forma10 = new GraphicsPath();
            forma10.AddEllipse(0, 0, g10.Width, g10.Height);
            g10.Region = new Region(forma10);
            GraphicsPath forma11 = new GraphicsPath();
            forma11.AddEllipse(0, 0, g11.Width, g11.Height);
            g11.Region = new Region(forma11);
            GraphicsPath forma12 = new GraphicsPath();
            forma12.AddEllipse(0, 0, g12.Width, g12.Height);
            g12.Region = new Region(forma12);
            GraphicsPath forma13 = new GraphicsPath();
            forma13.AddEllipse(0, 0, g13.Width, g13.Height);
            g13.Region = new Region(forma13);
            GraphicsPath forma14 = new GraphicsPath();
            forma14.AddEllipse(0, 0, g14.Width, g14.Height);
            g14.Region = new Region(forma14);
            GraphicsPath forma15 = new GraphicsPath();
            forma15.AddEllipse(0, 0, g15.Width, g15.Height);
            g15.Region = new Region(forma15);
        }

        private void BotoesO()
        {
            GraphicsPath forma = new GraphicsPath();
            forma.AddEllipse(0, 0, o1.Width, o1.Height);
            o1.Region = new Region(forma);
            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, o2.Width, o2.Height);
            o2.Region = new Region(forma2);
            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, o3.Width, o3.Height);
            o3.Region = new Region(forma3);
            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, o4.Width, o4.Height);
            o4.Region = new Region(forma4);
            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, o5.Width, o5.Height);
            o5.Region = new Region(forma5);
            GraphicsPath forma6 = new GraphicsPath();
            forma6.AddEllipse(0, 0, o6.Width, o6.Height);
            o6.Region = new Region(forma6);
            GraphicsPath forma7 = new GraphicsPath();
            forma7.AddEllipse(0, 0, o7.Width, o7.Height);
            o7.Region = new Region(forma7);
            GraphicsPath forma8 = new GraphicsPath();
            forma8.AddEllipse(0, 0, o8.Width, o8.Height);
            o8.Region = new Region(forma8);
            GraphicsPath forma9 = new GraphicsPath();
            forma9.AddEllipse(0, 0, o9.Width, o9.Height);
            o9.Region = new Region(forma9);
            GraphicsPath forma10 = new GraphicsPath();
            forma10.AddEllipse(0, 0, o10.Width, o10.Height);
            o10.Region = new Region(forma10);
            GraphicsPath forma11 = new GraphicsPath();
            forma11.AddEllipse(0, 0, o11.Width, o11.Height);
            o11.Region = new Region(forma11);
            GraphicsPath forma12 = new GraphicsPath();
            forma12.AddEllipse(0, 0, o12.Width, o12.Height);
            o12.Region = new Region(forma12);
            GraphicsPath forma13 = new GraphicsPath();
            forma13.AddEllipse(0, 0, o13.Width, o13.Height);
            o13.Region = new Region(forma13);
            GraphicsPath forma14 = new GraphicsPath();
            forma14.AddEllipse(0, 0, o14.Width, o14.Height);
            o14.Region = new Region(forma14);
            GraphicsPath forma15 = new GraphicsPath();
            forma15.AddEllipse(0, 0, o15.Width, o15.Height);
            o15.Region = new Region(forma15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BotoesB();
            BotoesI();
            BotoesN();
            BotoesG();
            BotoesO();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
