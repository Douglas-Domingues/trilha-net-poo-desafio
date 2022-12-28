using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("+55559999999", "Nokia 1120", "12345678", 512);
nokia.Ligar();
nokia.InstalarAplicativo("Snake II");

Console.WriteLine("iPhone: ");
Iphone iphone = new Iphone("+555599888888", "Iphone 13S", "87654321", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Flap Bird");