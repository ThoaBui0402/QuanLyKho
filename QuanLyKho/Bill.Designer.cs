
namespace QuanLyKho
{
     partial class Bill
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

          #region Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
               this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
               this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
               this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
               this.lbEmployeesName = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
               this.lbCustomerName = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
               this.lbBillDate = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
               this.lbBillID = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
               this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
               this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
               this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
               this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
               this.lbEmployeesGive = new DevExpress.XtraReports.UI.XRLabel();
               this.lbCustomerGive = new DevExpress.XtraReports.UI.XRLabel();
               this.lbTotalPrice = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
               this.Detail = new DevExpress.XtraReports.UI.DetailBand();
               this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
               this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
               this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
               this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
               ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
               // 
               // TopMargin
               // 
               this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrTable1});
               this.TopMargin.HeightF = 238.5F;
               this.TopMargin.Name = "TopMargin";
               // 
               // xrPanel1
               // 
               this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrPanel2,
            this.xrLabel3});
               this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
               this.xrPanel1.Name = "xrPanel1";
               this.xrPanel1.SizeF = new System.Drawing.SizeF(627F, 170.0001F);
               // 
               // xrPanel3
               // 
               this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbEmployeesName,
            this.xrLabel7,
            this.lbCustomerName,
            this.xrLabel9});
               this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 86.00001F);
               this.xrPanel3.Name = "xrPanel3";
               this.xrPanel3.SizeF = new System.Drawing.SizeF(365.8333F, 76.66676F);
               // 
               // lbEmployeesName
               // 
               this.lbEmployeesName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?EmployeesName")});
               this.lbEmployeesName.LocationFloat = new DevExpress.Utils.PointFloat(130.8333F, 44.16677F);
               this.lbEmployeesName.Name = "lbEmployeesName";
               this.lbEmployeesName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbEmployeesName.SizeF = new System.Drawing.SizeF(235F, 23.00003F);
               // 
               // xrLabel7
               // 
               this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.16677F);
               this.xrLabel7.Name = "xrLabel7";
               this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel7.SizeF = new System.Drawing.SizeF(113.3333F, 22.50003F);
               this.xrLabel7.StylePriority.UseFont = false;
               this.xrLabel7.Text = "Tên nhân viên:";
               // 
               // lbCustomerName
               // 
               this.lbCustomerName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CustomerName")});
               this.lbCustomerName.LocationFloat = new DevExpress.Utils.PointFloat(130.8333F, 9.000092F);
               this.lbCustomerName.Name = "lbCustomerName";
               this.lbCustomerName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbCustomerName.SizeF = new System.Drawing.SizeF(235F, 23F);
               // 
               // xrLabel9
               // 
               this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.500072F);
               this.xrLabel9.Name = "xrLabel9";
               this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel9.SizeF = new System.Drawing.SizeF(123.3333F, 22.50001F);
               this.xrLabel9.StylePriority.UseFont = false;
               this.xrLabel9.Text = "Tên khách hàng:";
               // 
               // xrPanel2
               // 
               this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbBillDate,
            this.xrLabel6,
            this.lbBillID,
            this.xrLabel4});
               this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(369.3333F, 86.00001F);
               this.xrPanel2.Name = "xrPanel2";
               this.xrPanel2.SizeF = new System.Drawing.SizeF(235F, 76.66676F);
               // 
               // lbBillDate
               // 
               this.lbBillDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?DateOfBill")});
               this.lbBillDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbBillDate.LocationFloat = new DevExpress.Utils.PointFloat(120F, 43.66679F);
               this.lbBillDate.Name = "lbBillDate";
               this.lbBillDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbBillDate.SizeF = new System.Drawing.SizeF(105F, 22.99998F);
               this.lbBillDate.StylePriority.UseFont = false;
               // 
               // xrLabel6
               // 
               this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 44.16677F);
               this.xrLabel6.Name = "xrLabel6";
               this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel6.SizeF = new System.Drawing.SizeF(111.6666F, 22.50003F);
               this.xrLabel6.StylePriority.UseFont = false;
               this.xrLabel6.Text = "Ngày hóa đơn:";
               // 
               // lbBillID
               // 
               this.lbBillID.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdBill]")});
               this.lbBillID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbBillID.LocationFloat = new DevExpress.Utils.PointFloat(120F, 9.500046F);
               this.lbBillID.Name = "lbBillID";
               this.lbBillID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbBillID.SizeF = new System.Drawing.SizeF(105F, 23F);
               this.lbBillID.StylePriority.UseFont = false;
               // 
               // xrLabel4
               // 
               this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
               this.xrLabel4.Name = "xrLabel4";
               this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel4.SizeF = new System.Drawing.SizeF(111.6666F, 22.50005F);
               this.xrLabel4.StylePriority.UseFont = false;
               this.xrLabel4.Text = "Số hóa đơn: ";
               // 
               // xrLabel3
               // 
               this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel3.ForeColor = System.Drawing.Color.Red;
               this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(140.8333F, 10F);
               this.xrLabel3.Name = "xrLabel3";
               this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel3.SizeF = new System.Drawing.SizeF(352.5001F, 41.33334F);
               this.xrLabel3.StylePriority.UseFont = false;
               this.xrLabel3.StylePriority.UseForeColor = false;
               this.xrLabel3.StylePriority.UseTextAlignment = false;
               this.xrLabel3.Text = "HÓA ĐƠN BÁN HÀNG";
               this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
               // 
               // xrTable1
               // 
               this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
               this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 185.0001F);
               this.xrTable1.Name = "xrTable1";
               this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
               this.xrTable1.SizeF = new System.Drawing.SizeF(627.0001F, 41.83319F);
               this.xrTable1.StylePriority.UseBorders = false;
               this.xrTable1.StylePriority.UseFont = false;
               // 
               // xrTableRow1
               // 
               this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell6,
            this.xrTableCell5,
            this.xrTableCell14,
            this.xrTableCell4});
               this.xrTableRow1.Name = "xrTableRow1";
               this.xrTableRow1.Weight = 1D;
               // 
               // xrTableCell1
               // 
               this.xrTableCell1.Name = "xrTableCell1";
               this.xrTableCell1.Text = "STT";
               this.xrTableCell1.Weight = 0.42499996185302735D;
               // 
               // xrTableCell2
               // 
               this.xrTableCell2.Name = "xrTableCell2";
               this.xrTableCell2.Text = "Mã mặt hàng";
               this.xrTableCell2.Weight = 0.9083329932632197D;
               // 
               // xrTableCell3
               // 
               this.xrTableCell3.Name = "xrTableCell3";
               this.xrTableCell3.Text = "Tên mặt hàng";
               this.xrTableCell3.Weight = 1.5750006236012761D;
               // 
               // xrTableCell6
               // 
               this.xrTableCell6.Name = "xrTableCell6";
               this.xrTableCell6.Text = "Giá(vnd)";
               this.xrTableCell6.Weight = 0.95166697845257842D;
               // 
               // xrTableCell5
               // 
               this.xrTableCell5.Name = "xrTableCell5";
               this.xrTableCell5.Text = "Số lượng";
               this.xrTableCell5.Weight = 0.6583328907989453D;
               // 
               // xrTableCell14
               // 
               this.xrTableCell14.Name = "xrTableCell14";
               this.xrTableCell14.Text = "Giảm giá";
               this.xrTableCell14.Weight = 0.6766666441155641D;
               // 
               // xrTableCell4
               // 
               this.xrTableCell4.Name = "xrTableCell4";
               this.xrTableCell4.Text = "Tổng giá(vnd)";
               this.xrTableCell4.Weight = 1.0750011083194893D;
               // 
               // BottomMargin
               // 
               this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12,
            this.xrPanel4,
            this.xrLabel11});
               this.BottomMargin.HeightF = 121F;
               this.BottomMargin.Name = "BottomMargin";
               // 
               // xrLabel12
               // 
               this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(461.8333F, 0F);
               this.xrLabel12.Name = "xrLabel12";
               this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel12.SizeF = new System.Drawing.SizeF(159.1667F, 23F);
               this.xrLabel12.StylePriority.UseFont = false;
               this.xrLabel12.Text = "Chữ ký của nhân viên:";
               // 
               // xrPanel4
               // 
               this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbEmployeesGive,
            this.lbCustomerGive,
            this.lbTotalPrice,
            this.xrLabel10,
            this.xrLabel8,
            this.xrLabel5});
               this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 1.833344F);
               this.xrPanel4.Name = "xrPanel4";
               this.xrPanel4.SizeF = new System.Drawing.SizeF(312.5F, 69.16666F);
               // 
               // lbEmployeesGive
               // 
               this.lbEmployeesGive.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?EmployeesGive")});
               this.lbEmployeesGive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbEmployeesGive.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 42.33333F);
               this.lbEmployeesGive.Name = "lbEmployeesGive";
               this.lbEmployeesGive.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbEmployeesGive.SizeF = new System.Drawing.SizeF(130.8333F, 21.16666F);
               this.lbEmployeesGive.StylePriority.UseFont = false;
               // 
               // lbCustomerGive
               // 
               this.lbCustomerGive.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?CustomerGive")});
               this.lbCustomerGive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbCustomerGive.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 21.16666F);
               this.lbCustomerGive.Name = "lbCustomerGive";
               this.lbCustomerGive.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbCustomerGive.SizeF = new System.Drawing.SizeF(130.8333F, 21.16666F);
               this.lbCustomerGive.StylePriority.UseFont = false;
               // 
               // lbTotalPrice
               // 
               this.lbTotalPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?TotalPriceBill")});
               this.lbTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.lbTotalPrice.LocationFloat = new DevExpress.Utils.PointFloat(172.5F, 0F);
               this.lbTotalPrice.Name = "lbTotalPrice";
               this.lbTotalPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.lbTotalPrice.SizeF = new System.Drawing.SizeF(130.8333F, 21.16666F);
               this.lbTotalPrice.StylePriority.UseFont = false;
               // 
               // xrLabel10
               // 
               this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(10F, 42.33332F);
               this.xrLabel10.Name = "xrLabel10";
               this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel10.SizeF = new System.Drawing.SizeF(152.5F, 21.16667F);
               this.xrLabel10.StylePriority.UseFont = false;
               this.xrLabel10.Text = "Tiền trả lại:";
               // 
               // xrLabel8
               // 
               this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10F, 21.16669F);
               this.xrLabel8.Name = "xrLabel8";
               this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel8.SizeF = new System.Drawing.SizeF(152.5F, 21.16666F);
               this.xrLabel8.StylePriority.UseFont = false;
               this.xrLabel8.Text = "Tiền khách đưa:";
               // 
               // xrLabel5
               // 
               this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
               this.xrLabel5.Name = "xrLabel5";
               this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel5.SizeF = new System.Drawing.SizeF(152.5F, 21.16666F);
               this.xrLabel5.StylePriority.UseFont = false;
               this.xrLabel5.Text = "Tổng tiền thanh toán:";
               // 
               // xrLabel11
               // 
               this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.xrLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
               this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(182.5F, 89.66665F);
               this.xrLabel11.Multiline = true;
               this.xrLabel11.Name = "xrLabel11";
               this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel11.SizeF = new System.Drawing.SizeF(294.1667F, 31.33334F);
               this.xrLabel11.StylePriority.UseFont = false;
               this.xrLabel11.StylePriority.UseForeColor = false;
               this.xrLabel11.Text = "Xin chân thành cảm ơn quý khách!\r\n";
               // 
               // Detail
               // 
               this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
               this.Detail.HeightF = 31.49999F;
               this.Detail.Name = "Detail";
               // 
               // xrTable2
               // 
               this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
               this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
               this.xrTable2.Name = "xrTable2";
               this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
               this.xrTable2.SizeF = new System.Drawing.SizeF(627F, 24.99997F);
               this.xrTable2.StylePriority.UseBorders = false;
               // 
               // xrTableRow2
               // 
               this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell13,
            this.xrTableCell12});
               this.xrTableRow2.Name = "xrTableRow2";
               this.xrTableRow2.Weight = 1D;
               // 
               // xrTableCell7
               // 
               this.xrTableCell7.Name = "xrTableCell7";
               xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
               xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
               this.xrTableCell7.Summary = xrSummary1;
               this.xrTableCell7.Text = "STT";
               this.xrTableCell7.Weight = 0.42499996185302735D;
               // 
               // xrTableCell8
               // 
               this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdItem]")});
               this.xrTableCell8.Name = "xrTableCell8";
               this.xrTableCell8.Weight = 0.9083330776692139D;
               // 
               // xrTableCell9
               // 
               this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemName]")});
               this.xrTableCell9.Name = "xrTableCell9";
               this.xrTableCell9.Weight = 1.5750002340194722D;
               // 
               // xrTableCell10
               // 
               this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PriceItem]")});
               this.xrTableCell10.Name = "xrTableCell10";
               this.xrTableCell10.Weight = 0.95166728362838815D;
               // 
               // xrTableCell11
               // 
               this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NumOfItem]")});
               this.xrTableCell11.Name = "xrTableCell11";
               this.xrTableCell11.Weight = 0.6583322804473255D;
               // 
               // xrTableCell13
               // 
               this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")});
               this.xrTableCell13.Name = "xrTableCell13";
               this.xrTableCell13.Weight = 0.67666754828608822D;
               // 
               // xrTableCell12
               // 
               this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalPriceItem]")});
               this.xrTableCell12.Name = "xrTableCell12";
               this.xrTableCell12.Weight = 1.0750002041489648D;
               // 
               // Bill
               // 
               this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
               this.Font = new System.Drawing.Font("Arial", 9.75F);
               this.Margins = new System.Drawing.Printing.Margins(99, 100, 239, 121);
               this.Version = "19.2";
               ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

          }

          #endregion

          private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
          private DevExpress.XtraReports.UI.XRPanel xrPanel1;
          private DevExpress.XtraReports.UI.XRPanel xrPanel3;
          private DevExpress.XtraReports.UI.XRLabel lbEmployeesName;
          private DevExpress.XtraReports.UI.XRLabel xrLabel7;
          private DevExpress.XtraReports.UI.XRLabel lbCustomerName;
          private DevExpress.XtraReports.UI.XRLabel xrLabel9;
          private DevExpress.XtraReports.UI.XRPanel xrPanel2;
          private DevExpress.XtraReports.UI.XRLabel lbBillDate;
          private DevExpress.XtraReports.UI.XRLabel xrLabel6;
          private DevExpress.XtraReports.UI.XRLabel lbBillID;
          private DevExpress.XtraReports.UI.XRLabel xrLabel4;
          private DevExpress.XtraReports.UI.XRLabel xrLabel3;
          private DevExpress.XtraReports.UI.XRTable xrTable1;
          private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
          private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
          private DevExpress.XtraReports.UI.XRLabel xrLabel12;
          private DevExpress.XtraReports.UI.XRPanel xrPanel4;
          private DevExpress.XtraReports.UI.XRLabel lbEmployeesGive;
          private DevExpress.XtraReports.UI.XRLabel lbCustomerGive;
          private DevExpress.XtraReports.UI.XRLabel lbTotalPrice;
          private DevExpress.XtraReports.UI.XRLabel xrLabel10;
          private DevExpress.XtraReports.UI.XRLabel xrLabel8;
          private DevExpress.XtraReports.UI.XRLabel xrLabel5;
          private DevExpress.XtraReports.UI.XRLabel xrLabel11;
          private DevExpress.XtraReports.UI.DetailBand Detail;
          private DevExpress.XtraReports.UI.XRTable xrTable2;
          private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
          private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
     }
}
