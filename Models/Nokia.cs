namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero,string modelo, string imei,int memoria) : base (numero, modelo, imei, memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo {nome} no {GetModelo()}");
        }
    }
}