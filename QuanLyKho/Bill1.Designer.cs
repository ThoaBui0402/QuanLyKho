
namespace QuanLyKho
{
     partial class Bill1
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
               this.components = new System.ComponentModel.Container();
               DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
               DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new DevExpress.DataAccess.ObjectBinding.Parameter();
               DevExpress.DataAccess.ObjectBinding.Parameter parameter2 = new DevExpress.DataAccess.ObjectBinding.Parameter();
               DevExpress.DataAccess.ObjectBinding.Parameter parameter3 = new DevExpress.DataAccess.ObjectBinding.Parameter();
               DevExpress.DataAccess.ObjectBinding.Parameter parameter4 = new DevExpress.DataAccess.ObjectBinding.Parameter();
               DevExpress.DataAccess.ObjectBinding.Parameter parameter5 = new DevExpress.DataAccess.ObjectBinding.Parameter();
               this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
               this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
               this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
               this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
               this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
               this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
               this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
               this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
               this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
               this.Detail = new DevExpress.XtraReports.UI.DetailBand();
               this.table1 = new DevExpress.XtraReports.UI.XRTable();
               this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
               this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
               this.table2 = new DevExpress.XtraReports.UI.XRTable();
               this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
               this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
               this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
               ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
               // 
               // objectDataSource1
               // 
               parameter1.Name = "_idBill";
               parameter1.Type = typeof(int);
               parameter1.ValueInfo = "0";
               parameter2.Name = "_idItem";
               parameter2.Type = typeof(int);
               parameter2.ValueInfo = "0";
               parameter3.Name = "_itemName";
               parameter3.Type = typeof(string);
               parameter4.Name = "_price";
               parameter4.Type = typeof(int);
               parameter4.ValueInfo = "0";
               parameter5.Name = "_numOfItem";
               parameter5.Type = typeof(int);
               parameter5.ValueInfo = "0";
               objectConstructorInfo1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1,
            parameter2,
            parameter3,
            parameter4,
            parameter5});
               this.objectDataSource1.Constructor = objectConstructorInfo1;
               this.objectDataSource1.DataSource = typeof(QuanLyKho.IssueVouDetailMod);
               this.objectDataSource1.Name = "objectDataSource1";
               // 
               // Title
               // 
               this.Title.BackColor = System.Drawing.Color.Transparent;
               this.Title.BorderColor = System.Drawing.Color.Black;
               this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
               this.Title.BorderWidth = 1F;
               this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
               this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
               this.Title.Name = "Title";
               // 
               // DetailCaption1
               // 
               this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
               this.DetailCaption1.BorderColor = System.Drawing.Color.White;
               this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
               this.DetailCaption1.BorderWidth = 2F;
               this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
               this.DetailCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
               this.DetailCaption1.Name = "DetailCaption1";
               this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
               this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
               // 
               // DetailData1
               // 
               this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
               this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
               this.DetailData1.BorderWidth = 2F;
               this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
               this.DetailData1.ForeColor = System.Drawing.Color.Black;
               this.DetailData1.Name = "DetailData1";
               this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
               this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
               // 
               // DetailData3_Odd
               // 
               this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
               this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
               this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
               this.DetailData3_Odd.BorderWidth = 1F;
               this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
               this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
               this.DetailData3_Odd.Name = "DetailData3_Odd";
               this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
               this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
               // 
               // PageInfo
               // 
               this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
               this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
               this.PageInfo.Name = "PageInfo";
               this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               // 
               // TopMargin
               // 
               this.TopMargin.Name = "TopMargin";
               // 
               // BottomMargin
               // 
               this.BottomMargin.Name = "BottomMargin";
               // 
               // GroupHeader1
               // 
               this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
               this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
               this.GroupHeader1.HeightF = 28F;
               this.GroupHeader1.Name = "GroupHeader1";
               // 
               // Detail
               // 
               this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
               this.Detail.HeightF = 25F;
               this.Detail.Name = "Detail";
               // 
               // table1
               // 
               this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
               this.table1.Name = "table1";
               this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
               this.table1.SizeF = new System.Drawing.SizeF(900F, 28F);
               // 
               // tableRow1
               // 
               this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6});
               this.tableRow1.Name = "tableRow1";
               this.tableRow1.Weight = 1D;
               // 
               // tableCell1
               // 
               this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
               this.tableCell1.Name = "tableCell1";
               this.tableCell1.StyleName = "DetailCaption1";
               this.tableCell1.StylePriority.UseBorders = false;
               this.tableCell1.StylePriority.UseTextAlignment = false;
               this.tableCell1.Text = "STT";
               this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell1.Weight = 0.12180262247721355D;
               // 
               // tableCell2
               // 
               this.tableCell2.Name = "tableCell2";
               this.tableCell2.StyleName = "DetailCaption1";
               this.tableCell2.StylePriority.UseTextAlignment = false;
               this.tableCell2.Text = "Mã mặt hàng";
               this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell2.Weight = 0.1081089358859592D;
               // 
               // tableCell3
               // 
               this.tableCell3.Name = "tableCell3";
               this.tableCell3.StyleName = "DetailCaption1";
               this.tableCell3.StylePriority.UseTextAlignment = false;
               this.tableCell3.Text = "Tên mặt hàng";
               this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell3.Weight = 0.1962828572591146D;
               // 
               // tableCell4
               // 
               this.tableCell4.Name = "tableCell4";
               this.tableCell4.StyleName = "DetailCaption1";
               this.tableCell4.StylePriority.UseTextAlignment = false;
               this.tableCell4.Text = "Giá (vnđ)";
               this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell4.Weight = 0.23737725151909722D;
               // 
               // tableCell5
               // 
               this.tableCell5.Name = "tableCell5";
               this.tableCell5.StyleName = "DetailCaption1";
               this.tableCell5.StylePriority.UseTextAlignment = false;
               this.tableCell5.Text = "Số lượng";
               this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell5.Weight = 0.16442001342773438D;
               // 
               // tableCell6
               // 
               this.tableCell6.Name = "tableCell6";
               this.tableCell6.StyleName = "DetailCaption1";
               this.tableCell6.Text = "Tổng giá (vnđ)";
               this.tableCell6.Weight = 0.17200831095377603D;
               // 
               // table2
               // 
               this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
               this.table2.Name = "table2";
               this.table2.OddStyleName = "DetailData3_Odd";
               this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
               this.table2.SizeF = new System.Drawing.SizeF(900F, 25F);
               // 
               // tableRow2
               // 
               this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12});
               this.tableRow2.Name = "tableRow2";
               this.tableRow2.Weight = 11.5D;
               // 
               // tableCell7
               // 
               this.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None;
               this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdBill]")});
               this.tableCell7.Name = "tableCell7";
               this.tableCell7.StyleName = "DetailData1";
               this.tableCell7.StylePriority.UseBorders = false;
               this.tableCell7.StylePriority.UseTextAlignment = false;
               this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell7.Weight = 0.12180262247721355D;
               // 
               // tableCell8
               // 
               this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IdItem]")});
               this.tableCell8.Name = "tableCell8";
               this.tableCell8.StyleName = "DetailData1";
               this.tableCell8.StylePriority.UseTextAlignment = false;
               this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell8.Weight = 0.1081089358859592D;
               // 
               // tableCell9
               // 
               this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ItemName]")});
               this.tableCell9.Name = "tableCell9";
               this.tableCell9.StyleName = "DetailData1";
               this.tableCell9.StylePriority.UseTextAlignment = false;
               this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell9.Weight = 0.1962828572591146D;
               // 
               // tableCell10
               // 
               this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PriceItem]")});
               this.tableCell10.Name = "tableCell10";
               this.tableCell10.StyleName = "DetailData1";
               this.tableCell10.StylePriority.UseTextAlignment = false;
               this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell10.Weight = 0.23737725151909722D;
               // 
               // tableCell11
               // 
               this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NumOfItem]")});
               this.tableCell11.Name = "tableCell11";
               this.tableCell11.StyleName = "DetailData1";
               this.tableCell11.StylePriority.UseTextAlignment = false;
               this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
               this.tableCell11.Weight = 0.16442001342773438D;
               // 
               // tableCell12
               // 
               this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalPriceItem]")});
               this.tableCell12.Name = "tableCell12";
               this.tableCell12.StyleName = "DetailData1";
               this.tableCell12.Weight = 0.17200832790798612D;
               // 
               // Bill1
               // 
               this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.Detail});
               this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
               this.DataSource = this.objectDataSource1;
               this.Font = new System.Drawing.Font("Arial", 9.75F);
               this.Landscape = true;
               this.PageHeight = 850;
               this.PageWidth = 1100;
               this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
               this.Version = "19.2";
               ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

          }

          #endregion

          private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
          private DevExpress.XtraReports.UI.XRControlStyle Title;
          private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
          private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
          private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
          private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
          private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
          private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
          private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
          private DevExpress.XtraReports.UI.XRTable table1;
          private DevExpress.XtraReports.UI.XRTableRow tableRow1;
          private DevExpress.XtraReports.UI.XRTableCell tableCell1;
          private DevExpress.XtraReports.UI.XRTableCell tableCell2;
          private DevExpress.XtraReports.UI.XRTableCell tableCell3;
          private DevExpress.XtraReports.UI.XRTableCell tableCell4;
          private DevExpress.XtraReports.UI.XRTableCell tableCell5;
          private DevExpress.XtraReports.UI.XRTableCell tableCell6;
          private DevExpress.XtraReports.UI.DetailBand Detail;
          private DevExpress.XtraReports.UI.XRTable table2;
          private DevExpress.XtraReports.UI.XRTableRow tableRow2;
          private DevExpress.XtraReports.UI.XRTableCell tableCell7;
          private DevExpress.XtraReports.UI.XRTableCell tableCell8;
          private DevExpress.XtraReports.UI.XRTableCell tableCell9;
          private DevExpress.XtraReports.UI.XRTableCell tableCell10;
          private DevExpress.XtraReports.UI.XRTableCell tableCell11;
          private DevExpress.XtraReports.UI.XRTableCell tableCell12;
     }
}
