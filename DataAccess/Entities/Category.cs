﻿
namespace DataAccess.Entities
{
	public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Advert> Adverts { get; set; } = new HashSet<Advert>();
    }
}
