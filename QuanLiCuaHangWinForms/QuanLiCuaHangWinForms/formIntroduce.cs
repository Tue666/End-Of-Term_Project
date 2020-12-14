using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangWinForms
{
    public partial class formIntroduce : Form
    {
        public formIntroduce()
        {
            InitializeComponent();
        }

        #region Methods
        #endregion

        #region Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            pcPR.Visible = false;
            btnClose.Visible = false;
        }
        #endregion
    }
}
