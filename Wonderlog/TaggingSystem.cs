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
                // Check if tag starts with '#'
                if (!input.StartsWith("#"))
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }
                // Check if tag length is between 3 and 15 (inclusive)
                if (input.Length < 3 || input.Length > 15)
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }
                // Check if tag contains any spaces
                if (input.Contains(" "))
                {
                    System.Console.WriteLine("Invalid");
                    continue;
                }

                // Check if all characters after '#' are lowercase letters
                bool valid = true;
                for (int i = 1; i < input.Length; i++)
                {
                    // If character is not a lowercase letter, mark as invalid
                    if (input[i] < 'a' || input[i] > 'z')
                    {
                        valid = false;
                        break;
                    }
                }

                // Print Valid if all checks passed, otherwise Invalid
                System.Console.WriteLine(valid ? "Valid" : "Invalid");

                 
            }
            

        }
    }
}