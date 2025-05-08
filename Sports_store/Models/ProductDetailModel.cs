using System.ComponentModel.DataAnnotations;

namespace Sports_store.Models
{
    public class ProductDetailModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản phẩm")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Sản phẩm")]
        public string Description { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Gía Sản phẩm")]
        public decimal Price { get; set; }

        public string Image {  get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public BrandModel Brand { get; set; }
        public CategoryModel Category { get; set; }
    }
}
