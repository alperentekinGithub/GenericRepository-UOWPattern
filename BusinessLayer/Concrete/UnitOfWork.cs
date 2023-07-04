using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        Context context = new Context();

        public UnitOfWork()
        {
            customerMenager = new CustomerManager(new EfCustomerDal(context));
        }

        public CustomerManager customerMenager { get; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
