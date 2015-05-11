﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xceed.DockingWindows;

namespace EasyMidas
{
    public partial class MessageTools : ToolWindow
    {
        public MessageTools()
        {
            InitializeComponent();
        }
        //信息输出框
        public System.Windows.Forms.TextBox Tb_out
        {
            get { return tb_out; }
            set { tb_out = value; }
        }

        private void tb_out_TextChanged(object sender, EventArgs e)
        {
            this.tb_out.ScrollToCaret();//滚到当前光标插入位置
        }
    }
}
