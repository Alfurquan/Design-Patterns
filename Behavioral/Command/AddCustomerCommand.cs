﻿using DesignPatterns.Behavioral.Command.FX;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void Execute()
        {
            service.AddCustomer();
        }
    }
}
