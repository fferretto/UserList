using Service_API.Interface.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service_API.Model
{
    public class DataListaUser : IDataListaUser
    {
        public int code { get; set; }
        public paginationModel meta { get; set; }
        public List<UserModel> data { get; set; }
    }
    public class DataUser
    {
        public int code { get; set; }
        public paginationModel meta { get; set; }
        public UserModel data { get; set; }
    }
    public class UserModel : IDataUserModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}