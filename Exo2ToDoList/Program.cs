List<string> toDoList = new List<string>(); 
toDoList.Add("Faire les courses ");
toDoList.Add("donner à manger au chien");
toDoList.Add("faire caca et s'essuyer c'est important !");

string choice="";

do
{
    Console.WriteLine("1: Ajouter des élémeents à la liste");
    Console.WriteLine("2: Retirer des éléments à la liste");
    Console.WriteLine("3: Afficher les éléments de la liste");
    Console.WriteLine("q: pour quitter le menu");
    Console.Write("Veuillez choisir parmi ces options : ");
    choice = Console.ReadLine();
    Console.WriteLine();

    if (choice == "1")
    {
        Console.WriteLine("Veuillez ajouter une toDo a la liste : ");
        toDoList.Add(Console.ReadLine());
    }


    if (choice == "2")
    {
        Console.WriteLine("Quel élément voulez-vous retirer ?");
        string item = Console.ReadLine();

        if (toDoList.Contains(item))
        {
            toDoList.Remove(item);
            Console.WriteLine("Item remove");
        }
        else
        {
            Console.WriteLine("Tu n'as qu'à le faire toi même");
        }
    }
} while (choice != "q");