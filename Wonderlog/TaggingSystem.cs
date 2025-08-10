using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class TaggingSystem
    {
        /*
        Tagging System Validator
        You are building a photo tagging system. A valid tag must be a single word, start with a #, contain only lowercase letters, and have a length between 2 and 15 characters (inclusive of the #).

        Output Specification
        For each potential tag, print Valid if it meets all the criteria, or Invalid if it fails any of them. Each result should be on a new line.

        Sample Input
        #travel
        #paris2024
        #views from the top
        #s

        Sample Output
        Valid 
        Invalid
        Invalid 
        Invalid
        */

        public static void TaggingFunct(params string[] hashtags)
        {
            var hashList = new Dictionary<char, string>();

            foreach (var input in hashtags)
            {
                if (!input.StartsWith("#"))
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }
                if (input.Length < 2 || input.Length > 15)
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }
                if (input.Contains(" "))
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }

                //checks if all characters are lower after #
                bool valid = true;
                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] < 'a' || input[i] > 'z')
                    {
                        valid = false;
                        break;
                    }
                }

                System.Console.WriteLine(valid ? "Valid" : "Invalid");

                 
            }
            

        }
    }
}