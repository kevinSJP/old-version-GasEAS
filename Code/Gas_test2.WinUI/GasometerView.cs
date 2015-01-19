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
    [Module("76E6F5E8-AD5A-4BEC-AF16-28BF8739E4B9", "煤气柜预测数据查询", "FunctionList")]

    public partial class GasometerView : UserControl
    {
        public GasometerView()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }








    }
}
