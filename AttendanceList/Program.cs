using Models;
using Services;

IService<Person> service = new InFileService<Person>();


bool exit = false;
do
{
    Console.Clear();
    ShowMenu();

    string? input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Add();
            break;
        case "2":
            Delete();
            break;
        case "3":
            Edit();
            break;
        case "4":
            ChangeState();
            break;
        case "5":
            exit = true;
            break;
    }
} while (!exit);


void ShowItems()
{
    IEnumerable<Person> items = service.Read();

    foreach (Person item in items)
    {
        Console.WriteLine($"{item.Id}.\t{(item.IsPresent ? "(X)" : "( )")}\t{item.Name}");
    }
}

void Add()
{
    Console.WriteLine("Provide name:");
    Person Person = new() { Name = Console.ReadLine()! }; 
    service.Create(Person);
}

void Delete()
{
    int id = ReadId();
    _ = service.Delete(id);
}

void Edit()
{
    int id = ReadId();
    Person? item = service.Read(id);
    if (item != null)
    {
        Console.WriteLine("Change:");
        item.Name = Console.ReadLine()!;
    }
}

void ChangeState()
{
    int id = ReadId();
    var item = service.Read(id);
    if(item != null)
    {
        item.IsPresent = !item.IsPresent;
    }
}

void ShowMenu()
{
    ShowItems();
    Console.WriteLine();
    Console.WriteLine("1. Add; 2. Delete; 3. Edit; 4. Change state; 5. Exit");
}

static int ReadId()
{
    Console.WriteLine("Id:");
    string input = Console.ReadLine()!;
    int id = int.Parse(input);
    return id;
}