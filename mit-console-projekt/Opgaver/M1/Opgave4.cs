namespace mit_console_projekt.Opgaver;

class Opgave4
{
    // delopgave 1
    public static int sfd(int a, int b)
    {
        if (b <= a && a % b == 0)
        {
            return b;
        }
        else
        {
            if (a < b)
            {
                return sfd(b, a);
            }
            else
            {
                return sfd(b, a % b);
            }
        }
    }

    // delopgave 2
    public static int potens(int n, int p)
    {
        if (p == 0)
        {
            return 1;
        }
        else
        {
            return n * potens(n, p - 1);
        }
    }

    // delopgave 3
    public static int gange(int a, int b)
    {
        if (b == 1)
        {
            return a;
        }
        else if (b == 0)
        {
            return 0;
        }
        else
        {
            return (a + gange(a, b - 1));
        }
    }

    //delopgave 4
    public static string Reverse(string s)
    {
        if (s.Length <= 1) return s;
        else return Reverse(s.Substring(1)) + s[0];
    }
}