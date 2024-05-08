using Business.Abstract;
using Business.Constants;
using Core.Utulities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetById(int categoryID)
        {


            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryID == categoryID));
        }

        public IResult Add(Category Category)
        {
            _categoryDal.Add(Category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category Category)
        {
            _categoryDal.Delete(Category);
            return new SuccessResult(Messages.CategoryDeleted);
        }



        public IDataResult<List<Category>> GetList()
        {

            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Update(Category Category)
        {
            _categoryDal.Update(Category);
            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
