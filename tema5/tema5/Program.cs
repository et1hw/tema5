using System;

namespace WarehouseStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список товаров на складе
            string[] warehouseItems = { "Laptop", "Monitor", "Keyboard", "Mouse", "Printer" };

            // Пользователь вводит название товара
            Console.Write("Введите название товара для поиска: ");
            string input = Console.ReadLine();

            // 1. Compare()
            Console.WriteLine("\n=== Использование Compare() ===");
            foreach (var item in warehouseItems)
            {
                int comparison = string.Compare(item, input, StringComparison.OrdinalIgnoreCase);
                if (comparison == 0)
                {
                    Console.WriteLine($"Товар \"{input}\" найден (сравнение игнорируя регистр).");
                }
            }

            // 2. Equals()
            Console.WriteLine("\n=== Использование Equals() ===");
            foreach (var item in warehouseItems)
            {
                if (item.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Товар \"{input}\" найден через Equals().");
                }
            }

            // 3. CompareOrdinal()
            Console.WriteLine("\n=== Использование CompareOrdinal() ===");
            foreach (var item in warehouseItems)
            {
                if (string.CompareOrdinal(item, input) == 0)
                {
                    Console.WriteLine($"Точное совпадение найдено с помощью CompareOrdinal().");
                }
            }

            // 4. IndexOf()
            Console.WriteLine("\n=== Использование IndexOf() ===");
            foreach (var item in warehouseItems)
            {
                if (item.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine($"Название \"{input}\" найдено в \"{item}\" через IndexOf().");
                }
            }

            // 5. Contains()
            Console.WriteLine("\n=== Использование Contains() ===");
            foreach (var item in warehouseItems)
            {
                if (item.Contains(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Название \"{input}\" содержится в \"{item}\" через Contains().");
                }
            }

            // 6. Операторы == и !=
            Console.WriteLine("\n=== Использование операторов == и != ===");
            foreach (var item in warehouseItems)
            {
                if (item == input)
                {
                    Console.WriteLine($"Точное совпадение с \"{input}\" через оператор ==.");
                }
                else if (item != input)
                {
                    Console.WriteLine($"\"{item}\" не совпадает с \"{input}\" через оператор !=.");
                }
            }

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}
