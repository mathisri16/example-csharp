using System;


      static void Main(string[] args)
      {
        student s = new student();
        s.ID = 1;
       s.Name = "test";
        Console.WriteLine($"id:{s.ID} name:{s.Name}");
     }

//Encapsulation
public class student
{
    // data hiding 

    private int id;

    //abstraction

    public int ID
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }
    private string name;
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }
}
