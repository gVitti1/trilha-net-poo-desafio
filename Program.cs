using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("1234", "M1", "1111111", 64);
Iphone iphone1 = new Iphone("5678", "M2", "2222222", 128);

Console.WriteLine("Smartphone Nokia: ");

nokia1.Numero = "4321";
nokia1.Ligar();
nokia1.InstalarAplicativo("Banco Digital");

Console.WriteLine("Smartphone Iphone: ");

iphone1.Numero = "8765";
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Xadrez Online");
