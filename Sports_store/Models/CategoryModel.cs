﻿using System.ComponentModel.DataAnnotations;
using Sports_store.Repository;

namespace Sports_store.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Danh mục")]
        public string Name { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô tả Danh mục")]

        public string Description { get; set; }
        [Required]
        public string Slug { get; set; }


        public int Status { get; set; }

        //public static implicit operator CategoryModel(CategoyModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
