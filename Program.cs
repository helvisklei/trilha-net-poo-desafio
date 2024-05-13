using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero:"9 99999999",nome:"Nokia", modelo:"Modelo Nokia 11",imei:"111111111",memoria: 64);
Console.WriteLine($"Smartphone {nokia.Nome}:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.FinalizarChamada();

Console.WriteLine(" ");

Smartphone iphone = new Iphone(numero:"9 88888888",nome:"Iphone", modelo: "Modelo Iphone XR", imei:"22222222222",memoria: 128);
Console.WriteLine($"Smartphone {iphone.Nome}");
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.FinalizarChamada();
