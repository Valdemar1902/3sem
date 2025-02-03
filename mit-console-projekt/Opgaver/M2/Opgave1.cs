namespace mit_console_projekt.Opgaver.M2;
using static System.Linq.Enumerable;
using static System.Console;

using mit_console_projekt.Data;

public class Opgave1
{
    // Udregner den samlede alder for alle mennesker.
    int totalAge = 0;
        for (int i = 0; i < people.Length; i++)
    {
        totalAge += people[i].Age;
    }
        
    // Tæller hvor mange der hedder "Nielsen"
    int countNielsen = 0;
        for (int i = 0; i < people.Length; i++)
    {
        if (people[i].Name.Contains("Nielsen"))
        {
            countNielsen++;
        }
    }
    // Find den ældste person
    Person oldestPerson = null;
        for (int i = 0; i < people.Length; i++)
    {
        if (oldestPerson == null || people[i].Age > oldestPerson.Age)
        {
            oldestPerson = people[i];
        }
    }
    
}