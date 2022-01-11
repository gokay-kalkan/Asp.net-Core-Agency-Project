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
   public class Team
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "Lütfen 30 karakteri aşmayınız.")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(50, ErrorMessage = "Lütfen 50 karakteri aşmayınız.")]
        public string Unvan { get; set; }
    }
}
