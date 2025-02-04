namespace mit_console_projekt.Opgaver;

class m1o3
{
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