﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System_Thesis
{
    public partial class CustomerButton : PictureBox
    {
        public CustomerButton()
        {
            InitializeComponent();
        }

        private void CustomerButton_Load(object sender, EventArgs e)
        {

        }
        private Image Normalimage;
        private Image Hoverimage;   

        public Image ImageNormal
        { 
          get { return Normalimage; }   
            set { Normalimage = value; }
        }

        public Image ImageHover
        {
            get { return Hoverimage; }
            set { Hoverimage = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = Hoverimage;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = Normalimage;
        }
    }
}
