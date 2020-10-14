using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromotionEngine.Service.BusinessLogic;
using PromotionEngine.Service.Interfaces;
using PromotionEngine.Service.Models;

namespace PromotionEngineUI
{
    public partial class PromEngineUI : Form
    {
        private readonly List<ProductDTO> _products;
        private readonly ICostCalculationService _calculationService;
        public IEnumerable<IPromotion> _promotions;

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

            var items = new List<Item>()
            {
                new Item(_products[0], a),
                new Item(_products[1], b),
                new Item(_products[2], c),
                new Item(_products[3], d)
            };

            _promotions = new List<IPromotion>
            {
                new PromotionBulkService(new PromotionBulk("A", 3, 130)),
                new PromotionBulkService(new PromotionBulk("B", 2, 45)),
                new PromotionDuoService(new PromotionDuo(new List<string>{"C","D"}, 30))
            };

            var total = _calculationService.FetchTotal(items, _promotions);
            //lblResult.Text = total.ToString();
        }
    }
}
