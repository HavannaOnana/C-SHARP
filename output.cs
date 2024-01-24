using System.Data;



Console.Write("What is your first number: ");
double num1=Convert.ToDouble(Console.ReadLine());

Console.Write("What is your second number: ");
double num2=Convert.ToDouble(Console.ReadLine());

Console.Write("Which operators : ");
string operators= Console.ReadLine();


double result;

switch(operators){

  case "+":
   result= num1 + num2;
   Console.WriteLine("the result is "+ result);
   break;

  case "-":
   result = num1 - num2;
   Console.WriteLine("the result is "+ result);
   break;

  case "x":
   result= num1 * num2;
   Console.WriteLine("the result is "+ result);
   break;

  case "/":
   result = num1 / num2;
   Console.WriteLine("the result is "+ result);
   break;

  case "%":
   result=num1 % num2;
   Console.WriteLine("the result is "+ result);
   break;
}
























Console.ReadKey();

































