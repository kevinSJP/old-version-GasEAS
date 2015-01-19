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
        public Config()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }




    }
}
