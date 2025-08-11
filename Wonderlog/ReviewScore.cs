using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class ReviewScore
    {
        /*
        You are given a list of reviews. You need to calculate a sentiment score for each review. The score is calculated as follows: +1 for each occurrence of the word "great", "amazing", or "love", and -1 for each occurrence of "bad", "terrible", or "poor". The check is case-insensitive.

        Output Specification
        For each review, print its sentiment score on a new line.

        Input:
        What a great trip, I love Paris!
        The hotel was terrible. Very bad service.
        The food was good, not amazing but not bad.

        Output:
        2
        -2
        -1
        */

        public static void ReviewScoreFunct(params string[] userInput)
        {
            //List<string> reviewList = new List<string>();
            //List<int> numberList = new List<int>();
            string[] positiveWords = new string[] { "great", "amazing", "love" };
            string[] negativeWords = new string[] { "bad", "terrible", "poor" };

            for (int r = 0; r < userInput.Length; r++)
            {
                int score = 0;
                string text = userInput[r];
                string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i].ToLower();
                    //checks for negative words
                    for (int j = 0; j < positiveWords.Length; j++)
                    {
                        if (word == positiveWords[j])
                        {
                            score++;
                        }
                    }
                    for (int k = 0; k < negativeWords.Length; k++)
                    {
                        if (word == negativeWords[k])
                        {
                            score--;
                        }
                    }
                }
                System.Console.WriteLine(score);
            }
            

        }
    }
}