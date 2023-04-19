using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_small_HR
{
    internal class AddCandidade
    {
        public string name;
        public string lastname;
        public int id ;
        public string dateofbirth;
        public string gender;
        public string email;
        public string phonenumber;
        public int expectedsalary;
        public string cv;
        public string typeofemployment;


        public string Combine()
        {
            return name+" "+lastname+"?"+ name + "?" + lastname + "?" + id + "?" + dateofbirth + "?" + gender + "?" + email + "?" + phonenumber + "?" + expectedsalary + "?" + typeofemployment + "?" + cv+ "?";
        }
    }
}
