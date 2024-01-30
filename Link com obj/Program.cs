
using System; 

class Progran
{
    static void Main()
    {
        List<Worker> workers = new List<Worker>() {

            new Worker("Jose", 4000),
            new Worker("Josias", 5000),
            new Worker("Elias", 9000),
            new Worker("Pedro", 5300),
        
        
        
        };

        var g = workers.Where(w=> w.salario<6000.00).Select(w => w.salario * 2);
        var d = workers.Where(w => w.nome[0] == 'P').Select(o=> o.nome);
        var w = workers.FirstOrDefault(obj => obj.nome[0] == 'J');
        foreach ( var a in g)
        {
            Console.WriteLine(a);
        }
        foreach (var a in d)
        {
            Console.WriteLine(a);
        }
        Console.WriteLine(w);

        Console.WriteLine("anderson");

        Console.WriteLine( " Depois do commit");
        Console.WriteLine(" Depois do commit2");
        Console.WriteLine(" Depois do commit3");
    }
}