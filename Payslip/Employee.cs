namespace payslip
{
    public class Employee
    {
      private string Firstname {get; set;}
      private string Surname {get; set;}
      
      public Employee(string firstname, string surname){
        Firstname = firstname;
        Surname = surname;
      }

      public string GetFullname()
      {
          var fullName = Firstname + " " + Surname;
          return fullName;
      }
    }
}