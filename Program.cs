using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();

                if (animal is ISwimmer hippo)
                {
                    hippo.Swim();
                }

                if (animal is IPackHunter wolf)
                {
                    wolf.HuntInPack();
                }

                Console.WriteLine();
            }
        }
    }
}
