Console.Write("Введите имя польователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура,этоже МАША!!!");
}
else
{
    Console.Write("привет,");
    Console.WriteLine(username);
}
