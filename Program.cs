            string[] array;
            Console.WriteLine("Введите,пожалуйста, массив строк. Для разделения используйте пробел");
            string str = Console.ReadLine();
            array = str.Split(' ');
            var resultArray = new string[array .Length];
            var realSize = 0;
            foreach (var value in array )
            {
                if (value.Length <= 3)
                {
                    resultArray[realSize] = value;
                    realSize++;
                }
            }
             Console.WriteLine("Формирую массив из строк:");
            Console.WriteLine(string.Join(Environment.NewLine, resultArray, 0, realSize));
            Console.ReadKey(true);