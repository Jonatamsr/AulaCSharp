using System;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }
        public void Acelerar()
        {
            Console.WriteLine("MOTO: Acelerando pela manopla.");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("MOTO: Pisando no pedal (freio)...");
            Velocidade -= 3;
        }
    }
}
