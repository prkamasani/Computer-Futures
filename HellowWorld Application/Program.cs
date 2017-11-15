using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;



namespace HellowWorld_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            EvalServiceReferance.EvalServiceClient client = new EvalServiceReferance.EvalServiceClient();
           var abc =  client.GetData(10);
           
            Console.WriteLine(client.Hellowworld());
            client.Close();
            Console.ReadLine();
        }
    }
}
