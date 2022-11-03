using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "8199999-9999", modelo: "Lumia 1020", imei: "123456789", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero:"819999-8888", modelo:"Iphone 11 Plus", imei:"987654321", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

