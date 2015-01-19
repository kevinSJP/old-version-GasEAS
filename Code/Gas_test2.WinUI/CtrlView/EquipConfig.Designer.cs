namespace Gas_test2.WinUI.CtrlView
{
    partial class EquipConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbox_Equip = new System.Windows.Forms.ListBox();
            this.dgv_L1 = new System.Windows.Forms.DataGridView();
            this.L1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPage_L1 = new System.Windows.Forms.TabPage();
            this.tbPage_L2 = new System.Windows.Forms.TabPage();
            this.dgv_L2 = new System.Windows.Forms.DataGridView();
            this.L2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbPage_L3 = new System.Windows.Forms.TabPage();
            this.dgv_L3 = new System.Windows.Forms.DataGridView();
            this.L3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_Alter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbPage_L1.SuspendLayout();
            this.tbPage_L2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L2)).BeginInit();
            this.tbPage_L3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Alter);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.lbox_Equip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 457);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "煤气相关设备：";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(214, 382);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 25);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(27, 382);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 25);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "添加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // lbox_Equip
            // 
            this.lbox_Equip.FormattingEnabled = true;
            this.lbox_Equip.ItemHeight = 16;
            this.lbox_Equip.Location = new System.Drawing.Point(24, 31);
            this.lbox_Equip.Name = "lbox_Equip";
            this.lbox_Equip.Size = new System.Drawing.Size(265, 292);
            this.lbox_Equip.TabIndex = 5;
            // 
            // dgv_L1
            // 
            this.dgv_L1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_L1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L1Name});
            this.dgv_L1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_L1.Location = new System.Drawing.Point(3, 3);
            this.dgv_L1.Name = "dgv_L1";
            this.dgv_L1.RowTemplate.Height = 23;
            this.dgv_L1.Size = new System.Drawing.Size(237, 365);
            this.dgv_L1.TabIndex = 0;
            // 
            // L1Name
            // 
            this.L1Name.HeaderText = "因素名称";
            this.L1Name.Name = "L1Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPage_L1);
            this.tabControl1.Controls.Add(this.tbPage_L2);
            this.tabControl1.Controls.Add(this.tbPage_L3);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F);
            this.tabControl1.Location = new System.Drawing.Point(358, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 401);
            this.tabControl1.TabIndex = 20;
            // 
            // tbPage_L1
            // 
            this.tbPage_L1.Controls.Add(this.dgv_L1);
            this.tbPage_L1.Location = new System.Drawing.Point(4, 26);
            this.tbPage_L1.Name = "tbPage_L1";
            this.tbPage_L1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_L1.Size = new System.Drawing.Size(243, 371);
            this.tbPage_L1.TabIndex = 0;
            this.tbPage_L1.Text = "直采数据";
            this.tbPage_L1.UseVisualStyleBackColor = true;
            // 
            // tbPage_L2
            // 
            this.tbPage_L2.Controls.Add(this.dgv_L2);
            this.tbPage_L2.Location = new System.Drawing.Point(4, 22);
            this.tbPage_L2.Name = "tbPage_L2";
            this.tbPage_L2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage_L2.Size = new System.Drawing.Size(243, 375);
            this.tbPage_L2.TabIndex = 1;
            this.tbPage_L2.Text = "操作数据";
            this.tbPage_L2.UseVisualStyleBackColor = true;
            // 
            // dgv_L2
            // 
            this.dgv_L2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_L2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L2Name});
            this.dgv_L2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_L2.Location = new System.Drawing.Point(3, 3);
            this.dgv_L2.Name = "dgv_L2";
            this.dgv_L2.RowTemplate.Height = 23;
            this.dgv_L2.Size = new System.Drawing.Size(237, 369);
            this.dgv_L2.TabIndex = 0;
            // 
            // L2Name
            // 
            this.L2Name.HeaderText = "因素名称";
            this.L2Name.Name = "L2Name";
            // 
            // tbPage_L3
            // 
            this.tbPage_L3.Controls.Add(this.dgv_L3);
            this.tbPage_L3.Location = new System.Drawing.Point(4, 22);
            this.tbPage_L3.Name = "tbPage_L3";
            this.tbPage_L3.Size = new System.Drawing.Size(243, 375);
            this.tbPage_L3.TabIndex = 2;
            this.tbPage_L3.Text = "调度数据";
            this.tbPage_L3.UseVisualStyleBackColor = true;
            // 
            // dgv_L3
            // 
            this.dgv_L3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_L3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L3Name});
            this.dgv_L3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_L3.Location = new System.Drawing.Point(0, 0);
            this.dgv_L3.Name = "dgv_L3";
            this.dgv_L3.RowTemplate.Height = 23;
            this.dgv_L3.Size = new System.Drawing.Size(243, 375);
            this.dgv_L3.TabIndex = 0;
            // 
            // L3Name
            // 
            this.L3Name.HeaderText = "因素名称";
            this.L3Name.Name = "L3Name";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView1.Location = new System.Drawing.Point(750, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(194, 457);
            this.treeView1.TabIndex = 21;
            // 
            // btn_Alter
            // 
            this.btn_Alter.Location = new System.Drawing.Point(119, 382);
            this.btn_Alter.Name = "btn_Alter";
            this.btn_Alter.Size = new System.Drawing.Size(75, 25);
            this.btn_Alter.TabIndex = 13;
            this.btn_Alter.Text = "修改";
            this.btn_Alter.UseVisualStyleBackColor = true;
            // 
            // EquipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EquipConfig";
            this.Size = new System.Drawing.Size(944, 457);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbPage_L1.ResumeLayout(false);
            this.tbPage_L2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L2)).EndInit();
            this.tbPage_L3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_L3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lbox_Equip;
        private System.Windows.Forms.DataGridView dgv_L1;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1Name;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPage_L1;
        private System.Windows.Forms.TabPage tbPage_L2;
        private System.Windows.Forms.DataGridView dgv_L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2Name;
        private System.Windows.Forms.TabPage tbPage_L3;
        private System.Windows.Forms.DataGridView dgv_L3;
        private System.Windows.Forms.DataGridViewTextBoxColumn L3Name;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_Alter;
    }
}
