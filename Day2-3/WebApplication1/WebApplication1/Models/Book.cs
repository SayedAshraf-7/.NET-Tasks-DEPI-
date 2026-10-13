using Microsoft.Extensions.Configuration;
using System;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Models
{
    //    1: Why did the property "Id" become a Primary Key
    //    without any explicit configuration?
    //    the property is automatically recognized as a primary key by convention.
    //    Q2: Why is "Country" nullable in the database
    //    while "Price" is not?
    //    The ? indicates that Country can be null when nullable reference types are enabled.
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
