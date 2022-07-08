
// Read n number of values in an array andd display in reverse order

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

/*class totalVowels {

    static void Main() {
        string? word;
        int countVowel = 0;

        Console.WriteLine("Enter a word: ");
        word = Console.ReadLine();
        char[] letter = new char[word.Length];
        letter = word.ToCharArray();
        foreach(char ch in letter) {

            switch(ch) {
                case 'a':
                countVowel++;
                break;
    
                case 'e':
                countVowel++;
                break;
    
                case 'i':
                countVowel++;
                break;
    
                case 'o':
                countVowel++;
                break;
    
                case 'u':
                countVowel++;
                break;
    
            }
        }

        Console.WriteLine("Total numbers of vowel letters in given word = {0}",countVowel);
    }
}
*/
using System;

namespace lab
{
    public class countVowel
    {
        public static void Main(string[] args)
        {
            String givenString;
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
                if (vowels.Contains(givenString[i]+""))
                {
                    totalVowels++;
                }
            }

            Console.WriteLine("Total vowels: " + totalVowels);
        }
    }
}