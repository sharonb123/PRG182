using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Zoe added input methods, switches, and totals
namespace Project2
{
  internal class Program
  {
    /// <summary>
    /// Enums for each type of Item on the Menu
    /// </summary>
    public enum Menu
    {
      Breakfast = 1,
      Combos,
      Chips,
      Burgers,
      Drinks,
      Checkout,
      Exit
    }

    public enum Breakfast
    {
      BreakfastSpecial = 1,
      HashbrownandEgg,
      SundaySpecial,
      Back
    }

    public enum Combos
    {
      Breakfastandcoffe = 1,
      Breakfastandjuice,
      Burgerandchips,
      Burgerdrinkandchcips,
      Back
    }

    public enum Chips
    {
      HotChips = 1,
      SpicyChips,
      Simba,
      Doritos,
      Back
    }

    public enum Burgers
    {
      BeefBurger = 1,
      ChickenBurger,
      SausyBurger,
      CheeseBurger,
      HawaiianBurger,
      Back
    }

    public enum Drinks
    {
      SoftDrinks = 1,
      Milkshake,
      Juice,
      HotDrinks,
      Back
    }

    public enum SoftDrinks
    {
      Coke = 1,
      Fanta,
      DrPepper,
      Sprite,
      Back
    }

    public enum Milkshake
    {
      chocolate = 1,
      straweberry,
      vanilla,
      mint,
      Back
    }

    public enum Juice
    {
      OrangeJuice = 1,
      CranberryJuice,
      AppleJuice,
      Back
    }

    public enum HotDrinks
    {
      Cappachino = 1,
      HotChocolate,
      Coffee,
      Tea,
      Back
    }

    static void Main(string[] args)
    {
      //The Goto loop will loop the user back to the beginning of the application so that it wont end until the Exit option is selected
      Loop:
      Console.Clear();

      //Arraylists have been called from ProductArrayList class
      ProductArrayList pal = new ProductArrayList();

      //Name of the fast food restuarant is displayed
      Console.WriteLine("\n\t\t\t-----Restaurant HappyFoods-----\n");
      Menu menuOption;


      //Menu of the fast food resturant for the user to select from
      Console.WriteLine("MENU");
      Console.WriteLine("-----");
      Console.WriteLine("\n\t1. Breakfast" + "\n\t2. Combos" + "\n\t3. Chips" + "\n\t4. Burgers" + "\n\t5. Drinks" + "\n\t6. Checkout" +"\n\t7. Exit");

      Console.WriteLine("\nPlease make your choice: ");
      menuOption = (Menu)Convert.ToInt32(Console.ReadLine());

      //While loop to loop the application until the user selects the CheckOut option.
      while (menuOption != Menu.Checkout)
      {
        //Switch statement to call up fucntions for different options on the menu when the user selects their choice.
        switch ((Menu)menuOption)
        {
          case Menu.Breakfast:
          {
            //Calls the function BreakfastMenu that contains the breakfast menu options
            BreakfastMenu(pal);
          }
          break;

          case Menu.Combos:
          {
            //Calls the function ComboMenu that contains the combos of food available
            CombosMenu(pal);
          }
          break;

          case Menu.Chips:
          {
            //Calls the function ChipsMenu that contains the different types of chips available
            ChipsMenu(pal);
          }
          break;

          case Menu.Burgers:
          {
            //Calls the function BurgerMenu that contains the different burger types available
            BurgersMenu(pal);
          }
          break;

          case Menu.Drinks:
          {
            //Calls the function DrinksMenu that contains the drink menu options
            DrinksMenu(pal);
          }
          break;

          case Menu.Exit:
          {
            //Displays the creators of the applications
            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
            Console.WriteLine("PRG181 Project 2");
            Console.WriteLine("Due Date: 10 June 2022");
            Console.WriteLine("Created by:");
            Console.WriteLine("------------\n");
            Console.WriteLine("\t David Moses: \t\t\t (577548)" + "\n\t Mia van Staden: \t\t (578692)" + "\n\t Nontsikelelo Buhlungu: \t (577878)" + "\n\t Zoë Treutens: \t\t\t (577989)");

            Console.WriteLine("\n\n\n\t--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*-- ");
            Console.WriteLine("\t\t\t\tThank you for ordering with Resturant HappyFoods! Have a great day!");
            Console.WriteLine("\t--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*--*-- ");
            Console.ReadKey();

            //Allows the user to exit the application
            Environment.Exit(0);
          }
          break;

          default:
          {
            Console.WriteLine("The number you have entered is not on the list, push enter to re-enter one of the numbers available in the list");
            Console.ReadKey();
          }
          break;
        }
        //Clears the console screen
        Console.Clear();
        Console.WriteLine("MENU");
        Console.WriteLine("-----");
        Console.WriteLine("\n\t1. Breakfast" + "\n\t2. Combos" + "\n\t3. Chips" + "\n\t4. Burgers" + "\n\t5. Drinks" + "\n\t6. Checkout" + "\n\t7. Exit");

        Console.WriteLine("\nPlease make your choice: ");
        menuOption = (Menu)Convert.ToInt32(Console.ReadLine());
      }
      Console.Clear();
      //
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("CHECKOUT");
      Console.WriteLine("--------");
      //Displays the order of the user
      Console.WriteLine(pal.DisplayOrder());

      Console.ReadKey();

      //Resets the shopping cart for the next user before looping
      pal.ResetShoppingCart();
      //Loops the application to the start for the next user
      goto Loop;

    }

    /// <summary>
    /// Breakfast Menu Options
    /// </summary>
    public static void BreakfastMenu(ProductArrayList pal)
    {
      int breakfast;
      //The breakfast menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("BREAKFAST MENU");
      Console.WriteLine("----------------\n");
      Console.WriteLine("\n\t1. Breakfast Special    R40.00" + "\n\t2. Hashbrowns and egg   R20.00" + "\n\t3. Sunday Special       R60.00" + "\n\t4. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each breakfast option
      switch ((Breakfast)breakfast)
      {
        case Breakfast.BreakfastSpecial:
        {
          Console.WriteLine("\nBreakfast special selected R40.00");
          Console.Write("Quantity of Breakfast Specials: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Breakfast Special", 40.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Breakfast.HashbrownandEgg:
        {
          Console.WriteLine("\nHashbrown and Egg breakfast selected R20.00");
          Console.Write("Quantity of Hashbrown and Egg: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Hashbrown and Egg", 20.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Breakfast.SundaySpecial:
        {
          Console.WriteLine("\nSunday Special breakfast selected R60.00");
          Console.Write("Quantity of Sunday Special: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Sunday Special", 60.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }

    /// <summary>
    /// Combos Menu Options
    /// </summary>
    /// <param name="menuOption">The option of going back to the main menu</param>
    public static void CombosMenu(ProductArrayList pal)
    {
      int breakfast;
      //The combo's menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("COMBOS MENU");
      Console.WriteLine("-------------\n"); 
      Console.WriteLine("\n\t1. Breakfast and coffee     R45.00" + "\n\t2. Breakfast and juice      R35.00" + "\n\t3. Burger and chips         R60.00" + "\n\t4. Burger, Drink and Chips  R70.00" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each combos option
      switch ((Combos)breakfast)
      {
        case Combos.Breakfastandcoffe:
        {
          Console.WriteLine("\nBreakfast and Coffee combo selected:  R45.00");
          Console.Write("Quantity of Breakfast and Coffee combo: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Breakfast and coffe", 45.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Combos.Breakfastandjuice:
        {
          Console.WriteLine("\nBreakfast and juice combo selected:   R35.00");
          Console.Write("Quantity of Breakfast and juice combo: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Breakfast and juice", 35.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Combos.Burgerandchips:
        {
          Console.WriteLine("\nBurger and chips combo selected:   R60.00");
          Console.Write("Quantity of Burger and chips combo: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Burger and chips", 60.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Combos.Burgerdrinkandchcips:
        {
          Console.WriteLine("\nBurger, drink and chips combo selected:   R70.00");
          Console.Write("Quantity of Burger, drink and chips combo: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Burger, drink and chips", 70.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }

    /// <summary>
    /// Chips Menus Options
    /// </summary>
    public static void ChipsMenu( ProductArrayList pal)
    {
      int breakfast;
      //The Chips menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("CHIPS MENU");
      Console.WriteLine("------------\n");
      Console.WriteLine("\n\t1. Hot Chips     R25.00" + "\n\t2. Spicy Chips   R30.00" + "\n\t3. Simba         R8.00" + "\n\t4. Doritos       R8.00" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each chip option
      switch ((Chips)breakfast)
      {
        case Chips.HotChips:
        {
          Console.WriteLine("\nHot Chips selected:  R25.00");
          Console.Write("Quantity of Hot Chips: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Hot Chips", 25.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Chips.SpicyChips:
        {
          Console.WriteLine("\nSpicy Chips selected:   R30.00");
          Console.Write("Quantity of Spicy Chips: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Spicy Chips", 30.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Chips.Simba:
        {
          Console.WriteLine("\nSimba Chip selected: R8.00");
          Console.Write("Quantity of Simba Chips: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Simbas", 8.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Chips.Doritos:
        {
          Console.WriteLine("\nDorito Chips selected:  R8.00");
          Console.Write("Quantity of Dorito Chips: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Doritos", 8.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("\nThe choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }


    /// <summary>
    /// Burger Menu Options
    /// </summary>
    public static void BurgersMenu(ProductArrayList pal)
    {
      int breakfast;
      //The Burger menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("BURGER MENU");
      Console.WriteLine("-------------\n");
      Console.WriteLine("\n\t1. Beef Burger       R49.90" + "\n\t2. Chicken Burger    R69.90" + "\n\t3. Sausy Burger      R59.90" + "\n\t4. Cheese Burger     R59.90" + "\n\t5. Hawaiian Burger   R79.90" + "\n\t6. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each Burger option
      switch ((Burgers)breakfast)
      {
        case Burgers.BeefBurger:
        {
          Console.WriteLine("\nBeef Burger selected:    R49.90");
          Console.Write("Quantity of Beef Burger: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Beef Burger", 49.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Burgers.ChickenBurger:
        {
          Console.WriteLine("\nChicken Burger selected:   R69.90");
          Console.Write("Quantity of Chicken Burger: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Chicken Burger", 69.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Burgers.SausyBurger:
        {
          Console.WriteLine("\nSausy Burger selected:   R59.90");
          Console.Write("Quantity of Sausy Burger: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Sausy Burger", 59.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Burgers.CheeseBurger:
        {
          Console.WriteLine("\nCheese Burger selected:   R59.90");
          Console.Write("Quantity of Cheese Burger: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);


          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Cheese Burger", 59.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Burgers.HawaiianBurger:
        {
          Console.WriteLine("\nHawaiian Burger selected:   R79.90");
          Console.Write("Quantity of hawaiian Burger: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);


          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Hawaiian Burger", 79.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }


    /// <summary>
    /// Drink Menu Menu
    /// </summary>
    public static void DrinksMenu(ProductArrayList pal)
    {
      int breakfast;
      //The Drinks menu is displayed for the user to choose a type of drink
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("DRINK MENU");
      Console.WriteLine("------------\n");
      Console.WriteLine("\n\t1. Soft Drinks" + "\n\t2. Milkshakes" + "\n\t3. Juice" + "\n\t4. Hot Drinks" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each type of drink option available
      switch ((Drinks)breakfast)
      {
        case Drinks.SoftDrinks:
        {
          //Calls the function softDrinks that contains the different soft drinks available
          FizzyDrinks(pal);
        }
        break;

        case Drinks.Milkshake:
        {
          //Calls the function Milkshakes that contains the different milkshakes available
          Milkshakes(pal);
        }
        break;

        case Drinks.Juice:
        {
          //Calls the function Juice that contains the different juices available
          Juices(pal);
        }
        break;

        case Drinks.HotDrinks:
        {
          //Calls the function warDrinks that contains the different hot drinks available
          Warmdrinks(pal);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }

    /// <summary>
    /// Soft Drink Options
    /// </summary>
    public static void FizzyDrinks(ProductArrayList pal)
    {
      int breakfast;
      //The Soft drink menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("SOFT DRINK MENU");
      Console.WriteLine("----------------\n");
      Console.WriteLine("\n\t1. Coke          R11.00" + "\n\t2. Fanta Grape   R8.49" + "\n\t3. Dr Pepper     R18.90" + "\n\t4. Sprite        R8.99" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each soft drink option
      switch ((SoftDrinks)breakfast)
      {
        case SoftDrinks.Coke:
        {
          Console.WriteLine("\nCoke Can selected:  R11.00");
          Console.Write("Quantity of Coke Cans: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Coke", 11.00, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case SoftDrinks.Fanta:
        {
          Console.WriteLine("\nFanta Grape selected:   R8.49");
          Console.Write("Quantity of Fanta Grapes: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Fanta", 8.49, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case SoftDrinks.DrPepper:
        {
          Console.WriteLine("\nDr Pepper selected:   R18.90");
          Console.Write("Quantity of Dr Peppers: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Dr Pepper", 18.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case SoftDrinks.Sprite:
        {
          Console.WriteLine("\nSprite selected:   R8.99");
          Console.Write("Quantity of Sprites: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Sprite", 8.99, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

      default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }

    /// <summary>
    /// Milkshake Options 
    /// </summary>
    public static void Milkshakes(ProductArrayList pal)
    {
      int breakfast;
      //The Milkshake menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("MILKSHAKES MENU");
      Console.WriteLine("----------------\n");
      Console.WriteLine("\n\t1. Chocolate Milkshake     R39.90" + "\n\t2. Strawberry Milkshake    R39.90" + "\n\t3. Vanilla Milkshake       R39.90" + "\n\t4. Mint Milkshake          R39.90" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each milkshake option
      switch ((Milkshake)breakfast)
      {
        case Milkshake.chocolate:
        {
          Console.WriteLine("\nChocolate Milkshake selected:  R39.90");
          Console.Write("Quantity of Chocolate Milkshakes: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Chocolate Milkshake", 39.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Milkshake.straweberry:
        {
          Console.WriteLine("\nStrawberry Milkshake selected:   R39.90");
          Console.Write("Quantity of Strawberry Milkshakes: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Straweberry Milkshake", 39.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Milkshake.vanilla:
        {
          Console.WriteLine("\nVanilla Milkshake selected:   R39.90");
          Console.Write("Quantity of Vanilla Milkshakes: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Vanilla Milkshake", 39.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Milkshake.mint:
        {
          Console.WriteLine("\nMint Milkshake selected:   R39.90");
          Console.Write("Quantity of Mint Milkshakes: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);


          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Mint Milkshake", 39.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }

    /// <summary>
    /// Juice Options
    /// </summary>
    public static void Juices(ProductArrayList pal)
    {
      int breakfast;
      //The Juice menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("JUICE MENU");
      Console.WriteLine("-----------\n");
      Console.WriteLine("\n\t1. Orange Juice      R23.33" + "\n\t2. Cranberry Juice   R32.10" + "\n\t3. Apple Juice       R23.99" + "\n\t4. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each Juice option
      switch ((Juice)breakfast)
      {
        case Juice.OrangeJuice:
        {
          Console.WriteLine("\nOrange Juice selected:  R23.33");
          Console.Write("Quantity of Orange Juices: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Orange Juice", 23.33, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case Juice.CranberryJuice:
        {
          Console.WriteLine("\nCranberry Juice selected:   R32.10");
          Console.Write("Quantity of Cranberry Juices: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Cranberry Juice", 23.33, quantity);
          pal.PutInShoppingCart(pi);

        }
        break;

        case Juice.AppleJuice:
        {
          Console.WriteLine("\nApple Juice selected:   R23.99");
          Console.Write("Quantity of Apple Juices: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Apple Juice", 23.99, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }


    /// <summary>
    /// Hot Drinks Options
    /// </summary>
    public static void Warmdrinks(ProductArrayList pal)
    {
      int breakfast;
      //The Hot drinks menu is displayed for the user to choose from
      Console.Clear();
      Console.WriteLine("\n\t\t\t\t\t-----Restaurant HappyFoods-----\n");
      Console.WriteLine("HOT DRINKS MENU");
      Console.WriteLine("-----------------\n");
      Console.WriteLine("\n\t1. Cappachino      R34.90" + "\n\t2. Hot Chocolate   R42.90" + "\n\t3. Coffee          R29.90" + "\n\t4. Tea             R21.90" + "\n\t5. Menu Page");

      Console.Write("\nPlease make your choice: ");
      breakfast = Convert.ToInt32(Console.ReadLine());

      //Switch case used to get the information on each Hot drink option
      switch ((HotDrinks)breakfast)
      {
        case HotDrinks.Cappachino:
        {
          Console.WriteLine("\nCappachino selected:  R34.90");
          Console.Write("Quantity of Cappachinos: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Cappachino", 34.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case HotDrinks.HotChocolate:
        {
          Console.WriteLine("\nHot Chocolate selected:   R42.90");
          Console.Write("Quantity of Hot Chocolates: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Hot Chocolate", 42.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case HotDrinks.Coffee:
        {
          Console.WriteLine("\nCoffee selected:   R29.90");
          Console.Write("Quantity of Coffees:  ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Coffee", 29.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        case HotDrinks.Tea:
        {
          Console.WriteLine("\nTea selected:   R21.90");
          Console.Write("Quantity of Teas: ");
          int quantity = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quantity: " + quantity);

          //Selection is stored in arraylist and added to shopping cart
          ProductInfo pi = new ProductInfo("Tea", 21.90, quantity);
          pal.PutInShoppingCart(pi);
        }
        break;

        default:
        {
          //Lets the user know the option they chose is not on the list
          Console.WriteLine("The choice you selected is not on the list please choose again");
          Console.ReadKey();
        }
        break;
      }
    }
  }
}