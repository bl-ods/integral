﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choe
{
    public partial class InputForm : Form
    {
        OutputForm outputForm;
        bool sidebarExpand = true;
        int poison = 562;
        public InputForm()
        {
            InitializeComponent();
        }

        private void pidor_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
            if (sidebarExpand == true)
            {

                poison -= 5;
                sidebarContainer.Location = new Point(0, poison);
                if (poison == 512)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
                
            }
            else
            {
                poison += 5;
                sidebarContainer.Location = new Point(0, poison);
                if (poison == 562)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
            
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(InputTextBox.Text, InputTextBox.Font);
            InputTextBox.Width = size.Width;
            InputTextBox.Height = size.Height;
        }


        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Uebok_Click(object sender, EventArgs e)
        {
            this.Hide();
            DATADATADATA.OutputTextDa = InputTextBox.Text;
            outputForm = new OutputForm();
            outputForm.Show();
        }


        bool Achee = true;
        private void Ploti_Click(object sender, EventArgs e)
        {
            //PlotiZaKnopki.Start();
        }


        private void Ache_Click(object sender, EventArgs e)
        {
            Ache.BackColor = Color.FromArgb(0, 0, 0, 0);
            Ache.Location = new Point(1051, 613);
            PanelPodpiski.Location = new Point(1051, 613);
            //PlotiZaKnopki.Start();
        }



        //int x = 0;
        //private void PlotiZaKnopki_Tick(object sender, EventArgs e)
        //{
        //    if (Achee == true)
        //    {
        //        x += 5;
        //        Ache.BackColor = Color.FromArgb(x, 0, 0, 0);
        //        if (x==200)
        //        {
        //            Achee = false;
        //            PlotiZaKnopki.Stop();
        //        }
        //
        //    }
        //    else
        //    {
        //        x -= 5;
        //        Ache.BackColor = Color.FromArgb(x, 0, 0, 0);
        //        if (x == 0)
        //        {
        //            Achee = true;
        //            Ache.Location = new Point(1051, 613);
        //            PlotiZaKnopki.Stop();
        //        }
        //    }
        //}
        //
        private void Ploti_MouseHover(object sender, EventArgs e)
        {
            PanelSDollarom.Location = new Point(0, 562);
        }

      

        private void ButtonDollar_Click(object sender, EventArgs e)
        {
            Ache.Location = new Point(0, 0);
            Ache.BackColor = Color.FromArgb(200, 0, 0, 0);
            PanelSDollarom.Location = new Point(1051, 613);
            PanelPodpiski.Location = new Point(350, 206);

        }

        private void NeDollar_Click(object sender, EventArgs e)
        {
            Ache.BackColor = Color.FromArgb(0, 0, 0, 0);
            Ache.Location = new Point(1051, 613);
            PanelPodpiski.Location = new Point(1051, 613);
        }
    }
}