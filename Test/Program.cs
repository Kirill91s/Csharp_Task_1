                Console.Write("Введите первое число : ");
                int numberA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите первое число : ");
                int numberB = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите первое число : ");
                int numberC = Convert.ToInt32(Console.ReadLine());

                if (numberA < numberB)
                {
                    numberA = numberB;
                }
                if (numberA < numberC)
                {
                    numberA = numberC;
                }
                Console.WriteLine("\r\nСамое большое число : " + numberA);