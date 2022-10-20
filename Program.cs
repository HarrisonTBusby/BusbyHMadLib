//Harrison Busby
//10/17/2022
//Mini Challenge 5 Redux
//Mad Lib

string playAgain = "yes";
string mad1;
string mad2;
string mad3;
string mad4;
string mad5;
string mad6;
string mad7;
string mad8;
string mad9;
string mad10;


while(playAgain == "yes"){

Console.WriteLine("Lets do a MadLib.");

Console.WriteLine("First we need a noun (place)");
mad1 = Console.ReadLine();


Console.WriteLine("Now we need a proper noun (Name)");
mad2 = Console.ReadLine();


Console.WriteLine("Now we need a verb (action (singular) )");
mad3 = Console.ReadLine();

Console.WriteLine("Now we need a adjective (describing word)");
mad4 = Console.ReadLine();

Console.WriteLine("Now we need a noun (place)");
mad5 = Console.ReadLine();


Console.WriteLine("Now we need a proper noun (Name)");
mad6 = Console.ReadLine();


Console.WriteLine("Now we need a verb + ed (action + ed)");
mad7 = Console.ReadLine();


Console.WriteLine("Now we need an adjective (describing word)");
mad8 = Console.ReadLine();

Console.WriteLine("Now we need noun (place)");
mad9= Console.ReadLine();


Console.WriteLine("Now we need a noun (place)");
mad10 = Console.ReadLine();

Console.WriteLine($"A man once went to the {mad1}. When he went there he encountered a wild {mad2}. Once he saw the {mad2} he {mad3} it as brutally as he could.");
Console.WriteLine($"Once the man {mad3} it, he became {mad4}.");
Console.WriteLine($"Once the man became {mad4}, he went on to befriend the wild {mad2}. Once they became good friends, they came to an {mad5}.");
Console.WriteLine($"While in the {mad5}, they met another. Their name was {mad6}.");
Console.WriteLine($"Once {mad2} and {mad6} met eachother, they {mad7} eachother."); 
Console.WriteLine($"They two continued to {mad7} until they eventually became {mad8}.");
Console.WriteLine($"After a while, they stopped and started going toward the {mad9}.");
Console.WriteLine($"When they got there they saw the {mad10} and they couldn't be any happier.");
Console.WriteLine("THE END");

Console.WriteLine("Would you like to play again?");
playAgain = Console.ReadLine();
if(playAgain == "yes"){
Console.WriteLine("Lets play again");
}else{
    Console.WriteLine("Go away.");

}
}
