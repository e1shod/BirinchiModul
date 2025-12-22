namespace UyIshi1._11
{
    internal class Program
    {
        static List<Fruit> fruits = new List<Fruit>();

        static void Main(string[] args)
        {
            Fruit fruit1 = new Fruit()
            {
                Id = Guid.NewGuid(),
                Name = "Olma",
                Color = "Qizil",
                Price = 2.5m,
                Quantity = 50
            };

            Fruit fruit2 = new Fruit()
            {
                Id = Guid.NewGuid(),
                Name = "Banan",
                Color = "Sariq",
                Price = 3,
                Quantity = 100
            };

            AddFruit(fruit1);
            AddFruit(fruit2);

            DisplayFruits();
            Console.WriteLine("1 step");

            var newFruit = new Fruit()
            {
                Name = "Mandarin",
                Color = "Olov Rang",
                Price = 5,
                Quantity = 70
            };

            UpdateFruit(fruit1.Id, newFruit);

            DisplayFruits();
            Console.WriteLine("2 step");

            RemoveFruit(fruit1.Id);
            DisplayFruits();
        }

        static void AddFruit(Fruit fruit)
        {
            fruits.Add(fruit);


        }
        static void RemoveFruit(Guid Id)
        {
            foreach (var fruit in fruits)

            {
                if (fruit.Id == Id)
                {
                    fruits.Remove(fruit);
                    break;

                }
            }
        }

        static void UpdateFruit(Guid Id, Fruit newFruit)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Id == Id)
                {
                    newFruit.Id = Id;
                    fruits[i] = newFruit;
                    break;
                }
            }
        }


        static void DisplayFruits()
        {
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"fruit ID: {fruit.Id}");
                Console.WriteLine($"Nomi: {fruit.Name}");
                Console.WriteLine($"Rangi: {fruit.Color}");
                Console.WriteLine($"Narxi: {fruit.Price}");
                Console.WriteLine($"Miqdori: {fruit.Quantity}");
                Console.WriteLine();
            }
        }
    }
}
