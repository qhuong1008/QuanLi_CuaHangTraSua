
namespace CuaHangTraSua.GUI
{
    partial class ItemInfo
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
            this.cbSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtMota = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.ConfirmBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.cbSoluong);
            this.groupBox1.Controls.Add(this.txtMota);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(-9, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Thông tin";
            // 
            // cbSoluong
            // 
            this.cbSoluong.Location = new System.Drawing.Point(246, 177);
            this.cbSoluong.Name = "cbSoluong";
            this.cbSoluong.Size = new System.Drawing.Size(301, 36);
            this.cbSoluong.TabIndex = 11;
            this.cbSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cbSoluong.ValueChanged += new System.EventHandler(this.cbSoluong_ValueChanged);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(246, 242);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(449, 126);
            this.txtMota.TabIndex = 8;
            this.txtMota.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "(ví dụ: ít đường)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(143, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mô tả:";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.AutoSize = true;
            this.txtGiaSP.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtGiaSP.Location = new System.Drawing.Point(241, 115);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(77, 29);
            this.txtGiaSP.TabIndex = 4;
            this.txtGiaSP.Text = "60000";
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoSize = true;
            this.txtTenSP.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTenSP.Location = new System.Drawing.Point(241, 51);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(187, 29);
            this.txtTenSP.TabIndex = 3;
            this.txtTenSP.Text = "Trà sữa trà xanh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(60, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(60, 51);
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
            // ConfirmBtn
            // 
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.Navy;
            this.ConfirmBtn.Image = global::CuaHangTraSua.Properties.Resources._32x32;
            this.ConfirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmBtn.Location = new System.Drawing.Point(308, 393);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ConfirmBtn.Size = new System.Drawing.Size(183, 75);
            this.ConfirmBtn.TabIndex = 19;
            this.ConfirmBtn.Text = "Xác nhận ";
            this.ConfirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Bahnschrift", 11F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Image = global::CuaHangTraSua.Properties.Resources._32x322;
            this.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBtn.Location = new System.Drawing.Point(512, 393);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.DeleteBtn.Size = new System.Drawing.Size(183, 75);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Hủy       ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 479);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemInfo";
            this.Load += new System.EventHandler(this.ItemInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSoluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtMota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtGiaSP;
        private System.Windows.Forms.Label txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cbSoluong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}