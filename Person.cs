using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadametrics.Data.Models
{
  public class Person : TableEntity
  {
    public int Id { get; set; }
    public PersonType PersonType { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Initials
    {
      get
      {
        return FirstName.Substring(0,1).ToUpper() + LastName.Substring(0,1).ToUpper();
      }
    }
    public string Title { get; set; }
    public string FullName
    {
      get
      {
        return FirstName + " " + LastName;
      }
    }
    public Sex Sex { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public static Person CreatePerson()
    {
      Person person = new Person
      {
        Id = 1,
        PersonType = PersonType.Parent,
        FirstName = "Toby",
        LastName = "Worth",
        Sex = Sex.Male,
        Email = "toby@group.com",
        PhoneNumber = "+440123456789"
      };

      return person;
    }

    public static List<Person> CreatePeople()
    {
      List<Person> peopleList = new List<Person>{
        new Person{
          Id=1,
          PersonType=PersonType.Teacher,
          FirstName="Toby",
          LastName="Worth",
          Sex=Sex.Male,
          Email="toby@group.com",
          PhoneNumber="+440123456789"
        },
        new Person{
          Id=2,
          PersonType=PersonType.Teacher,
          FirstName="Stuart",
          LastName="White",
          Sex=Sex.Male,
          Email="stuart@group.com",
          PhoneNumber="+440123456789"
        },
        new Person{
          Id=3,
          PersonType=PersonType.Teacher,
          FirstName="Samantha",
          LastName="Taylor",
          Sex=Sex.Female,
          Email="samt@group.com",
          PhoneNumber="+440123456789"
        }
      };

      return peopleList;
    }
  }

  public enum Sex
  {
    Male,
    Female
  }

  public enum PersonType
  {
    Teacher,
    Student,
    Parent
  }
}
