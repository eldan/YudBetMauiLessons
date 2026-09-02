using Lesson_05_List_Dictionary_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05_List_Dictionary_Linq
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      #region Simple List<string>
      List<string> studentList = new List<string>() { "Dan", "Ronnit", "Ron", "Dannit" };
      PrintListOfString(studentList);
      Console.WriteLine("There are " + studentList.Count + " students.");
      Console.WriteLine("First Student is " + studentList[0]);
      studentList.Add("Shlomi");
      studentList.Add("Eldan");
      Console.WriteLine("Last Student is " + studentList[studentList.Count - 1]);
      studentList.RemoveAt(4);
      studentList.Remove("Eldan");
      PrintListOfString(studentList);
      //Sort(), Reverse();

      List<string> results = studentList.FindAll(x => x.StartsWith("Ro"));
      PrintListOfString(results);

      results = studentList.FindAll(x => x.Contains("a")).ToList();
      PrintListOfString(results);
      #endregion
      */

      #region List<User>
      
      List<User> users = new List<User>();
      users.Add(new User()
      {
        Id = 1,
        Name = "John Smith",
        Email = "john@example.com",
        Password = "123456",
        BirthDate = new DateTime(1990, 5, 12)
      });

      users.Add(new User()
      {
        Id = 2,
        Name = "Sarah Cohen",
        Email = "sarah@example.com",
        Password = "abcdef",
        BirthDate = new DateTime(1985, 8, 23)
      });

      users.Add(new User()
      {
        Id = 3,
        Name = "David Brown",
        Email = "david@example.com",
        Password = "qwerty",
        BirthDate = new DateTime(1995, 2, 7)
      });

      users.Add(new User()
      {
        Id = 4,
        Name = "Michael Green",
        Email = "michael@example.com",
        Password = "pass123",
        BirthDate = new DateTime(1988, 11, 30)
      });


      users.Add(new User()
      {
        Id = 5,
        Name = "Anna Levi",
        Email = "anna@example.com",
        Password = "welcome",
        BirthDate = new DateTime(1992, 7, 18)
      });
    

      Console.WriteLine(users[1].Email);
      PrintListOfUsers(users);

      // search for someone
      string searchStr = Console.ReadLine();
      var results = users.FindAll(x => x.Email.Contains(searchStr));
      //Console.WriteLine(results.Count);

      results = users.FindAll(x => x.Email.Equals(searchStr));
      //Console.WriteLine(results.Count);

      // Language Integrated Query (LINQ) - C#
      results = users
      .Where(x => x.BirthDate.Year > 1990 && x.Name.Contains("a"))
      .ToList();

      PrintListOfUsers(results);
     
      
      #endregion


      #region Dictionary
      //Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>
      //{
      //    {
      //        "pistol",
      //        new Weapon
      //        {
      //            Name = "Pistol",
      //            Damage = 20,
      //            Ammo = 12
      //        }
      //    },
      //    {
      //        "rifle",
      //        new Weapon
      //        {
      //            Name = "Rifle",
      //            Damage = 40,
      //            Ammo = 30
      //        }
      //    },
      //    {
      //        "shotgun",
      //        new Weapon
      //        {
      //            Name = "Shotgun",
      //            Damage = 80,
      //            Ammo = 8
      //        }
      //    }   
      //};
      //Console.WriteLine(weapons["shotgun"].Damage);
      #endregion




    }
    static void PrintListOfString(List<string> lst)
    {
      //for (int i = 0; i < lst.Count; i++)
      //{
      //    Console.WriteLine(lst[i]);
      //}
      foreach (string s in lst) { Console.Write(s + " "); }
    ;
      Console.WriteLine();
    }

    static void PrintListOfUsers(List<User> lst)
    {
      foreach (User user in lst)
      {
        //Console.WriteLine($"{user.Id}: {user.Name} - {user.Email} - {user.BirthDate}");
        Console.WriteLine($"{user.Id}: {user.Name} - {user.Email} - {user.BirthDate.ToString("dd/MM/yyyy")}");
      }
    }
  }
}
