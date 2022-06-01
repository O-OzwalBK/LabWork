// Check whether a number is divisible by 5 or not.
/*class checkDivisibility {
    static void Main() {
        int inputNumber,remainder;

        Console.Write("Enter any number: ");        inputNumber = Convert.ToInt32(Console.ReadLine());

        remainder = inputNumber % 5;
        if(remainder == 0) {
            Console.WriteLine("The number is divisible by 5.");
        }
        else {
            Console.WriteLine("The number is not divisible by 5.");
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

// Read month number and display corresponding month name.
/*class Program {
    static void Main() {
        
        int checkMonth;
        Console.Write("Insert month in number: ");
        checkMonth = Convert.ToInt32(Console.ReadLine());
        switch (checkMonth) {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("February");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Invalid month!!");
        }
    }
}*/

// Read a number and display corresponding month name.
/*class Program {
    static void Main() {
        int checkMonth;

        Console.Write("Enter month in number: ");      checkMonth = Convert.ToInt32(Console.ReadLine());

        if(checkMonth == 1) {
            Console.WriteLine("January");
        }
        else if(checkMonth == 2) {
            Console.WriteLine("February");
        }
        else if(checkMonth == 3) {
            Console.WriteLine("March");
        }
        else if(checkMonth == 4) {
            Console.WriteLine("April");
        }
        else if(checkMonth == 5) {
            Console.WriteLine("May");
        }
        else if(checkMonth == 6) {
            Console.WriteLine("June");
        }
        else if(checkMonth == 7) {
            Console.WriteLine("July");
        }
        else if(checkMonth == 8) {
            Console.WriteLine("August");
        }
        else if(checkMonth == 9) {
            Console.WriteLine("September");
        }
        else if(checkMonth == 10) {
            Console.WriteLine("October");
        }
        else if(checkMonth == 11) {
            Console.WriteLine("November");
        }
        else if(checkMonth == 12) {
            Console.WriteLine("December");
        }
        else
            Console.WriteLine("Please do not be stupid and enter a valid month.");
    }
}*/

// Check whether a triangle can be formed with given angles.
/*class Triangle {
    static void Main() {
        int angle1,angle2,angle3,sum;

        Console.WriteLine("Enter three angles in degree: ");
        angle1 = Convert.ToInt32(Console.ReadLine());
        angle2 = Convert.ToInt32(Console.ReadLine());
        angle3 = Convert.ToInt32(Console.ReadLine());

        sum = angle1 + angle2 + angle3;
        if(sum == 180) {
            Console.WriteLine("The angles can form a triangle.");
        }
        else 
            Console.WriteLine("The given angles cannot form a triangle.");
    }
}*/
