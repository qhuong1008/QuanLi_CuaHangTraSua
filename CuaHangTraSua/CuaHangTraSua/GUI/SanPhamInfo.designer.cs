
namespace CuaHangTraSua.GUI
{
    partial class SanPhamInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.BtnSua = new System.Windows.Forms.Button();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.BtnXacnhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.BtnXoa);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnXacnhan);
            this.groupBox1.Controls.Add(this.cbLoaiSP);
            this.groupBox1.Controls.Add(this.BtnSua);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(-9, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(159, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(148, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(60, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(58, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(229, 111);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(350, 36);
            this.txtTenSP.TabIndex = 20;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(229, 176);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(350, 36);
            this.txtGia.TabIndex = 21;
            // 
            // BtnSua
            // 
            this.BtnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSua.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.BtnSua.ForeColor = System.Drawing.Color.Navy;
            this.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSua.Location = new System.Drawing.Point(111, 307);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnSua.Size = new System.Drawing.Size(145, 60);
            this.BtnSua.TabIndex = 24;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Items.AddRange(new object[] {
            "L01 - Trà sữa",
            "L02 - Trà trái cây",
            "L03 - Cà phê",
            "L04 - Bánh ngọt"});
            this.cbLoaiSP.Location = new System.Drawing.Point(229, 238);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(350, 37);
            this.cbLoaiSP.TabIndex = 25;
            // 
            // BtnXacnhan
            // 
            this.BtnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXacnhan.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.BtnXacnhan.ForeColor = System.Drawing.Color.Navy;
            this.BtnXacnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXacnhan.Location = new System.Drawing.Point(434, 307);
            this.BtnXacnhan.Name = "BtnXacnhan";
            this.BtnXacnhan.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnXacnhan.Size = new System.Drawing.Size(145, 61);
            this.BtnXacnhan.TabIndex = 26;
            this.BtnXacnhan.Text = "Xác nhận";
            this.BtnXacnhan.UseVisualStyleBackColor = true;
            this.BtnXacnhan.Click += new System.EventHandler(this.BtnXacnhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(60, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(229, 51);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(350, 36);
            this.txtMaSP.TabIndex = 28;
            // 
            // BtnXoa
            // 
            this.BtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXoa.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.BtnXoa.ForeColor = System.Drawing.Color.Navy;
            this.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXoa.Location = new System.Drawing.Point(273, 307);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.BtnXoa.Size = new System.Drawing.Size(144, 61);
            this.BtnXoa.TabIndex = 29;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // SanPhamInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 418);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPhamInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemInfo";
            this.Load += new System.EventHandler(this.SanPhamInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnXacnhan;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
    }
}