using System.ComponentModel.DataAnnotations;

namespace GraphQLAPI.Models
{

    public class updateSuperHero
    {

        [key]
        public Guid Id { get; set; }

        public Guid? Name { get; set; }

        public string? Description { get; set; }

        public string? Height { get; set; }
    }
}
