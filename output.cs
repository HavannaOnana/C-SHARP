using System.ComponentModel.Design;
using System.Data;
using System;




class Program{
   
  static void Main(){
  
  int[] intarray={1,2,3};
  string[] namearray={"Aba","Luke","Preach"};
  double[] doublearray={0.1,2.4,3.3};

  display(intarray);

   

  }

  public static void display<thing>(thing[] array){
   foreach(thing item in array){
      Console.WriteLine(item);
   }
  }


}
























