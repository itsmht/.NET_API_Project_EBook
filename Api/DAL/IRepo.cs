using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public interface IRepo<T>
    {
        void Add(T e);
        List<T> Get();
        void Edit(T e);
        void Delete(T e);
    }
    public interface IRepo<T, ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Edit(T e);
        void Delete(T e);

    }

    public interface IRepo<T, ID, STR>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Edit(T e);
        void Delete(T e);
    }

}