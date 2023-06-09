// See https://aka.ms/new-console-template for more information
//4.Accept two numbers & find the greater number.

int num1, num2;

Console.WriteLine("enter the first number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the second number ");
num2 = Convert.ToInt32(Console.ReadLine()); 

if (num1 > num2)
{
    Console.WriteLine("the number is greater" + num1);

}
else
{
    Console.WriteLine("the numberis not greater" + num2);
}