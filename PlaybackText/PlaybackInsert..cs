﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PlaybackText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)

        {
            
            string path = UID + ".txt";
            


            {
                //Create a file to write to

         
                StreamWriter File = new StreamWriter(path);
                File.WriteLine(playback_TextBox.Text + " " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                File.Close();
                Close();

            }
            


            
        }

        
        

        
    }
}