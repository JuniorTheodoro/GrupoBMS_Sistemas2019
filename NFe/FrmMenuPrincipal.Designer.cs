namespace NFe {
    partial class FrmMenuPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblRazaoSocial = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imageLogo = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOperacional = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFinancas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVendas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadastros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblInformacoes = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Controls.Add(this.lblRazaoSocial);
            this.panelCabecalho.Controls.Add(this.imageLogo);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1104, 87);
            this.panelCabecalho.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = global::NFe.Properties.Resources.close;
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(1057, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 28);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 3;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 10;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRazaoSocial.Location = new System.Drawing.Point(98, 28);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(119, 32);
            this.lblRazaoSocial.TabIndex = 2;
            this.lblRazaoSocial.Text = "EMPRESA";
            // 
            // imageLogo
            // 
            this.imageLogo.BackColor = System.Drawing.Color.Transparent;
            this.imageLogo.Image = global::NFe.Properties.Resources.logoNova;
            this.imageLogo.ImageActive = null;
            this.imageLogo.Location = new System.Drawing.Point(25, 20);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(48, 48);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 1;
            this.imageLogo.TabStop = false;
            this.imageLogo.Zoom = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelCabecalho;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnOperacional);
            this.panelMenu.Controls.Add(this.btnFinancas);
            this.panelMenu.Controls.Add(this.btnServicos);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.btnCadastros);
            this.panelMenu.Controls.Add(this.btnInicio);
            this.panelMenu.Controls.Add(this.slider);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 87);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1104, 66);
            this.panelMenu.TabIndex = 1;
            // 
            // btnOperacional
            // 
            this.btnOperacional.Activecolor = System.Drawing.Color.White;
            this.btnOperacional.BackColor = System.Drawing.Color.White;
            this.btnOperacional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOperacional.BorderRadius = 0;
            this.btnOperacional.ButtonText = "Operacional";
            this.btnOperacional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacional.DisabledColor = System.Drawing.Color.Gray;
            this.btnOperacional.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOperacional.Iconimage = null;
            this.btnOperacional.Iconimage_right = null;
            this.btnOperacional.Iconimage_right_Selected = null;
            this.btnOperacional.Iconimage_Selected = null;
            this.btnOperacional.IconMarginLeft = 0;
            this.btnOperacional.IconMarginRight = 0;
            this.btnOperacional.IconRightVisible = true;
            this.btnOperacional.IconRightZoom = 0D;
            this.btnOperacional.IconVisible = true;
            this.btnOperacional.IconZoom = 90D;
            this.btnOperacional.IsTab = false;
            this.btnOperacional.Location = new System.Drawing.Point(922, 7);
            this.btnOperacional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOperacional.Name = "btnOperacional";
            this.btnOperacional.Normalcolor = System.Drawing.Color.White;
            this.btnOperacional.OnHovercolor = System.Drawing.Color.White;
            this.btnOperacional.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnOperacional.selected = false;
            this.btnOperacional.Size = new System.Drawing.Size(162, 35);
            this.btnOperacional.TabIndex = 7;
            this.btnOperacional.Text = "Operacional";
            this.btnOperacional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOperacional.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOperacional.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperacional.Click += new System.EventHandler(this.BtnOperacional_Click);
            // 
            // btnFinancas
            // 
            this.btnFinancas.Activecolor = System.Drawing.Color.White;
            this.btnFinancas.BackColor = System.Drawing.Color.White;
            this.btnFinancas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinancas.BorderRadius = 0;
            this.btnFinancas.ButtonText = "Finanças";
            this.btnFinancas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinancas.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinancas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinancas.Iconimage = null;
            this.btnFinancas.Iconimage_right = null;
            this.btnFinancas.Iconimage_right_Selected = null;
            this.btnFinancas.Iconimage_Selected = null;
            this.btnFinancas.IconMarginLeft = 0;
            this.btnFinancas.IconMarginRight = 0;
            this.btnFinancas.IconRightVisible = true;
            this.btnFinancas.IconRightZoom = 0D;
            this.btnFinancas.IconVisible = true;
            this.btnFinancas.IconZoom = 90D;
            this.btnFinancas.IsTab = false;
            this.btnFinancas.Location = new System.Drawing.Point(752, 7);
            this.btnFinancas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Normalcolor = System.Drawing.Color.White;
            this.btnFinancas.OnHovercolor = System.Drawing.Color.White;
            this.btnFinancas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnFinancas.selected = false;
            this.btnFinancas.Size = new System.Drawing.Size(162, 35);
            this.btnFinancas.TabIndex = 6;
            this.btnFinancas.Text = "Finanças";
            this.btnFinancas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinancas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFinancas.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnServicos
            // 
            this.btnServicos.Activecolor = System.Drawing.Color.White;
            this.btnServicos.BackColor = System.Drawing.Color.White;
            this.btnServicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicos.BorderRadius = 0;
            this.btnServicos.ButtonText = "Serviços";
            this.btnServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicos.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicos.Iconimage = null;
            this.btnServicos.Iconimage_right = null;
            this.btnServicos.Iconimage_right_Selected = null;
            this.btnServicos.Iconimage_Selected = null;
            this.btnServicos.IconMarginLeft = 0;
            this.btnServicos.IconMarginRight = 0;
            this.btnServicos.IconRightVisible = true;
            this.btnServicos.IconRightZoom = 0D;
            this.btnServicos.IconVisible = true;
            this.btnServicos.IconZoom = 90D;
            this.btnServicos.IsTab = false;
            this.btnServicos.Location = new System.Drawing.Point(582, 7);
            this.btnServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Normalcolor = System.Drawing.Color.White;
            this.btnServicos.OnHovercolor = System.Drawing.Color.White;
            this.btnServicos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnServicos.selected = false;
            this.btnServicos.Size = new System.Drawing.Size(162, 35);
            this.btnServicos.TabIndex = 5;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnServicos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnServicos.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnVendas
            // 
            this.btnVendas.Activecolor = System.Drawing.Color.White;
            this.btnVendas.BackColor = System.Drawing.Color.White;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.BorderRadius = 0;
            this.btnVendas.ButtonText = "Vendas";
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVendas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVendas.Iconimage = null;
            this.btnVendas.Iconimage_right = null;
            this.btnVendas.Iconimage_right_Selected = null;
            this.btnVendas.Iconimage_Selected = null;
            this.btnVendas.IconMarginLeft = 0;
            this.btnVendas.IconMarginRight = 0;
            this.btnVendas.IconRightVisible = true;
            this.btnVendas.IconRightZoom = 0D;
            this.btnVendas.IconVisible = true;
            this.btnVendas.IconZoom = 90D;
            this.btnVendas.IsTab = false;
            this.btnVendas.Location = new System.Drawing.Point(396, 7);
            this.btnVendas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Normalcolor = System.Drawing.Color.White;
            this.btnVendas.OnHovercolor = System.Drawing.Color.White;
            this.btnVendas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnVendas.selected = false;
            this.btnVendas.Size = new System.Drawing.Size(162, 35);
            this.btnVendas.TabIndex = 4;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVendas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVendas.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCadastros
            // 
            this.btnCadastros.Activecolor = System.Drawing.Color.White;
            this.btnCadastros.BackColor = System.Drawing.Color.White;
            this.btnCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastros.BorderRadius = 0;
            this.btnCadastros.ButtonText = "Cadastros";
            this.btnCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastros.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastros.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastros.Iconimage = null;
            this.btnCadastros.Iconimage_right = null;
            this.btnCadastros.Iconimage_right_Selected = null;
            this.btnCadastros.Iconimage_Selected = null;
            this.btnCadastros.IconMarginLeft = 0;
            this.btnCadastros.IconMarginRight = 0;
            this.btnCadastros.IconRightVisible = true;
            this.btnCadastros.IconRightZoom = 0D;
            this.btnCadastros.IconVisible = true;
            this.btnCadastros.IconZoom = 90D;
            this.btnCadastros.IsTab = false;
            this.btnCadastros.Location = new System.Drawing.Point(186, 7);
            this.btnCadastros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Normalcolor = System.Drawing.Color.White;
            this.btnCadastros.OnHovercolor = System.Drawing.Color.White;
            this.btnCadastros.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnCadastros.selected = false;
            this.btnCadastros.Size = new System.Drawing.Size(162, 35);
            this.btnCadastros.TabIndex = 3;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastros.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastros.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.White;
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Início";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = null;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(16, 7);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.White;
            this.btnInicio.OnHovercolor = System.Drawing.Color.White;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(162, 35);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Início";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(160)))), ((int)(((byte)(237)))));
            this.slider.Location = new System.Drawing.Point(16, 54);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(162, 7);
            this.slider.TabIndex = 2;
            this.slider.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 153);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1104, 447);
            this.panelContainer.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.lblInformacoes);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 561);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1104, 39);
            this.panelFooter.TabIndex = 3;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.Location = new System.Drawing.Point(3, 10);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(162, 20);
            this.lblInformacoes.TabIndex = 0;
            this.lblInformacoes.Text = "bunifuCustomLabel1";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 600);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton imageLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRazaoSocial;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinancas;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicos;
        private Bunifu.Framework.UI.BunifuFlatButton btnVendas;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastros;
        private Bunifu.Framework.UI.BunifuFlatButton btnOperacional;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelFooter;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInformacoes;
    }
}