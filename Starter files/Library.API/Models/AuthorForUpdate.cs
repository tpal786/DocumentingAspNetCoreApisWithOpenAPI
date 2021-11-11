using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    /// <summary>
    /// Author update include Firstname, lastname
    /// </summary>
    public class AuthorForUpdate
    {  
        /// <summary>
        /// Firstname of author
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        /// <summary>
        /// Lastname of author
        /// </summary>
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
    }
}
