namespace QuanLyDaiLy
{
    partial class Quan
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbldl = new System.Windows.Forms.GroupBox();
            this.txttq = new System.Windows.Forms.TextBox();
            this.txtmq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btntk = new System.Windows.Forms.Button();
            this.dataQuan = new System.Windows.Forms.DataGridView();
            this.btncn = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.grbldl.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cập Nhập Quận";
            // 
            // grbldl
            // 
            this.grbldl.Controls.Add(this.txttq);
            this.grbldl.Controls.Add(this.txtmq);
            this.grbldl.Controls.Add(this.label3);
            this.grbldl.Controls.Add(this.label2);
            this.grbldl.Location = new System.Drawing.Point(12, 88);
            this.grbldl.Name = "grbldl";
            this.grbldl.Size = new System.Drawing.Size(346, 134);
            this.grbldl.TabIndex = 1;
            this.grbldl.TabStop = false;
            this.grbldl.Text = "Thông tin chung";
            // 
            // txttq
            // 
            this.txttq.Location = new System.Drawing.Point(121, 79);
            this.txttq.Name = "txttq";
            this.txttq.Size = new System.Drawing.Size(218, 20);
            this.txttq.TabIndex = 3;
            // 
            // txtmq
            // 
            this.txtmq.Location = new System.Drawing.Point(121, 31);
            this.txtmq.Name = "txtmq";
            this.txtmq.Size = new System.Drawing.Size(218, 20);
            this.txtmq.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên quân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã quận:";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btncn);
            this.gb2.Controls.Add(this.btnxoa);
            this.gb2.Controls.Add(this.btnthoat);
            this.gb2.Controls.Add(this.btthem);
            this.gb2.Location = new System.Drawing.Point(12, 321);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(711, 63);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(565, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Đóng";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(109, 19);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.txttk);
            this.gb3.Controls.Add(this.btntk);
            this.gb3.Location = new System.Drawing.Point(12, 243);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(346, 63);
            this.gb3.TabIndex = 3;
            this.gb3.TabStop = false;
            this.gb3.Text = "Tìm kiếm";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(121, 25);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(218, 20);
            this.txttk.TabIndex = 4;
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(39, 23);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 0;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            // 
            // dataQuan
            // 
            this.dataQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuan.Location = new System.Drawing.Point(364, 88);
            this.dataQuan.Name = "dataQuan";
            this.dataQuan.Size = new System.Drawing.Size(359, 218);
            this.dataQuan.TabIndex = 4;
            this.dataQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQuan_CellClick);
            // 
            // btncn
            // 
            this.btncn.Location = new System.Drawing.Point(398, 20);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(75, 23);
            this.btncn.TabIndex = 5;
            this.btncn.Text = "Cập nhập";
            this.btncn.UseVisualStyleBackColor = true;
            this.btncn.Click += new System.EventHandler(this.btncn_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(237, 20);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Quan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 388);
            this.Controls.Add(this.dataQuan);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.grbldl);
            this.Controls.Add(this.label1);
            this.Name = "Quan";
            this.Text = "Quận";
            this.Load += new System.EventHandler(this.LoaiDaiLy_Load);
            this.grbldl.ResumeLayout(false);
            this.grbldl.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbldl;
        private System.Windows.Forms.TextBox txttq;
        private System.Windows.Forms.TextBox txtmq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.DataGridView dataQuan;
        private System.Windows.Forms.Button btncn;
        private System.Windows.Forms.Button btnxoa;
    }
}