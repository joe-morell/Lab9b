using System;
class Employee {

  string firstname;
  string lastname;
  string id;
  int age;
  string address;
  string phoneNumber;
  string title;
  double yearlySalary;
  string employmentStatus;

  public Employee() {

    firstname = "Uknown";
    lastname = "Uknown";
    id = "Unknown";
    age = 0;
    employmentStatus = "Active";

  }

  public Employee (string eFirstname, string eLastname, string eId, int eAge) {

    firstname = eFirstname;
    lastname = eLastname;
    id = eId;
    age = eAge;
    employmentStatus = "Active";

  }

  public void Intro() {

    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Employment Status: " + employmentStatus);

  }
}