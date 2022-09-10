

    //veribles
    int continueGame = 1;
    var random = new Random();
var list = new List<string> { 
 "It is certain.",
 "It is decidedly so.",
 "Without a doubt.",
 "Yes definitely.",
 "You may rely on it.",
 "As I see it, yes.",
 "Most likely.",
 "Outlook good.",
 "Yes.",
 "Signs point to yes.",
 "Reply hazy, try again.", "Ask again later.",
 "Better not tell you now.",
 "Cannot predict now.",
 "Concentrate and ask again.",
 "Don't count on it.",
 "My reply is no.",
 "My sources say no.",
 "Outlook not so good.",
 "Very doubtful." };
int index = random.Next(list.Count);

    // user input 
    Console.ReadLine();
Console.WriteLine("What would you like to ask the magic ball?" );
    Console.ReadLine();
    Console.WriteLine(list[index]);
    Console.WriteLine("Would you like to ask another question? 'Y' for yes, 'N' for no." );
    string choice = Console.ReadLine();



//result

// tests



