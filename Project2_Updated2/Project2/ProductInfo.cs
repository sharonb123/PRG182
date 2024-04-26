using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//David's class
namespace Project2
{
  internal class ProductInfo
  {
    private readonly String name;
    private readonly double price;
    private readonly int quantity;

    //parameterised constructor
    public ProductInfo(String n, double p, int q)
    {
      name = n;
      price = p;
      quantity = q;
    }

    //default constructor
    public ProductInfo()
    {

    }

    //Method to access name outside class
    public String GetName()
    {
      return name;
    }

    //Method to access price outside class
    public double GetPrice()
    {
      return price;
    }

    //Method to access quantity outside class
    public int GetQuantity()
    {
      return quantity;
    }

    //Method to display product info in a structured manner
    public String DisplayInfo()
    {
      String temp = "";
 
      temp += String.Format("{0,-20}", name);
      temp += String.Format("{0,10}", "R" + price);
      temp += String.Format("{0,20}", "(" + quantity + ")");

            return temp;
    }
  }
}
