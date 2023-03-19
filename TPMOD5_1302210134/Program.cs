class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = "Chandra";
        halo.SebutUser(nama);

        DataGeneric<string> data = new DataGeneric<string>("1302210134");
        data.PrintData();
    }
}