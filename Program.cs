using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia (numero: "142536", modelo: "Nokia 01", imei: "9874563210", memoria: 64);
Console.WriteLine("Teste do Nokia");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Smartphone iphone = new Iphone (numero: "415263", modelo: "Iphone 14", imei: "0123654789", memoria: 128);
Console.WriteLine("Teste do iPhone");
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();
