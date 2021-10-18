//An enum is a special "class" that 
//represents a group of constants (unchangeable/read-only variables).
enum Months
{
  January,    // 0
  February,   // 1
  March,      // 2
  April,      // 3
  May,        // 4
  June,       // 5
  July        // 6
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
//output"3"



//You can also assign your own enum values,
//and the next items will update the number accordingly
enum Months
{
  January,    // 0
  February,   // 1
  March=6,    // 6
  April,      // 7
  May,        // 8
  June,       // 9
  July        // 10
}

static void Main(string[] args)
{
  int myNum = (int) Months.April;
  Console.WriteLine(myNum);
}
