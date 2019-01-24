using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalizaer { 
    class Program  {
        static void Main(string[] args) {
            string input = "i am a goat. i eat anything? okay.";
            string output = "";

            output += char.ToUpper(input[0]);

            if (input.Length > 1) {
                output += input[1];
            }

                for (int i = 2; i < input.Length; i += 1)    {
                    char current     = input[i];
                    char left1       = input[i-1];
                    char left2 = input[i-2];

                    if (char.IsWhiteSpace(left1) && char.IsPunctuation(left2)) { 
                        output += char.ToUpper(current);
                    }else{
                        output += current;
                    }//end if
                }//end for

            Console.WriteLine(output);

            Console.ReadKey();
           
        }//end main
   

        
        
        
        }//class
}//end namespace
