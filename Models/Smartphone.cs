namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo{ get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set;}
        public string Nome { get; set;}

        public Smartphone(string numero,string nome,string modelo,string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Nome = nome;
            // TODO: Passar os parâmetros do construtor para as propriedades , feito
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void FinalizarChamada()
        {
            Console.WriteLine("Finalizando a chamada...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}