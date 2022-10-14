using System;
using System.Collections.Generic;
namespace Filter;
public delegate bool FilterDelegate(Person p);

class Program
{
    public static void Main(string[] args)
    {
        Person person1=new Person() {Name="John",Age=41};
        Person person2=new Person() {Name="venkat",Age=21};
        Person person3=new Person() {Name="jai",Age=51};
        Person person4=new Person() {Name="dinesh",Age=31};
        Person person5=new Person() {Name="baskarn",Age=30};
        Person person6=new Person() {Name="Ganesh",Age=61};
        
        //creating list

        List<Person> people=new List<Person>{person1,person2,person3,person4,person5,person6};

        DisplayPeople("children",people,IsChild);
        DisplayPeople("Adults",people,IsAdult);
        DisplayPeople("Seniors",people,IsSenior);
        DisplayPeople("Voters",people,IsVoter);

    }
    static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
    {
        System.Console.WriteLine("people in "+title+" list are");

        foreach (Person p in people)
        {
            if(filter(p))
            {   
                System.Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
                System.Console.WriteLine("{0},is {1} years old",p.Name,p.Age);
                 System.Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");

            }
        }
    }
    static bool IsChild(Person p){return p.Age<15 ;}
    static bool IsVoter(Person p){return p.Age>17 ;}
    static bool IsAdult(Person p)
    {
        if(p.Age>=18 && p.Age<50)
        {
            return true ; 
        }
        else 
        {
                return false;
        }
    }
    static bool IsSenior(Person p)
    {
        return p.Age>=50;
    }

}