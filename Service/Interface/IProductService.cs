using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interface
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();

        ProductViewModel GetById(int id);

        void SaveChanges();
    }
}
