//string[] heroes = { "Harry Potter", "Spiderman", "Luke Skywlker", "Frodo" };
//string[] villains = { "Dracula", "Joker", "Sauron", "Darth Vader", "Voldemort" };


using System.IO;

string folderPath = @"C:\automateinstall\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";
string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] lines = File.ReadAllLines(folderPath + heroFile);
string[] weapon = { "magic wand", "light sabre", "fork", "wooden sword", "lego brick" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"{hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"{villain} with {villainWeapon} takes over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rand = new Random();
    int RandomIndex = rand.Next(0, someArray.Length);
    string randomStringFromArreay = someArray[RandomIndex];
    return randomStringFromArreay;

} 

