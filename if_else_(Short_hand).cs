//Short Hand If...Else (Ternary Operator)
Syntax
variable = (condition) ? expressionTrue :  expressionFalse;

//Example in normal way:
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}

//Example in Shorhand if else
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);
