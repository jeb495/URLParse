using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParse
{
    class Program
    {


        static void ParseUrl(string url)
        {
            var input = new Uri(url);
            Console.WriteLine("Full URL:         {0}", input.AbsoluteUri);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.scheme?view=net-5.0#System_Uri_Scheme
            Console.WriteLine("Scheme:      {0}", input.Scheme);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.dnssafehost?view=net-5.0
            Console.WriteLine("Host:        {0}", input.DnsSafeHost);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.port?view=net-5.0
            Console.WriteLine("Port:        {0}", input.Port);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.localpath?view=net-5.0
            Console.WriteLine("Path:        {0}", input.LocalPath);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.query?view=net-5.0
            Console.WriteLine("Query:       {0}", input.Query);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.fragment?view=net-5.0
            Console.WriteLine("Fragment:    {0}", input.Fragment);

            //https://docs.microsoft.com/en-us/dotnet/api/system.uri.authority?view=net-5.0
            Console.WriteLine("Authority:   {0}", input.Authority);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("URL Parser By github.com/jeb495");
            Console.WriteLine("Enter A URL To Parse");
            string userInput =  Console.ReadLine();
            ParseUrl(userInput);
            Console.ReadKey();


        }
    }
}
