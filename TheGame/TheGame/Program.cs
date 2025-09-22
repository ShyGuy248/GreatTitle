using System.ComponentModel.Design;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("H-hey, so um, I know this isn't a great place to be doing this, but we're supposed to make you smile, and this is, like, literally the only way to do that, at least, that's what we were told. So, um, first of all, what's your name?");
//this sets the players name. this is shown with string interpolation a little bit later as well
string playerName = Console.ReadLine();
Console.WriteLine($"Ok, so your name is {playerName}. that's good to know.");

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
//from here on out, the same stuff mostly applies from before, so you probably know how it works at this point. The following code is only really used for new questions/answers, and follows a very defined pattern
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
Console.WriteLine("Sixth Question. In the finale to season one, The Smiling Friends go to what country?");
Console.WriteLine("A: Brazil B: Japan");
Console.WriteLine("C: Mexico D: Canada");
string AnswerSeven = Console.ReadLine();
if (AnswerSeven == "A")
{
    points += 1;
    Console.WriteLine($"Yeah, that- that trip really sucked. You do NOT wanna know the specifics on that- anyways, {points} points, woohoo...");
}
else if (AnswerSeven == "brazil")
{
    points += 1;
    Console.WriteLine($"Yeah, that- that trip really sucked. You do NOT wanna know the specifics on that- anyways, {points} points, woohoo...");
}
else
{
    Console.WriteLine($"Don't- just, don't even ask, man. {points} points.");
}
Console.WriteLine("Seventh Question. Why was the Mr. Frog show cancelled?");
Console.WriteLine("A: Low ratings B: Mr. Frog put a TMZ reporter in his mouth");
Console.WriteLine("C: Political Controversy D: Mr. Frog smacked a child upside the head on camera and didn't apologize");
string AnswerEight = Console.ReadLine();
if (AnswerEight == "B")
{
    points += 1;
    Console.WriteLine($"Yeah, let's just- move on from that, I don't wanna talk about it. {points} points.");
}
else if (AnswerEight == "mr. frog put a tmz reporter in his mouth")
{
    points += 1;
    Console.WriteLine($"Yeah, let's just- move on from that, I don't wanna talk about it. {points} points.");
}
else
{
    Console.WriteLine($"Oh, so you don't know about what happened. Don't look it up. Seriously. {points} points.");
}
Console.WriteLine("Eighth Question. What was the name of that weird guy who stole all of me and Pim's stuff that one time?");
Console.WriteLine("A: Roy Dismey B: Gwimbly");
Console.WriteLine("C: Glep D: Shrimpina");
string AnswerNine = Console.ReadLine();
if (AnswerNine == "A")
{
    points += 1;
    Console.WriteLine($"How the hell did you know about tha- whatever, we're almost done anyways. {points} points.");
}
else if (AnswerNine == "roy dismey")
{
    points += 1;
    Console.WriteLine($"How the hell did you know about tha- whatever, we're almost done anyways. {points} points.");
}
else
{
    Console.WriteLine($"Yeah, I think I-I'd be concerned if you did know about that, honestly. {points} points.");
}
Console.WriteLine("Ninth Question. Who was the culprit in Simon S. Saltys murder?");
Console.WriteLine("A: Crazy Cup B: Nobody, it turned out he had a heart attack");
Console.WriteLine("C:All of the mascots D: Mustard");
//Yeah, there might be a faster way to do this, but I think this is fairly readable at least and works pretty well for what I'm going for.
string AnswerTen = Console.ReadLine();
if (AnswerTen == "B")
{
    points += 1;
    Console.WriteLine($"Ok, it's getting like, really weird at this point. Who even wrote this...? {points} points.");
}
else if (AnswerTen == "nobody")
{
    points += 1;
    Console.WriteLine($"Ok, it's getting like, really weird at this point. Who even wrote this...? {points} points.");
}
else if (AnswerTen == "nobody, it turned out he had a heart attack")
{
    points += 1;
    Console.WriteLine($"Ok, it's getting like, really weird at this point. Who even wrote this...? {points} points.");
}
else
{
    Console.WriteLine($"Yeah, I'm honestly glad you didn't know that, it's getting like, super weird. {points} points.");
}
Console.WriteLine("Alright, last question, then we can all go home and forget this ever happened.");
Console.WriteLine("What language does Glep speak?");
Console.WriteLine("A: Complete Gibberish B: Wingon");
Console.WriteLine("C: Klingon D: Japanese");
string AnswerEleven  = Console.ReadLine();
if (AnswerEleven == "B")
{
    points += 1;
    Console.WriteLine($"Okay, thank god you got that right. You got {points} points, which means...");
}
else if (AnswerEleven == "wingon")
{
    points += 1;
    Console.WriteLine($"Okay, thank god you got that right. You got {points} points, which means...");
}
else
{
    Console.WriteLine($"Okay, well, you got that one wrong, but I don't think it even matters at this point. You got {points} points, which means...");
}
if (points > 5)
{
    Console.WriteLine($"You won, {playerName}! You got {points} points, and I think we made you smile, so we can all go home and forget this ever happened.");
}
else
{
    Console.WriteLine($"You lost, {playerName} You only got {points} points,  But don't freak out, you, oh, you seem pretty happy anyways. Like, REALLY happy. Um...");
    Console.WriteLine("We'll just- go home, and forget any of this ever happened. Okay? Okay.");
}
