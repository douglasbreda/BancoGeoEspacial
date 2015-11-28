using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios
{
    public partial class formReportPadrao : Form
    {
        public formReportPadrao()
        {
            InitializeComponent();
        }

        private void formReportPadrao_Load(object sender, EventArgs e)
        {
            this.reportPadrao.RefreshReport();
        }
    }
}
