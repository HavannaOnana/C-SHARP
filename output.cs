using System.Data;


static double multiply(double x, double y){
     double z=x*y;
     return z;
}

static void Main(){
   double x;
   double y;
   double result;

   Console.WriteLine("Enter in the number 1: ");
   x=Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Enter in the number 2: ");
   y=Convert.ToDouble(Console.ReadLine());

   result=multiply(x,y);

   Console.WriteLine(result);



}


Main();














Console.ReadKey();

































