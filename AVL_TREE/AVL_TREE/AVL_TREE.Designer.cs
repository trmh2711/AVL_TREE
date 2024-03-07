namespace AVL_TREE
{
    partial class AVL_TREE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_xoa_tree = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.label_dauvao = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_chonfile = new System.Windows.Forms.Button();
            this.txt_chonFile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xoa = new System.Windows.Forms.TextBox();
            this.cb_random = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_them = new System.Windows.Forms.TextBox();
            this.ShowPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_random)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.Location = new System.Drawing.Point(40, 150);
            this.btn_random.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(116, 46);
            this.btn_random.TabIndex = 4;
            this.btn_random.Text = "Tạo Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(205, 150);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 46);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(363, 150);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 46);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(520, 150);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(107, 46);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_xoa_tree
            // 
            this.btn_xoa_tree.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_tree.Location = new System.Drawing.Point(677, 150);
            this.btn_xoa_tree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa_tree.Name = "btn_xoa_tree";
            this.btn_xoa_tree.Size = new System.Drawing.Size(107, 46);
            this.btn_xoa_tree.TabIndex = 6;
            this.btn_xoa_tree.Text = "Xóa Cây";
            this.btn_xoa_tree.UseVisualStyleBackColor = true;
            this.btn_xoa_tree.Click += new System.EventHandler(this.btn_xoa_tree_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(809, 150);
            this.hScrollBar1.Maximum = 1000;
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hScrollBar1.Size = new System.Drawing.Size(520, 46);
            this.hScrollBar1.SmallChange = 10;
            this.hScrollBar1.TabIndex = 28;
            this.hScrollBar1.Value = 500;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // ShowPanel
            // 
            this.ShowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowPanel.Controls.Add(this.label_dauvao);
            this.ShowPanel.Location = new System.Drawing.Point(9, 9);
            this.ShowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(1531, 347);
            this.ShowPanel.TabIndex = 29;
            this.ShowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowPanel_Paint);
            // 
            // label_dauvao
            // 
            this.label_dauvao.AutoSize = true;
            this.label_dauvao.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dauvao.Location = new System.Drawing.Point(7, 9);
            this.label_dauvao.Name = "label_dauvao";
            this.label_dauvao.Size = new System.Drawing.Size(60, 25);
            this.label_dauvao.TabIndex = 0;
            this.label_dauvao.Text = "        ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.hScrollBar1);
            this.panel2.Controls.Add(this.btn_tim);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_xoa_tree);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.btn_random);
            this.panel2.Location = new System.Drawing.Point(9, 359);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 249);
            this.panel2.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.91388F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.08612F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_chonfile, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_chonFile, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(523, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Đọc từ file";
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chonfile.Location = new System.Drawing.Point(406, 2);
            this.btn_chonfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Size = new System.Drawing.Size(75, 23);
            this.btn_chonfile.TabIndex = 27;
            this.btn_chonfile.Text = "Chọn File";
            this.btn_chonfile.UseVisualStyleBackColor = true;
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click);
            // 
            // txt_chonFile
            // 
            this.txt_chonFile.Location = new System.Drawing.Point(212, 2);
            this.txt_chonFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_chonFile.Name = "txt_chonFile";
            this.txt_chonFile.Size = new System.Drawing.Size(188, 22);
            this.txt_chonFile.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.68965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.31034F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Controls.Add(this.txt_tim, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_xoa, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_random, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_them, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1525, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(1378, 2);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(60, 22);
            this.txt_tim.TabIndex = 5;
            this.txt_tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tim_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn số node muốn tạo random";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1083, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhập vào Node muốn tìm";
            // 
            // txt_xoa
            // 
            this.txt_xoa.Location = new System.Drawing.Point(1005, 2);
            this.txt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_xoa.Name = "txt_xoa";
            this.txt_xoa.Size = new System.Drawing.Size(60, 22);
            this.txt_xoa.TabIndex = 23;
            this.txt_xoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_xoa_KeyDown);
            // 
            // cb_random
            // 
            this.cb_random.Location = new System.Drawing.Point(202, 4);
            this.cb_random.Margin = new System.Windows.Forms.Padding(4);
            this.cb_random.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cb_random.Name = "cb_random";
            this.cb_random.Size = new System.Drawing.Size(60, 22);
            this.cb_random.TabIndex = 16;
            this.cb_random.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhập vào Node muốn thêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhập vào Node muốn xóa";
            // 
            // txt_them
            // 
            this.txt_them.Location = new System.Drawing.Point(573, 2);
            this.txt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_them.Name = "txt_them";
            this.txt_them.Size = new System.Drawing.Size(60, 22);
            this.txt_them.TabIndex = 21;
            this.txt_them.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_them_KeyDown);
            // 
            // AVL_TREE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 619);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AVL_TREE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVL_TREE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AVL_TREE_Load);
            this.SizeChanged += new System.EventHandler(this.AVL_TREE_SizeChanged);
            this.ShowPanel.ResumeLayout(false);
            this.ShowPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_random)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_xoa_tree;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cb_random;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_chonfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chonFile;
        private System.Windows.Forms.TextBox txt_xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_dauvao;
        public System.Windows.Forms.Panel ShowPanel;
    }
}