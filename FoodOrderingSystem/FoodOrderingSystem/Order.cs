using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem
{
     
    public class Order
    {
        public static int arrayIndex = 0;
        public static Order[] orders = new Order[100];
        String customerName;
        int totalPrice;
        int totalItem;
        DateTime datetime;
        Product[] productList;

        public Order(String customerName,
        int totalPrice,
        int totalItem,
         Product[] productList
        )
        {
            this.customerName = customerName;
            this.totalPrice = totalPrice;
            this.totalItem = totalItem;
            this.datetime = DateTime.Now.Date;
            this.productList = productList;
        }
        public String get_customer_name()
        {
            return customerName;
        }
        public int getTotalPrice()
        {
            return totalPrice;
        }
        public int getTotalItem()
        {
            return totalItem;
        }
        public String get_datetime()
        {
            return datetime.ToString();
        }

    }
}
