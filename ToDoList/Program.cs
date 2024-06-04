using Models;
using Services;

IService service = new InFileService();


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
    IEnumerable<ToDoItem> items = service.Read();

    foreach (ToDoItem item in items)
    {
        Console.WriteLine($"{item.Id}.\t{(item.IsCompleted ? "(X)" : "( )")}\t{item.Task}");
    }
}

void Add()
{
    Console.WriteLine("Describe your task:");
    ToDoItem toDoItem = new(Console.ReadLine()!); //! - wyłącznie ostrzeżenia o możliwości pojawienia się null
    service.Create(toDoItem);
}

void Delete()
{
    int id = ReadId();
    _ = service.Delete(id);
}

void Edit()
{
    int id = ReadId();
    ToDoItem? item = service.Read(id);
    if (item != null)
    {
        Console.WriteLine("Change:");
        item.Task = Console.ReadLine()!;
    }
}

void ChangeState()
{
    int id = ReadId();

    _ = service.ChangeIsCompleted(id);
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