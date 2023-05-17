namespace QLSV_1911060974_Hai
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.themtt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.suatt = new System.Windows.Forms.ToolStripButton();
            this.xoatt = new System.Windows.Forms.ToolStripButton();
            this.timkiem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.danhsachsv = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.txtHocphan = new System.Windows.Forms.TextBox();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.dgvQlsv = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlsv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themtt,
            this.suatt,
            this.xoatt,
            this.timkiem,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.danhsachsv});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // themtt
            // 
            this.themtt.Image = ((System.Drawing.Image)(resources.GetObject("themtt.Image")));
            this.themtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themtt.Name = "themtt";
            this.themtt.Size = new System.Drawing.Size(90, 24);
            this.themtt.Text = "&Thêm TT";
            this.themtt.Click += new System.EventHandler(this.themtt_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // suatt
            // 
            this.suatt.Image = ((System.Drawing.Image)(resources.GetObject("suatt.Image")));
            this.suatt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.suatt.Name = "suatt";
            this.suatt.Size = new System.Drawing.Size(78, 24);
            this.suatt.Text = "&Sửa TT";
            this.suatt.Click += new System.EventHandler(this.suatt_Click);
            // 
            // xoatt
            // 
            this.xoatt.Image = ((System.Drawing.Image)(resources.GetObject("xoatt.Image")));
            this.xoatt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xoatt.Name = "xoatt";
            this.xoatt.Size = new System.Drawing.Size(79, 24);
            this.xoatt.Text = "&Xóa TT";
            this.xoatt.Click += new System.EventHandler(this.xoatt_Click);
            // 
            // timkiem
            // 
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(96, 24);
            this.timkiem.Text = "&Tìm Kiếm";
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // danhsachsv
            // 
            this.danhsachsv.Image = ((System.Drawing.Image)(resources.GetObject("danhsachsv.Image")));
            this.danhsachsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.danhsachsv.Name = "danhsachsv";
            this.danhsachsv.Size = new System.Drawing.Size(126, 24);
            this.danhsachsv.Text = " &Danh sách SV";
            this.danhsachsv.Click += new System.EventHandler(this.danhsachsv_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Học Phần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lớp";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(178, 50);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(100, 22);
            this.txtMasv.TabIndex = 7;
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(178, 106);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.Size = new System.Drawing.Size(100, 22);
            this.txtTensv.TabIndex = 8;
            // 
            // txtHocphan
            // 
            this.txtHocphan.Location = new System.Drawing.Point(178, 163);
            this.txtHocphan.Name = "txtHocphan";
            this.txtHocphan.Size = new System.Drawing.Size(100, 22);
            this.txtHocphan.TabIndex = 9;
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Location = new System.Drawing.Point(412, 50);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(100, 22);
            this.txtMakhoa.TabIndex = 10;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(412, 106);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(100, 22);
            this.txtMalop.TabIndex = 11;
            // 
            // dgvQlsv
            // 
            this.dgvQlsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlsv.Location = new System.Drawing.Point(34, 213);
            this.dgvQlsv.Name = "dgvQlsv";
            this.dgvQlsv.RowHeadersWidth = 51;
            this.dgvQlsv.RowTemplate.Height = 24;
            this.dgvQlsv.Size = new System.Drawing.Size(733, 225);
            this.dgvQlsv.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvQlsv);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.txtMakhoa);
            this.Controls.Add(this.txtHocphan);
            this.Controls.Add(this.txtTensv);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Hai_1911906974";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton themtt;
        private System.Windows.Forms.ToolStripButton suatt;
        private System.Windows.Forms.ToolStripButton xoatt;
        private System.Windows.Forms.ToolStripButton timkiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton danhsachsv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.TextBox txtHocphan;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.DataGridView dgvQlsv;
    }
}

