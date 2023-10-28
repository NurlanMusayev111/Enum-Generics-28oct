


using enum_Generics_practice;
using enum_Generics_practice.Helpers;
using System.Collections.Generic;
using System.Xml.Linq;

//string email = Console.ReadLine();

//var result = email.CheckEmail();


//if (result == true) 
//{
//    Console.WriteLine("Success");
//}
//else
//{
//    Console.WriteLine("Wrong");
//}


//Console.WriteLine("Please add your email address");

//string email = Console.ReadLine();

//var res = email.CheckTrimEmail(" ");

//if(res == true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}


//Person person = new Person();

//person.Id = 1;
//person.Name = "Cavid";
//person.Surname = "Bashirov";


//int[] arr = { 1, 2, 3, 4, 5 };

//Console.WriteLine(arr.GetMultipyArray());




//Intlist list = new Intlist();

//list.Add(1);
//list.Add(2);
//list.Add(3);

//list.GetAll();


//StringList list = new();

//list.Add("Oruc");
//list.Add("Semed");
//list.Add("Nurlan");

//PersonList personList = new PersonList();

//List.Add(Id = 1, Name = "Test1", Surname = "Test1");
//List.Add(Id = 2, Name = "Test2", Surname = "Test2");
//List.Add(Id = 3, Name = "Test3", Surname = "Test3");

//list.GetAll();




//-----------------------------------------------

//Repository<Person> repo1 = new Repository<Person>();
//Repository<int> repo2 = new Repository<int>();
//Repository<string> repo3 = new Repository<string>();
//Repository<Person,BaseEntity> repo4 = new Repository<Person,BaseEntity>();



//DataList<string> words = new DataList<string>();

//words.Add("Salam1");
//words.Add("Salam2");
//words.Add("Salam3");


//var datas = words.GetAll();

//foreach (var item in datas)
//{
//    Console.WriteLine("item");
//}



//Repository<Person> repository = new Repository<Person>();

//repository.Add(new Person(Id = 1 , Name = "Test1" , Surname = "Test1"));

//Repository<Student> studentRepository = new Repository<Student>();


string paymentType = "Cash";
int tp = 2;
static void CheckPaymentType(string type)
{
    switch (type)
    {
        case nameof(PaymentType.Card):
            Console.WriteLine("With card");
            break;

        case nameof(PaymentType.Cash):
            Console.WriteLine("With cash");
            break;

        default:
            Console.WriteLine("Payment type is wrong");
            break;
    }
    //if (type == PaymentType.Card.ToString())
    //{
    //    Console.WriteLine("With card");
    //}
    //else if (type == PaymentType.Cash.ToString())
    //{
    //    Console.WriteLine("With cash");
    //}

    //else
    //{
    //    Console.WriteLine("Payment type is wrong");
    //}
}

CheckPaymentType(paymentType);










