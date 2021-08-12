using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string firstname;
        private string lastname;
        //private string footer;

        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }
        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            //this.name = footer;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set 
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        /*public string Footer
         {
          get
         {
               return footer;
         }
        set
         {
             footer = value;
         } */
       }
    }

