using System;  
class Main  
{  
    static void Main()  
{  
    int cost,sell, profit; 

           

     Console.Write("Input Cost: ");  
     cost= Convert.ToInt32(Console.ReadLine()); 
     Console.Write("Input Sell: ");  
     sell= Convert.ToInt32(Console.ReadLine());  
      
    if(sell>cost) 
    {  
        profit = sell-cost;  
        Console.Write("profit amount : "+profit);  
    }  
    else if(cost>sell)  
    {  
        profit = cost-sell;  
        Console.Write("loss :"+ profit);  
    }  
    else   
    {  
        Console.Write(" no profit and no loss ");  
    }  
}
}  
  
                        
