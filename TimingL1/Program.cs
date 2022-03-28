using System;


namespace get_current_time
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string datetime = DateTime.Now.ToString(" dddddd:dd:hhhh:mmmm:ss:yyyy tt");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(datetime);

            }
           

        }
    }
}