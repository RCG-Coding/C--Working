using System;

namespace SimpleCalculator{
    class SC{
        static void Main(String[] args){
            
            Console.Write("Enter your first number : ");
            string num1 = Console.ReadLine();
            Console.Write("Enter your second number : ");
            string num2 = Console.ReadLine();

            if(!string.IsNullOrEmpty(num1) && !string.IsNullOrEmpty(num2)){
                if(int.TryParse(num1, out int n1)&& int.TryParse(num2, out int n2)){
                    int sum = n1 + n2;
                    Console.WriteLine("Sum = "+ sum);

                    int sub1 = n1 - n2;
                    Console.WriteLine($"{n1} - {n2} = "+ sub1);

                    int sub2 = n2 - n1;
                    Console.WriteLine($"{n2} - {n1} = "+ sub2);

                    int mul = n1 * n2;
                    Console.WriteLine("Multiplication = "+ mul);

                    double div1 = (double) n1 / n2;
                    Console.WriteLine($"{n1} divide by {n2} = {div1:f3}");

                    double div2 = (double) n2 / n1;
                    Console.WriteLine($"{n2} divide by {n1} = {div2:f3}");

                }else{
                    Console.WriteLine("This is not integer number please enter the integer number for calculation");
                }
            }else{
                Console.WriteLine("The Input number can not be null or empty, please enter the valied number");
            }
        }
    }
}

            

