namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ab;
            Povtor:
                Console.WriteLine("Выберите какую операцию вы хотите сделать: ");
                Console.WriteLine("\r\n1. Игра угадай число\r\n" +
                                  "2. Таблица умножения\r\n" +
                                  "3. Вывод делителей числа\r\n" +
                                  "4. Выход из программы\r\n");

               
                ab = Convert.ToInt32(Console.ReadLine());
                while (ab != 4)
                {
                    if (ab == 1)
                    {
                        As();
                    goto Povtor;
                    }
                    if (ab == 2)
                    {
                        Ar();
                    goto Povtor;
                    }
                    if (ab == 3)
                    {
                        AD();
                    goto Povtor;
                    }
                    if (ab == 4)
                    {
                        PI();
                    goto Povtor;
                    }
                }
                static void As()
                {
                    {
                        Random rand = new Random();
                        int a = rand.Next(100);
                        int count = 1;
                        Console.WriteLine("Число от 0 до 100 загадано");
                        Console.WriteLine("Введите число:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        while (count <= 8)
                        {
                            if (a == b)
                            {
                                Console.WriteLine("Компьютер загадал число" + b + "Поздравляю, вы угадали число");
                                break;
                            }
                            else
                            {
                                count++;
                                if (count == 9)
                                {
                                    Console.WriteLine("Число не отгано " + a);
                                    break;
                                }
                                if (b < a)
                                {
                                    Console.WriteLine("Число больше");
                                }
                                if (b > a)
                                {
                                    Console.WriteLine("Число меньше");
                                }
                                Console.WriteLine("Число не угадано. Попытка " + count);
                                b = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                }
                static void Ar()
                    {
                    for (int m = 1; m < 10; m++)
                    {
                        for (int c = 1; c < 10; c++)
                        {
                            Console.Write("{0} ", m * c);
                            if (c == 9)
                            {
                                Console.WriteLine();
                            }
                        }
                    }
                    }
                static void AD()
                {
                    Console.WriteLine("Введите любое число для разложение на множетели ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    for (int t = 1; t <= y; t++)
                    {
                        if (y % t == 0)
                            Console.WriteLine(t);
                    }
                }
                    static void PI()
                    {
                    Console.WriteLine("Завершение программы.");
                    }
                    
                    
            }
        }               
    }
   
  
    
