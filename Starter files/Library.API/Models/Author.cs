using System;

namespace Library.API.Models
{
    /// <summary>
    /// An author wiht Id, Firstname, Lastname fields
    /// </summary>
    public class Author
    {
        /// <summary>
        /// The id of author
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The first name of author
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The lastname of author
        /// </summary>
        public string LastName { get; set; }
    }
}
