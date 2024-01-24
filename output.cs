using System.ComponentModel.Design;
using System.Data;


// method for checking out

static double CheckOut( params double[] prices){
   double total= 0;
   
   foreach(double price in prices){
      total=total+ price;
   }

   return total;
}

static void Main(){
   double total=CheckOut(3.99,2.42,12.3);

   Console.WriteLine(total);

}

Main();































Console.ReadKey();

































