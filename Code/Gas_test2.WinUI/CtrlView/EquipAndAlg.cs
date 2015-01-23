using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using EAS;
using EAS.Services;
using EAS.Data.Linq;

using Gas_test2.Entities;

using Gas_test2.BLL;

namespace Gas_test2.WinUI.CtrlView
{
    public partial class EquipAndAlg : UserControl
    {
        private DataSet dataset = new DataSet();

        public EquipAndAlg()
        {
            InitializeComponent();
        }

        private void EquipAndAlg_Load(object sender, EventArgs e)
        {
            FreshCbox();
            FreshTree();
            FreshDG();
        }

        private void FreshDG()
        {
            throw new NotImplementedException();
        }

        private void FreshTree()
        {
            dataset.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryData("EquipName","EquipTypeSlet");
            Tree_Alg.Nodes.Clear();
            int j = 0;
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                string equipname = dataset.Tables[0].Rows[j]["EquipName"].ToString();
                TreeNode tn = Tree_Alg.Nodes.Add(equipname);

                dataset.Clear();
                dataset = ServiceContainer.GetService<IGasDAL>().QueryData("EquipAlgSlet", "EquipName", equipname);

                int k = 0;
                foreach (DataRow dr2 in dataset.Tables[0].Rows)
                {
                    string L1;

                    TreeNode tn1 = new TreeNode(dataset.Tables[0].Rows[j]["AlgName"].ToString());
                    tn.Nodes.Add(tn1);
                    L1 = dataset.Tables[0].Rows[k]["L1"].ToString();
                    string[] L1D = L1.Split(';');
                    for (int i = 0; i < L1D.Count() - 1; i++)
                    {
                        TreeNode tn12 = new TreeNode(L1D[i]);
                        tn1.Nodes.Add(tn12);
                    }


                    k++;
                }
                j++;
            }
        }

        private void FreshCbox()
        {
            cbox_Eq.Items.Clear();
            dataset.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryData("EquipName", "EquipTypeSlet");
            int j = 0;
            foreach (DataRow dr in dataset.Tables[0].Rows)
            {
                cbox_Eq.Items.Add(dataset.Tables[0].Rows[j][0]);
                j++;
            }
        }
    }
}
