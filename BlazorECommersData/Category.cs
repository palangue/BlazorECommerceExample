using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorECommersData
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int Age { get; set; }
    }
}
