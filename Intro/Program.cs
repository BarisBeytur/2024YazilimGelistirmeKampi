
// Console 
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

//Console.WriteLine("Hello, World!");

// Variables
//string message1 = "Krediler";
//int term = 12;
//double amount = 100000.5;

//// CamelCase
//bool isAuthenticated = true;


//Console.WriteLine(message1);


// Conditions
//if (isAuthenticated)
//{
//    Console.WriteLine("Buton --> Hoşgeldin Barış");
//}
//else
//{
//    Console.Write("Buton --> Sisteme giriş yap!");
//}

// Arrays
//string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";


// Loops
//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[i]);
//}

// Classes
//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C#";
//course1.Description = ".NET 8 vs....";
//course1.Price = 0;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Java 17 ...";
//course2.Price = 10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Python 3.12...";
//course3.Price = 20;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

CourseManager courseManager = new CourseManager(new CourseDal());

List<Course> courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Kod bitti.");


IndividualCustomer customer1 = new IndividualCustomer(); 
customer1.Id = 1;
customer1.NationalIdentity = "12345678911";
customer1.FirstName = "Emre";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "54875875487";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer()
{
    Id = 3,
    Name = "Kodlamaio",
    CustomerNumber = "654778",
    TaxNumber = "2124577899"
};

CorporateCustomer customer4 = new CorporateCustomer()
{
    Id = 3,
    Name = "Abc",
    CustomerNumber = "654779",
    TaxNumber = "2124647899"
};









