// See https://aka.ms/new-console-template for more information
Console.WriteLine(Opgave3.Faculty(5)); // Output skal være '120'.

class Opgave3 {
    public static int Faculty(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Faculty(n - 1);
        }
    }
}
    
 