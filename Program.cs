//Samuel Laguna
//09-17-22
//Today I am going to build a guessing game. Using a function 



bool playAgain = true;
bool end = false;
 int easyLvl = 11;
 int medLvl = 51;
 int hardLvl = 101;
 int winningNumber = 0;
 int gameMaxNum = 0;
 int numGuess = 0;
 string userInput;
 string option;
 int randomNum = 0;
 int guessCount = 0;
bool validNum = false;
while(playAgain == true){
Console.WriteLine("Guessing game what level would you like to play.");
Console.WriteLine("Easy - Guessing form 1 -10");
Console.WriteLine("Medium - guessing from 1 - 50");
Console.WriteLine("Hard - Guessing from 1 - 100");

option = Console.ReadLine();

while(option != "Easy" && option != "Medium" && option != "Hard"){
 Console.WriteLine("Did i enter a valid choice");
 option = Console.ReadLine();
}

Console.WriteLine("you chose " + option);

Random random = new Random();
if(option == "Easy"){
  winningNumber = random.Next(0, easyLvl);
  gameMaxNum = easyLvl - 1;
  
}
if(option == "Medium"){

    winningNumber = random.Next(0, medLvl);

    gameMaxNum = medLvl -1;
}
if(option == "Hard")
{
    winningNumber = random.Next(0, hardLvl);
    gameMaxNum = hardLvl -1;
}

while(validNum == false)
{
    Console.WriteLine("Enter a number from 1 to " + gameMaxNum);
    userInput = Console.ReadLine();
    validNum = Int32.TryParse(userInput, out numGuess);
if(validNum == true){

 if ((numGuess <= gameMaxNum) && (numGuess >= 1))
 {
 validNum = true;
 }
 
else
{
    Console.WriteLine("Please pick a valid number.");
    validNum = true;
}  




   
}else{
    Console.WriteLine("You entered something that is not a number, Please pick a number.");
}


}




if(numGuess == winningNumber)
{
    Console.WriteLine("You are correct! The winning number was " + winningNumber);
    validNum = true;
}

else if(numGuess > winningNumber){
  Console.WriteLine("Num is to big");
  validNum = true;
}

else if(numGuess < winningNumber)
{
    Console.WriteLine("You number is to low.");
}


while(numGuess != winningNumber){
        Console.ReadLine();

    if(numGuess !> winningNumber){
        validNum = true;
    }else{
        Console.WriteLine("Please try another number");
        validNum = true;
    }
}
string ending = Console.ReadLine();
        if(ending == "end")
        {
            playAgain = false;
        }else
        {
            end = true;
        }
}



