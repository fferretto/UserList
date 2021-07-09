using System;
using System.Collections.Generic;
using System.Text;

namespace Service_API.Model
{
    public class paginationModel
    {
        public paginationModel()
        {
            pagination = new InformationPagination();
        }
        public InformationPagination pagination { get; set; }
    }
    public class InformationPagination
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
}