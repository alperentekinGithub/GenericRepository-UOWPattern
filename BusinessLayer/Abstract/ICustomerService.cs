using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetList();
        void Update(Customer customer);
        void Insert(Customer customer);
        void Delete(Customer customer);
        Customer GetById(int Id);
    }
}
