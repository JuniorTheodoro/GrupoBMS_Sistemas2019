using System;
using System.Windows.Forms;

namespace NFe {
    public partial class FrmMenuPrincipal : Form {
        public FrmMenuPrincipal() {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnInicio_Click(object sender, EventArgs e) {
            DeslocamentoSlider(sender);
        }

        private void DeslocamentoSlider(object sender) {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {

        }

        private void BtnOperacional_Click(object sender, EventArgs e) {
            DeslocamentoSlider(sender);

            ControlOperacional().BringToFront();
        }
    }
}
