namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string NomeApp { get; set; }
        public string Numero { get; set; }
        public string ModeloCel { get; set; }

        public string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string memoria)
        {
            Numero = numero;
            ModeloCel = modelo;
            Memoria = memoria;
            Console.WriteLine($"Dados do smartphone:");
            Console.WriteLine($"Modelo: {ModeloCel}");
            Console.WriteLine($"Nª: {Numero}");
            Console.WriteLine($"Espaço disponível: {Memoria}GB");
            Console.WriteLine("");

        }
        public void Ligar()
        {
            Console.WriteLine($"Nª {Numero} Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Nª {Numero} Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}