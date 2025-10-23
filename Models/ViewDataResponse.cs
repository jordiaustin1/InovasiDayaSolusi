using System.Collections.Generic;

namespace ViewDataApi.Models
{
    public class ViewDataResponse
    {
        public List<Transaction> data { get; set; }
        public List<Status> status { get; set; }
    }
}
