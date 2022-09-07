// See https://aka.ms/new-console-template for more information

Box s1 = new Box();
Box s2 = new Box();


snake a1 = new snake();
snake a2 = new snake();

s1.name = "brun";
s2.name = "svart";

a1.name = "big boss";
a2.name = "bad snake";

s1.hp -= 70;
a1.hp -= 10;
// ey 

Console.WriteLine(s1.hp);
Console.WriteLine(s2.hp);
Console.ReadLine();
Console.WriteLine("boom an explotion happens injuring multipol members");
Console.ReadLine();
Console.WriteLine(a1.hp);
Console.WriteLine(a2.hp);

Console.WriteLine("Snake dont kill the child or the mission will be a failure");


Console.ReadLine();




