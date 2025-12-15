namespace UyIshi1._8
{
    class User
    {
        public int Id;
        public string FIO;
        public string PassportSeriya;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> foydalanuvchilar = new List<User>();
            int idSanoq = 1;

            while (true)
            {
                Console.WriteLine("\n1 - Create");
                Console.WriteLine("2 - Reading");
                Console.WriteLine("3 - Update");
                Console.WriteLine("4 - Dalete");
                Console.Write("Tanlang: ");

                int tanlov;
                if (!int.TryParse(Console.ReadLine(), out tanlov))
                {
                    Console.WriteLine("❗ Son kiriting");
                    continue;
                }

                // Create
                if (tanlov == 1)
                {
                    Console.Write("Passport seriyasi: ");
                    string passport = Console.ReadLine();

                    bool borMi = false;
                    foreach (var foydalanuvchi in foydalanuvchilar)
                    {
                        if (foydalanuvchi.PassportSeriya == passport)
                        {
                            borMi = true;
                            break;
                        }
                    }

                    if (borMi)
                    {
                        Console.WriteLine(" Bu passport seriya avval ro'yxatdan o'tgan");
                    }
                    else
                    {
                        Console.Write("F.I.O: ");
                        string fio = Console.ReadLine();

                        foydalanuvchilar.Add(new User
                        {
                            Id = idSanoq,
                            FIO = fio,
                            PassportSeriya = passport
                        });

                        idSanoq++;
                        Console.WriteLine(" Foydalanuvchi qo'shildi");
                    }
                }

                // Reading
                else if (tanlov == 2)
                {
                    if (foydalanuvchilar.Count == 0)
                    {
                        Console.WriteLine(" Ro'yxat bo'sh");
                    }
                    else
                    {
                        foreach (var foydalanuvchi in foydalanuvchilar)
                        {
                            Console.WriteLine($"{foydalanuvchi.Id} | {foydalanuvchi.FIO} | {foydalanuvchi.PassportSeriya}");
                        }
                    }
                }

                // Update
                else if (tanlov == 3)
                {
                    Console.Write("ID kiriting: ");
                    int id;
                    if (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine(" Noto'g'ri ID");
                        continue;
                    }

                    User topildi = null;
                    foreach (var foydalanuvchi in foydalanuvchilar)
                    {
                        if (foydalanuvchi.Id == id)
                        {
                            topildi = foydalanuvchi;
                            break;
                        }
                    }

                    if (topildi == null)
                    {
                        Console.WriteLine(" Topilmadi");
                    }
                    else
                    {
                        Console.Write("Yangi passport seriya: ");
                        string yangiPassport = Console.ReadLine();

                        bool bandMi = false;
                        foreach (var foydalanuvchi in foydalanuvchilar)
                        {
                            if (foydalanuvchi.PassportSeriya == yangiPassport && foydalanuvchi.Id != id)
                            {
                                bandMi = true;
                                break;
                            }
                        }

                        if (bandMi)
                        {
                            Console.WriteLine(" Bu passport seriya band!");
                        }
                        else
                        {
                            topildi.PassportSeriya = yangiPassport;
                            Console.WriteLine(" Passport yangilandi");
                        }
                    }
                }

                // Dalele
                else if (tanlov == 4)
                {
                    Console.Write("ID kiriting: ");
                    int id;
                    if (!int.TryParse(Console.ReadLine(), out id))
                    {
                        Console.WriteLine("❗ Noto'g'ri ID");
                        continue;
                    }

                    User ochiriladi = null;
                    foreach (var foydalanuvchi in foydalanuvchilar)
                    {
                        if (foydalanuvchi.Id == id)
                        {
                            ochiriladi = foydalanuvchi;
                            break;
                        }
                    }

                    if (ochiriladi == null)
                    {
                        Console.WriteLine(" Topilmadi");
                    }
                    else
                    {
                        foydalanuvchilar.Remove(ochiriladi);
                        Console.WriteLine(" O'chirildi");
                    }
                }
                else
                {
                    Console.WriteLine("❗ Noto'g'ri tanlov");
                }
            }
        }
    }
}