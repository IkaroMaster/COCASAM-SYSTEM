using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CapaPresentacion.Formularios
{
    public partial class FrmSplash : DevExpress.XtraEditors.XtraForm
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Start();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            if (i == 10)
            {
                Hide();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
        }
    }
}
