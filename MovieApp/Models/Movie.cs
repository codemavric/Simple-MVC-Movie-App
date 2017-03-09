using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        [Required(ErrorMessage ="Please enter in a valid movie title:")]
        [StringLength(30)]
        public string title { get; set; }

        [Required(ErrorMessage ="Please enter in a valid date (MM/yyyy)")]
        [DisplayFormat(DataFormatString ="{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime releaseDate { get; set; }
        public string genre { get; set; }
        [Range(50,350)]
        public double price { get; set; }
        public bool onDiscount { get; set; }

        public string isMovieDiscounted()
        {
            string answer = "";

            if (onDiscount == true)
            {
                answer = "Yes";
            }
            else
            {
                answer = "No";
            }
            return answer;
        }


    }
}