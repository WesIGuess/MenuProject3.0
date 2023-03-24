using System;

namespace Menu
{
 
  class menuItem
  {

    public string Name {get; set; }
    public string Description {get; set; }
    public string Catagory {get; set; }
   public double Price {get; set; }
   public bool IsNew {get; set; }
   public string Updated {get; set; }

   


       public menuItem(string name, string updated,string description, string catagory, double price, bool isNew)
    {
        Name = name;
        Description = description;
        Catagory = catagory;
        Price = price;
        IsNew = isNew;
        Updated = updated;
       
       

        }
       
    static void Main(string[] args)
    
    { 
      menuItem spaghetti = new menuItem("Spagheti", "3/24/2023","Noodles and sauce", "Main Course", 4.99, true);
      menuItem applePie = new menuItem("Apple Pie", "3/24/2023","All American and all sugar", "Desert", 2.99, false);
      menuItem salad = new menuItem("House Salad", "3/24/2023","Lettuce and other veggies, in a pile, on a plate, very expensive", "Appitizer", 15.99, false);

     if (salad.IsNew == true)
     {Console.WriteLine("This is a new item");}

  Console.WriteLine("Menu  \n   last updated " + DateTime.Now + "\n");
  Console.WriteLine(salad.Catagory + "\n " +  salad.Name +"  Last Updated: " + salad.Updated + "\n " + salad.Description + " \n $" + salad.Price + " ");
   if (salad.IsNew == true)
     {Console.WriteLine("This is a new item!");}
     Console.WriteLine("\n");
  Console.WriteLine( spaghetti.Catagory + "\n " + spaghetti.Name+ "  Last Updated: " + spaghetti.Updated +"\n" + spaghetti.Description + "\n $" + spaghetti.Price + " ");
    if (spaghetti.IsNew == true)
     {Console.WriteLine("This is a new item!");}
     Console.WriteLine("\n");
 Console.WriteLine( applePie.Catagory + " \n" + applePie.Name + "  Last Updated: " + applePie.Updated +"\n " + applePie.Description + "\n $" + applePie.Price + " " );
   if (salad.IsNew == true)
     {Console.WriteLine("This is a new item!");}
    }
 

  }  
}