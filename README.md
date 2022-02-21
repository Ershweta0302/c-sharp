//Write a program in c# sharp to calculate the sum of elements in an array using function.
using System;
public class function
  {
    public static int Sum(int[] arr1)
    {
        int tot=0;
        for (int i = 0;i < arr1.Length; i++)
        tot += arr1[i];
        return tot;
    }
    public static void Main()
    {
       int[] arr1 = new int[5];
       Console.Write("\n\nFunction : Calculate the sum of the elements in an array :\n");  
       Console.Write("--------------------------------------------------------------\n");      
    
       Console.Write("Input 5 elements in the array :\n");    
       for(int j=0; j<5; j++)    
       {    
        Console.Write("element - {0} : ",j);  
        arr1[j] = Convert.ToInt32(Console.ReadLine());         
       }    
       Console.WriteLine("The sum of the elements of the array is {0}", Sum(arr1));
    }
}
//Write a c# sharp program to adds number using function overloding concept.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.sum();
            Calculator.sum(5, 4);
            Calculator.sum(9.3f, 8.6f);
            Calculator.sum("Hello World");
            Console.Read();
        }
    }
    static class Calculator
    {
        public static void sum()
        {
            Console.WriteLine("No Value Provided");
        }
        public static void sum(int x, int y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(float x, float y)
        {
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, (x + y));
        }
        public static void sum(string s)
        {
            Console.WriteLine("{0} - is not a numeric value", s);
        }
    }
}
//Write a program in c# sharp to make employee class to print the Employee (salary, id , name)
// C# program to display the details of the employee's
// whose salary is between 6000 and 8000
// using LINQ.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee{
	
// Declare 4 variables - id,name and salary
int emp_id;
string emp_name;
int emp_salary;

// Get the to string method that returns id,name and salary
public override string ToString()
{
	return emp_id + " " + emp_name + " " + emp_salary;
}

// Driver code
static void Main(string[] args)
{
	
	// Declare a list variable
	List<Employee> emp = new List<Employee>()
	{
		
		// Create 3 employee details
		new Employee{ emp_id = 101, emp_name = "bobby", emp_salary = 8900 },
		new Employee{ emp_id = 102, emp_name = "deepu", emp_salary = 7000 },
		new Employee{ emp_id = 103, emp_name = "manoja", emp_salary = 6700 }};
						
	// Iterate the Employee by selecting Employee id
	// greater than 101 using where function
	IEnumerable<Employee> Query =
	from employee in emp where employee.emp_salary >= 6000 &&
	employee.emp_salary <= 8000 select employee;

	// Display employee details
	Console.WriteLine("ID   Name  Salary");
	Console.WriteLine("+++++++++++++++++++++++++++");
	foreach (Employee e in Query)
	{
		
		// Call the to string method
		Console.WriteLine(e.ToString());
	}
}
}
//Write a program in c# sharp to find the area of square and area of triangle using constructer overloding.
// C# program to illustrate the invoking of
// overloaded constructor using this keyword
using System;

class GFG {
	
	// Private data members
	private int Length, Height;
	private double Width;

	// Default Constructor
	public GFG()
	{
		Console.WriteLine("Default Constructor Invoked");
	}

	// The constructor calls the
	// Default constructor
	public GFG(int l, double w) : this()
	{
		Console.WriteLine("Parameterized Constructor in 2nd Constructor");
		
		// assigning value of
		// 'Length'and 'Width'
		Length = l;
		Width = w;
		
	}

	// The constructor call the
	// parameterized constructor
	public GFG(int l, double w, int h) : this(l, w)
	{
		Console.WriteLine("Parameterized Constructor in 3rd Constructor");
		
		// assign value of 'Height'
		Height = h;
	
	}
	
	// Public Method to calculate volume
	public double Volume()
	{
		return (Length * Width * Height);
	}
}

// Driver Class
class Geeks {
	
	// Main Method
	public static void Main()
	{
		
		// Invoking 3rd Constructor
		// here Constructor chaining
		// came into existence
		GFG g = new GFG(10, 20.5, 30);

		// calling the 'Volume' Method
		Console.WriteLine("Volume is : {0}", g.Volume());

	}
}
//Write a program in c# sharp to find the cube of n number using static class.
using System;  
public class Cube 
{  
    public static void Main() 
 {
    int i,ctr;
	Console.Write("\n\n");
    Console.Write("Display the cube of the number:\n");
    Console.Write("---------------------------------");
    Console.Write("\n\n");	
	
    Console.Write("Input number of terms : ");
    ctr= Convert.ToInt32(Console.ReadLine());	
    for(i=1;i<=ctr;i++)
    {
	 Console.Write("Number is : {0} and cube of the {1} is :{2} \n",i,i, (i*i*i));     
    }
  }
} 
//Write a program in c# sharp to insert and display the data of student (roll,name,subject) using (get,set)property.

// C# program to print the list of students
// details using select clause
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
class Student{
      
// Declare 4 variables - roll, name, subject
int stu_roll; 
string stu_name;
string stu_subject;
  
// Get the to string method that returns
// roll, name, department and subject
public override string ToString()
{
    return stu_roll + " " + stu_name + " " + 
           stu_subject + " ";
}
  
// Driver code
static void Main(string[] args)
{
      
    // Declare a list variable 
    List<Student> stu = new List<Student>()
    {
          
        // Create 3 Student details
        new Student{ stu_roll = 101, stu_name = "Anjali", 
                     stu_subject = "English"},
        new Student{ stu_roll = 102, stu_name = "Anurag", 
                     stu_subject = "Math"},
        new Student{ stu_roll = 103, stu_name = "deepu", 
                     stu_subject ="Hindi"},
    };
      
    // Iterate the Employee 
    // using select function
    IEnumerable<Student> Query = from student in stu select student;
      
    // Display student details
    Console.WriteLine("RollNo  Name  Subject");
    Console.WriteLine("+++++++++++++++++++++++++++");
    foreach (Student e in Query)
    {
          
        // Call the to string method
        Console.WriteLine(e.ToString());
    }
}
}
