using DAL.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Concretes
{
    public class Category : Base
    {
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
    }
}
