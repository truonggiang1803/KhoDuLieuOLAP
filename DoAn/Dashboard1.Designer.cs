namespace DoAn
{
    partial class Dashboard1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn2 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn3 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension6 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension7 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension8 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension9 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.dashboardOlapDataSource1 = new DevExpress.DashboardCommon.DashboardOlapDataSource();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardOlapDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dashboardOlapDataSource1
            // 
            this.dashboardOlapDataSource1.ComponentName = "dashboardOlapDataSource1";
            this.dashboardOlapDataSource1.ConnectionName = "DESKTOP-7U6NLFV_DW_CHOLON1_DW CHOLON1";
            this.dashboardOlapDataSource1.ConnectionString = "Data Source=DESKTOP-7U6NLFV;Initial Catalog=DW_CHOLON1;Timeout=1200;Cube Name=DW " +
    "CHOLON1;User ID=sa;Password=\"sa2012\";";
            this.dashboardOlapDataSource1.Name = "OLAP Data Source 1";
            // 
            // gridDashboardItem1
            // 
            measure1.DataMember = "[Measures].[DOANHSO]";
            gridMeasureColumn1.Weight = 66.970588235294116D;
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure1);
            measure2.DataMember = "[Measures].[SOLUONG]";
            gridMeasureColumn2.Weight = 66.970588235294116D;
            gridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn2.AddDataItem("Measure", measure2);
            measure3.DataMember = "[Measures].[TONGTIEN]";
            gridMeasureColumn3.Weight = 91.058823529411768D;
            gridMeasureColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn3.AddDataItem("Measure", measure3);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridMeasureColumn1,
            gridMeasureColumn2,
            gridMeasureColumn3});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            dimension1.DataMember = "[D SANPHAM]";
            dimension2.DataMember = "[D NHANVIEN]";
            dimension3.DataMember = "[D NHACUNGCAP]";
            dimension4.DataMember = "[D LOAIHANG]";
            dimension5.DataMember = "[D KHUVUC]";
            dimension6.DataMember = "[D KHACHHANG]";
            dimension7.DataMember = "[D DATETIME]";
            dimension8.DataMember = "[D CUAHANG]";
            dimension9.DataMember = "[D CHUNGLOAI]";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.gridDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.gridDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.gridDashboardItem1.DataItemRepository.Add(dimension5, "DataItem4");
            this.gridDashboardItem1.DataItemRepository.Add(dimension6, "DataItem5");
            this.gridDashboardItem1.DataItemRepository.Add(dimension7, "DataItem6");
            this.gridDashboardItem1.DataItemRepository.Add(dimension8, "DataItem7");
            this.gridDashboardItem1.DataItemRepository.Add(dimension9, "DataItem8");
            this.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem9");
            this.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem10");
            this.gridDashboardItem1.DataItemRepository.Add(measure3, "DataItem11");
            this.gridDashboardItem1.DataSource = this.dashboardOlapDataSource1;
            this.gridDashboardItem1.GridOptions.ColumnWidthMode = DevExpress.DashboardCommon.GridColumnWidthMode.Manual;
            this.gridDashboardItem1.HiddenDimensions.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1,
            dimension2,
            dimension3,
            dimension4,
            dimension5,
            dimension6,
            dimension7,
            dimension8,
            dimension9});
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Grid 1";
            this.gridDashboardItem1.ShowCaption = true;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardOlapDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem1.Weight = 100D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardOlapDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardOlapDataSource dashboardOlapDataSource1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
    }
}
