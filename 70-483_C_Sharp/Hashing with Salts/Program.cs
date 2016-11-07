using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing_with_Salts
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doAgain = false;
            do
            {
                Console.Write("Enter Password : ");
                string password = Console.ReadLine();

                string hashedPassword = Hash(password);
                Console.WriteLine("Your password : " + password);
                Console.WriteLine("Your hashed password : " + hashedPassword);

                string hashedSaltedPassword = HashWithSalt(password);
                Console.WriteLine("Your hashed salted password : " + hashedSaltedPassword);

                // user login scenario
                Console.WriteLine("\n\n\nUser logging in again.....");
                Console.Write("Enter Password : ");
                password = Console.ReadLine();
                string hashedPassword2 = Hash(password);
                Console.WriteLine("Your hashed password : " + hashedPassword2);
                string hashedSaltedPassword2 = HashWithSalt(password);
                Console.WriteLine("Your hashed salted password : " + hashedSaltedPassword2);

                // login hashed and salted hashed password comparison
                if (hashedPassword == hashedPassword2 && hashedSaltedPassword == hashedSaltedPassword2)
                {
                    Console.WriteLine("\n\n\nLogin Success");
                }
                else
                {
                    Console.WriteLine("\n\n\nLogin Unsuccessful");
                }

                // looping
                Console.Write("\n\n\nDO it again (y / n) : ");                
                doAgain = Console.ReadLine().ToLower() == "y"? true : false;
            } while (doAgain);
            
        }

        // Hashing a string with a salt
        private static string HashWithSalt(string password)
        {
            string salt = "QsG%):@2,nk";                    // salt is a hard coded random string
            HashAlgorithm algorithm = SHA256.Create();
            string saltedPlainPassword = salt + password;    // just add salt
            byte[] saltedPlainPasswordByteArr = Encoding.Default.GetBytes(saltedPlainPassword);
            byte[] hashedPasswordByteArr = algorithm.ComputeHash(saltedPlainPasswordByteArr);
            string hashedSaltedPasword = Convert.ToBase64String(hashedPasswordByteArr);
            return hashedSaltedPasword;
        } 

        // Hashing a string
        private static string Hash(string password)
        {
            HashAlgorithm algorithm = SHA256.Create();
            byte[] passwordByteArray = Encoding.Default.GetBytes(password);
            byte[] hashedPasswordByteArray = algorithm.ComputeHash(passwordByteArray);
            string hashedPassword = Convert.ToBase64String(hashedPasswordByteArray);
            return hashedPassword;
        }
    }
}
