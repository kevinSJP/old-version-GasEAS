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
    [Module("E1AF8773-8622-4449-8E55-A39D6DFA654E", "查询数据显示", "FunctionList")]

    public partial class QueryView : UserControl
    {
        public QueryView()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }





    }
}
