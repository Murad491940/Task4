namespace MathHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathhelper=new MathHelper();
            
            Console.WriteLine(MathHelper.PritValue(5,10));
            Console.WriteLine(MathHelper.PritValue(true));
            Console.WriteLine(MathHelper.PritValue(2,3,6));
            MathHelper.PritValue("Murad","Azizzade");

           

        }
    }
}