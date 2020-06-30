using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System.Windows.Forms;

namespace TestingPrograms
{
    public partial class testAnaForm : XtraForm
    {
        public testAnaForm()
        {
            InitializeComponent();
        }

        private void sporcubilgiTabPage_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Tag.ToString()=="min")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (XtraMessageBox.Show("Program Kapatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Application.Exit();
                {

                }
            }
        }

        private void testAnaForm_Load(object sender, System.EventArgs e)
        {
            foreach (XtraTabPage item in xtraTabControl1.TabPages)
            {
                if (item.Name != "anaSayfaTabPage")
                {
                    item.PageVisible = false;
                }

            }
            foreach (XtraTabPage item in xtraTabControl2.TabPages)
            {
                if (item.Name != "anaSayfaTabPage2")
                {
                    item.PageVisible = false;
                }

            }
        }

        private void kisiselBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(kisiselBilgilerTabPage);}

        private void FormGoster(XtraTabPage ac)
        {
            ac.PageVisible = true; xtraTabControl1.SelectedTabPage = ac;
            ac.PageVisible = true; xtraTabControl2.SelectedTabPage = ac;
        }

        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage!=anaSayfaTabPage)
            {
                xtraTabControl1.SelectedTabPage.PageVisible = false;
            }
        }

        private void antroBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(AntropometikXtraTabPage);}

        private void sporcuListesiBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(sporcuListesiXtraTabPage);}

        private void xtraTabControl2_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (xtraTabControl2.SelectedTabPage != anaSayfaTabPage2)
            {
                xtraTabControl2.SelectedTabPage.PageVisible = false;
            }
        }

        private void buzDisiBar_ItemChanged(object sender, System.EventArgs e)
        {
            FormGoster(buzDisiTabPage);
        }
    }
}
