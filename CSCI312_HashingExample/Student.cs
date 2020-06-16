using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI312_HashingExample
{
    public class Student
    {
        private string _name;
        private decimal _gpa;

        public uint Id { get; set; }

        /// <summary>
        /// Get/Set the name.  Throws exception on null assignment.
        /// </summary>
        public string Name
        {
            get
            {
                return _name; 
            }
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentNullException("Name cannot be null!");
            }
        }

        public decimal GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                if (value >= 0.0m && value <= 4.0m)
                    _gpa = value; 
            }
        }

        public override int GetHashCode()
        {
            string id = Id.ToString().PadLeft(8, '0');
            id = id.Substring(6, 2);
            return int.Parse(id);
        }

    }
}
