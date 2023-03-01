using System;

namespace Cezar
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Podaj wartość klucza: ");
            int key = 0;
            try
            {
                key = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Wprowadzona wartość nie jest prawidłowa.");
            }
            Console.Write("Podaj hasło: ");
            String line = Console.ReadLine();
            string cezarLine = encrypt(line, key);
            Console.WriteLine(cezarLine);
        }

        private static String encrypt(String line, int key)
        {
            String encrypted = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsLower(line[i]))
                {
                    int characterIndex = line[i] - (char)('a');
                    int characterShifted = (characterIndex + key) % 26 + (char)('a');
                    encrypted += (char)(characterShifted);
                }
                else if (Char.IsUpper(line[i]))
                {
                    int characterIndex = line[i] - (char)('A');
                    int characterShifted = (characterIndex + key) % 26 + (char)('A');
                    encrypted += (char)(characterShifted);
                }
                else
                {
                    Console.Write("Hasło powinno składać się tylko z małych liter!");
                }
            }
            return encrypted;
        }
    }
}
