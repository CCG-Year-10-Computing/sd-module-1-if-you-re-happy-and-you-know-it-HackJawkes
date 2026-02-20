// Program name: ChatJTH - 3 Star if Statement Module
// Created on: 11/02/26
// Created by: Jack Hawkes


// Declare Variables here
using System.ComponentModel.Design;
bool correctInput = false;
bool nameTrue = false;
string name = ("");
int age = 0;
int loop = 0;
string ageInput = ("");
string favColour = ("");
string userInput = ("");

List<string> options = new List<string>
{
    "penne",
    "spaghetti",
    "bow tie",
    "macaroni",
    "lasagna",
    "linguini",
    "rigatoni",
    "ravioli",
    "gnocchi"
};


//Start of chatbot
Console.WriteLine("Welcome to ChatJTH! I'm your really basic chatbot!");
Console.WriteLine("Lets start with your name. What is it?");
while (!nameTrue)
{
    Console.Write("- ");
    name = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
    {
        Console.WriteLine();
        Console.WriteLine("I don't think that's a name. Please enter your name this time...");
    }

    else
    {
        Console.WriteLine();
        nameTrue = true;
    }
}

Console.WriteLine($"Nice to meet you {name}! How old are you?");

while (age == 0)
{
    Console.Write("- ");
    ageInput = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(ageInput) || ageInput.All(char.IsDigit))
    {
        age = Convert.ToInt32(ageInput);

    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("I don't think thats a number. Please only use numbers for age. :)");
    }
}

Console.WriteLine();
Console.WriteLine($"Cool! So your name is {name} and you are {age} years old. What is your favourite colour?");

while (loop != 3)
{
    Console.Write("- ");
    favColour = Console.ReadLine();
    if (Enum.TryParse<ConsoleColor>(favColour, true, out var colour))
    {
        Console.ForegroundColor = colour;
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"I don't think {favColour} is a colour. Do you like any others?");
        loop++;
    }

}

if (loop >= 3)
{
    Console.WriteLine();
    Console.WriteLine($"That's fine {name}, lets talk about something else.");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Nice, I like {favColour} too!");
    loop = 0;
}
nameTrue = false;
Console.WriteLine($"Tell me {name}, do you like pasta or sushi better?");
while (!nameTrue)
{
    Console.Write("- ");
    userInput = Console.ReadLine();

    if (userInput.ToLower() == "pasta")
    {
        correctInput = true;
        Console.WriteLine();
        Console.WriteLine($"Nice {name}, I love pasta too! Personally, I preffer penne, but what about you?");
        Console.Write("- ");
        userInput = Console.ReadLine();
        if (options.Contains(userInput))
        {
            Console.WriteLine();
            Console.WriteLine($"Yeah, I like {userInput} too!");
        }

    }
    else if (userInput.ToLower() == "sushi")
    {
        correctInput = true;
        Console.WriteLine();
        Console.WriteLine($"Cool! I like sushi too {name}! Do you like chicken or fish?");
        Console.Write("- ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "chicken" || userInput.ToLower() == "fish")
        {
            Console.WriteLine();
            Console.WriteLine($"Yeah, {userInput} sushi is great.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("I haven't seen sushi with that in it before, but I'm sure it tastes great!");
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Sorry, I didn't understand. Do you prefer pasta or sushi?");
    }

    if (correctInput == true)
    {
        Console.WriteLine();
        Console.WriteLine($"Do you want to keep talking {name} or are you done?");
        Console.Write("- ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
        {
            Console.WriteLine(); Console.WriteLine($"That's all good {name}. Do you like sushi or pasta?");
        }
        else
        {
            Console.WriteLine(); Console.WriteLine($"That's all good {name}. We can talk again any time.");
            Console.WriteLine($"Bye {name}!");
            break;
        }
    }
}

