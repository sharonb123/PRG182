using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//David's class
namespace Project2
{
  internal class ProductArrayList
  {
    ArrayList shoppingCart = new ArrayList();

    //method to put chosen product in shopping cart
    public void PutInShoppingCart(ProductInfo pi)
    {
      shoppingCart.Add(pi);
    }

    //method to reset shopping cart after Checkout option is chosen
    public void ResetShoppingCart()
    {
      shoppingCart.Clear();
    }

    //Helper method for displayOrder() method
    private double GetTotalPrice()
    {
      ProductInfo pi = new ProductInfo();
      double total = 0.00;
      for (int i = 0; i < shoppingCart.Count; i++)
      {
        pi = (ProductInfo)shoppingCart[i];
        total += pi.GetPrice() * pi.GetQuantity();
      }

      return total;
    }

    //Method to display customer's order
    public String DisplayOrder()
    {
      String temp = "";
      ProductInfo pi = new ProductInfo();

      for (int i = 0; i < shoppingCart.Count; i++)
      {
        pi = (ProductInfo)shoppingCart[i];
        temp += pi.DisplayInfo() + "\n";
      }

      temp += "\nYour Total amounts to: R" + GetTotalPrice();

      return temp;
    }
  }
}
