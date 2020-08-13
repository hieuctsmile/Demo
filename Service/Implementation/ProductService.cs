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

        public ProductService(IRepository<Product, int> productRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Add(product);
        }

        public void Update(ProductViewModel productViewModel)
        {
            var product = _mapper.Map<ProductViewModel, Product>(productViewModel);
            _productRepository.Update(product.Id, product);
        }

        public void Delete(int id)
        {
            _productRepository.RemoveById(id);
        }

        public List<ProductViewModel> GetAll(int pageSize,int page = 1)
        {
            if(pageSize == null)
            {
                pageSize = 10;
            }
            var query = _productRepository.FindAll();
            query = query.Skip((page - 1) * pageSize).Take(pageSize);

            var data = _mapper.ProjectTo<ProductViewModel>(query).ToList();
            return data;
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