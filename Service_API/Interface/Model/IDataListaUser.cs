using Service_API.Model;
using System.Collections.Generic;

namespace Service_API.Interface.Model
{
    public interface IDataListaUser
    {
        int code { get; set; }
        paginationModel meta { get; set; }
        List<UserModel> data { get; set; }
    }
}
