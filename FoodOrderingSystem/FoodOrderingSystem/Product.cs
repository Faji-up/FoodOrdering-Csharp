using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FoodOrderingSystem
{
   
    public  class Product
    {
        String productImage;
        String productName;
        int productPrice;
        int productStack;
        int productId;
        public Product(String productImage,
        String productName,
        int productPrice,
        int productStack,
        int productId)
        {
            this.productStack = productStack;
            this.productImage = productImage;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productId = productId;
        }
        public String getProductImage() {  return productImage; }
        public String getProductName() {  return productName; }
        public int getProductPrice() {  return productPrice; }
        public int getProductId() { return productId;}
        public int getProductStack() {  return productStack; }

        
    }
}
