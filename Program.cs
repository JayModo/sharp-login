using System;
using System.Collections.Generic;
using sharp_login.models;

namespace sharp_login
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Dictionary<string, Users> users = new Dictionary<string, Users>();
      Users jake = new Users("jake", "password");
      Users mark = new Users("mark", "password");
      users.Add(jake.Name, jake);
      users.Add(mark.Name, mark);

      System.Console.Write("UserName: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();

      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("you are logged in");
      }
      else
      {
        System.Console.WriteLine("Invalid Username or Password");
      }
    }
  }
}
