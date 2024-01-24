using System.ComponentModel.Design;
using System.Data;



class Program{

   static void Main(){
     
     Car car=new Car();
     Boat boat=new Boat();
     
   }
}


class Vehicle{

   public int speed=0;

   public void go(){
      Console.WriteLine("This vehicle is moving");
   }
}


class Car: Vehicle{
   public int wheels=4;
   int maxspeed=500;
};

class Boat:Vehicle{
   public int wheels=0;
   int maxspeed=1000;
}








































