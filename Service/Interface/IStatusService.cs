using System.Collections.Generic;
using Model.ViewModel;

namespace Services.Interface
{
    public interface IStatusService
    {
        void Add(StatusViewModel statusViewModel);

        void Update(StatusViewModel statusViewModel);

        void Delete(int id);

        List<StatusViewModel> GetAll();

        StatusViewModel GetById(int id);

        void SaveChanges();
    }
}