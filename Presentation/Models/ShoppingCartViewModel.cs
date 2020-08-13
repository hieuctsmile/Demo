using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }
    }
}
