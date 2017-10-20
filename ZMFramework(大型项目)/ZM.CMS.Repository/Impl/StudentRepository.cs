using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityModels;

namespace ZM.CMS.Repository.Impl
{
    public class StudentRepository : IStudentRepository
    {
        private List<StudtentModels> Articles = new List<StudtentModels>();

        public StudentRepository()
        {
            //添加演示数据
            Add(new StudtentModels { Id = 1, Name = "张三", Major = "软件工程", Graduation = "2013年", School = "西安工业大学" });
            Add(new StudtentModels { Id = 2, Name = "李四", Major = "计算机科学与技术", Graduation = "2013年", School = "西安工业大学" });
            Add(new StudtentModels { Id = 3, Name = "王五", Major = "自动化", Graduation = "2013年", School = "西安工业大学" });
        }
        public StudtentModels Add(StudtentModels item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            Articles.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            Articles.RemoveAll(p => p.Id == id);
            return true;
        }

        public StudtentModels Get(int id)
        {
            return Articles.Find(p => p.Id == id);
        }

        public IEnumerable<StudtentModels> GetAll()
        {
            return Articles;
        }

        public bool Update(StudtentModels item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = Articles.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            Articles.RemoveAt(index);
            Articles.Add(item);
            return true;
        }
    }
}
