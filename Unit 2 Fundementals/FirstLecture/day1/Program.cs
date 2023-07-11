//create a variable called x and give it a value of 5
int age = 5;
string name = "Justin";
string name2 = "Ethan";
/*
 * validate the number variable
 * do something if validated
 */
if (age == 1)
{

}

//declaring variables
int money;
//intialize variable
money = 5;
//combined
bool hungry = true;

//constant
const double taxRate = 0.06;
// taxRate = 6; // not allowed to change constants
//Console.WriteLine(taxRate);

//mini code problem
Console.WriteLine("Please enter a radius");
//string entry = Console.ReadLine();
//double value = double.Parse(entry);
double value = double.Parse(Console.ReadLine());
double area = Math.PI * Math.Pow(value, 2);
Console.WriteLine(area);

//increment/decrement
age++;
age = age + 1;
age--;
age = age - 1;

//odd or even
Console.WriteLine("Please enter a number");
int input = int.Parse(Console.ReadLine());
int oddCheck = input % 2;
if(oddCheck == 0)
{
    Console.WriteLine("even");
}
else if(oddCheck == 1)
{
    Console.WriteLine("odd");
}

//assignment
value = 0;
value = age * 100 - Math.PI;

int assign = 0;
Console.WriteLine(assign);
assign = 5;
Console.WriteLine(assign);
assign += 2;
Console.WriteLine(assign);
assign -= 5;
Console.WriteLine(assign);

//null
string catName = null;
Console.WriteLine(catName);
catName = "Felony";
Console.WriteLine(catName);

string y = null;

if(y == null)
{
    y = "dsjklfahk";
}

//nonnullable
//int z = null;

//exercises
//1
Console.WriteLine("Enter some text.");
string ex1 = Console.ReadLine();
Console.WriteLine(ex1);

//2
Console.WriteLine("Enter a number");
int ex2 = int.Parse(Console.ReadLine());
ex2++;
Console.WriteLine(ex2);

//3
Console.WriteLine("Enter a number");
double ex3 = double.Parse(Console.ReadLine());
ex3 += .5;
Console.WriteLine(ex3);

//4
Console.WriteLine("enter the first number");
double ex4 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double ex42 = double.Parse(Console.ReadLine());
double sum = ex4 + ex42;
Console.WriteLine(sum);

//5
Console.WriteLine("enter the first number");
double ex5 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double ex52 = double.Parse(Console.ReadLine());
double sum5 = ex5 * ex52;
Console.WriteLine(sum5);
