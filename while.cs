using System;

public class Reverse {

public static void Main() {

int number,x,y,sum=0;



Console.Write("Input number: ");

number = Convert.ToInt32(Console.ReadLine());

for(y=number;y!=0;y=y/10) {

x=y % 10;

sum=sum*10+x;

}

Console.Write("The number reversed : "+sum);

}

}