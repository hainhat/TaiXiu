namespace TaiXiu
{
    partial class Form1
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.ColumnHeader columnHeader4;
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.rbtTai = new System.Windows.Forms.RadioButton();
            this.rbtXiu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btRoll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listHistory = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Lần chơi";
            columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Điểm";
            columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đặt cược";
            columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kết quả";
            columnHeader4.Width = 123;
            // 
            // pic1
            // 
            this.pic1.Image = global::TaiXiu.Properties.Resources._1;
            this.pic1.Location = new System.Drawing.Point(81, 29);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 98);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::TaiXiu.Properties.Resources._1;
            this.pic2.Location = new System.Drawing.Point(229, 29);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(100, 98);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 0;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::TaiXiu.Properties.Resources._1;
            this.pic3.Location = new System.Drawing.Point(379, 29);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(100, 98);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 0;
            this.pic3.TabStop = false;
            // 
            // rbtTai
            // 
            this.rbtTai.AutoSize = true;
            this.rbtTai.Checked = true;
            this.rbtTai.Location = new System.Drawing.Point(15, 207);
            this.rbtTai.Name = "rbtTai";
            this.rbtTai.Size = new System.Drawing.Size(91, 20);
            this.rbtTai.TabIndex = 1;
            this.rbtTai.TabStop = true;
            this.rbtTai.Text = "Tài (11-18)";
            this.rbtTai.UseVisualStyleBackColor = true;
            // 
            // rbtXiu
            // 
            this.rbtXiu.AutoSize = true;
            this.rbtXiu.Location = new System.Drawing.Point(15, 243);
            this.rbtXiu.Name = "rbtXiu";
            this.rbtXiu.Size = new System.Drawing.Size(82, 20);
            this.rbtXiu.TabIndex = 1;
            this.rbtXiu.Text = "Xỉu (3-10)";
            this.rbtXiu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài hay Xỉu ???";
            // 
            // btRoll
            // 
            this.btRoll.Location = new System.Drawing.Point(229, 156);
            this.btRoll.Name = "btRoll";
            this.btRoll.Size = new System.Drawing.Size(100, 32);
            this.btRoll.TabIndex = 3;
            this.btRoll.Text = "Thảy ";
            this.btRoll.UseVisualStyleBackColor = true;
            this.btRoll.Click += new System.EventHandler(this.btRoll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền hiện tại";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(85, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 358);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBet);
            this.tabPage1.Controls.Add(this.txtCurrent);
            this.tabPage1.Controls.Add(this.pic1);
            this.tabPage1.Controls.Add(this.pic2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pic3);
            this.tabPage1.Controls.Add(this.btRoll);
            this.tabPage1.Controls.Add(this.rbtTai);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbtXiu);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(560, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tỉu Xài";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBet
            // 
            this.txtBet.Location = new System.Drawing.Point(437, 240);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 22);
            this.txtBet.TabIndex = 5;
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(437, 206);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.ReadOnly = true;
            this.txtCurrent.Size = new System.Drawing.Size(100, 22);
            this.txtCurrent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiền cược";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(560, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listHistory
            // 
            this.listHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3,
            columnHeader4});
            this.listHistory.HideSelection = false;
            this.listHistory.Location = new System.Drawing.Point(0, 0);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(560, 326);
            this.listHistory.TabIndex = 0;
            this.listHistory.UseCompatibleStateImageBehavior = false;
            this.listHistory.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Copyright by Tuôi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìu Xải";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.RadioButton rbtTai;
        private System.Windows.Forms.RadioButton rbtXiu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listHistory;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

