using AutoMapper;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Base
{
    public class BaseService
    {
        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;
        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
    }
}
