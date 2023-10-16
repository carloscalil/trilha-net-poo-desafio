using DesafioPOO.Models;

Console.WriteLine($"Smartphone Nokia:");
Smartphone nokia = new Nokia("789546","Modelo Nokia","111222333",32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("------------------------------------------");

Console.WriteLine($"Smartphone Iphone:");
Smartphone iphone = new Iphone("789546I","Modelo Iphone","91112223332",64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
