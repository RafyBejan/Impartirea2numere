namespace Impartirea2numere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = x / y;
            if(x!=0 && x%y==0)
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Impartire cu rest");
            }
            
        }
    }
}