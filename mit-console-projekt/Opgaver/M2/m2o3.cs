using System.Globalization;

namespace mit_console_projekt.Opgaver;
using static Console;
using System.Linq;
public class m2o3
{
    static string[] badwords = { "fuck", "dum", "træls", "fisse" };

    public static void WordRemover()
    {
        string text = "store fede fisse og den er træls, fuck fuck ahhhh!";
        
        var filter = CreateWordFilterFn(badwords);
        string filteredText = filter(text);
        
        Console.WriteLine(filteredText);
    }
    public static Func<string, string> CreateWordFilterFn (string[] badwords)
    {
        return (text) => {
            
            foreach (var badword in badwords)
            {
                text = text.Replace(badword, new string(' ', badword.Length));
            }
            return text;
        };
    }
    public static void WordReplacer()
    {
        string text = "store fede fisse og den er træls, fuck fuck ahhhh!";

        
        var filter = CreateWordReplacerFn(badwords);
        string filteredText = filter(text);
        
        Console.WriteLine(filteredText);
    }
    public static Func<string, string> CreateWordReplacerFn (string[] badwords)
    {
        return (text) => {
            
            foreach (var badword in badwords)
            {
                text = text.Replace(badword, new string('*', badword.Length));
            }
            return text;
        };
    }
}