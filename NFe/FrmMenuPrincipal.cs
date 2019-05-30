using System;
using System.Windows.Forms;

namespace NFe {
    public partial class FrmMenuPrincipal : Form {
        private readonly Utils.Utils utils = new Utils.Utils();
        private int xPos = 0, YPos = 0;

        public FrmMenuPrincipal() {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e) {
            timerLabel.Start();
        }

        private void BtnFechar_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnInicio_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void BtnOperacional_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void BtnCadastros_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void BtnVendas_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void BtnServicos_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void BtnFinancas_Click(object sender, EventArgs e) {
            utils.DeslocamentoSlider(slider, sender);
        }

        private void TimerLabel_Tick(object sender, EventArgs e) {
            if (xPos == 0) {
                this.lblInformacoes.Location = new System.Drawing.Point(this.Width, YPos);
                xPos = this.Width;
            }
            else {
                this.lblInformacoes.Location = new System.Drawing.Point(xPos, YPos);
                xPos -= 2;
            }
        }
    }
}
