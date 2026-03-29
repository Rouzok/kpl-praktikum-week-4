using System;

namespace TugasGeneric
{
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
        }
    }
}