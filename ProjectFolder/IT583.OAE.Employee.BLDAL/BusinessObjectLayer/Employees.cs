using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT583.OAE.Employee.BLDAL.BusinessObjectLayer
{
    public class Employees
    {
        public Employees()
        {
        }
        /// <summary>
        /// Gets or Sets EmployeeID
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Employee ID")]
        public int? EmployeeID { get; set; }


        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }


        /// <summary>
        /// Gets or Sets HiredDate
        /// </summary>
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Hired Date")]
        public DateTime HiredDate { get; set; }

    }
}
