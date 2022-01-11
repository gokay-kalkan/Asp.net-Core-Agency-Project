using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Services
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Boş Geçilemez")]
        [StringLength(30,ErrorMessage ="Lütfen 30 karakteri aşmayınız.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [StringLength(100, ErrorMessage = "Lütfen 100 karakteri aşmayınız.")]
        public string Description { get; set; }
    }
}
