using System;

class Employee {

    //Fields
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;
    private double percent; //check if problem
    private bool inactive;


    //Properties
    public string Firstname{get; set;}
    public string Lastname {get; set;}
    public int Age {
      get{ return age; }
      set{
        if (value>=18)
          age = value;
        else
        {
          age = 18;
        }          
      }
    }


    public double Yearlysalary{
      get{ return yearlysalary; }
      set{
        if (value>1000)
        yearlysalary = value;
        else
        {
        yearlysalary = 1000;
        }
      }
    }
    public string Id{get; set;}
    public string Employmentstatus{get; set;}

    public double Percent{get; set;} //check if problem

   
    //Constructors
    public Employee()
    {
      Firstname="Unknown";
      Lastname="Unknown";
      Id="Unknown";
      Age=0;
    }

    public Employee(string empfirstname, string emplastname, string empid, int empage, double empyearlysalary)
    {
      Firstname = empfirstname;
      Lastname = emplastname;
      Id = empid;
      Age = empage;
      Yearlysalary = empyearlysalary;

    }

    public void Intro()
    {
      Console.WriteLine("First name: " + Firstname);
      Console.WriteLine("Last name: " + Lastname);
      Console.WriteLine("Age: " + Age);
      Console.WriteLine("Id: " + Id);
      Console.WriteLine("Yearly Salary: " + Yearlysalary);
    }

    public void IncreaseSalary(double Percent)
    {
      if ( Percent >  0) 
      {
      Yearlysalary = Yearlysalary + (Yearlysalary * Percent);
      Console.WriteLine("Yearly salary updated to " + Yearlysalary);
      }
      else
      {
        Console.WriteLine("Invalid input. Yearly Salary not updated.");
      }
    }

    public void RemoveEmployee()
    {
      if (inactive)
      {
        Console.WriteLine("Employee already inactive");
      }
      else
      {
        Console.WriteLine("Employee removed successfully!");
        inactive=true;
      }

    }
}
