
List<string> toDoList =  new List<string>(); 
toDoList.Add("Faire les courses ");
toDoList.Add("donner à manger au chien");
toDoList.Add("faire caca ");

string choice=" ";
do
{

    Console.WriteLine("1: Ajouter des élémeents à la liste");
    Console.WriteLine("2: Retirer des éléments à la liste");
    Console.WriteLine("3: Afficher les éléments de la liste");
    Console.WriteLine("q: pour quitter le menu");
} while (choice != "q");