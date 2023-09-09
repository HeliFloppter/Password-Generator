using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_generator
{
    public class Conditions
    {
        public bool isAuto;
        public bool isLetters;
        public bool isSymbols;
        public int symbolCount = 8;



        List<string> letters = new List<string>() { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z" };
        List<string> symbols = new List<string>() { "~", "!", "@", "#", "$", "%", "^", "", "&", "*", "(", ")", "—", "_", "=", "+", "[", "]", "{", "}", ";", ":", "‘", "«", "/", "<", ">", "?", "|" };
        List<string> pass_symbols = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };


        public List<string> Shuffle(List<string> nums)
        {
            Random random = new Random();
            for (int i = nums.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                
                var temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
            }

            return nums;

        }
        public List<string> getCondition()
        {

            if (isAuto == true)
            {
                isLetters = true;
                isSymbols = true;
                pass_symbols.AddRange(letters);
                pass_symbols.AddRange(symbols);

                return Shuffle(pass_symbols);

            }
            if (isLetters == true)
            {
                pass_symbols.AddRange(letters);

                if (isSymbols == true)
                {            
                    pass_symbols.AddRange(symbols);

                    return Shuffle(pass_symbols);
                }

                return Shuffle(pass_symbols);

            }

            if (isSymbols == true)
            {
                
                
                pass_symbols.AddRange(symbols);

                return Shuffle(pass_symbols);
            }

            else
            {
                return Shuffle(pass_symbols);
            }
            

        }

        


    }

    public class Generator: Conditions
    {
        string password;
        Random rnd = new Random();
        public String Create(bool isAuto, bool isLetters, bool isSymbols, int symbolsCount)
        {
            this.isAuto = isAuto;
            this.isLetters = isLetters;
            this.isSymbols = isSymbols;
            this.symbolCount = symbolsCount;
            List<string> listPassword  = getCondition();
            Random key = new Random();

            for (int i = 0; i < symbolCount; i++)
            {

                password += listPassword[key.Next(listPassword.Count)];

            }
            

            return password;

        }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
