namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" herança feita
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string nome, string modelo, string imei, int memoria) : base(numero,nome, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" feito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando a plicativo {nomeApp} no celular {Nome}");
        }
    }
}