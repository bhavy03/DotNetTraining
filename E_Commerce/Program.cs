using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace E_Commerce
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select the operation you want to perform");
                Console.WriteLine("1. Add Information\n2. Retrieve Information\n3. Update Information\n4. Remove Information\n5. Exit");
                Console.WriteLine("Enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ECommerceManager.AddInfo();
                        break;
                    case 2:
                        ECommerceManager.RetrieveInfo();
                        break;
                    case 3:
                        ECommerceManager.UpdateInfo();
                        break;
                    case 4:
                        ECommerceManager.DeleteInfo();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }
            }
        }
    }
}

//ASP.NET Core Web API is a framework provided by Microsoft for building HTTP-based APIs (RESTful web services) using ASP.NET Core.
//REST(stands for Representational State Transfer) is an Architectural Design Pattern used for Exchanging Data over a Distributed Environment.
//The stateless constraint specifies that client-server communication must be stateless between requests. That means the server should not store any information,
//i.e., session state related to the client on the server. 
//HTTP stands for Hypertext Transfer Protocol. It is the foundation of data communication for the World Wide Web.
//It defines how messages are formatted and transmitted and how web servers and browsers should respond to various commands.
//POST is not idempotent others are that means they generate the same result every time.
//A method is considered idempotent if executing the same request multiple times has the same effect as making it just once.
//In other words, no matter how many times we perform the operation, the final result on the server is the same as doing it once. 

//1xx(Informational Responses): The request is being processed.
//2xx (Successful Responses): The request was successfully received, understood, and accepted.
//3xx (Redirection Responses): Further action is needed to complete the request.
//4xx (Client Error Responses): There was an issue with the client’s request.
//5xx (Server Error Responses): The server encountered an issue processing the request.