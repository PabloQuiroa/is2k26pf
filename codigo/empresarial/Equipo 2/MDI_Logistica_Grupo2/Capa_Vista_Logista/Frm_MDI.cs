using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logista
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LOGIN LOGIN = new Frm_LOGIN();
            LOGIN.ShowDialog();

            this.Close();
        }
    }
}
