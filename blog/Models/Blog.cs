using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "عنوان اجباریست")]
        [Display(Name = "عنوان مقاله")]
        public string Title { get; set; }

        [Required(ErrorMessage = "عکس اجباریست")]
        [Display(Name = "عکس مقاله")]
        public string Img { get; set; }

        [Required(ErrorMessage = "توضیحات اجباریست")]
        [Display(Name = "توضیحات مقاله")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "متن مقاله اجباریست")]
        [Display(Name = "متن مقاله")]
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
