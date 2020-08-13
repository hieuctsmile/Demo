using AutoMapper;
using System;
using Model.Entites;
using Model.ViewModel;

namespace Model.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<StatusViewModel, Status>()
                .ConstructUsing(c => new Status(c.Id, c.Name));  
        }
    }
}
