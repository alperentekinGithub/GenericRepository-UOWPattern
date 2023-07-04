using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using GenericRepository_UOWPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository_UOWPattern.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {

        UnitOfWork unitOfWork = new UnitOfWork();

        /// <summary>
        /// 
        /// </summary>
        [HttpPost]
        public string addCustomer(Customer Customer)
        {
            Customer.CreateTime = DateTime.Now;
            Customer.UpdateTime = DateTime.Now;
            try
            {
                unitOfWork.customerMenager.Insert(Customer);
                unitOfWork.Complete();
                unitOfWork.Dispose();
                return "Successfully Added";
            }
            catch (Exception e)
            {
                return "add failed :" + e;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("{id}")]
        [HttpGet]
        public RWMCustomer GetCustomer(int id)
        {
            Customer customer = new Customer();
            RWMCustomer rwmCustomer = new RWMCustomer();
            try
            {
                customer = unitOfWork.customerMenager.GetById(id);
                rwmCustomer.customer = customer;
                rwmCustomer.message = "Customer successfully brought";
                return rwmCustomer;
            }
            catch (Exception e)
            {
                rwmCustomer.customer = customer;
                rwmCustomer.message = "An error occurred while fetching data.\n" + "Exception:" + e;
                return rwmCustomer;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public List<Customer> getCustomerAll()
        {
            return unitOfWork.customerMenager.GetList();
        }
    }
}
