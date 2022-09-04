Random rand = new Random();

List<string> lista = new List<string>();
lista.Add("Gabriel Silva");
lista.Add("Erick Pereira");
lista.Add("Vitoria Silva");
lista.Add("Gislaine Pereira");
lista.Add("Silvia Silva");
lista.Add("Guilherme da Costa");
lista.Add("Gustavo Silva");


//lista.Insert(0, "Antes do primeiro elemento");

/*
for (int i = 0; i < rand.Next(90, 100); i++)
{
    lista.Add(rand.Next(1, 10000).ToString());
}
*/
PrintList(lista);

Console.WriteLine("List count: " + lista.Count);


List<string> listb = new List<string>();
Console.WriteLine();

string? search1 = lista.Find(x => x.Contains("a"));
string? search2 = lista.Find(x => x.Contains("v"));


Console.WriteLine($"Find > Contains a: {search1}");
Console.WriteLine($"Find > Contains v: {search2}");
Console.WriteLine();

string? search3 = lista.FindLast(x => x.Contains("v"));
string? search4 = lista.FindLast(x => x[0] == 'V');

Console.WriteLine($"FindLast > Contains v: {search3}");
Console.WriteLine($"FindLast name with char V: {search4}");
Console.WriteLine();


int search5 = lista.FindIndex(x => x[0] == 'G');
int search6 = lista.FindLastIndex(x => x[0] == 'G');

Console.WriteLine($"First index with char A: {search5}");
Console.WriteLine($"Last index with char A: {search6}");
Console.WriteLine();


int search7 = lista.FindIndex(x => x[0] == 'G');
int search8 = lista.FindLastIndex(x => x[0] == 'G');

Console.WriteLine($"First index with char G: {search7}");
Console.WriteLine($"Last index with char G: {search8}");
Console.WriteLine();

Console.WriteLine("-----------------------------");
Console.WriteLine();
Console.WriteLine("Nomes com menos de 15 caracteres: ");

List<string> search9 = lista.FindAll(x => x.Length < 15);
PrintList(search9);



string? search10 = search9.Find(x => x.Contains("Gabriel"));
search9.Remove(search10);

search9.RemoveAll(x => x[0] != 'V');
Console.WriteLine("Removendo nomes que não começam com V:");
PrintList(search9);

Console.WriteLine("Primeira Lista: ");
PrintList(lista);

Console.WriteLine("Removendo Pereira:");
lista.RemoveAll(x => x.Contains("Pereira"));
PrintList(lista);

static void PrintList(List<string> list)
{
    Console.WriteLine("____________       ___________");
    Console.WriteLine("____________|Start|___________");
    Console.WriteLine("------------------------------");
    foreach (string s in list)
    {
        Console.WriteLine(s);

    }
    Console.WriteLine("____________       ___________");
    Console.WriteLine("_____________|End|____________");
    Console.WriteLine("------------------------------");
}