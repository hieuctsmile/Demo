using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data.Infrastructure;
using Model.Entites;
using Model.ViewModel;
using Services.Interface;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product, int> _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
