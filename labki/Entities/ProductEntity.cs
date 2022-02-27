

using Microsoft.AspNetCore.Identity;

namespace labki.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsGood { get; set; }

        public IdentityUser Owner { get; set; } //dane usera, który zrobi³ wpis
    }
}