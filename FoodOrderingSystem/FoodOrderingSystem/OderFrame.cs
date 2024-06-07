using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderingSystem
{
    public partial class OderFrame : Form
    {
        

        
        int totalItemValue = 0;
        int totalPriceValue = 0;
        Product[] productList = { new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/burger.jfif", "Cheese Burger",100,100,1),
                                  new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/burger2.jpg", "Beef Cheese",120,100,2),
                                  new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/coke1.png", "Coke",50,100,3),
                                   new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/footloong1.png", "Cheese Footloong",100,100,4),
                                    new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/fries1.jpg", "Fries",80,100,5),
                                   new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/fries2.jpeg", "Spicy Fries",100,100,6),
                                new Product("C:/Users/Admin/source/repos/FoodOrderingSystem/FoodOrderingSystem/Images/coke1.png", "Coke Big",80,100,3)};
        public OderFrame()
        {
           
            InitializeComponent();
            add_food_card();
            update_order();
           


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();
            foodFrame.Controls.Clear();
            add_food_card();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderList.Items.Remove(orderList.SelectedItem);
        }

        private void foodFrame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            customer.Text = "Customer: " + customerName.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Order order = new Order(customerName.Text,totalPriceValue,totalItemValue,get_food_ordered());
            Order.orders[Order.arrayIndex] = order;
           
            get_food_ordered();
            orderList.Items.Clear();
            foodFrame.Controls.Clear();
            add_food_card();
            totalPriceValue = 0;
            totalItemValue = 0;
            update_order();
            customerName.Text = "";

            Order.arrayIndex++;
            //foreach(Order order1 in Order.orders) {
              //  if(order1 != null)
              //  {
                 //   MessageBox.Show(order1.get_customer_name());
              //  }
                
           // }
        }
        private void add_food_card()
        {
            foreach( Product product in productList)
            {
                Panel pictureBox = new Panel();
                pictureBox.BackgroundImage = Image.FromFile(product.getProductImage());
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox.Size = new Size(266, 191);
                pictureBox.Location = new Point(3, 3);

                CheckBox checkBox = new CheckBox();
                checkBox.Name = product.getProductName();
                checkBox.Font = new Font("Arial", 10, FontStyle.Regular);
                checkBox.Location = new Point(14, 200);
                checkBox.Text = product.getProductName();
                checkBox.ForeColor = Color.Black;
                checkBox.MouseClick += (s,e) =>
                {
                    if(checkBox.Checked)
                    {
                        orderList.Items.Add(product.getProductName());
                        totalPriceValue += product.getProductPrice();
                        totalItemValue++;
                       
                    }
                    else
                    {
                        orderList.Items.Remove(product.getProductName());
                        totalItemValue --;
                        totalPriceValue -= product.getProductPrice();
                    }
                    update_order();
                };
               

                Label label = new Label();
                label.Text = "P" + product.getProductPrice().ToString() + ".00";
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.Location  = new Point(187, 204);
                label.ForeColor = Color.Black;

                Panel panel = new Panel();
                panel.Size = new Size(272, 236);

                panel.Controls.Add(checkBox);
                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;

                foodFrame.Controls.Add(panel);
            }
            
        }
        private void update_order()
        {
            totalItem.Text = "Total item: " + totalItemValue.ToString();
            totalPrice.Text = "Total price: " + totalPriceValue.ToString(); 
        }

        public Product[] get_food_ordered()
        {
            Product[] newProductList = new Product[1000]; 
           foreach (var item in orderList.Items)
            {
                foreach (var product in productList)
                {
                    if (item.ToString().Equals(product.getProductName()))
                    {
                        newProductList.Append(product);
                    }
                }
            }
            return newProductList;

            }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryFrame historyFrame = new HistoryFrame();
            historyFrame.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }
    }

    }
