using System;
using System.Collections.Generic;
using System.Text;

namespace ReferenceTypes
{
    class PersonManager  //Burda Cutomer:Person ve Employee:Person dediğimiz için
                        //Metod içerisine hem person hem customer hemde employee gönderebiliriz.
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
