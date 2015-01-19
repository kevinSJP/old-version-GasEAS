using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS.Data;
using EAS.Data.ORM;
using EAS.Data.Access;
using EAS.Modularization;

using EAS;
using EAS.Services;
using EAS.Data.Linq;

using Gas_test2.Entities;

using Gas_test2.BLL;

namespace Gas_test2.WinUI
{
    [Module("2455E304-4E99-4E45-A269-128EAD805943", "煤气系统配置", "FunctionList")]

    public partial class Config : UserControl
    {

        #region 定义与初始化
        int CtrlFlag = 0;   //控件显示标识位
        #endregion

        public Config()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }

        private void Config_Load(object sender, EventArgs e)
        {
            //CtrlView.GasometerConfig Ctrl = new CtrlView.GasometerConfig();
            //panel1.Controls.Add(Ctrl);
            btn_Next.Text = "开始配置";
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            

            switch (CtrlFlag)
            {
                case 0:
                    CtrlView.GasometerConfig Ctrl0 = new CtrlView.GasometerConfig();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(Ctrl0);
                    break;
                case 1:
                    CtrlView.EquipConfig Ctrl1 = new CtrlView.EquipConfig();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(Ctrl1);
                    break;
                case 2:
                    CtrlView.OmeterAndEquip Ctrl2 = new CtrlView.OmeterAndEquip();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(Ctrl2);
                    break;
                case 3:
                    CtrlView.EquipAndAlg Ctrl4 = new CtrlView.EquipAndAlg();
                    panel1.Controls.Clear();
                    panel1.Controls.Add(Ctrl4);
                    btn_Next.Text = "完成";
                    break;
                case 4:
                    btn_Next.Text = "再次配置";
                    CtrlFlag = -1;
                    break;
                default:
                    btn_Next.Text = "流程错误";
                    
                    break;
            
            }

            CtrlFlag = CtrlFlag + 1;

        }




    }
}
