using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first name of person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name name of person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The primary number of person 
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
