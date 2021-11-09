using System;

namespace City_CodeMelli
{
    class Program
    {
        static void Main(string[] args)
        {

            string id;
            do
            {
                System.Console.WriteLine("Please Enter Your National Id :");
                id = Console.ReadLine();
            } while (id.Length != 10);

            spell(id);
           
            
        }

        public static void spell(string national_id)
        {
            int[] sp = new int[10];
            for (var i = 0; i < 10; i++)
            {
                sp[i] = int.Parse(national_id.Substring(i, 1));
            }

           division(sp);
            city(sp);
            
        }
        
        public static bool division(int[] s)
        {
            int sum=0;
            int count =10 ;
            // int[] calc = new int[10];
            for (int i = 0; i < 10 ; i++)
            {
                s[i] = s[i] * count;
                count--;
                
            }
            // foreach (var item in s)
            // {
            //     System.Console.WriteLine(item);  
            // }
            for (int i = 0; i < 9; i++)
            {
                sum = sum + s[i];
            }

            
             bool res = check(sum,s[9]);
             System.Console.WriteLine(res);
             
            return res;
            
        }
        
        public static bool check(int summary,int controller)
        {
            int remain = summary % 11 ;
            if (remain < 2)
            {
                if(remain == controller)
                {
                    return true;
                
                }
                else
                {
                    return false;
                }
            }
            else if( controller == 11 - remain )
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

public static int city(int[] c)
        {
            
            int sum1 = 0;
            int count = 100;
            int div = 10;
            // int remain = 0;
            for (int i = 0; i < 3; i++)
            {
                // remain = c[i] % div;
                // c[i] = (c[i] / div) + remain;
                c[i] = (c[i] / div) ;
                
                c[i] = c[i] * count;
                count = count / 10;
                div--;
            }
            // foreach (var item in c)
            // {
            //     System.Console.WriteLine(item);
            // }
            for (int i = 0; i < 3; i++)
            {
                sum1 = sum1 + c[i];
            }
            // System.Console.WriteLine(sum);

            switch (sum1)
            {
                case 274 :
                    System.Console.WriteLine("You City is : Oroomiye");
                    break;
                case 275 :
                    System.Console.WriteLine("You City is : Oroomiye");
                    break;
                case 295 :
                    System.Console.WriteLine("You City is : Oshnavieh");
                    break;
                case 637 :
                    System.Console.WriteLine("You City is : Anzal");
                    break;
                case 292 :
                    System.Console.WriteLine("You City is : Bookan");
                    break;
                case 492 :
                    System.Console.WriteLine("You City is : Poldasht");
                    break;
                case 289 :
                    System.Console.WriteLine("You City is : Piranshahr");
                    break;
                case 284 :
                    System.Console.WriteLine("You City is : Salmas");
                    break;
                case 285 :
                    System.Console.WriteLine("You City is : Salmas");
                    break;
                case 094 :
                    System.Console.WriteLine("You City is : Mashhad");
                    break;
                default:
                System.Console.WriteLine("SORRY::Your ID isn't in the range of our City DataBase");
                    break;
            }
           
            return sum1;
          
        }
        
        
    }
}
