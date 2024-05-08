using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entities.Concrete
{
    public class Category : IEntity
    {

        public int CategoryID { get; set; }

       
        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        public byte[]? Picture { get; set; }
    }
}
