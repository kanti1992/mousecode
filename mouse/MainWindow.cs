﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace mysz
{
    public partial class main_form : Form
    {
        const int CHART_WIDTH = 800;
        const int CHART_HEIGHT = 600;
        Thread coordinateUpdater;
        Thread coordinateSaver;
        List<String> coordsList;
        public main_form()
        {
            InitializeComponent();
            coordinateUpdater = new Thread(updateCoordinates);
            coordinateSaver = new Thread(saveCoordinates);
            coordsList = new List<String>();
            coordinates_list.DataSource = coordsList;  
            coordinateUpdater.Start();
        }

        public int getX()
        {
           int X = MousePosition.X - this.Left - pictureBox.Location.X - 8;
            // -8 is shifted because of strange window coordinates
           if (X < 0)
               return 0;
           if (X > CHART_WIDTH)
               return CHART_WIDTH;
           return X;
        }

        public int getY()
        {
            int Y = MousePosition.Y - this.Top - pictureBox.Location.Y - 30;
            // -30 is shifted because of strange window coordinates
            if (Y < 0)
                return 0;
            if (Y > CHART_HEIGHT)
                return CHART_HEIGHT;
            return Y;
        }

        public string getXstring()
        {
            int x = getX();
            if (x < 10)
                return "    " + x.ToString();
            else if (x < 100)
                return "  " + x.ToString();
            else
                return x.ToString();
        }

        public string getYstring()
        {
            int y = getY();
            if (y < 10)
                return "    " + y.ToString();
            else if (y < 100)
                return "  " + y.ToString();
            else
                return y.ToString();
        }

        void updateCoordinates()
        {
            while (true)
            {
                if (this.X_value.InvokeRequired || this.Y_value.InvokeRequired)
                {
                    this.X_value.BeginInvoke((MethodInvoker)delegate() { this.X_value.Text = getXstring(); ;});
                    this.Y_value.BeginInvoke((MethodInvoker)delegate() { this.Y_value.Text = getYstring(); ;});
                }
                else
                {
                    this.X_value.Text = getXstring();
                    this.Y_value.Text = getYstring();
                }
                Thread.Sleep(10);
            }
        }

        void saveCoordinates()
        {
            while (true)
            {
                coordsList.Add(string.Format("    {0}            {1}", getXstring(), getYstring()));
                if (this.coordinates_list.InvokeRequired)
                {
                    this.coordinates_list.BeginInvoke((MethodInvoker)delegate() {
                        this.coordinates_list.DataSource = null;
                        this.coordinates_list.Items.Clear();
                        this.coordinates_list.DataSource = coordsList;
                        int VisibleCoordsNumber = coordinates_list.ClientSize.Height / coordinates_list.ItemHeight;
                        coordinates_list.TopIndex = Math.Max(coordinates_list.Items.Count - VisibleCoordsNumber + 1, 0);
                   });
                }
                else
                {
                    this.coordinates_list.DataSource = null;
                    this.coordinates_list.Items.Clear();
                    this.coordinates_list.DataSource = coordsList; 
                }
                Thread.Sleep(10);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            coordsList.Clear();
            coordsList.Add(string.Format("    {0}            {1}", getXstring(), getYstring()));
            if (!coordinateSaver.IsAlive)
            {
                coordinateSaver = new Thread(saveCoordinates);
                coordinateSaver.Start();
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (coordinateSaver.IsAlive)
                coordinateSaver.Abort();
            /*TODO zmienic watki zeby nie rzucalo wyjatkow*/
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(coordinateUpdater.IsAlive) 
                coordinateUpdater.Abort();
            if (coordinateSaver.IsAlive)
                coordinateSaver.Abort();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        //    //TODO ustalić odpowiednią skalę i odległość, zależną od okna!
            //pictureBox;
            if (coordsList.Count < 2)
                return;
            Pen p = new Pen(Color.Blue, 2f);
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
            int lastx = Convert.ToInt32(coordsList[0].Substring(0, 10));
            int lasty = Convert.ToInt32(coordsList[0].Substring(10));
            g.DrawEllipse(p, lastx-1, lasty-1, 2, 2);
            int x = Convert.ToInt32(coordsList[1].Substring(0, 10));
            int y = Convert.ToInt32(coordsList[1].Substring(10));
            g.DrawEllipse(p, x - 1, y - 1, 2, 2);
            g.DrawLine(p, new Point(lastx, lasty), new Point(x, y));
            for (int i = 2; i < coordsList.Count; i++)
            {
                lastx = x;
                lasty = y;
                x = Convert.ToInt32(coordsList[i].Substring(0, 10));
                y = Convert.ToInt32(coordsList[i].Substring(10));
                g.DrawEllipse(p, x - 1, y - 1, 2, 2);
                g.DrawLine(p, new Point(lastx, lasty), new Point(x, y));
            }

        }
    }
}
