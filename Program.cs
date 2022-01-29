using System;
using System.Text.RegularExpressions;

namespace ProgrammingIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Question 1:
            Console.WriteLine("Q1");
            String s  = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student","Center"};
            string[] bulls_string2 = new string[] { "MarshallStudent ","Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            // flag = true;
            if (flag)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] {1, 2, 3, 2};
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();

            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("Q4:");
            Console.WriteLine("The sum of diagonal elements in the bulls grid is:{0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is: {0}", rotated_string);
            Console.WriteLine();

            //Question 6:
            Console.WriteLine("Q6:");
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }


        /// <summary>
        /// This function below retuns a string without any vowels {a,e,i,o,u}
        ///Regex.Replace takes in three parameters input string, the characters that user wants to fetch and a character the user wants to replace.
        /// </summary>
        /// <param name="s">'s' is the input string that the user is entering</param>
        /// <returns>final_string, it is the string returned after removing all the vowels from the input string</returns>
        private static string RemoveVowels(string s) 
        {
            try
            {
                string final_string = "";
                /* https://stackoverflow.com/questions/16117043/regular-expression-replace-in-c-sharp */
                final_string = Regex.Replace(s, "[aeiouAEIOU]", "");
                return final_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        /// <summary>
        /// The method ArrayStringsAreEqual takes in two arrays of strings and concates the strings present in the index positions and returns a bool value
        /// i.e true or false. After concatinating the elements if the final string of first input matches or is same as that of second the function returns
        /// true else the function returns false.
        /// </summary>
        /// <param name="bulls_string1">contains a array of strings thay are passed as inuputs</param>
        /// <param name="bulls_string2">second input contains a array of strings that are passed as inputs</param>
        /// <returns>'true' if the two strings matches after concatination else returns false</returns>
        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string res = ""; // intializing a varible res for storing the string after concatination in bulls_string1
                string res1 = "";// intializing a varible res1 for storing the string after concatination in bulls_string1
                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    res += bulls_string1[i]; //adding the strings present in the array to the empty res string.
                }
                for (int j = 0; j < bulls_string2.Length; j++)
                {
                    res1 += bulls_string2[j];//adding the strings present in the array to the empty res string.
                }
                if (res == res1)
                {
                    return true; // if both res and res1 are equal the true is returned.
                }
                else
                {
                    return false; // if both res and res1 are equal the false is returned.
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /// <summary>
        /// The method SumOfUnique takes in integer array as an input returns the sum of unique elements i.e the elements that are repeated.
        /// First for loop is used to iterate through array. Second for loop is used to count the all the integers present in the array. If there is
        /// only one non repeating integer then the count is one else the count will be the number of times a number is repeating. Then all the numbers whose
        /// count is 1 are added and returns their total.
        /// </summary>
        /// <param name="bull_bucks">It takes array of integers</param>
        /// <returns>'sum' of the unqiue elements i.e the sum of numbers whose count is 1</returns>
        private static int SumOfUnique(int[] bull_bucks)
        {
            try {
                int sum = 0;//Intializing a variable sum which the sum of the unique numbers
                for (int i = 0; i < bull_bucks.Length; i++)// Used to loop through the length of the array
                {
                    int count = 0;// To find the total number of times a number is repeating.
                    for (int j = 0; j < bull_bucks.Length; j++)// Used to loop through the length of the array
                    {
                        if (bull_bucks[i] == bull_bucks[j])// if the the number in both loops are equal
                        {
                            count++; //incrementing the count variable
                        }
                    }
                    if (count == 1)//captures all the numbers that have a count of 1(unique)
                    {
                        sum += bull_bucks[i];// sum of all those numbers
                    }
                }
                return sum;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        /// <summary>
        /// The Method DiagonalSum takes in a 2D array as an input and the sum of the diagonal elements are calculated. If it is a nXn(n is odd) 2D array the the center element
        /// in the array is added only once. GetLength method is used to return the value of the 2D array. The first for loop is used to iterate through
        /// the length of the 2D array and the second for loop also does the same thing but in the first iteration i=0 and j=0 and in the second iteration 
        /// i will be  0 and j will be 1 and so on .If the index i and j are same then the sum variable adds the numbers present in those indexes. 
        /// sum1 variable adds up the numbers where if the sum of the indexes i & j equals to the length of the 2D and is substracted 1 from it. r
        /// res variable adds up sum and sum1 and returns the total sum.
        /// </summary>
        /// <param name="bulls_grid"></param>
        /// <returns></returns>
        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int sum = 0;//intializing the sum variable
                int sum1 = 0;//intializing the sum1 variable
                int res = 0;//intializing the res variable
                for (int i = 0; i < bulls_grid.GetLength(0); i++)//loops through the length of the 2D array
                {
                    for (int j = 0; j < bulls_grid.GetLength(0); j++)//loops through the length of the 2D array
                    {
                        if (i == j)
                        {
                            sum += bulls_grid[i, j];//adds up the numbers in same indices
                        }
                        else if ((i + j) == bulls_grid.GetLength(0) - 1)
                        {
                            sum1 += bulls_grid[i, j]; //adds up the numbers in that are present in the else if condition.
                    }

                        
                    }
                    res = sum + sum1;// adds up the sum and sum1 values
                }
                return res;//returns the result of the sum and sum1 variables.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// The method RestoreString takes in two inputs a string and the array of integers. The actual string is returned if the numbers present in
        /// the array is arranged in the ascending order. First the string is converted into an array of characters which is initialized with the length
        /// of the string. The characters present in the string are stored character array. The second loop is used for looping into the characters array
        /// and add the characters present in the respective indices.
        /// </summary>
        /// <param name="bulls_string">The input string </param>
        /// <param name="indices">Interger array</param>
        /// <returns>The actual word after sorting and appending</returns>
        private static string RestoreString(string bulls_string, int[] indices)
        {
            try {
                string s = "";//Intializing an empty string
                char[] chars = new char[bulls_string.Length];//Intializing the length of the character array to the length of the string.
                for (int i = 0; i < indices.Length; i++)
                {
                    int p = indices[i];//indices at are stored in p
                    chars[p] = bulls_string[i];//the characater present in the string at the particular index is stored in the character index.
                }
                for (int j = 0; j < chars.Length; j++)
                {
                    s += chars[j];// add the characters to the empty string.
                }

                return s;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            }
       /// <summary>
       /// The method ReversePrefix takes in a string and character. If the first occurence of that character appears in the string then the part of that
       /// string is reversed. The first for loop is used to iterate through the lenght of the string and the if condition is used to find out the first
       /// occurence of the character in the string. If it matches then the part of the string before the character is reversed. If the character is not 
       /// found the string then 'abcd' is returned.
       /// </summary>
       /// <param name="bulls_string">Input string</param>
       /// <param name="ch">The character we are looking out for in the string</param>
       /// <returns>string with part of the string is reversed where the first occurence of the character is found</returns>
        private static string ReversePrefix(string bulls_string, char ch)
        {
            try
            {
                string s = "";//Intializing with the empty string
                string p = "";
                string res = "";
                for (int i = 0; i < bulls_string.Length; i++)//Iterating through the entire length of the string
                {

                    if (bulls_string[i] == ch)
                    {
                        s = bulls_string.Substring(0, i + 1);//if the character we are looking for is found then s stores the part of the string upto the character
                        p = bulls_string.Substring(i + 1);//p stores the part of the string after the character we are looking for.
                        char[] charArray = s.ToCharArray();//THe string present in s is converted into char array
                        string rs = "";
                        for (int j = charArray.Length - 1; j > -1; j--)//Iterates from the last element in the string
                        {
                            rs += charArray[j];//Each character is added to the empty string
                        }
                        res = rs + p;// res is the result of the concatination of rs and p strings
                    }
                }

                if (res == "")
                {
                    return "abcd";//if the character is not found then res is an empty string the the result is abcd
                }
                else
                {
                    return res;//retuns the resultant string with part of the string where the character found reversed and part after the traget character.
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

    }
}
