using System.ComponentModel.Design;
using System.Data;



class Program{

   static void Main(){

      Car[] garage=new Car[3];
     
     Car car1=new Car("Mercedes");
     Car car2=new Car("Toyota");
     Car car3=new Car("Lambo");

     garage[0]=car1;
     garage[1]=car2;
     garage[2]=car3;

     foreach(Car car in garage){
      Console.WriteLine(car.model);
     }

     
   }
}



class Car{

   public String model;

   public Car(string model){
      this.model=model;
   }
}






































