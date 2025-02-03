using Hotelier.BusinessLayer.Abstract;
using Hotelier.DataAccessLayer.Abstract;
using Hotelier.DataAccessLayer.EntityFramework;
using Hotelier.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelier.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public List<Testimonial> TGetAll()
        {
            return _testimonialDal.GetAll();
        }

        public List<Testimonial> TGetAllDeleted()
        {
            return _testimonialDal.GetAllDeleted();
        }

        public Testimonial TGetById(Guid id)
        {
            return _testimonialDal.GetById(id);
        }

        public void THardDelete(Guid id)
        {
            _testimonialDal.HardDelete(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity);
        }

        public void TSoftDelete(Guid id)
        {
            _testimonialDal.SoftDelete(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
