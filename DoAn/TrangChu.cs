using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.FluentDesignSystem;

namespace DoAn
{
    public partial class TrangChu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Add(new ucDashboard() { Dock = DockStyle.Fill });
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(uc);
            uc.Show();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            CHUNGLOAI cl = new CHUNGLOAI();
            cl.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(cl);

            cl.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {

            this.fluentDesignFormContainer1.Controls.Clear();
            FACT_SALES f = new FACT_SALES();
            f.TopLevel = false;
            
            this.fluentDesignFormContainer1.Controls.Add(f);

            f.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            CUAHANG ch = new CUAHANG();
            ch.TopLevel = false;

            this.fluentDesignFormContainer1.Controls.Add(ch);

            ch.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            DATETIME dt = new DATETIME();
            dt.TopLevel = false;

            this.fluentDesignFormContainer1.Controls.Add(dt);

            dt.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            KHACHHANG kh = new KHACHHANG();
            kh.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(kh);

            kh.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            KHUVUC kv = new KHUVUC();
            kv.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(kv);

            kv.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            LOAIHANG lh = new LOAIHANG();
            lh.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(lh);
            lh.Show();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(ncc);
            ncc.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            NHANVIEN nv = new NHANVIEN();
            nv.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(nv);
            nv.Show();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            SANPHAM sp = new SANPHAM();
            sp.TopLevel = false;
            this.fluentDesignFormContainer1.Controls.Add(sp);
            sp.Show();
        }
    }
}