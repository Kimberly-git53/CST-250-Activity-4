using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public class PizzaOrder
{
    

    //Properties
    public string Name { get; set; }
    public List<string> Toppings { get; set; }
    public List<string> OtherToppings { get; set; }
    public enum CrustType
    {
        Thin,
        HandTossed,
        DeepDish,
        CheeseStuffed
    }
    public CrustType Crust { get; set; }
   
    public int Sauceqty { get; set; }
    public int Garlicqty { get; set; }
    public int Parmesanqty { get; set; }
    public DateTime Delivery { get; set; }
    public int NumberOfPizzas { get; set; }
    public int CheeseLevel { get; set; }
    public string SauceColorHex { get; set; }


    // Constructors
    public PizzaOrder(string name, List<string> toppings, List<string> otherToppings, 
        CrustType crust, int sauceqty, int garlicqty, int parmesanqty, 
        DateTime delivery, int numberOfPizzas, int cheeseLevel, string saucecColorHex)
    {
        Name = name;
        Toppings = toppings;
        OtherToppings = otherToppings;
        Crust = crust;
        Sauceqty = sauceqty;
        Garlicqty = garlicqty;
        Parmesanqty = parmesanqty;
        Delivery = delivery;
        NumberOfPizzas = numberOfPizzas;
        CheeseLevel = cheeseLevel;
        SauceColorHex = saucecColorHex;
    }

    public PizzaOrder()
    {
        // Default constructor
        Toppings = new List<string>();
        OtherToppings = new List<string>();
        Delivery = DateTime.Now;
    }
}

