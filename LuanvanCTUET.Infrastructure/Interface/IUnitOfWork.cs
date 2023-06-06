using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuanvanCTUET.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
      /// <summary>
      /// Call save change
      /// </summary>
        void Commit();
    }
}
