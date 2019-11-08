using System;
using AutoMapper;
using Entities;
using Service.Dto;

namespace Service.AutoMapperConfiguration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            MappBranch();
        }

        void MappBranch()
        {
            CreateMap<Branch, BranchDto>().ReverseMap();
        }
    }
}
