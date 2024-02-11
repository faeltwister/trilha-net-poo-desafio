using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i1 = new("961399185","12S","5458-56D",512);

Console.WriteLine("Iphone");
i1.ReceberLigacao();
i1.InstalarAplicativo("Zap");

Console.WriteLine("--------------");

Nokia n1 = new("961355658","C55","9085-48A",128);
Console.WriteLine("Nokia");
n1.ReceberLigacao();
n1.InstalarAplicativo("Linkedin");
