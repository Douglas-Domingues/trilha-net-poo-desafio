namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Realizando a instalação do {nomeApp} no seu Smartphone Nokia.");
            Console.Beep(40, 500);
            Console.WriteLine($"{nomeApp} instalado com sucesso!\n");
        }
    }
}