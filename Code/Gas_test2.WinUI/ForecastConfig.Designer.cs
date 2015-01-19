namespace Gas_test2.WinUI
{
    partial class ForecastConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Equip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Alg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.C_Trigger = new EAS.Windows.UI.Controls.DataGridViewNumEditColumn();
            this.C_Duration = new EAS.Windows.UI.Controls.DataGridViewNumEditColumn();
            this.btn_Start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预测功能相关设置：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Equip,
            this.C_Alg,
            this.C_Trigger,
            this.C_Duration});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(938, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // C_Equip
            // 
            this.C_Equip.HeaderText = "设备种类";
            this.C_Equip.Name = "C_Equip";
            this.C_Equip.ReadOnly = true;
            // 
            // C_Alg
            // 
            this.C_Alg.HeaderText = "算法选择";
            this.C_Alg.Name = "C_Alg";
            // 
            // C_Trigger
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "F0";
            this.C_Trigger.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_Trigger.HeaderText = "预测时间间隔";
            this.C_Trigger.Name = "C_Trigger";
            // 
            // C_Duration
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "F0";
            this.C_Duration.DefaultCellStyle = dataGridViewCellStyle2;
            this.C_Duration.HeaderText = "预测时长";
            this.C_Duration.Name = "C_Duration";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(741, 403);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(154, 37);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "启动预测";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // ForecastConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.groupBox1);
            this.Name = "ForecastConfig";
            this.Size = new System.Drawing.Size(944, 457);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Equip;
        private System.Windows.Forms.DataGridViewComboBoxColumn C_Alg;
        private EAS.Windows.UI.Controls.DataGridViewNumEditColumn C_Trigger;
        private EAS.Windows.UI.Controls.DataGridViewNumEditColumn C_Duration;
        private System.Windows.Forms.Button btn_Start;

    }
}
