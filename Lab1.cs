// Print college's name
/*class displayName {
    static void Main() {
        Console.WriteLine("Gandaki College of Engineering and Science");
    }
}
*/

// Ask user's name and age and print them.
/*class printInfo {
    static void Main() {
        string? userName,userAge;
        Console.Write("Enter your name: ");         userName = Console.ReadLine();
        Console.Write("Enter your age: ");          userAge  = Console.ReadLine();

        Console.WriteLine("Name: " + userName);
        Console.WriteLine("Age: " + userAge);
    }
}
*/

// Ask marks of 3 subjects of a student, calculate percentage with average marks and display them.
/*class marks {
    static void Main() {
        int sub1,sub2,sub3,sum,avg,percent;

        Console.Write("Enter marks of subject 1: ");        sub1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks of subject 2: ");        sub2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter marks of subject 3: ");        sub3 = Convert.ToInt32(Console.ReadLine());

        sum = sub1 + sub2 + sub3;
        avg = sum / 3;
        percent = sum / 3;

        Console.WriteLine("Your average marks is " + avg + ".");
        Console.WriteLine("Your percetage is " + percent + "%.");
    }
}
*/

// Ask for a number and print whether it is odd or even.
/*class oddOrEven {
    static void Main() {
        int number;

        Console.Write("Enter a positive number: ");         number = Convert.ToInt32(Console.ReadLine());

        if(number%2 == 0) {
            Console.WriteLine("The number you entered is even.");
        }
        else {
            Console.WriteLine("The number you entered is odd.");
        }
    }
}
*/

// Read number from user and print if it is divisible by 3 and 5.
/*class checkDivisibility {
    static void Main() {
        int anyNumber,temp1,temp2;

        Console.Write("Enter any positive number: ");       anyNumber = Convert.ToInt32(Console.ReadLine());

        temp1 = anyNumber%3;
        temp2 = anyNumber%5;

        if(temp1==0 && temp2==0) {
            Console.WriteLine("The number is divisible by both 3 and 5.");
        }
        else {
            Console.WriteLine("The number is not divisible by both 3 and 5.");
        }
    }
}
*/