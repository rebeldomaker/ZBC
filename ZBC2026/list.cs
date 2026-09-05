static void Main(string[] args)
{   // create the list
    List<string> OCs = new List<string>();
    
    // add items to the newly created list
    OCs.Add("Klonopin");
    OCs.Add("Welbutrin");
    OCs.Add("Ditch");

    foreach (string oc in OCs)
    {
        Console.WriteLine(oc);
    }
    
    // remove an element from the list
    OCs.Remove("Ditch");

    foreach (string oc in OCs)
    {
        Console.WriteLine(oc);
    }

}