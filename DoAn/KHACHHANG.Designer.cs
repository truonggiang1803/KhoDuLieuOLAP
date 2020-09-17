namespace DoAn
{
    partial class KHACHHANG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHACHHANG));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo11 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo12 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelTableSettings excelTableSettings1 = new DevExpress.DataAccess.Excel.ExcelTableSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelTableSettings1);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Nap = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_fact = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("#9Slide03 AmpleSoft", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập dữ liệu vào Dimension KHÁCH HÀNG\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8421F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.1579F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 456);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgv_fact, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.10579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.8942F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(865, 397);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.41201F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.58799F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(859, 49);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.11504F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.88496F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(401, 43);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(199, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(199, 37);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(93, 31);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Nạp";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(190, 37);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nạp dữ liệu từ SQL";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.91849F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.08151F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(410, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(446, 43);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nạp dữ liệu từ excel";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Nap, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_Xoa, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(231, 37);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btn_Nap
            // 
            this.btn_Nap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Nap.Appearance.Options.UseFont = true;
            this.btn_Nap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Nap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nap.ImageOptions.Image")));
            this.btn_Nap.Location = new System.Drawing.Point(3, 3);
            this.btn_Nap.Name = "btn_Nap";
            this.btn_Nap.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Nap.Size = new System.Drawing.Size(109, 31);
            this.btn_Nap.TabIndex = 1;
            this.btn_Nap.Text = "Nạp";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.ImageOptions.Image")));
            this.btn_Xoa.Location = new System.Drawing.Point(118, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Xoa.Size = new System.Drawing.Size(110, 31);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            // 
            // dgv_fact
            // 
            this.dgv_fact.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_fact.Location = new System.Drawing.Point(3, 58);
            this.dgv_fact.Name = "dgv_fact";
            this.dgv_fact.RowHeadersWidth = 62;
            this.dgv_fact.RowTemplate.Height = 28;
            this.dgv_fact.Size = new System.Drawing.Size(859, 336);
            this.dgv_fact.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "E:\\KH2-NAM3\\CSDL_OLAP\\Fact.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "MANCC";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "MACL";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "MALH";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "MASP";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "MAKV";
            fieldInfo5.Type = typeof(string);
            fieldInfo6.Name = "MANV";
            fieldInfo6.Type = typeof(string);
            fieldInfo7.Name = "MACH";
            fieldInfo7.Type = typeof(string);
            fieldInfo8.Name = "MAKH";
            fieldInfo8.Type = typeof(string);
            fieldInfo9.Name = "ID";
            fieldInfo9.Type = typeof(System.DateTime);
            fieldInfo10.Name = "SOLUONG";
            fieldInfo10.Type = typeof(double);
            fieldInfo11.Name = "TONGTIEN";
            fieldInfo11.Type = typeof(double);
            fieldInfo12.Name = "DOANHSO";
            fieldInfo12.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10,
            fieldInfo11,
            fieldInfo12});
            excelTableSettings1.TableName = "FACT_SALES";
            excelSourceOptions1.ImportSettings = excelTableSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KHACHHANG";
            this.Text = "KHACHHANG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KHACHHANG_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.SimpleButton btn_Nap;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_fact;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}