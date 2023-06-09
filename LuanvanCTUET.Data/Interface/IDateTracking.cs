using System;

namespace LuanvanCTUET.Data.Interface
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}