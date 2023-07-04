using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public Customer GetById(int Id)
        {
            return _customerDal.GetByID(Id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.List();
        }

        public void Insert(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
