using System;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string word = "";
            string secretWord = "";
            char result = '+';
            string newWord = "";
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input != "End")
                {
                    result = char.Parse(input);
                    if ((result >= 65 && result <= 90) || (result >= 97 && result <= 122))
                    {

                        if (result == 'c' && !(secretWord.Contains("c")))
                        {
                            secretWord += char.ToString(result);
                        }
                        else if (result == 'o' && !(secretWord.Contains("o")))
                        {
                            secretWord += char.ToString(result);
                        }
                        else if (result == 'n' && !(secretWord.Contains("n")))
                        {
                            secretWord += char.ToString(result);
                        }
                        else
                        {
                            word += char.ToString(result);
                        }
                        if (secretWord.Contains("n") && secretWord.Contains("o") && secretWord.Contains("c"))
                        {
                            word += " ";
                            newWord = word;
                            secretWord = "";
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (input == "End")
            {
                Console.WriteLine(newWord);
            }
        }
    }
}

