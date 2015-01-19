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
    [Module("B47CEC4B-CFE9-434C-8097-5F5B1FA7ACA7", "预测参数配置", "FunctionList")]

    public partial class ForecastConfig : UserControl
    {
        public ForecastConfig()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            System.Type T = typeof(ForecastView);
            EAS.Application.Instance.OpenModule(T);
        }






    }
}
