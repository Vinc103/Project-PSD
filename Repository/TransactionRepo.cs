using Project_PSD.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class TransactionRepo
    {
        public interface ITransactionRepository
        {
            IEnumerable<TransactionHeader> GetAll();
            TransactionHeader GetById(int id);
            void Add(TransactionHeader transaction);
            void Update(TransactionHeader transaction);
            void Delete(int id);
        }
    }

}
