using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {


    List<int> numbers = new List<int>();

    int num = 1;
    while (num != 0)
    {
        Console.Write("Give me a number. Enter 0 when finished");
        string userNum =Console.ReadLine();
        num = int.Parse(userNum);
        if (num != 0)
        {
            numbers.Add(num);
        }
        
        

    }

    //Console.WriteLine(numbers.Count);

    int sum = numbers.Sum();
    Console.WriteLine($"The sum is {sum}");  
    

    float average = (float)sum / numbers.Count;
    Console.WriteLine($"The average is {average}");
    int max = numbers[0];
    foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
    
}
    
Console.WriteLine($"The max is {max}");
    
       
    }
}