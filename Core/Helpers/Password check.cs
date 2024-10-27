using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public class Password_check
    {
        public bool PasswordCheck(string password)
        {
            bool IsPasswordCorrect;
            bool correctpassword = false;
            int boyukherf = 0;
            int kicikherf = 0;
            int reqem = 0;




            for (int i = 0; i < password.Length; i++)
            {

                if (Char.IsDigit(password[i]))
                {
                    reqem++;
                }
                if (Char.IsUpper(password[i]))
                {
                    boyukherf++;
                }
                if (Char.IsLower(password[i]))
                {
                    kicikherf++;
                }

            }
            if (password.Length < 8)
            {
                Console.WriteLine("Sifre de minimum 8 simvol olmalidir");


            }
            else if (reqem < 1)
            {
                Console.WriteLine("Sifrede en az bir reqem olmalidi");

            }
            else if (boyukherf < 1)
            {
                Console.WriteLine("Sifrede en az bir boyuk herf olmalidi");

            }
            else if (kicikherf < 1)
            {
                Console.WriteLine("Sifrede en az bir kicik herf olmalidi");

            }
            else
            {
                Console.WriteLine("Sifreniz teyin olundu");
                correctpassword = true;

            }
            IsPasswordCorrect = correctpassword;


            return IsPasswordCorrect;
        }
    }
}

