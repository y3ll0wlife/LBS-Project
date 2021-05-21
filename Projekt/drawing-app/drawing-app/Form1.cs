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

namespace drawing_app
{
   
    class Config
    {
        public static bool isColor1Selected = true;
    }

    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen pen = new Pen(Color.Black);
        public Graphics canvas;
        public GraphicsState canvaState;


        public Form1()
        {
            InitializeComponent();
            canvas = drawingCanvas.CreateGraphics();
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }
   
        private void drawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            pen.Width = Convert.ToInt32(penWidthSize.Value);
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                pen.Color = color1.BackColor;
                canvas.DrawLine(pen, old, current);
                old = current;
            }
            if (e.Button == MouseButtons.Right)
            {
                current = e.Location;
                pen.Color = color2.BackColor;
                canvas.DrawLine(pen, old, current);
                old = current;
            }
        }

        private void colorPicker_Click(object sender, EventArgs e)
        { 
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Config.isColor1Selected) color1.BackColor = dlg.Color;
                else color2.BackColor = dlg.Color;
            }
        }

        private void color2_MouseClick(object sender, MouseEventArgs e)
        {
            color1Selected.Visible = false;
            color2Selected.Visible = true;
            Config.isColor1Selected = false;
        }
        private void color1_MouseClick(object sender, MouseEventArgs e)
        {
            color1Selected.Visible = true;
            color2Selected.Visible = false;
            Config.isColor1Selected = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
              //  canvas.Restore();
            }
           
        }
    }
}
