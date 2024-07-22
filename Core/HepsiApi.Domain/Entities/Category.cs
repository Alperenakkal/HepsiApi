using HepsiApi.Domain.Common;
using System;
using System.Collections.Generic;

namespace HepsiApi.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public Category()
        {
            Details = new List<Detail>();
            Products = new List<Product>();
        }

        public Category(int parentId, string name, int priorty) : this()
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }

        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }

        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
