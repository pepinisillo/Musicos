class Musico
{
//campos
 public string nombre{get; set;}

//constructores
 public Musico(string n)
 {
    nombre = n;
 }

//Métodos
 public void saluda()
 {
    //Console.WriteLine("Hola soy {1}", nombre);
    Console.WriteLine($"Hola soy {nombre}");
 }
 
public virtual void toca()
{
    Console.WriteLine($"{nombre} está tocando su instrumento");
}
}
/*class Bajista
{
//

//constructor

}*/
//las clases abstractas no pueden crear objetos solo referencias
class Baterista:Musico
{
    public string bateria{get; set;}

    public Baterista(string n, string b):base(n)
    {
        bateria = b;
    }
    public override void toca()
    {
        Console.WriteLine($"{nombre} está tocando su {bateria}");
    }
}
class Bajista:Musico
{
    public string bajo{get; set;}
    public Bajista(string n, string b):base(n)
    {
        this.bajo = b;
    }
    public override void toca()
    {
        Console.WriteLine($"{nombre} esta tocando su {bajo}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {

        List<Musico> grupo = new List<Musico>();
        grupo.Add(new Musico("Joem"));
        grupo.Add(new Bajista("Joe", "uiui"));
        grupo.Add(new Baterista("ko", "uuy"));

        foreach(var m in grupo)
        m.saluda();

        foreach(var m in grupo)
        m.toca();
    }
}