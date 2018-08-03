using Aula0208_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.Modelo = "Eclipse GST";
            car.Acelerar();
            ExecutaTesteMotor(car);
            Console.ReadKey();

            Moto moto = new Moto();
            moto.Modelo = "R1";
            moto.Acelerar();
        }

        static void ExecutaTesteMotor(IMotorizado vec)
        {
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);
            vec.Frenar();
            vec.Frenar();
            Console.WriteLine("Velocidade atual: " + vec.Velocidade);

        }
    }
}
