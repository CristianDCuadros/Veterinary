using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El documento es requerido")]

        [MaxLength(13)]

        public string Document { get; set; } = null;
        public string FirstName { get; set; } = null;

        public string LastName { get; set; } = null;

        public string FixedPhone { get; set; } = null;

        public string Cellphone { get; set; } = null;

        public string Address { get; set; } = null;

        public string Fullname => $"{FirstName}" +
            $"{LastName}";
    }
}
