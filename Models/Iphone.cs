namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Realizando a instalação do {nomeApp} no seu iPhone.");
            Console.Beep(40, 500);
            Console.WriteLine($"{nomeApp} instalado com sucesso!\n");
        }
    }
}