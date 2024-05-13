namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
{
    public Samsung(string numero,string nome, string modelo, string imei, int memoria) : base(numero,nome, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        throw new NotImplementedException();
    }
}
}