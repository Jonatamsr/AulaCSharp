using System;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("BARCO: Acelerando, empurrando maneta");
            Velocidade += 3;
        }

        public void Frenar()
        {
            Console.WriteLine("BARCO: Pisando no pedal (freio)...");
            Velocidade -= 5;
        }
    }
}
