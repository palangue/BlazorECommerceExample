using System;
namespace BlazorECommersData
{
    public class Demo_Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }

        public List<DemoProductProp>? ProductProperties { get; set; }
    }
}



