using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Customer customer1 = new Customer();
            Employee employee1 = new Employee();

            person1.FirstName = "Görkem";
            person1.LastName = "Arısoy";
            person1.IdNumber = 123456;

            customer1.CreditCardNo = "123456789";

            employee1.EmployeeNumber = 1;
            employee1.FirstName = "Selin";

            //employee aslında bir person olduğu için eşitlik verebildik. employee1=person1 diyemezdik.
            person1 = employee1;  //Stackta bulunan person1'i employee1'in referansına bağladık. yani person1 bilgileri de yok olmuş oldu.
            Console.WriteLine(employee1.FirstName);         //eğer bunlar değer tipinde olsaydı sadece değeri kullanılcak, içeriği kaybolmayacaktı.
            Console.WriteLine(person1.FirstName);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1); //employee1 aynı zamanda person olduğu için method içine person beklemesine rağmen gönderebiliyoruz.
                                            //buda bize farklı kategorilerde personlar için aynı metotu kullanma imkanı tanır.
        }
    }
}
