using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        private string _lname; //private access modifier (no code outside this class can access it)

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }


        public string LastName
            { 
                get
                {
                return _lname;
                }

                set
                {
                _lname = value;
                }
        
        
             }

    }
}
