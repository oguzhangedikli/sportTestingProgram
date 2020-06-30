using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System.Windows.Forms;

namespace TestingPrograms
{
    public partial class testAnaForm : DevExpress.XtraEditors.XtraForm
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
        }

        private void kisiselBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(kisiselBilgilerTabPage);}

        private void FormGoster(XtraTabPage ac)
        {ac.PageVisible = true; xtraTabControl1.SelectedTabPage = ac;}

        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {if (xtraTabControl1.SelectedTabPage!=anaSayfaTabPage){xtraTabControl1.SelectedTabPage.PageVisible = false;}}

        private void antroBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(AntropometikXtraTabPage);}

        private void sporcuListesiBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {FormGoster(sporcuListesiXtraTabPage);}

    }
}
