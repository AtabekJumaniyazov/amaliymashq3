    //1. Tub sonlar:
    // Foydalanuvchidan son kiritishni so'rash
    Console.Write("Iltimos, biror butun sonni kiriting: ");
    int number = int.Parse(Console.ReadLine());

    // Tub son ekanligini tekshirish
    bool isPrime = number > 1 && !Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                                         .Any(i => number % i == 0);
        // Natijani chiqarish
        Console.WriteLine(isPrime ? "Tub" : "Tub emas");
    //2. Bo'luvchisiz sonlar:
        // Foydalanuvchidan son kiritishni so'rash
        Console.Write("Iltimos, biror butun sonni kiriting: ");
        int number1 = int.Parse(Console.ReadLine());

        // Bo'luvchilarni topish
        List<int> divisors = new List<int>();

        for (int i = 2; i <= 10; i++)
        {
            if (number1 % i == 0)
            {
                divisors.Add(i);
            }
        }

        // Natijani chiqarish
        if (divisors.Any())
        {
            Console.WriteLine("Bo'luvchilari: " + string.Join(", ", divisors));
        }
        else
        {
            Console.WriteLine("2 dan 10 gacha bo'lgan bo'luvchilari yo'q.");
        }
        //3 Daraja hisoblash:
         // Foydalanuvchidan son kiritishni so'rash
        Console.Write("Iltimos, biror butun sonni kiriting: ");
        int number2 = int.Parse(Console.ReadLine());

        // Foydalanuvchidan darajani kiritishni so'rash
        Console.Write("Iltimos, darajani kiriting (musbat butun son): ");
        int exponent = int.Parse(Console.ReadLine());

        // Darajaning musbat butun son ekanligini tekshirish
        if (exponent < 0)
        {
            Console.WriteLine("Daraja musbat butun son bo'lishi kerak.");
            return;
        }

        // Sonni berilgan darajaga ko'tarish
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= number2;
        }

        // Natijani chiqarish
        Console.WriteLine("Natija: " + result);
        //4 Harajatlar to'plamini hisoblash: 
        // Foydalanuvchidan to'plam miqdorlarni kiritishni so'rash
        Console.WriteLine("Iltimos, harajat miqdorlarini kiriting (vergul bilan ajrating): ");
        string input = Console.ReadLine();

        // Kiritilgan qiymatlarni ajratib olish va butun sonlarga o'tkazish
        List<int> amounts = input.Split(',').Select(int.Parse).ToList();

        // Yig'indisini hisoblash
        int total = amounts.Sum();

        // Natijani chiqarish
        Console.WriteLine("Yig'indisi: " + total);
        //5 Armstrong sonlar: 
        // Foydalanuvchidan son kiritishni so'rash
        Console.Write("Iltimos, biror butun sonni kiriting: ");
        int number3 = int.Parse(Console.ReadLine());

        // Sonning raqamlarini olish va Armstrong son ekanligini tekshirish
        if (IsArmstrong(number3))
        {
            Console.WriteLine($"{number3} Armstrong son");
        }
        else
        {
            Console.WriteLine($"{number3} Armstrong son emas");
        }
    

    // Armstrong son ekanligini tekshiruvchi funksiya
    static bool IsArmstrong(int number3)
    {
        int originalNumber = number3;
        int result = 0;
        int numberOfDigits = (int)Math.Floor(Math.Log10(number3)) + 1;

        while (number3 > 0)
        {
            int digit = number3 % 10;
            result += (int)Math.Pow(digit, numberOfDigits);
            number3 /= 10;
        }

        return result == originalNumber;
    }
    //6 Sifatli bo'luvchilar:
     // Foydalanuvchidan son kiritishni so'rash
        Console.Write("Iltimos, biror butun sonni kiriting: ");
        int number4 = int.Parse(Console.ReadLine());

        // Sifatli bo'luvchilar sonini hisoblash
        int count = CountProperDivisors(number4);

        // Natijani chiqarish
        Console.WriteLine($"{number4} raqamining sifatli bo'luvchilari soni: {count}");
    
    // Sifatli bo'luvchilar sonini hisoblovchi funksiya
    static int CountProperDivisors(int number4)
    {
        int count = 0;

        // 1 dan boshlab sonning yarimiga qadar bo'lgan sonlarni tekshiramiz
        for (int i = 1; i <= number4 / 2; i++)
        {
            if (number4 % i == 0)
            {
                count++;
            }
        }

        return count;
    }