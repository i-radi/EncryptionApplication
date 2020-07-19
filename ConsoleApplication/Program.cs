using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptionV1;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Key: ");
            var key = Console.ReadLine();
            Console.WriteLine("Enter Message: ");
            var message = Console.ReadLine();

            try
            {
                var obj = new Encryption(key);
                Console.WriteLine(obj.getCipher(message));
            }
            catch
            {
                Console.WriteLine("Error etl3 mn hna");
            }

        }
    }
}
