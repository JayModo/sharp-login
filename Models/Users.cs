namespace sharp_login.models
{


  class Users
  {
    public string Name { get; set; }
    string Password { get; set; }


    public bool ValidatePassword(string input)
    {
      return input == Password;
    }
    public Users(string name, string pass)
    {
      Name = name;
      Password = pass;
    }

  }

}