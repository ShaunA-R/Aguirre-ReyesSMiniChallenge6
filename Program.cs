//Shaun Aguirre-Reyes
// 10/18/22
// This program the computer decides whether a number is odd or even



Console.Clear();

int i;
string playAgain = "yes";
while(playAgain == "yes"){


Console.Write("Enter a Number: ");
i = int.Parse(Console.ReadLine());
if (i % 2 == 0)
{
Console.Write("Entered Number is an Even Number. ");
}else
{
Console.Write("Entered Number is an Odd Number. ");
}
Console.WriteLine("Would you like to play again?");

playAgain = Console.ReadLine();

if(playAgain == "yes"){
    Console.WriteLine("Lets try again");
}else{
    Console.WriteLine("Have an amazing day then :)");
}
}
