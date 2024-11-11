bool yippi = false;
string lösenord;

Console.WriteLine("Lösenorddddddd::");

while(yippi == false)
{
    lösenord = Console.ReadLine();
    if(lösenord == "125"){
        Console.WriteLine("Bra jobbat nu hejdå");
        Thread.Sleep(2000);
        yippi = true;
}
else if(string.IsNullOrWhiteSpace(lösenord))
{
    Console.WriteLine("Skriv någotngint snälla");
    continue;
}
else
{
    Console.WriteLine("Feell");
    continue;
}

}
