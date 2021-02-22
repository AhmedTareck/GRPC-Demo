using Grpc.Core;
using GrpcService.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;

        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            //return base.GetCustomerInfo(request, context); 

            CustomerModel output = new CustomerModel();

            if(request.UserId==1)
            {
                output.FirstName = "Ahmed";
                output.LastName = "Tareck";

            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Tareck";
                output.LastName = "Ben";
            }
            else
            {
                output.FirstName = "Ali";
                output.LastName = "Ahmed";
            }

            return Task.FromResult(output);
        }

        public override async Task GetNewCustomers(NewCustomerRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>
            {
                new CustomerModel
                {
                    FirstName="Ahmed",
                    LastName="tareck",
                    EmailAddress="ahmedtareckb@gmail.com",
                    Age=23,
                    IsAlive=true
                },
                new CustomerModel
                {
                    FirstName="Fathi",
                    LastName="tareck",
                    EmailAddress="ahmedtareckb@gmail.com",
                    Age=24,
                    IsAlive=true
                },
                new CustomerModel
                {
                    FirstName="Abdo",
                    LastName="tareck",
                    EmailAddress="ahmedtareckb@gmail.com",
                    Age=25,
                    IsAlive=true
                }
            };

            foreach (var cust in customers)
            {
                await Task.Delay(1000);
                await responseStream.WriteAsync(cust);
            }
        }

    }
}
