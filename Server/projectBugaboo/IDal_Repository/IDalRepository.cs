using Dto_Common_Enteties;
using System;

namespace IDal_Repository
{
    //CRUD- create,Read,Update<Delete מממשק תשתיתי שיכיל את פעולות היסוד
    //למחלקה שיהיו פונקציות נוספות ניצור ממשק נוסף שימממש ממשק זה ויכיל את המתודות הנוספות
    public interface IDalRepository<T>
    {
        public Task<List<T>> SelectAllAsync();
        //public Task<List<T>> SelectAllCategory();
        //public Task<List<T>> SelectAllModel();
        public Task<int> AddAsync(T t);
        //Task<T> SelectByIdAsync(int id);
        //Task<int> UpdateAsync(int id, T t);
        //Task<int> DeleteAsync(int id);
    }
    
}
