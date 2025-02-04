using System.Globalization;
using mit_console_projekt.Data;

namespace mit_console_projekt.Opgaver;
using static Console;
using System.Linq;

public class m2o4
{
    public class BubbleSort
    {
        Data.Person[] people = Data.PeopleData.GetPeople();

        // Bytter om på to elementer i et array
        private static void Swap(Person[] array, int i, int j)
        {
            Person temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Laver sortering på array med Bubble Sort. 
        // compareFn bruges til at sammeligne to personer med.
        public static void Sort(Person[] array, Func<Person, Person, int> compareFn)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    // Laver en ombytning, hvis to personer står forkert sorteret
                    if (compareFn(array[j], array[j + 1]) > 0)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }
    }

    public static void SortByAge()
    {
        Data.Person[] people = Data.PeopleData.GetPeople();
        
        Func<Person, Person, int> CompareFn = (p1, p2) => 
            p1.Age < p2.Age ? -1 : (p1.Age == p2.Age ? 0 : 1);

        int result = CompareFn(people[1], people[2]);
        Console.WriteLine("Forklaring: -1: Person 1 er yngre. 0: Person 1 og 2 er lige gamle. 1: Person 1 er ældre.");
        Console.WriteLine(result);
    }
    
}