namespace media_moda_mediana;

class Program
{
    static String getInformations(int valuesTyped) 
    {
        int vetSize = 50;
        var vetNumber = new double[valuesTyped];

        Console.WriteLine("Type the numbers below;");
        try
        {
            for(int i = 0; i < valuesTyped; i++) 
            {
                vetNumber[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();

            Console.Write("\nThe numbers typed are: ");
            foreach (var vetNum in vetNumber)
            {
                Console.Write(vetNum +", ");
            }

            sortFunction(vetNumber);

            /* Moda's values --------------------------- */
            double numShowedMore = 0.0;
            int indexShowedMore = 0;
            for(int i = 0; i < vetNumber.Length; i++)
            {
                int numShowed = 0;
                for(int j = 0; j < vetNumber.Length; j++)
                {
                    if(vetNumber[i] == vetNumber[j]) 
                    {
                        numShowed++;
                    }
                    if(numShowed > numShowedMore)
                    {
                        numShowedMore = numShowed;
                        indexShowedMore = i;
                    }
                }
            }
            Console.WriteLine("\nMode's values: "+ vetNumber[indexShowedMore]);

            /* Median's value ------------------------------*/
            Array.Sort(vetNumber);
            int middle = vetNumber.Length / 2;
            if(vetNumber.Length %2 != 0)
            {
                Console.WriteLine("\nMedian's value :"+ vetNumber[middle]);
            }
            else
            {
                Console.WriteLine("\nMedian's value :"+ (vetNumber[middle] + vetNumber[middle - 1]) / 2);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine("Unexpected error: "+ error.Message);
        }

        //TODO: criar um return ao final -- 
        return "Program done.";
    }

    static void sortFunction(double[] vetNumber)
    {
        Array.Sort(vetNumber);
        Console.Write("\n\nOrdered numbers: ");
        foreach(double vetNum in vetNumber) 
        {
            Console.Write(vetNum +", ");
        }
        
        Console.WriteLine(meanFunction(vetNumber));
    }

    static String meanFunction(double[] vetNumber)
    {
        double mean = 0.0;
        double aux = 0.0;
        foreach(double vetNum in vetNumber)
        {
            aux += vetNum;
            mean = (aux / vetNumber.Length);
        }
        return "\n\nThe Mean of the numbers: "+ mean;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Mean, Median and Mode!");
        Console.WriteLine("How many values do you want to type?");
        try
        {
            Console.WriteLine(getInformations(int.Parse(Console.ReadLine())));
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}
