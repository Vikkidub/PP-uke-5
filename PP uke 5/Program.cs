using PP_uke_5;
/* 
 * Du skal starte med å lage en harrypotter character klasse med egenskaper som navn, house, inventory (ex wand eller pet)

Få applikasjonen til å printe ut en introduksjon for karakteren, som sier noe om hva de heter, hvilket hus de er medlem av og hvilke items de har

Karakteren skal ha mulighet til å gå inn i en Magibutikk, der kan de kjøpe et dyr:  ugle,rotte eller en katt. De har også mulighet til å kjøpe en tryllestav: føniksstav, unikornstav eller trollstav. For å få til dette må du lage en egen klasse som er butikken, og presentere brukeren med en meny for hva personen skal kjøpe.

Karakteren skal ha mulighet til å trylle - ta inn input fra brukeren, og dersom en skriver en riktig trylleformel skal det printes til skjermen at de har utført tryllingen
trylleformler: 
vingardium leviosa (får en fjær til å fly)
hokus pokus (fyrer av fyrverkerier)
*/


    string pet;
    string wand;

    List<String> inventory = new List<string>();

    var character = new Character("", "");

    Console.WriteLine("Velkommen til Harry Potter verden");
    Console.WriteLine("-----------------------------------");

    AddInventoryItems();
    ShowInventory();
    void MainMenu()
    {
        Console.WriteLine("1. Gå til Magibutikk");
        Console.WriteLine("2. Prøv en trylleformel");
        Console.WriteLine("3. Vis inventory");

        var userInput = Console.ReadLine();

        switch (userInput)
        {
        case "1":
            Magibutikk();
            break;
        }

    }

    void AddInventoryItems()
    {
        inventory.Add("enhjørningstav");
        inventory.Add("ugle");
    }

    void ShowInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine(inventory[i]);
        }
    }

