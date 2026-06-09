using Golabgiri.ViewModel.DTO.LoginDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.IServices
{
    public interface ILoginService
    {
        Task<bool> UpdateUserLogin(LoginDTO info);
        bool GetUser(LoginDTO info);
    }
}
