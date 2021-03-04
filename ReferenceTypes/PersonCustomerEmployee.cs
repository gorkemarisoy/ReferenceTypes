using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    class Person
    {
        public int IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person  //customer bir persondır. Ek olarak kredi kartı nosu var
    {
        public string CreditCardNo { get; set; }
    }

    class Employee:Person //Employee bir persondır, ek olarak employee numarası var
    {
        public int EmployeeNumber { get; set; }
    }
}
