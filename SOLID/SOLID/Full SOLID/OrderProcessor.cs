using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Full_SOLID
{
    internal class OrderProcessor :IOrderProcessor
    {
        private readonly IProductRepository _productRepository;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotificationService _notificationService;

        public OrderProcessor(IProductRepository productRepository, IPaymentProcessor paymentProcessor, INotificationService notificationService)
        {
            _productRepository = productRepository;
            _paymentProcessor = paymentProcessor;
            _notificationService = notificationService;
        }

        public void PlaceOrder(string customerName, List<int> productIds, string paymentMethod)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();

            foreach (int productId in productIds)
            {
                Product product = _productRepository.GetProductById(productId);
                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }

            if (orderedProducts.Count > 0)
            {
                if (paymentMethod == "CreditCard")
                {
                    _paymentProcessor.ProcessPayment(totalCost);
                }
                else if (paymentMethod == "PayPal")
                {
                    _paymentProcessor.ProcessPayment(totalCost);
                }

                Order order = new Order
                {
                    CustomerName = customerName,
                    Products = orderedProducts,
                    TotalCost = totalCost
                };

                _notificationService.SendOrderConfirmationEmail(order);
            }
        }
    }
}
