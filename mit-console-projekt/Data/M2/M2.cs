namespace mit_console_projekt.Data;

public class people
{

    Person[] people = new Person[]
    {
        new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
        new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
        new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
        new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
        new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
        new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
    };

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}