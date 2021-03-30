using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Facade.II
{
    public class OrderFacade
    {
        private IProductService _productService;
        private IPaymentService _paymentService;
        private ICartService _cartService;

        public OrderFacade(IProductService productService, IPaymentService paymentService, ICartService cartService)
        {
            _productService = productService;
            _paymentService = paymentService;
            _cartService = cartService;
        }

        public void Order(int[] productIds, int cartId)
        {
            foreach (var item in productIds)
            {
                var price = _productService.GetPrice(item);
                _cartService.AddProduct(cartId, item, price);
            }

            var totalPrice = _cartService.GetPrice(cartId);
            _paymentService.Pay(cartId, totalPrice);
        }
    }
}
