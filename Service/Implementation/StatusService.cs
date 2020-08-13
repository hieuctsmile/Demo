using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data.Infrastructure;
using Model.Entites;
using Model.ViewModel;
using Services.Interface;

namespace Services.Implementation
{
    public class StatusService : IStatusService
    {
        private readonly IRepository<Status, int> _statusRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StatusService(IRepository<Status, int> statusRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _statusRepository = statusRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Add(StatusViewModel statusViewModel)
        {
            var status = _mapper.Map<StatusViewModel, Status>(statusViewModel);
            _statusRepository.Add(status);
        }

        public void Update(StatusViewModel statusViewModel)
        {
            var status = _mapper.Map<StatusViewModel, Status>(statusViewModel);
            _statusRepository.Update(status.Id, status);
        }

        public void Delete(int id)
        {
            _statusRepository.RemoveById(id);
        }

        public List<StatusViewModel> GetAll()
        {
            var listStatus = _statusRepository.FindAll();
            return _mapper.ProjectTo<StatusViewModel>(listStatus).ToList(); ;
        }

        public StatusViewModel GetById(int id)
        {
            return _mapper.Map<Status, StatusViewModel>(_statusRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}