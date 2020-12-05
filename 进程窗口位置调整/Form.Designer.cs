namespace 进程窗口位置调整
{
    partial class Form
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.ProslistBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.Mainlabel = new System.Windows.Forms.Label();
            this.Showlabel = new System.Windows.Forms.Label();
            this.HighcheckBox = new System.Windows.Forms.CheckBox();
            this.CentercheckBox = new System.Windows.Forms.CheckBox();
            this.WincomboBox = new System.Windows.Forms.ComboBox();
            this.ProcesslistView = new System.Windows.Forms.ListView();
            this.CHId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHPMainWindowTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHPMainHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProslistBox
            // 
            this.ProslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProslistBox.FormattingEnabled = true;
            this.ProslistBox.HorizontalScrollbar = true;
            this.ProslistBox.IntegralHeight = false;
            this.ProslistBox.ItemHeight = 12;
            this.ProslistBox.Location = new System.Drawing.Point(3, 3);
            this.ProslistBox.Name = "ProslistBox";
            this.ProslistBox.ScrollAlwaysVisible = true;
            this.ProslistBox.Size = new System.Drawing.Size(731, 168);
            this.ProslistBox.TabIndex = 0;
            this.ProslistBox.SelectedIndexChanged += new System.EventHandler(this.ProslistBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(789, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "刷新进程列表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(865, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "调整窗体";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Itemlabel
            // 
            this.Itemlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Location = new System.Drawing.Point(787, 60);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(65, 12);
            this.Itemlabel.TabIndex = 3;
            this.Itemlabel.Text = "进程信息：";
            // 
            // Mainlabel
            // 
            this.Mainlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Location = new System.Drawing.Point(787, 304);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(77, 12);
            this.Mainlabel.TabIndex = 4;
            this.Mainlabel.Text = "已选中进程：";
            // 
            // Showlabel
            // 
            this.Showlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Showlabel.AutoSize = true;
            this.Showlabel.Location = new System.Drawing.Point(787, 347);
            this.Showlabel.Name = "Showlabel";
            this.Showlabel.Size = new System.Drawing.Size(65, 12);
            this.Showlabel.TabIndex = 5;
            this.Showlabel.Text = "输出结果：";
            // 
            // HighcheckBox
            // 
            this.HighcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HighcheckBox.AutoSize = true;
            this.HighcheckBox.Location = new System.Drawing.Point(787, 384);
            this.HighcheckBox.Name = "HighcheckBox";
            this.HighcheckBox.Size = new System.Drawing.Size(72, 16);
            this.HighcheckBox.TabIndex = 6;
            this.HighcheckBox.Text = "高级检索";
            this.HighcheckBox.UseVisualStyleBackColor = true;
            // 
            // CentercheckBox
            // 
            this.CentercheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CentercheckBox.AutoSize = true;
            this.CentercheckBox.Checked = true;
            this.CentercheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CentercheckBox.Location = new System.Drawing.Point(787, 406);
            this.CentercheckBox.Name = "CentercheckBox";
            this.CentercheckBox.Size = new System.Drawing.Size(72, 16);
            this.CentercheckBox.TabIndex = 7;
            this.CentercheckBox.Text = "窗口居中";
            this.CentercheckBox.UseVisualStyleBackColor = true;
            // 
            // WincomboBox
            // 
            this.WincomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WincomboBox.FormattingEnabled = true;
            this.WincomboBox.Location = new System.Drawing.Point(865, 403);
            this.WincomboBox.Name = "WincomboBox";
            this.WincomboBox.Size = new System.Drawing.Size(140, 20);
            this.WincomboBox.TabIndex = 8;
            this.WincomboBox.SelectedIndexChanged += new System.EventHandler(this.WincomboBox_SelectedIndexChanged);
            // 
            // ProcesslistView
            // 
            this.ProcesslistView.AllowColumnReorder = true;
            this.ProcesslistView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcesslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHId,
            this.CHProcessName,
            this.CHPMainWindowTitle,
            this.CHHandle,
            this.CHPMainHandle});
            this.ProcesslistView.GridLines = true;
            this.ProcesslistView.HideSelection = false;
            this.ProcesslistView.LabelEdit = true;
            this.ProcesslistView.Location = new System.Drawing.Point(3, 177);
            this.ProcesslistView.MultiSelect = false;
            this.ProcesslistView.Name = "ProcesslistView";
            this.ProcesslistView.Size = new System.Drawing.Size(731, 169);
            this.ProcesslistView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ProcesslistView.TabIndex = 9;
            this.ProcesslistView.UseCompatibleStateImageBehavior = false;
            this.ProcesslistView.View = System.Windows.Forms.View.Details;
            // 
            // CHId
            // 
            this.CHId.Text = "Id";
            this.CHId.Width = 63;
            // 
            // CHProcessName
            // 
            this.CHProcessName.Text = "ProcessName";
            this.CHProcessName.Width = 100;
            // 
            // CHPMainWindowTitle
            // 
            this.CHPMainWindowTitle.Text = "MainWindowTitle";
            this.CHPMainWindowTitle.Width = 379;
            // 
            // CHHandle
            // 
            this.CHHandle.Text = "Handle";
            this.CHHandle.Width = 50;
            // 
            // CHPMainHandle
            // 
            this.CHPMainHandle.Text = "MainHandle";
            this.CHPMainHandle.Width = 83;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 355);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ProcesslistView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ProslistBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(737, 349);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(769, 411);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(763, 44);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(737, 38);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 32);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "进程包含名称：";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(550, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(3, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 20);
            this.button3.TabIndex = 0;
            this.button3.Text = "搜索";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(665, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 32);
            this.panel2.TabIndex = 13;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 434);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.WincomboBox);
            this.Controls.Add(this.CentercheckBox);
            this.Controls.Add(this.HighcheckBox);
            this.Controls.Add(this.Showlabel);
            this.Controls.Add(this.Mainlabel);
            this.Controls.Add(this.Itemlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(751, 330);
            this.Name = "Form";
            this.Text = "窗口位置调整";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProslistBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.Label Showlabel;
        private System.Windows.Forms.CheckBox HighcheckBox;
        private System.Windows.Forms.CheckBox CentercheckBox;
        private System.Windows.Forms.ComboBox WincomboBox;
        private System.Windows.Forms.ListView ProcesslistView;
        private System.Windows.Forms.ColumnHeader CHId;
        private System.Windows.Forms.ColumnHeader CHProcessName;
        private System.Windows.Forms.ColumnHeader CHHandle;
        private System.Windows.Forms.ColumnHeader CHPMainWindowTitle;
        private System.Windows.Forms.ColumnHeader CHPMainHandle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

