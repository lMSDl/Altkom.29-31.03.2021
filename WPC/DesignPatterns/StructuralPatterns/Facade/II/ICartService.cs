using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Facade.II
{
    public interface ICartService
    {
        float GetPrice(int cartId);
        float AddProduct(int cartId, int productId, float price);
    }
}
