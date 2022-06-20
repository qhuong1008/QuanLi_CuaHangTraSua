
namespace CuaHangTraSua.GUI
{
    partial class QuanLiMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnThemSP = new System.Windows.Forms.Label();
            this.SP_gridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SP_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(14, 38);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(600, 26);
            this.search.TabIndex = 4;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Thông tin sản phẩm";
            // 
            // BtnThemSP
            // 
            this.BtnThemSP.BackColor = System.Drawing.Color.Transparent;
            this.BtnThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThemSP.Image = global::CuaHangTraSua.Properties.Resources._32x32;
            this.BtnThemSP.Location = new System.Drawing.Point(628, 27);
            this.BtnThemSP.Name = "BtnThemSP";
            this.BtnThemSP.Size = new System.Drawing.Size(53, 48);
            this.BtnThemSP.TabIndex = 16;
            this.BtnThemSP.Click += new System.EventHandler(this.BtnThemSP_Click);
            // 
            // SP_gridview
            // 
            this.SP_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SP_gridview.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SP_gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SP_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SP_gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.SP_gridview.Location = new System.Drawing.Point(1, 83);
            this.SP_gridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SP_gridview.Name = "SP_gridview";
            this.SP_gridview.RowHeadersVisible = false;
            this.SP_gridview.RowHeadersWidth = 62;
            this.SP_gridview.RowTemplate.Height = 28;
            this.SP_gridview.Size = new System.Drawing.Size(1248, 472);
            this.SP_gridview.TabIndex = 17;
            this.SP_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfoSP_gridview_CellClick);
            this.SP_gridview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InfoSP_gridview_MouseClick);
            // 
            // QuanLiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 578);
            this.Controls.Add(this.SP_gridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnThemSP);
            this.Controls.Add(this.search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLiMenu";
            this.Text = "QuanLiMenu";
            this.Load += new System.EventHandler(this.QuanLiMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label BtnThemSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SP_gridview;
    }
}