using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
    }
}
