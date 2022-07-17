Console.WriteLine("Enter the value of N");
int N=Convert.ToInt32(Console.ReadLine());
double s = 0;
if(N>0)
{
    for (double i = 1; i <= N; i++)
    {
        double Hnum = (1/i);
        s+=Hnum;
        Console.WriteLine("The Harmonic series are as follow: " +Hnum.ToString());
        //Console.WriteLine(s);
    }
   // Console.WriteLine(Hnum.ToString());
    Console.WriteLine("The SUM of above series is: " +s);
}
else
    Console.WriteLine("Invalid Entry");