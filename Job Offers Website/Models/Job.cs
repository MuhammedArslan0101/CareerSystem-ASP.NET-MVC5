using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("Name Job")]
        public string JobTitle { get; set; }
        [DisplayName("Description Job")]
        [AllowHtml]
        public string JobContent { get; set; }
        [DisplayName("Image Job")]
        public string JobImage { get; set; }

        [DisplayName("Type Job")]
        public int CategoryId { get; set; }

        public string UserID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}