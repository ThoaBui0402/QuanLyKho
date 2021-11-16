namespace QuanLyKho
{
    partial class Item_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Store));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtpkDayOfBill = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gctListItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlTb = new System.Windows.Forms.Panel();
            this.nudStored = new System.Windows.Forms.NumericUpDown();
            this.pnlPriceIn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceIn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.tbOnce = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStored)).BeginInit();
            this.pnlPriceIn.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1588, 719);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(414, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1171, 713);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(6, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(858, 703);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpkDayOfBill);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 150);
            this.panel5.TabIndex = 63;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dtpkDayOfBill
            // 
            this.dtpkDayOfBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDayOfBill.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDayOfBill.Location = new System.Drawing.Point(681, 38);
            this.dtpkDayOfBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDayOfBill.Name = "dtpkDayOfBill";
            this.dtpkDayOfBill.Size = new System.Drawing.Size(134, 27);
            this.dtpkDayOfBill.TabIndex = 57;
            this.dtpkDayOfBill.ValueChanged += new System.EventHandler(this.dtpkDayOfBill_ValueChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(357, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(227, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Danh sách mặt hàng";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(510, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(267, 26);
            this.label16.TabIndex = 56;
            this.label16.Text = "Tìm kiếm theo ngày:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gctListItem);
            this.panel8.Location = new System.Drawing.Point(3, 158);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(816, 543);
            this.panel8.TabIndex = 0;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // gctListItem
            // 
            this.gctListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctListItem.Location = new System.Drawing.Point(0, 0);
            this.gctListItem.MainView = this.gridView1;
            this.gctListItem.Name = "gctListItem";
            this.gctListItem.Size = new System.Drawing.Size(816, 543);
            this.gctListItem.TabIndex = 0;
            this.gctListItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gctListItem;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 706);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnlTb);
            this.panel7.Controls.Add(this.pnlBtn);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 702);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pnlTb
            // 
            this.pnlTb.Controls.Add(this.nudStored);
            this.pnlTb.Controls.Add(this.pnlPriceIn);
            this.pnlTb.Controls.Add(this.label14);
            this.pnlTb.Controls.Add(this.lbNumber);
            this.pnlTb.Controls.Add(this.tbItemID);
            this.pnlTb.Controls.Add(this.tbOnce);
            this.pnlTb.Controls.Add(this.label11);
            this.pnlTb.Controls.Add(this.label13);
            this.pnlTb.Controls.Add(this.tbItemName);
            this.pnlTb.Location = new System.Drawing.Point(3, 39);
            this.pnlTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTb.Name = "pnlTb";
            this.pnlTb.Size = new System.Drawing.Size(291, 260);
            this.pnlTb.TabIndex = 59;
            this.pnlTb.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTb_Paint);
            // 
            // nudStored
            // 
            this.nudStored.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStored.Location = new System.Drawing.Point(146, 58);
            this.nudStored.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudStored.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStored.Name = "nudStored";
            this.nudStored.Size = new System.Drawing.Size(134, 27);
            this.nudStored.TabIndex = 59;
            this.nudStored.ValueChanged += new System.EventHandler(this.nudStored_ValueChanged);
            // 
            // pnlPriceIn
            // 
            this.pnlPriceIn.Controls.Add(this.label3);
            this.pnlPriceIn.Controls.Add(this.tbPriceIn);
            this.pnlPriceIn.Location = new System.Drawing.Point(3, 182);
            this.pnlPriceIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPriceIn.Name = "pnlPriceIn";
            this.pnlPriceIn.Size = new System.Drawing.Size(267, 34);
            this.pnlPriceIn.TabIndex = 58;
            this.pnlPriceIn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPriceIn_Paint);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Giá :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbPriceIn
            // 
            this.tbPriceIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPriceIn.Location = new System.Drawing.Point(143, 0);
            this.tbPriceIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPriceIn.Name = "tbPriceIn";
            this.tbPriceIn.Size = new System.Drawing.Size(121, 27);
            this.tbPriceIn.TabIndex = 51;
            this.tbPriceIn.TextChanged += new System.EventHandler(this.tbPriceIn_TextChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(3, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 26);
            this.label14.TabIndex = 42;
            this.label14.Text = "Mã mặt hàng:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbNumber.Location = new System.Drawing.Point(3, 59);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(267, 26);
            this.lbNumber.TabIndex = 46;
            this.lbNumber.Text = "Số lượng tồn:";
            this.lbNumber.Click += new System.EventHandler(this.lbNumber_Click);
            // 
            // tbItemID
            // 
            this.tbItemID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemID.Location = new System.Drawing.Point(146, 21);
            this.tbItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(134, 27);
            this.tbItemID.TabIndex = 41;
            this.tbItemID.TextChanged += new System.EventHandler(this.tbItemID_TextChanged);
            // 
            // tbOnce
            // 
            this.tbOnce.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOnce.Location = new System.Drawing.Point(147, 134);
            this.tbOnce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOnce.Name = "tbOnce";
            this.tbOnce.Size = new System.Drawing.Size(133, 27);
            this.tbOnce.TabIndex = 47;
            this.tbOnce.TextChanged += new System.EventHandler(this.tbOnce_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(3, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 26);
            this.label11.TabIndex = 48;
            this.label11.Text = "Đơn vị tính:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 26);
            this.label13.TabIndex = 44;
            this.label13.Text = "Tên mặt hàng:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemName.Location = new System.Drawing.Point(147, 98);
            this.tbItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(133, 27);
            this.tbItemName.TabIndex = 43;
            this.tbItemName.TextChanged += new System.EventHandler(this.tbItemName_TextChanged);
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnAddNew);
            this.pnlBtn.Controls.Add(this.btnAdd);
            this.pnlBtn.Controls.Add(this.btnCancel);
            this.pnlBtn.Controls.Add(this.btnSave);
            this.pnlBtn.Location = new System.Drawing.Point(12, 347);
            this.pnlBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(283, 155);
            this.pnlBtn.TabIndex = 58;
            this.pnlBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBtn_Paint);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAddNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.ImageOptions.Image")));
            this.btnAddNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(16, 15);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(121, 48);
            this.btnAddNew.TabIndex = 81;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(177, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 48);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(19, 86);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 48);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(177, 86);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 48);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Chi tiết mặt hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // Item_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Item_Store";
            this.Text = "Mặt hàng";
            this.Load += new System.EventHandler(this.Item_Store_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlTb.ResumeLayout(false);
            this.pnlTb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStored)).EndInit();
            this.pnlPriceIn.ResumeLayout(false);
            this.pnlPriceIn.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtpkDayOfBill;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceIn;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Panel pnlPriceIn;
        private System.Windows.Forms.Panel pnlTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.TextBox tbOnce;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbItemName;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private System.Windows.Forms.NumericUpDown nudStored;
        private DevExpress.XtraGrid.GridControl gctListItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}