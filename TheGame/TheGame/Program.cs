using System.ComponentModel.Design;

Console.WriteLine("H-hey, so um, I know this isn't a great place to be doing this, but we're supposed to make you smile, and this is, like, literally the only way to do that, at least, that's what we were told. So, um, first of all, what's your name?");
//this sets the players name. this is shown with string interpolation a little bit later as well
string playerName = Console.ReadLine();

if (playerName == "stinkystinkymrfuck")
{
    Console.WriteLine("Alright man, I'm not gonna make you go back and change that, but like, I can tell you're lying.");
}
else{
    Console.WriteLine($"Ok, so your name is {playerName}. that's good to know.");
}
Console.WriteLine("Anyways, we're supposed to like, ask you some trivia questions about our life, or whatever. I'm just reading off of this sheet here... it says that we're gonna ask you 10 questions, you get a point for each one. and if you get 5 or more right, you win, apparently.");
Console.WriteLine("Did you like, get all that?");
string AnswerOne = Console.ReadLine();
if (AnswerOne == "yes")
{
    Console.WriteLine("Alright, good, we can get started on this.");
}
else if (AnswerOne == "no")
{
     Console.WriteLine("Look, man, I'm really sorry but we just like, really don't have the time to go over this again, so we're just gonna keep moving.");
}
else
{
    Console.WriteLine("Let's just- let's just get this done and over with, man.");
}
Console.WriteLine("first question. Which person, often considered the 5th smiling friend, was unfortunately fired by Mr. Boss?");
Console.WriteLine("A: Pim B: Tyler");
Console.WriteLine("C: Charlie D: Desmond");
//setting point value to 0 to be added onto later with correct answers
int points = 0;
//if the input is anything but the correct answer, the program will count it as incorrect regardless of if it was an actual answer or not
string AnswerTwo = Console.ReadLine();
if (AnswerTwo == "B")
{
    points += 1;
    Console.WriteLine($"Yeah, dude! You got one right! Now you got {points} point. Just- get four more And you'll have this in the bag.");
}
else if (AnswerTwo == "tyler")
{
    points += 1;
    Console.WriteLine($"Yeah, man!You got one right! Now you got {points} point. Just- get four more And you'll have this in the bag.");
}
//Both the letter and the name would be correct here
else
{
    Console.WriteLine($"Aw, sorry, man. But- it's only the first question, you've still got like, nine left. Still {points} points, though.");

}
//interpolation was also used here, I didn't realize I was supposed to use it at first LOL
//from here on out, the same stuff mostly applies from before, so you probably know how it works at this point. The following code is only really used for new questions/answers
Console.WriteLine("Second question. In the first episode, The character Desmond is famously voiced by someone from this YouTube channel:");
Console.WriteLine("A: RedLetterMedia B: MeatCanyon");
Console.WriteLine("C: Vinesauce D: Dead Meat");
string AnswerThree  = Console.ReadLine();
if (AnswerThree == "A")
{
    points += 1;
    Console.WriteLine($"Awesome job, man! That's {points} points you have now.");
}
else if (AnswerThree == "redlettermedia")
{
    points += 1;
    Console.WriteLine($"Awesome job, man! That's {points} points you have now.");
}
else
{
    Console.WriteLine($"Sorry, man. You're still at {points} points.");
}

Console.WriteLine("Third question. What video game does Mr. Landlord want Allan to play with him?");
Console.WriteLine("A: Halo: Combat Evolved for the Xbox B:Baldur's Gate 3 for the PS5");
Console.WriteLine("C:Ghostbusters for the NES D: Burnout Revenge for the PS2");
string AnswerFour = Console.ReadLine();
if (AnswerFour == "D")
{
    points += 1;
    Console.WriteLine($"You're killing it, man! That's {points} points you're at now.");
}
else if (AnswerFour == "burnout revenge")
{
    points += 1;
    Console.WriteLine($"You're killing it, man! That's {points} points you're at now.");
}
else if (AnswerFour == "burnout revenge for the ps2")
{
    points += 1;
    Console.WriteLine($"You're killing it, man! That's {points} points you're at now.");
}
else
{
    Console.WriteLine($"Sorry, man. That's still {points} points.");
}
Console.WriteLine("Fourth Question. The rival business to The Smiling Friends is called:");
Console.WriteLine("A: The Frowning Friends B: The Laughing Friends");
Console.WriteLine("C: The Crying Friends D: The Mourning Friends");
string AnswerFive = Console.ReadLine();
if (AnswerFive == "A")
{
    points += 1;
    Console.WriteLine($"Sick, dude! That's {points} points.");
}
else if (AnswerFive == "the frowning friends")
{
    points += 1;
    Console.WriteLine($"Sick, dude! That's {points} points.");
}
else
{
    Console.WriteLine($"Come on, man! That's still {points} points. You were right there!");
}
Console.WriteLine("Fifth question. Mr Frog won his presidential campaign against what other person?");
Console.WriteLine("A: Glep B: Barack Obama");
Console.WriteLine("C: President Jimble D: Jimmy Fallon");
string AnswerSix = Console.ReadLine();
if (AnswerSix == "C")
{
    points += 1;
    Console.WriteLine($"W-wow, man, I honestly didn't expect you to get that. Even got you to {points} points, jeez.");
}
else if (AnswerSix == "president jimble")
{
    points += 1;
    Console.WriteLine($"W-wow, man, I honestly didn't expect you to get that. Even got you to {points} points, jeez.");
}
else
{
    Console.WriteLine($"Aw, man. I was really hoping you'd get that one. But you're still stuck at {points} points...");
}
