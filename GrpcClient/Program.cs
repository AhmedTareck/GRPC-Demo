using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;
using GrpcService.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var input = new HelloRequest 
            //{
            //    Name="Ahmed Tareck Ben Suliman"
            //};

            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            var chanel = GrpcChannel.ForAddress("https://localhost:5001");

            var customerClint = new Customer.CustomerClient(chanel);

            var clientRequested = new CustomerLookupModel { UserId = 2 };

            var customer = await customerClint.GetCustomerInfoAsync(clientRequested);

            Console.WriteLine($"{customer.FirstName} { customer.LastName}");
           
            
            Console.WriteLine();
            Console.WriteLine("New Customer List");
            Console.WriteLine();

            

            using (var call=customerClint.GetNewCustomers(new NewCustomerRequest()))
            {
                while(await call.ResponseStream.MoveNext())
                {
                    var currentCustomer = call.ResponseStream.Current;

                    Console.WriteLine($"{ currentCustomer.FirstName} { currentCustomer.LastName} " +
                        $"{ currentCustomer.EmailAddress} { currentCustomer.Age} { currentCustomer.IsAlive}");
                }
            }

            Console.ReadLine();
        }
    }
}
