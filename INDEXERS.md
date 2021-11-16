**What are Indexers ?**

Indexers in C# are called as smart arrays. 
A C# indexer could be a class property which allows us to access a member variable of a class or struct using the features of an array. In C#, indexers are created using this keyword. 
Indexers in C# are applicable on both classes and structs. 

**Why we use indexers ?**
- instead of a new data structure, the class itself is a data structure.
- simplified syntax - syntactic sugar
 
**When we should use indexer ?**
- if our class needs list(/array) of its instances (example 1)
- if our class represents list(/array) of values directly related to our class (example 2)

**Example 1:**
````cs
public class Person{
    public string Name{get; set;}

    private Person[] _backingStore;
    public Person this[int index]
    {
        get{
            return _backingStore[index];
        }
        set{
            _backingStore[index] = value;
        }
    }
}

Person p = new Person();
p[0] = new Person(){Name = "Hassan"};
p[1] = new Person(){Name = "John Skeet"};
````
**Example 2:**
````cs
class TempratureRecord{
    private float[] temps = new float[10] { 56.2F, 56.7F, 56.5F, 56.9F, 58.8F, 61.3F, 56.5F, 56.9F, 58.8F, 61.3F};

    public int Length{
        get { return temps.Length; }
    }

    public float this[int index]
    {
        get{
            return temps[index];
        }
        set{
            temps[index] = value;
        }
    }
}
````

**How to Create an Indexer ?**

````cs
<modifier> <return type> this [argument list]  
{  
get  
{  
// your get block code  
}  
set  
{  
// your set block code  
}  
}
````

**How to use an indexer ?**
````cs
using System;  
namespace Indexer_example1  
{  
    class Program  
    {  
        class IndexerClass  
        {  
            private string[] names = new string[10];  
            public string this[int i]  
            {  
                get  
                {  
                    return names[i];  
                }  
                set  
                {  
                    names[i] = value;  
                }  
            }  
        }  
        static void Main(string[] args)  
        {  
            IndexerClass Team = new IndexerClass();  
            Team[0] = "Rocky";  
            Team[1] = "Teena";  
            Team[2] = "Ana";  
            Team[3] = "Victoria";  
            Team[4] = "Yani";  
            Team[5] = "Mary";  
            Team[6] = "Gomes";  
            Team[7] = "Arnold";  
            Team[8] = "Mike";  
            Team[9] = "Peter";  
            for (int i = 0; i < 10; i++)  
            {  
                Console.WriteLine(Team[i]);  
            }  
            Console.ReadKey();  
        }  
    }  
}
````
**Important points to remember on indexers:**
- Always created with this keyword.
- Parameterized property are called indexer.
- It is used on group of elements
- It can be overloaded
- ref and out parameter modifiers are not permitted in indexer. 
 

**Example 1:**

The following example shows how to declare a private array field, temps, and an indexer.
The indexer enables direct access to the instance tempRecord[i]. 
The alternative to using the indexer is to declare the array as a public member and access its members, tempRecord.temps[i], directly.

````cs
public class TempRecord
{
    // Array of temperature values
    float[] temps = new float[10]
    {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    };

    // To enable client code to validate input
    // when accessing your indexer.
    public int Length => temps.Length;
    
    // Indexer declaration.
    // If index is out of range, the temps array will throw the exception.
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}
````
Notice that when an indexer's access is evaluated, for example, in a Console.Write statement, the get accessor is invoked. 
Therefore, if no get accessor exists, a compile-time error occurs.

````cs
using System;

class Program
{
    static void Main()
    {
        var tempRecord = new TempRecord();

        // Use the indexer's set accessor
        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;

        // Use the indexer's get accessor
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Element #{i} = {tempRecord[i]}");
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    /* Output:
        Element #0 = 56.2
        Element #1 = 56.7
        Element #2 = 56.5
        Element #3 = 58.3
        Element #4 = 58.8
        Element #5 = 60.1
        Element #6 = 65.9
        Element #7 = 62.1
        Element #8 = 59.2
        Element #9 = 57.5
    */
}
````
