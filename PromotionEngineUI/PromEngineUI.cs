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
        private readonly ICostCalculationService _costCalculationService;
        public IEnumerable<IPromotion> _promotions;

        public PromEngineUI()
        {
            InitializeComponent();
            _costCalculationService = new CostCalculationService();
            var promA = new ProductDTO("A", 50);
            var promB = new ProductDTO("B", 30);
            var promC = new ProductDTO("C", 20);
            var promD = new ProductDTO("D", 15);

            _products = new List<ProductDTO>
            {
                promA,
                promB,
                promC,
                promD
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal a = numericA.Value;
            decimal b = numericB.Value;
            decimal c = numericC.Value;
            decimal d = numericD.Value;

            var items = new List<Item>();

            if (a > 0)
            {
                items.Add(new Item(_products[0], a));
            }
            if (b > 0)
            {
                items.Add(new Item(_products[1], b));
            }
            if (c > 0)
            {
                items.Add(new Item(_products[2], c));
            }
            if (d > 0)
            {
                items.Add(new Item(_products[3], d));
            }

            _promotions = new List<IPromotion>
            {
                new PromotionBulkService(new PromotionBulk("A", 3, 130)),
                new PromotionBulkService(new PromotionBulk("B", 2, 45)),
                new PromotionDuoService(new PromotionDuo(new List<string>{"C","D"}, 30))
            };

            var total = _costCalculationService.FetchTotal(items, _promotions);
            label1.Text = total.ToString();
        }
    }
}
