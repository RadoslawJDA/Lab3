﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3v2
{
    public partial class Test : Form
    {
        private Dictionary<string, string> wordDictionary;
        private KeyValuePair<string, string> currentWord;
        public Test(Dictionary<string, string> dictionary)
        {
            InitializeComponent();
            wordDictionary = dictionary;
            
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
