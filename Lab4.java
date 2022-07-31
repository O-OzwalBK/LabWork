// Take input from user and print it on screen

/*import java.util.Scanner;

public class Lab4 {
	public static void main(String[] args) {
		//Scanner object
		Scanner userInputScanner = new Scanner(System.in);
		String userName="";
		
		System.out.println("Enter your name: ");
		// Get the string
		userName = userInputScanner.nextLine();

		System.out.println("Your name is "+userName);
		// close the scanner
		userInputScanner.close();
	}
}
*/

// Check whether the user input is odd or even
/*
import java.util.Scanner;

public class Lab4 {
	public static void main(String[] args) {
		Scanner numberScanner = new Scanner(System.in);
		int number;

		System.out.println("Enter a number: ");
		number = numberScanner.nextInt();

		if(number%2==0) {
			System.out.println("The input number is even.");
		}
		else {
			System.out.println("The input number is odd.");
		}
		numberScanner.close();
	}
}
*/

// Print first 100 natural numbers
/*
public class Lab4 {
	public static void main(String[] args) {
		int loop = 1;

		System.out.println("First 100 natural numbers:");
		while(loop<=100) {
			System.out.print(loop+"\t");
			if(loop%10==0) {
				System.out.println();
			}
			loop++;
		}
	}
}
*/

// Create a class named Employee with data members name and age.

/*
import java.util.Scanner;

class employee {
	String name;
	int age;

	void getData() {
		Scanner scanName = new Scanner(System.in);
		Scanner scanAge = new Scanner(System.in);
		
		System.out.println("Enter your name: ");
		name = scanName.nextLine();
		System.out.println("Enter your age: ");
		age = scanAge.nextInt();

		scanName.close();
		scanAge.close();
	}
	void showData() {
		System.out.println("Name: "+name);
		System.out.println("Age: "+age);
	}
}

public class Lab4 {
	public static void main(String[] args) {
		employee emp = new employee();

		emp.getData();
		emp.showData();
	}
}
*/

// Implement simple inheritance

/*
import java.util.Scanner;

class sum {
	int a;
}

class calculate extends sum {
	int b;

	void getData() {
		Scanner scanNumber = new Scanner(System.in);

		System.out.println("Enter the value of a: ");
		a = scanNumber.nextInt();
		System.out.println("Enter the value of b: ");
		b = scanNumber.nextInt();

		scanNumber.close();
	}
	
	void showData() {
		System.out.println("Sum = "+(a+b));
	}
}

class Lab4 {
	public static void main(String[] args) {
		calculate calc = new calculate();
		
		calc.getData();
		calc.showData();
	}
}
*/

// Implement function overloading

/*
class calculate {
	int add(int a, int b) {
		return a+b;
	}
	int add(int a,int b,int c) {
		return a+b+c;
	}
	float add(int a,float b) {
		return a+b;
	}
}

class Lab4 {
	public static void main(String[] args) {
		calculate calc = new calculate();

		System.out.println("2+3 = "+calc.add(2,3));
		System.out.println("2+3+5 = "+calc.add(2,3,5));
		System.out.println("2+3.69f = "+calc.add(2,3.69f));
	}
}
*/

// Implement function overriding in java

/*
class sum {
	int a = 45;
	void showData() {
		System.out.println("a = "+a);
	}
}

class calculate extends sum {
	int b = 39;
	void showData() {
		System.out.println("a = "+a+" b = "+b);
	}
}

class Lab4 {
	public static void main(String[] args) {
		calculate calc = new calculate();

		calc.showData();
	}
}
*/

