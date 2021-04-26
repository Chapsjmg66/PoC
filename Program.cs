using System;

using Newtonsoft.Json;

namespace ProofOfConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var json = @"{ 'NewDefinitions' : true}";

            //json = "";

            int test = 1;
            int test2 = 12;
            int test3 = 123;

            var dt = DateTime.Now.ToShortTimeString();
            dt = DateTime.Now.ToLongTimeString();
            string idx = test.ToString("D3");
            idx = test2.ToString("D3");
            idx = test3.ToString("D3");

            var hb = new Heartbeat();
            hb = JsonConvert.DeserializeObject<Heartbeat>(json);
            try
            {
                if (hb.NewDefinitions)
                {
                    Console.Out.WriteLine("TRUE");
                }
                else
                {
                    Console.Out.WriteLine("Others");
                }
            }
            catch( Exception ex)
            {
                Console.Out.WriteLine("Ooops");
                Console.Out.WriteLine(ex.ToString());
            }


        }
    }

    public class Heartbeat
    {
        public bool NewDefinitions { get; set; }
    }
}
