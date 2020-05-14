using System;

public class Alindrome {

public static void Main() {

int number,r,sum=0,t;

Console.Write("Input a number: ");

number = Convert.ToInt32(Console.ReadLine());



t=number;

do{

number=number/10;

r=number % 10;

sum=sum*10+r;

}

while(number!=0 )

if(t==sum)

Console.Write(" is a palindrome number.\n);

else

Console.Write(" is not a palindrome number.\n");

}

}

