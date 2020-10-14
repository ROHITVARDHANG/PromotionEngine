using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromotionEngineUI
{
    public partial class PromEngineUI : Form
    {
        public PromEngineUI()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal a = numericA.Value;
            decimal b = numericB.Value;
            decimal c = numericC.Value;
            decimal d = numericD.Value;
        }
    }
}
