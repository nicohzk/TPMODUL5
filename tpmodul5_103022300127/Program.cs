class Halogeneric
{
    public void SapaUser<T>(T User)
    {
        Console.WriteLine("Halo " + User);
    }
}

class DataGeneric<T>
{
    private T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Halogeneric halo = new Halogeneric();
        string namaPraktikan = "Hizkia";
        halo.SapaUser(namaPraktikan);
        string nim = "103022300127";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}
