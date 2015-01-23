namespace Gas_test2.WinUI.CtrlView
{
    partial class EquipAndAlg
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tree_Alg = new System.Windows.Forms.TreeView();
            this.cbox_Eq = new System.Windows.Forms.ComboBox();
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.DG_Alg = new System.Windows.Forms.DataGridView();
            this.C_Alg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.C_Factor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Alg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree_Alg
            // 
            this.Tree_Alg.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tree_Alg.Location = new System.Drawing.Point(642, 0);
            this.Tree_Alg.Name = "Tree_Alg";
            this.Tree_Alg.Size = new System.Drawing.Size(302, 457);
            this.Tree_Alg.TabIndex = 6;
            // 
            // cbox_Eq
            // 
            this.cbox_Eq.FormattingEnabled = true;
            this.cbox_Eq.Location = new System.Drawing.Point(33, 31);
            this.cbox_Eq.Name = "cbox_Eq";
            this.cbox_Eq.Size = new System.Drawing.Size(193, 24);
            this.cbox_Eq.TabIndex = 0;
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.cbox_Eq);
            this.gbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbox1.Font = new System.Drawing.Font("宋体", 12F);
            this.gbox1.Location = new System.Drawing.Point(0, 0);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(642, 85);
            this.gbox1.TabIndex = 7;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "选择设备：";
            // 
            // DG_Alg
            // 
            this.DG_Alg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Alg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Alg,
            this.C_Factor});
            this.DG_Alg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Alg.Location = new System.Drawing.Point(0, 0);
            this.DG_Alg.Name = "DG_Alg";
            this.DG_Alg.RowTemplate.Height = 23;
            this.DG_Alg.Size = new System.Drawing.Size(642, 372);
            this.DG_Alg.TabIndex = 0;
            // 
            // C_Alg
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.C_Alg.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_Alg.HeaderText = "可选算法";
            this.C_Alg.Name = "C_Alg";
            // 
            // C_Factor
            // 
            this.C_Factor.HeaderText = "算法因素1";
            this.C_Factor.Name = "C_Factor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DG_Alg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 372);
            this.panel1.TabIndex = 8;
            // 
            // EquipAndAlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbox1);
            this.Controls.Add(this.Tree_Alg);
            this.Name = "EquipAndAlg";
            this.Size = new System.Drawing.Size(944, 457);
            this.Load += new System.EventHandler(this.EquipAndAlg_Load);
            this.gbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Alg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Tree_Alg;
        private System.Windows.Forms.ComboBox cbox_Eq;
        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.DataGridView DG_Alg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_Alg;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_Factor;

    }
}
