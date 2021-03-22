using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace game_store_demo.Models
{
    public class VideoGame
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Console { get; set; }
        [Required]
        [Range(1,int.MaxValue, ErrorMessage ="Quantity must be greater than 0")]
        public int Quantity { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public int Price { get; set; }
    }
}
