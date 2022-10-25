using DesafioPOO.Models;

var aparelho1 = new Nokia(numero: "11 111111111", modelo: "Nokia 12", memoria: "128");
aparelho1.InstalarAplicativo("Instagram");
aparelho1.InstalarAplicativo("Whatsapp");
aparelho1.Ligar();
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("");

var aparelho2 = new Iphone(numero: "22 222222222", modelo: "Iphone 12 Pro MAX", memoria: "256");
aparelho2.InstalarAplicativo("Instagram");
aparelho2.InstalarAplicativo("Whatsapp");
aparelho2.ReceberLigacao();






// TODO: Realizar os testes com as classes Nokia e Iphone