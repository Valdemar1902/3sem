namespace mit_console_projekt.Opgaver
{
    using static Console;
    using System.Linq;

    public class m2o1
    {
        

        public static void linq()
        {
            // Hent data
            Data.Person[] people = Data.PeopleData.GetPeople();

            // Udregner den samlede alder for alle mennesker.
            var totalAge = people.Sum(p => p.Age);
            WriteLine($"Total Age: {totalAge}");

            // Tæller hvor mange der hedder "Nielsen"
            int countNielsen = people.Count(p => p.Name.Contains("Nielsen"));
            WriteLine($"Count of Nielsen: {countNielsen}");

            // Find den ældste person
            Data.Person oldestPerson = people.OrderByDescending(p => p.Age).FirstOrDefault();
            WriteLine($"Oldest Person: {oldestPerson?.Name}, Age: {oldestPerson?.Age}");
        }
    }
}