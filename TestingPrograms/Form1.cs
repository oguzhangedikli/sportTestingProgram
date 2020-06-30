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

        #region MinimizeAndCloseButton
        private void sporcubilgiTabPage_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Tag.ToString() == "min")
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
        #endregion

        #region anasayayfaDışındakiSayfalarBaşlangıçtaGörünmez
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
        #endregion

        #region FormGosterMethodu
        private void FormGoster(XtraTabPage ac)
        {
            ac.PageVisible = true; xtraTabControl1.SelectedTabPage = ac;
            ac.PageVisible = true; xtraTabControl2.SelectedTabPage = ac;
        }
        #endregion

        #region tabControldeKapatmaTuşuAnaSayfayıKapatmasın
        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage != anaSayfaTabPage)
            {
                xtraTabControl1.SelectedTabPage.PageVisible = false;
            }
        }

        private void xtraTabControl2_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (xtraTabControl2.SelectedTabPage != anaSayfaTabPage2)
            {
                xtraTabControl2.SelectedTabPage.PageVisible = false;
            }
        }
        #endregion

        #region formGoster
        private void antroBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(AntropometikXtraTabPage); }

        private void sporcuListesiBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(sporcuListesiXtraTabPage); }


        private void kisiselBar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(kisiselBilgilerTabPage); }


        private void buzDisiBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(buzDisiTabPage); }

        private void oksijensizBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(oksijensizTabPage); }

        private void oksijenliBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(oksijenliTabPage); }

        private void kaleciBeceriTestleriBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(kaleciBeceritestleriTabPage); }

        private void sutHiziTestleriBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(sutHiziTestleriTabPage); }

        private void uzunlukOlcumleriBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(uzunlukOlcümleriTabPage); }

        private void cevreOlcumleriBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(cevreOlcumleriTabPage); }

        private void capOlcumlariBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(capOlcümleriTabPage); }

        private void fonksiyonelOlcBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(fonksiyonelOlcumlerTabPage); }

        private void fizyoterapiBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        { FormGoster(fizyoterapiTabPage); }
        #endregion

        #region FormuHareketEttirme
        int x, y;
        private void sporcubilgiTabPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left += e.X - x;
            this.Top += e.Y - y;

        }

        private void sporcubilgiTabPage_MouseDown(object sender, MouseEventArgs e)
        {
            {
                x = e.X;
                y = e.Y;
            }
        }
        #endregion
    }
}
