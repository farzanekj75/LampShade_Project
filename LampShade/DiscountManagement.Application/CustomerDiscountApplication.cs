using _0_Framework.Application;
using DiscountManagement.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountManagement.Application
{
    public class CustomerDiscountApplication : ICustomerDiscountApplication
    {
        private readonly ICustomerDiscountApplication _customerDiscountApplication;

        public CustomerDiscountApplication(ICustomerDiscountApplication customerDiscountApplication)
        {
            _customerDiscountApplication = customerDiscountApplication;
        }

        public OperationResult Define(DefineCustomerDiscount command)
        {
            throw new NotImplementedException();
        }

        public OperationResult Edit(EditCustomerDiscount command)
        {
            throw new NotImplementedException();
        }

        public EditCustomerDiscount GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDiscountSearchModel> Search(CustomerDiscountSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
