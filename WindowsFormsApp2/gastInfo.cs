using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class gastInfo : Form
    {
        public gastInfo()
        {
            InitializeComponent();
        }

        private void gastInfo_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                gastInfoTable.RowCount = gastInfoTable.RowCount + 1;
                gastInfoTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                gastInfoTable.Controls.Add(new Label() { Text = "1123" }, 1, gastInfoTable.RowCount - 1);
                gastInfoTable.Controls.Add(new Label() { Text = "12345" }, 2, gastInfoTable.RowCount - 1);
                gastInfoTable.Controls.Add(new Label() { Text = "123" }, 3, gastInfoTable.RowCount - 1);
            }
            this.Text = Convert.ToString(gastInfoTable.RowCount);
        }
    }
}
