using System.ComponentModel.Design;
using System.Data;



class Program{

   static void Main(){

      Mercedes mercedes=new Mercedes();
      Ferrari ferrari=new Ferrari();


      mercedes.drive();
      ferrari.drive();
         
      

   }

     
   
}



class Car{
 
 public virtual void drive(){
   Console.WriteLine("The car drives");
 }

}

class Mercedes:Car{
    public override void drive()
    {
        Console.WriteLine("This Mercedes is lite ");
    }

}

class Ferrari: Car{
    public override void drive()
    {
        Console.WriteLine("This Ferrari is fire");
    }
}






































