using AutoMapper;
using Glabgiri.DAL.Context;
using Glabgiri.DAL.IRepositories;
using Glabgiri.DAL.Repositories;
using Glabgiri.DAL.UnitOfWork;
using Golabgiri.BLL.IServices;
using Golabgiri.BLL.Mapper;
using Golabgiri.Domain.Entities;
using Golabgiri.ViewModel.DTO.LoginDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.Services
{
    public class LoginService:ILoginService
    {
        private IUnitOfWork _db;
        private readonly IMapper _mapper;

        public LoginService( IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _db = unitOfWork;
        }
        public async Task<bool> UpdateUserLogin(LoginDTO info)
        {
            var entity = _mapper.Map<Login>(info); ;
            try
            {
                _db.LoginRepository.Update(entity);
                return true;
            }
            catch
            {

                return false;
            }

        }
        public bool GetUser(LoginDTO info)
        {
            string Password = _db.LoginRepository.GetUser(info.UserName);
            if (info.Password == Password)
            {
                return true;
            }
            else
                return false;

        }
    }
}
