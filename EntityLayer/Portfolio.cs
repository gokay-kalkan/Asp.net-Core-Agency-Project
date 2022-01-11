using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Portfolio
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "Lütfen 50 karakteri aşmayınız.")]
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
    }
}
