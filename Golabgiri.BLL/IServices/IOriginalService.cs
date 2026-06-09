using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golabgiri.BLL.IServices
{
    public interface IOriginalService
    {
        Task SaveAsync();
        void Dispose();
    }
}
