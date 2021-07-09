using System;
using System.Collections.Generic;
using System.Text;

namespace Service_API.Interface.Model
{
    public interface IDataUserModel
    {
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        string gender { get; set; }
        string status { get; set; }
        DateTime created_at { get; set; }
        DateTime updated_at { get; set; }

    }
}
