using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }

}