using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Qlink
{
    internal class Professional
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> Professions { get; set; }
        public int star { get; set; }  
        public override string ToString()
        {
            string professionsList = string.Join(", ", Professions);
            return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Phone: {Phone}, City: {City}, BirthDate: {BirthDate}, Professions: {professionsList}";
        }

    }
}
