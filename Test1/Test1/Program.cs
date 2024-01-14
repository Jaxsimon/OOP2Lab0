class Program
{
    static void Main(string[] args)
    {
        //Calculate Difference

        Console.WriteLine("Lab 0");

        Console.WriteLine("Enter a Low Number: ");
        double lowNumber = GetLowNum();

        Console.WriteLine("Enter a High Number: ");
        double highNumber = GetHighNum(lowNumber);

        double dif = highNumber - lowNumber;
        Console.WriteLine($"The difference between {highNumber} and {lowNumber} is {dif}.");


        //List

        List<double> numList = new List<double>();
        for (double i = lowNumber + 1; i < highNumber; i++) 
        { 
            numList.Add(i);
        }

        using (StreamWriter sw = new StreamWriter("/Users/jaxso/source/repos/Test1/Test1/numbers.txt"))
        {
            numList.Reverse();
            foreach (double num in numList) 
            {
                sw.WriteLine(num);
            }
        }

        String line;
        using (StreamReader sr = new StreamReader("/Users/jaxso/source/repos/Test1/Test1/numbers.txt"))
        {
            double sum = 0;
            line = sr.ReadLine();
            while (line != null)
            {
                sum = sum + Convert.ToDouble(line);
                line = sr.ReadLine();
            }
            Console.WriteLine($"The sum of list is {sum}.");
        }

        //Prime Numbers

        Console.WriteLine("Prime Numbers:");
        PrintPrimeNum(lowNumber, highNumber);

        //Methods

        static double GetLowNum()
            {
                double lowNum;
                while (true)
                {
                    string lnum = Console.ReadLine();

                    if (double.TryParse(lnum, out lowNum) && lowNum > 0)
                    {
                        return lowNum;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
            }

        static double GetHighNum(double lowNum)
        {
            double highNum;
            while (true)
            {
                string hnum = Console.ReadLine();
                if (double.TryParse(hnum, out highNum) && highNum > lowNum)
                {
                    return highNum;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static bool FindPrime(double num)
        {
            for(int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintPrimeNum(double lowNum, double highNum)
        {
            for (double i = lowNum + 1; i < highNum; i++)
            {
                if (FindPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}