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

namespace Bingo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormatarBotoesLetras();
            FormatarBotoesB();
            FormatarBotoesI();
            FormatarBotoesN();
            FormatarBotoesG();
            FormatarBotoesO();
        }

        private void FormatarBotoesLetras()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, btnB.Width, btnB.Height);
            btnB.Region = new Region(forma1);

            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, btnI.Width, btnI.Height);
            btnI.Region = new Region(forma2);

            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, btnG.Width, btnG.Height);
            btnG.Region = new Region(forma3);

            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, btnN.Width, btnN.Height);
            btnN.Region = new Region(forma4);

            GraphicsPath forma5 = new GraphicsPath();
            forma5.AddEllipse(0, 0, btnO.Width, btnO.Height);
            btnO.Region = new Region(forma5);
        }

        private void FormatarBotoesB()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, b1.Width, b1.Height);
            b1.Region = new Region(forma1);

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

            colunaB.Controls.Add(b1);
            colunaB.Controls.Add(b2);
            colunaB.Controls.Add(b3);
            colunaB.Controls.Add(b4);
            colunaB.Controls.Add(b5);
        }

        private void FormatarBotoesI()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, i1.Width, i1.Height);
            i1.Region = new Region(forma1);

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

            colunaI.Controls.Add(i1);
            colunaI.Controls.Add(i2);
            colunaI.Controls.Add(i3);
            colunaI.Controls.Add(i4);
            colunaI.Controls.Add(i5);
        }

        private void FormatarBotoesN()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, n1.Width, n1.Height);
            n1.Region = new Region(forma1);

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

            colunaN.Controls.Add(n1);
            colunaN.Controls.Add(n2);
            colunaN.Controls.Add(n3);
            colunaN.Controls.Add(n4);
            colunaN.Controls.Add(n5);
        }

        private void FormatarBotoesG()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, g1.Width, g1.Height);
            g1.Region = new Region(forma1);

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

            colunaG.Controls.Add(g1);
            colunaG.Controls.Add(g2);
            colunaG.Controls.Add(g3);
            colunaG.Controls.Add(g4);
            colunaG.Controls.Add(g5);
        }

        private void FormatarBotoesO()
        {
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, o1.Width, o1.Height);
            o1.Region = new Region(forma1);

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

            colunaO.Controls.Add(o1);
            colunaO.Controls.Add(o2);
            colunaO.Controls.Add(o3);
            colunaO.Controls.Add(o4);
            colunaO.Controls.Add(o5);
        }
    }
}
