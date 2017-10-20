using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
using ZM.CMS.Repository;
namespace ZM.CMS.Services.Impl
{
    public class StudentServices : IStudentServices
    {
        private IStudentRepository _m;
        public StudentServices(IStudentRepository repository)
        {
            _m = repository;
        }
        public StudtentModels Add(StudtentModels item)
        {
            return _m.Add(item);
        }

        public bool Delete(int id)
        {
            return _m.Delete(id);
        }

        public StudtentModels Get(int id)
        {
            return _m.Get(id);
        }

        public IEnumerable<StudtentModels> GetAll()
        {
            return _m.GetAll();
        }

        public bool Update(StudtentModels item)
        {
            return _m.Update(item);
        }
    }
}
