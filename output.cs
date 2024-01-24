using System.ComponentModel.Design;
using System.Data;



class Program{

   static void Main(){

      Car car1 =new Car("Mustang","red");

      Car car2=Copy(car1);

      Console.WriteLine($"{car2.color} {car2.model}");

     
   }

   public static Car Copy(Car car){
      return new Car(car.model,car.color);
   }

     
   
}



class Car{

   public String model;
   public String color;

   public Car(string model,string color){
      this.model=model;
      this.color=color;
   }
}






































