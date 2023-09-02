using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;
using System.Transactions;


namespace w
{
    class Program 
    {
       
        public static void Main() 
        
        {
              //primary user interaction part shits
           Console.WriteLine(" Welcome To Mathematics hub!\n Whats your name? \n");
           string name=Convert.ToString(Console.ReadLine()); 
           Console.Clear(); 
           returntothis: 
Console.ForegroundColor=ConsoleColor.White; 
           Console.WriteLine(" Hey "+name+" ! \n\n Select what do you want to do."); 
           Console.WriteLine("\n 1. Factorial of any number \n 2. Quadratic equation solver \n 3. Simulatenous linear equation solver. \n 4.Physics Problem (Distance travelled and accelerations) \n");
           int choice=Convert.ToInt16(Console.ReadLine()); 
        
        switch (choice)
        {
           case 1:
            Factorial();  
            break; 

            case 2:
            Quadratic();
            break; 

            
            case 3:
            linearEquation(); 
            break;

            case 4:
            physicsFiesta(); 
            break;
        }

        
        



        //factorial function 
        static void Factorial()
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.DarkGreen;  
            Console.WriteLine("Hello ! Welcome to factorial calculator."); 
            Console.WriteLine(" \n 1. Integer \n 2. Non-integer \n"); 
            Console.Write("\n Select your desired option =   ");
            int choice=Convert.ToInt16(Console.ReadLine()); 

            if (choice==1)
            {
                Console.Clear(); 
                Console.Write(" Enter the Number?   "); 
             double fact=Convert.ToDouble(Console.ReadLine()); 
                double final =1; 
                for (int i = 1; i <= fact; i++)
                {
                    final *= i;
                }
                Console.WriteLine(" The Factorial of "+fact+" is "+final); 
            }

            if (choice==2)
            {
                Console.Clear(); 
                Console.WriteLine(" \n Note: We will use the gamma function to approximate the value of factorial of non-integers");
                Console.Write("Enter your number?  =  ");  
                double fact1=Convert.ToDouble(Console.ReadLine()); 
                int k=10000; 
                double semifinal=1; 
                for (int i = 1; i <=k; i++)
                {
                    semifinal *=((i)/(i+fact1)); 
                }
                double final1= (Math.Pow(k,fact1)) * semifinal; 
                Console.WriteLine(" The Factorial of "+ fact1+"is "+ final1); 
            }



        
        }

        //quadratic function
    static void  Quadratic()
        {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
        Console.Clear(); 
        Console.WriteLine("Hello ! Welcome to the quadratic equation solver. \n Make your quadratic equation in the form of Ax^2+Bx+C=0, and enter! \n" );
Console.Write("Coefficient A= ");
int a=Convert.ToInt16(Console.ReadLine()); 

Console.Write("Coefficient B= ");
int b=Convert.ToInt16(Console.ReadLine()); 

Console.Write("Coefficient C= ");
int c=Convert.ToInt16(Console.ReadLine()); 

double ans1, ans2, det, subAns1; 
string ans0; 
det= (Math.Pow(b,2))-4*a*c; 
if (det<0)
{
    det=-det; 
    ans1=-b/(2*a); 
    ans0=Convert.ToString(ans1); 
    ans2=Math.Sqrt(det)/(2*a);
    Console.WriteLine("The Solutions are:\n"+ans0+"+"+ans2+"i");
    Console.WriteLine(ans0+"-"+ans2+"i");

}
else if (det>=0)
{
ans1=(-b+Math.Sqrt(det))/(2*a);
ans2=(-b-Math.Sqrt(det))/(2*a);  
Console.WriteLine("The Solutions are:\n"+ans1+"\n"+ans2); 
}
        }


         static async void physicsFiesta()
         {
            Console.ForegroundColor=ConsoleColor.DarkGreen;
            Console.Clear();
                
                Console.WriteLine("Hello! Welcome to Physics acceleration calculator!\n");

                 Console.WriteLine("Select an option \n 1. Find distance covered of particular segement \n 2. Find distance covered upto particular segment"); 
            int choice=Convert.ToInt16(Console.ReadLine());
            Console.Clear(); 
            Console.Write("Enter the Number of accelerations in the question ?  =  ");
            int accelerationNumber=Convert.ToInt16(Console.ReadLine());
                double[] acceleration= new double[accelerationNumber+1];
            acceleration[0]=0; 

                 Console.Write("Enter the initial velocity at the start ?   =    "); 
            double initialVelocity=Convert.ToDouble(Console.ReadLine()); 
            
            Console.Write("Enter the uniform time period between the accelerations ? =     "); 
            double Time=Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= accelerationNumber; i++)
            {
                Console.WriteLine("Enter the accleration number "+i); 
                acceleration[i]=Convert.ToDouble(Console.ReadLine()); 
            }
                if (choice==1)
            {Console.WriteLine("Enter the segment of which you want to know the distance covered of:");
            int segment=Convert.ToInt16(Console.ReadLine());  

                double subAnswer1=0;
                double subAnswer2=0; 
                double subAnswer3=0; 
                double finalAnswer=0;
                double sumofAcceleration=0;
                int segment1=segment-1; 

                for (int i = 1; i <= (segment); i++)
                {
                    sumofAcceleration +=acceleration[i-1]; 
                }
                    subAnswer1=initialVelocity*Time;
                    subAnswer2=Math.Pow(Time,2);
                    subAnswer3=((0.5)*acceleration[segment])+sumofAcceleration;
                    finalAnswer=subAnswer1+subAnswer2*subAnswer3;
                    Console.WriteLine("The distance covered by the "+segment+" is= "+finalAnswer); 
            }
            if(choice==2)
            {
                Console.WriteLine("Enter the segment upto which you want know the distance covered of ?  =   "); 
                int segment=Convert.ToInt16(Console.ReadLine()); 
                    double subAns12=0;
                    double subAns22=0;  
                    double finalAnswer1=0; 
                    double everChanging;
                for (int i = 0; i <= segment; i++)
                {
                        everChanging=((2*(segment)+1-(2*i))*0.5);
                  subAns12+=  everChanging*acceleration[i]*(Math.Pow(Time,2));
            
                }
                        subAns22=segment*initialVelocity*Time;
                        finalAnswer1=subAns12+subAns22;
                        Console.WriteLine("The total distance covered till the specified segment is "+ finalAnswer1); 
              }



                   
                        
                    }
                
                static void linearEquation()
                {
                    Console.Clear();
                    Console.Write("Enter how many variables  =    "); 
                    int variable=Convert.ToInt16(Console.ReadLine());
                    double [,]coefficent=new double [variable+1,variable]; 
                    

                    for (int i = 0; i <= variable; i++)
                    {
                        coefficent[0,i]=0;
                    }

                    for (int i = 1; i <= variable; i++)
                    {
                        for (int j = 1; j <=variable; j++)
                        {
                        Console.Write("Enter the coefficient of variable no.  "+j +"   in equation no  "+i+"           =");
                       coefficent[i,j]= Convert.ToInt16(Console.ReadLine());
                        }
                    }








                    int hcf()
                    {
                        int a=0;
                        return a;
                    }
                }
            
         

        








    Console.WriteLine(" Do you want to go again? (Y/N)"); 
string thisOne=Convert.ToString(Console.ReadLine()); 
  thisOne= thisOne.ToUpper(); 
  Console.Clear(); 

switch (thisOne)
{
    case "Y":
    goto returntothis; 
    break;
}

                        
    }
    }

 
}