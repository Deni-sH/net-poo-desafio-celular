namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(modelo, numero, imei, memoria)
        {
            
        }

    public override void InstalarAplicativo(string nomeApp);
         {
           Console.WriteLine($"instalando aplicativo{nomeApp}");
         }
         
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }

}