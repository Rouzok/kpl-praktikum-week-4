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

    class Program
    {
        static void Main(string[] args)
        {
            string myNIM = "103082400009";
            DataGeneric<string> dataObj = new DataGeneric<string>(myNIM);

            dataObj.PrintData();
        }
    }
}