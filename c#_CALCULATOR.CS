class Min{
static void Main{
char operator;
    int first, second;
    Console.WriteLine("Enter an operator (+, -, *,): ");
   operator=Console.ReadLine();
    Console.WriteLine("Enter first: ");
    first=Console.ReadLine();
    Console.WriteLine("Enter second: ");
   second=Console.ReadLine();
 
    switch (operator) {
    case '+':
        Console.WriteLine( (first + second));
        break;
    case '-':
        Console.WriteLine(first - second);
        break;
    case '*':
        Console.WriteLine(first * second);
        break;
    case '/':
        Console.WriteLine(first / second);
        break;
       
    default:
        Console.WriteLine("Error! operator is not correct");
    }
 
   
}
}