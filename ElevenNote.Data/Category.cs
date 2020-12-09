using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [Display(Name="Category")]
        public string Name { get; set; }

        [ForeignKey(nameof(Note))]
        public int Id { get; set; }
        public virtual Note Note { get; set; }
    }
}
