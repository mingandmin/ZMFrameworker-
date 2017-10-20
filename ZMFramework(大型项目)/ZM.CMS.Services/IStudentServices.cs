using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;
namespace ZM.CMS.Services
{
    public interface IStudentServices
    {
        IEnumerable<StudtentModels> GetAll();
        StudtentModels Get(int id);
        StudtentModels Add(StudtentModels item);
        bool Update(StudtentModels item);
        bool Delete(int id);
    }
}
