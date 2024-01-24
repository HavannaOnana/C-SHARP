using System.ComponentModel.Design;
using System.Data;



class Program{

   static void Main(){

    
    Mercedes mercedes=new Mercedes();
    Ferrari ferrari=new Ferrari();
    Lambo lambo=new Lambo();

    Car[] vehicles={mercedes,ferrari,lambo};

    foreach(Car car in vehicles){
      car.Go();
    }
    
 

   }

     
   
}



class Car{
  public virtual void Go(){
    Console.WriteLine("Move");
  }

}


class Mercedes: Car{
  public override void Go(){
   Console.WriteLine("The Mercedes is moving");
  }
}

class Ferrari: Car{

 public override void Go(){
   Console.WriteLine("The Ferrari is moving");
  }

}

class Lambo:Car{

}


































