using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gas_test2.WinUI.CtrlView
{
    public partial class OmeterAndEquip : UserControl
    {
        public OmeterAndEquip()
        {
            InitializeComponent();
        }

        private void OmeterAndEquip_Load(object sender, EventArgs e)
        {
            /* 设置label显示方式
            string str = "输入设备：";
            int LblNum = str.Length;   //Label内容长度         
            int RowNum = 10;           //每行显示的字数         
            float FontWidth = label1.Width / label1.Text.Length;  //每个字符的宽度         
            int RowHeight=15;           //每行的高度         
            int ColNum = (LblNum - (LblNum / RowNum) * RowNum) == 0 ? (LblNum / RowNum) : (LblNum / RowNum) + 1;   //列数         
            label1.AutoSize = false;    //设置AutoSize         
            label1.Width = (int)(FontWidth * 10.0);          //设置显示宽度         
            label1.Height = RowHeight * ColNum;           //设置显示高度
             */ 
        }
    }
}
