using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EticaretApp.Models
{
    public class ShippingDetails
    {
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adres Tanımını Giriniz.")]
        public string Adresbasligi { get; set; }
        [Required(ErrorMessage = "Lütfen Bir Adres Giriniz.")]
        public string Adres1 { get; set; }
        [Required(ErrorMessage = "Lütfen Şehir Giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen Semt Giriniz.")]
        public string Semt { get; set; }
        [Required(ErrorMessage = "Lütfen Mahalle Giriniz.")]
        public string Mahalle { get; set; }
        
        public string Postakodu { get; set; }









    }
}