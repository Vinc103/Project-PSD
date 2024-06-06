using Project_PSD.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class MakeupRepo
    {
        public interface IMakeupRepository
        {
            IEnumerable<Makeup> GetAll();
            Makeup GetById(int id);
            void Add(Makeup makeup);
            void Update(Makeup makeup);
            void Delete(int id);
        }
    }

}
