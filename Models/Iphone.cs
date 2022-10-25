namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string memoria) : base(numero, modelo, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            NomeApp = nomeApp;  
            Console.WriteLine($"Aplicativo {nomeApp} instalado no {ModeloCel}!!");
        }    
    }
}