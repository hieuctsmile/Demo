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

        public List<ProductViewModel> GetAll()
        {
            var listStatus = _productRepository.FindAll();
            return _mapper.ProjectTo<ProductViewModel>(listStatus).ToList(); ;
        }

        public ProductViewModel GetById(int id)
        {
            return _mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
