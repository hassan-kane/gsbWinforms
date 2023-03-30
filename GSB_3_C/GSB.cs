using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_3_C
{
    public partial class GSB : Form
    {
        private gsbrapportsEntities mesDonneesGSB;
        public GSB()
        {
            InitializeComponent();
            this.mesDonneesGSB = new gsbrapportsEntities();
        }

        private void gERERLESVISITEURSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GERER_VISITEURS v = new GERER_VISITEURS(this.mesDonneesGSB);
            v.Show();
        }

        private void vOIRSLESRAPPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VOIR_RAPPORTS r = new VOIR_RAPPORTS(this.mesDonneesGSB);
            r.Show();
        }
    }
}
