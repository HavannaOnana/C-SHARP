using System.ComponentModel.Design;
using System.Data;


class Human{
 
  public string name;
  public int age;

  public void Eat(){
   Console.Write($"{name} is eating");
  }

  public void sleep(){
   Console.Write($"{name} is sleeping");
  }

}


class Program{

   static void Main(){

      Human human1=new Human();
      human1.name="Albert";
      human1.age=33;

      human1.Eat();
      human1.sleep();


      Human human2=new Human();
      human2.name="Alex";
   }


}













































