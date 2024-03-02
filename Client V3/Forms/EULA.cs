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

        }

        private void lbl_Link_DeepMiningProtocol_Click(object sender, EventArgs e)
        {
            Process.Start("https://adlos.notion.site/Deep-Mining-Protocol-V1-93715c956a384f8687ad58e44448f978?pvs=4");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
