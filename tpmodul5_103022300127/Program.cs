class DataGeneric<T> { 
    private T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData() {
        Console.WriteLine($"Data yang tersimpan adalah : {Data}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nim = "103022300127";
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}