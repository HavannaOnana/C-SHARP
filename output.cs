using System.Data;


Random random=new Random();

bool playAgain=true;
string player;
string computer;

while(playAgain){

  player="";
  computer="";
  while(player!="rock" && player!="paper" && player!="scissors"){
   Console.Write("Enter Rock, Paper or Scissors : ");
   player=Console.ReadLine();
   player=player.ToLower();
  }

  
  switch(random.Next(1,4)){
    
    case 1:
     computer="rock";
     break;

    case 2:
     computer="paper";
     break;

    case 3:
     computer="scissors";
     break;

  }

  Console.WriteLine("Player: "+ player);
  Console.WriteLine("Computer: "+ computer);

  switch(player){

    case "rock":
     if(computer=="rock"){
      Console.WriteLine("It is a draw");
     }
     else if(computer=="paper"){
      Console.WriteLine("You loose");
     }
     else{
      Console.WriteLine("You win");
     }
     break;

     case "paper":
     if(computer=="rock"){
      Console.WriteLine("You win");
     }
     else if(computer=="paper"){
      Console.WriteLine("It is a draw");
     }
     else{
      Console.WriteLine("You loose");
     }
     break;

     case "scissors":
     if(computer=="rock"){
      Console.WriteLine("You loose");
     }
     else if(computer=="paper"){
      Console.WriteLine("You win");
     }
     else{
      Console.WriteLine("It is a draw");
     }
     break;

  }
   
}


















Console.ReadKey();

































