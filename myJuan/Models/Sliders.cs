using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myJuan.Models
{
    public class Sliders
    {
        public int Id { get; set; }
       [StringLength(maximumLength:35)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 35)]

        public string Title2 { get; set; }
        [StringLength(maximumLength: 250)]

        public string Desc { get; set; }
        [StringLength(maximumLength: 35)]

        public string Btntext { get; set; }
        [StringLength(maximumLength: 200)]

        public string BtnUrl { get; set; }
        [StringLength(maximumLength: 200)]

        public string Image { get; set; }

    }
}
