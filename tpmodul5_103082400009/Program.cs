using System;

namespace TugasGeneric
{
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            string namaPanggilan = "Alvan";
            halo.SapaUser(namaPanggilan);
            string myNIM = "103082400009";
            DataGeneric<string> dataObj = new DataGeneric<string>(myNIM);

            dataObj.PrintData();
        }
    }
}