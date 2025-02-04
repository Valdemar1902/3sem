namespace mit_console_projekt.Opgaver;
using static System.Console;
using mit_console_projekt.Data;
using System.Linq;

public class Opgave2
{
    public static void findNummer()
    {
        Data.Person[] people = Data.PeopleData.GetPeople();
        
        people
            .Where(person => person.Phone == "+4543215687")
            .ToList()
            .ForEach(s => WriteLine(s.Name));
    }
    public static void findAlder()
    {
        Data.Person[] people = Data.PeopleData.GetPeople();
        
        people
            .Where(person => person.Age > 30)
            .ToList()
            .ForEach(s => WriteLine(s.Name));
    }
    public static void arrayUdenLandekode()
    {
        Data.Person[] people = Data.PeopleData.GetPeople();
        List<Data.Person> newPeople = new List<Person>();
        
        

        foreach (var person in people)
        {
            if (person.Phone.StartsWith("+45"))
            {
                person.Phone = person.Phone.Remove(0, 3);
            }

            newPeople.Add(person);
        }
        newPeople
        .Where(person => person.Age > 30)
        .ToList()
        .ForEach(s => WriteLine($"{s.Name} {s.Phone}"));
    }
}
