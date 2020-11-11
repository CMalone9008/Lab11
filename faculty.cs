using System;
class faculty : Person
{
  public string Id {get; set;}
  public string Title {get; set;}
  public virtual DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public double YearlySalary {get; set;}
  public bool Tenured {get; set;}
  public int YearOfEmployment {get; set;}
  


  public faculty() : base()
  {
   FirstName = "unknown";
   LastName = "unknown";
   Id = "unknown";
   Title = "unknown";
   //DateTime dt1 = new DateTime(0001, 00, 0000);
   Employer = "unknown";
   YearlySalary = 0;
   //Tenured = False;

  }



  public faculty(string fname, string lname, string title) : base()
  {
    FirstName = fname;
    LastName = lname;
    Title = title;
    
  }

  public void Intro()
  {
    Console.WriteLine(FirstName);
    Console.WriteLine(LastName);
    Console.WriteLine(Title);
  }

  public void GrantTenured(int YearOfEmployment)
  { 
    if(DateTime.Now.Year - YearOfEmployment >= 5)
     Console.WriteLine("Tenured");
    
    else
    Console.WriteLine("No Tenured");
  }
  
  public void Raise()
  {
   
   if((DateTime.Now.Year - YearOfEmployment) >= 2 && Title == "Instructor")
   {
     Console.WriteLine("Faculty promoted to Assistant Professor rank");
   }
   if((DateTime.Now.Year - YearOfEmployment) >= 5 && Title == "Assistant Professor")
   {
     Console.WriteLine("Faculty promoted to Associate Professor rank");
   }
   if((DateTime.Now.Year - YearOfEmployment) > 10 && Title == "Associate Professor")
   {
    Console.WriteLine("Faculty promoted to Professor rank");
   }
   if(Title == "Professor")
   {
     Console.WriteLine("No more promotions possible");
   }
  
  }

  public bool Promote()
  {
   //return true;
   return false; 
  }
  
  //public override void Intro()
  //{
    //base.Intro();
    //Console.WriteLine("I work as " + Title + "at" + School + "since" + YearOfEmployment);
  //}

  
  
  
  


}