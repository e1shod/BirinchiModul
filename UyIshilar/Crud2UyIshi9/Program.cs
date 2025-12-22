namespace Crud2UyIshi9
{
    internal class Program
    {
        // CRUD => Create Read Update Delete
        static List<string> Ids = new List<string>();
        static void Main(string[] args)
        {
            var newL = string.Empty;
            var oldP = string.Empty;
            var log = string.Empty;
            while (true)
            {
                Console.WriteLine("1. Login va parol qoshing");
                Console.WriteLine("2. Loginni o'chiring");
                Console.WriteLine("3. Loginni o'chiring");
                Console.WriteLine("4. Loginlar va parollarni ko'rish ko'rish");
                Console.WriteLine("5. Parol yangilash");
                Console.WriteLine("6. Quit");
                Console.Write("Kiriting : ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Loginni kiriting : ");
                    newL = Console.ReadLine();
                    var res = ValidateId(newL);
                    var exists = Ids.Contains(newl);
                    if (res == true && exists == false)
                    {
                        AddId(newL);
                        Console.WriteLine("Id muvaffaqiyatli qo'shildi.");
                    }
                    else
                    {
                        Console.WriteLine("Id noto'g'ri formatda kiritildi.");
                    }
                }
                else if (choice == 2)
                {
                    Console.Write("Id ni kiriting : ");
                    newP = Console.ReadLine();
                    var exists = Ids.Contains(newP);
                    if (exists == true)
                    {
                        DeleteId(newP);
                        Console.WriteLine("Id muvaffaqiyatli o'chirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Bunday id mavjud emas.");

                    }
                }
                else if (choice == 3)
                {
                    DisplayIds();
                }
                else if (choice == 4)
                {
                    Console.Write("Eski id ni kiriting : ");
                    oldP = Console.ReadLine();
                    Console.Write("Yangi id ni kiriting : ");
                    newP = Console.ReadLine();
                    var validateRes = ValidateId(newP);
                    var exists = Ids.Contains(oldP);

                    if (validateRes == true && exists == true)
                    {
                        UpdateId(oldP, newP);
                        Console.WriteLine("Id muvaffaqiyatli yangilandi.");
                    }
                    else
                    {
                        Console.WriteLine("Id yangilashda xatolik yuz berdi.");
                    }

                }
                else
                {
                    Console.WriteLine("Davay");
                    break;
                }


                Console.ReadKey();
                Console.Clear();
            }



        }

        static void AddId(string id)
        {
            Ids.Add(id);
        }

        static void DeleteId(string id)
        {
            Ids.Remove(id);
        }

        static void DisplayIds()
        {
            foreach (var id in Ids)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine();
        }

        static void UpdateId(string oldP, string newP)
        {
            var index = Ids.IndexOf(oldP); // AE4557789
            if (index != -1)
            {
                Ids[index] = newP;
            }
        }

        static bool ValidateId(string id)
        {
            if (id >= "A" && id =< "Z"; ) // "AeR4578855"
            {
                return false;
            }

            if (!char.IsUpper(id[0]) || !char.IsUpper(id[1]))
            {
                return false;
            }

            for (int i = 2; i < id.Length; i++)
            {
                if (!char.IsDigit(id[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
