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
    public partial class VOIR_RAPPORTS : Form
    {
        private gsbrapportsEntities mesDonneesGSB;
        public VOIR_RAPPORTS(gsbrapportsEntities mesDonneesGSB)
        {
            InitializeComponent();
            this.mesDonneesGSB = mesDonneesGSB;
            // exécute la requête et charge les données dans une liste
            this.bdgSrcRapports.DataSource = mesDonneesGSB.rapports.ToList(); // lie la liste à la source de données
        }
    }
}
