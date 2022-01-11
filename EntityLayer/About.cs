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
   public class About
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Boş geçemezsiniz")]
        [StringLength(500,ErrorMessage ="max 500 karakter uzunluğunda olmalıdır.")]
        public string Description { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public string Image { get; set; }
    }
}
