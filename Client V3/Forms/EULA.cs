using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client_V3.Forms
{
    public partial class EULA : Form
    {
        public EULA()
        {
            InitializeComponent();
        }

        private void EULA_Load(object sender, EventArgs e)
        {
            lbl_Bonus_Deposito.Text = Variabili.bonus_Deposito.ToString() + "% (Tantum)";
            lbl_Bonus_Invito_Ref.Text = Variabili.bonus_Innvito_Ref.ToString() + "% (ADS)";
            lbl_Bonus_Invitato_Ref.Text = Variabili.bonus_Invitato_Ref.ToString() + "% (ADS)";
        }

        private void lbl_Link_DeepMiningProtocol_Click(object sender, EventArgs e)
        {
            Process.Start("https://adlos.notion.site/Deep-Mining-Protocol-V1-93715c956a384f8687ad58e44448f978?pvs=4");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Prelievo_Deposito_Click(object sender, EventArgs e)
        {
            Process.Start("https://adlos.notion.site/Creazione-Wallet-Metamask-8357406e7b6c45baa9a5f02f72f85e62");
        }

        private void lbl_Deep_Client_Click(object sender, EventArgs e)
        {
            Process.Start("https://adlos.notion.site/Tutorial-Deep-Client-21e173c024a14024b887a931d65ca3a3");
        }
    }
}
