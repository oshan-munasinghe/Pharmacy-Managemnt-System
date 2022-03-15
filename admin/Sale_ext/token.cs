using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin.Sale_ext
{
    public partial class token : UserControl
    {
        public token()
        {
            InitializeComponent();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
