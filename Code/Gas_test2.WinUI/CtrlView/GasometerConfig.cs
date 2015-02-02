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

namespace Gas_test2.WinUI.CtrlView
{
    public partial class GasometerConfig : UserControl
    {
        private DataSet dataset = new DataSet();

        public GasometerConfig()
        {
            InitializeComponent();
        }

        private void GasometerConfig_Load(object sender, EventArgs e)
        {
            
            FreshLbox("GasometerName", "GasometerType", "lbox_Gasometer");

            CtrlView.banner Ctrl0 = new CtrlView.banner();
            panel1.Controls.Clear();
            panel1.Controls.Add(Ctrl0);
            Ctrl0.Size.Height=100;
            Ctrl0.Dock = DockStyle.Top;
        }

        /// <summary>
        /// 读取数据库数据到listbox
        /// </summary>
        /// <param name="cloum">列名</param>
        /// <param name="tab">表名</param>
        /// <param name="listbox">listbox名</param>
        private void FreshLbox(string cloum, string tab, string listbox)
        {
            /*
            dataset.Clear();

            dataset = ServiceContainer.GetService<IGasDAL>().QueryData(cloum, tab);

            int j = 0;
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                if (listbox == "lbox_Type")
                {
                    
                    lbox_Type.Items.Add(dataset.Tables[0].Rows[j][0]);
                }
                else if (listbox == "lbox_Equip")
                {
                    //dataset = ServiceContainer.GetService<IGasDAL>().QueryData(cloum, tab);
                    if (dataset.Tables[0].Rows[j][6].ToString() == "1")
                        lbox_Equip.Items.Add(dataset.Tables[0].Rows[j][0]);
                }
                j++;
            }
            */
            //if (listbox == "lbox_Gasometer")
            //{}
            lbox_Gasometer.Items.Clear();
            dataset.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryData(cloum, tab);
            int j = 0;
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                lbox_Gasometer.Items.Add(dataset.Tables[0].Rows[j][cloum]);
                //panel

                j++;
            }       
            


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormView.AddEquip addequip = new FormView.AddEquip();
            ModuleClass.FuncClass.clikUI = "ometer";
            addequip.ShowDialog();
            addequip.Dispose();
            
            FreshLbox("GasometerName", "GasometerType", "lbox_Gasometer");
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {

                /////////删除表一行数据
                ServiceContainer.GetService<IGasDAL>().DeleteData("GasometerType", "GasometerName", lbox_Gasometer.SelectedItem.ToString());
                lbox_Gasometer.Items.RemoveAt(lbox_Gasometer.SelectedIndex);
                
                FreshLbox("EquipName", "EquipTypeSlet", "lbox_Gasometer");
            }
            catch
            {
                MessageBox.Show("选择删除项");
            }
        }
    }
}
