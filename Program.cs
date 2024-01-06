using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

nokia.ExibirInformacoes();

Console.WriteLine("\n");

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ExibirInformacoes();

Console.WriteLine("\n");

iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();