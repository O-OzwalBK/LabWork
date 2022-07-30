
// Read n number of values in an array and display in reverse order

/*class reverseArray {
    static void Main() {
        
        int i,n;
        Console.Write("How many numbers do you want to store: ");       n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for(i=0;i<n;i++) {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(i=n-1;i>=0;i--) {
            Console.WriteLine("array[{0}] = {1}",i,array[i]);
        }
    }
}
*/

// Find the sum  of elements in the array

/*class sumArray {

    static void Main() {
        int n,i,sum=0;

        Console.Write("Enter number of elements: ");        n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for(i=0;i<n;i++) {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(i=0;i<n;i++) {
            sum = sum + array[i];
        }

        Console.WriteLine("Sum of elements of array = {0}.",sum);
    }
}
*/

// Read a string and print the total number of vowels in the string

/*using System;

namespace labWork
{
    public class countVowel
    {
        public static void Main(string[] args)
        {
            String? givenString;
            String vowels = "aeiouAEIOU";
            int totalVowels = 0;

            Console.WriteLine("Enter any word: ");
            givenString = Console.ReadLine();

            if(string.IsNullOrEmpty(givenString) || string.IsNullOrWhiteSpace(givenString))
            {
                Console.WriteLine("Sorry, the word is empty. Please enter again.");
                return;
            }

            for (int i = 0; i < givenString.Length; i++)
            {
                if (vowels.Contains(givenString[i]))
                {
                    totalVowels++;
                }
            }
            
            Console.WriteLine("Total vowels: " + totalVowels);
        }
    }
}
*/

// Reverse given string using array

/*using System;
namespace labWork
{
    static class stringManipulation
    {
        public static string ReverseString(string str)
        {
            
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray); 
            return new string(stringArray);
        }
    }
    public class stringWork
    {
        static void Main()
        {
            string? userString = "";
            Console.WriteLine("Enter a string: ");
            userString = Console.ReadLine();

            if(string.IsNullOrEmpty(userString))
            {
                Console.WriteLine("Empty string");
                return;
            }
            Console.WriteLine("Original string:");
            Console.WriteLine(userString);

            
            Console.WriteLine("Reversed string:");
            Console.WriteLine(stringManipulation.ReverseString(userString));

        }
    }
}
*/
