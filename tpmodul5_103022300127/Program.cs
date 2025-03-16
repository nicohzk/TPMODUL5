class Halogeneric {
    public void SapaUser<T>(T User) {
        Console.WriteLine("Halo "+ User);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Halogeneric halo = new Halogeneric();
        string namaPraktikan = "Hizkia";
        halo.SapaUser(namaPraktikan);
    }
}