using System;

namespace SupplierCatalogAnalytics
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Category { get; private set; }
        public decimal Price { get; private set; }
        public string Supplier { get; private set; }

        public Product(int id, string name, string category, decimal price, string supplier)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
            Supplier = supplier;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product other)
            {
                return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase) &&
                       string.Equals(Category, other.Category, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashName = Name != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Name) : 0;
            int hashCategory = Category != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Category) : 0;
            return hashName ^ hashCategory;
        }
    }
}