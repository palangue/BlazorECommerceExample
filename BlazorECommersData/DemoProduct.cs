using System;
namespace BlazorECommersData
{
    public class DemoProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }

        public IEnumerable<DemoProductProp> ProductProperties { get; set; }
    }
}



