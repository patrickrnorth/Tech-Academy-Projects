using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace IterationAssign
{
    class Program
    {
        static void Main(string[] args)
        {


            /*Create a one-dimesional Array of strings. Ask user to input some text. Create a loop that goes through each string in the Array, 
            * adding the user's text to the string. Then create a loop that prints off each string in the Array on a separate line.
            */
            string[] myStringArray = { "This", "is", "only", "a", "test" };

            Console.WriteLine("Please input a small amount of text: ");
            string userText = Console.ReadLine();

            for (int i = 0; i < myStringArray.Length; i++)
            {
                string addUserString = myStringArray[i] + " " + userText;
                Console.WriteLine(addUserString + " " + "\n");
            }
            Console.ReadLine();

            //Create an infinite loop
            //string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            //for( ; ; )
            //{
            //    Console.WriteLine("Infinite.");
            //}

            //Fix an infinite loop
            string[] infinite = { "i", "n", "f", "i", "n", "i", "t", "e" };
            for (int j = 0; j < infinite.Length; j++)
            {
                Console.WriteLine(infinite[j]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<" operator
            int[] myLoop = { 1, 2, 3, 4, 5 };
            for (int k = 0; k < myLoop.Length; k++)
            {
                Console.WriteLine(myLoop[k]);
            }
            Console.ReadLine();

            //Create a loop where the comparison used to determine whether to continue iterating the loop is a "<=" operator
            for (int l = 0; l <= 2; l++)
            {
                Console.WriteLine(myLoop[l]);
            }
            Console.ReadLine();


            /*Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List. 
            * Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            */

            List<string> myWords = new List<string>();
            myWords.Add("In");
            myWords.Add("my");
            myWords.Add("experience");
            myWords.Add("there");
            myWords.Add("is");
            myWords.Add("no");
            myWords.Add("such");
            myWords.Add("thing");
            myWords.Add("as");
            myWords.Add("luck.");

            Console.WriteLine("Type a word from this sentance to find what index that word is contained at. \"In my experience there is no such thing as luck.\"");
            string userWord = Console.ReadLine();

            //Loop that will look for a word typed by the user in the List
            foreach (string word in myWords)
            {
                if (word == userWord)
                {
                    Console.WriteLine("The index of " + "\"" + userWord + "\"" + " is: " + myWords.IndexOf(word));
                    break;
                }
            }

            //catches if the user entered a word that is not in the sentance.
            if (myWords.Contains(userWord) == false)
            {
                Console.WriteLine("You did not enter a word from the sentance.");
            }
            Console.ReadLine();


            /*Create a List of strings that has at least two identical strings in the List.
            *Ask the user to select text to search for in the List. Create a loop that iterates through the loop and then
            *displays the indices of the array that contain matching text on the screen.
            */

            List<string> mySong = new List<string>();
            List<int> repeatLyrics = new List<int>();

            mySong.Add("Too");
            mySong.Add("legit");
            mySong.Add("too");
            mySong.Add("legit");
            mySong.Add("to");
            mySong.Add("quit");

            Console.WriteLine("Please input a word from the below lyrics: ");
            Console.WriteLine("Too legit too legit to quit");
            string userWordLyric = Console.ReadLine();

            //search List mySong for a match to the user's word then add the index of that word to the List repeatLyrics
            foreach (string lyric in mySong)
            {
                if (lyric == userWordLyric)
                {
                    repeatLyrics.Add(mySong.IndexOf(lyric));
                }
            }

            //if user word is not in the List display error            
            if (mySong.Contains(userWordLyric) == false)
            {
                Console.WriteLine("The word you typed is not in the lyrics.");
            }            

            //List all indicies from mySong that have lyrics that repeat
            if (mySong.Contains(userWordLyric))
            {
                Console.WriteLine("The indicies of the word you typed are: ");
                foreach (int repeatIndex in repeatLyrics)
                {
                    Console.WriteLine(repeatIndex);
                }
            }
            Console.ReadLine();

            
            
            //11. Create a list of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> nameList = new List<string>();
            List<string> nameRepeat = new List<string>();
            
            nameList.Add("Billy");
            nameList.Add("James");
            nameList.Add("Ryan");
            nameList.Add("John");
            nameList.Add("Jason");
            nameList.Add("Billy");

            // loop adds a name to the nameRepeat List and then checks to see if the name is already in the list
            foreach (string name in nameList)
            {
                if (nameRepeat.Contains(name))
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("The name " + name + " has already appeared in the list!");
                }
                else
                {
                    nameRepeat.Add(name);
                    Console.WriteLine("This name " + name + " has not appeared in the list yet!");

                }

            }





            //foreach (string name in nameList)
            //{
            //    for (int i =0; i < nameList.Count; i++)
            //    {
                    
            //        if (name[i] == name[i++])
            //        {
            //            Console.WriteLine("The name " + name + " has already appeared in the list.");
            //        }
                       
            //    }

            //}
        }
    }
}






