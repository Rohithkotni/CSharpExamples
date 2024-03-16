// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Examples;
using Examples.ClassesExercises;
using Examples.Trail_Examples;
using Examples.Udemy;

//StringMethods.Methods();
//StringManipulations.Manipulations();
//Switch.SwitchCase();
//DoWhile.dowhile();
//Loops.ForLoop();
//Loops.WhileLoop();

//HighScores.CheckHighscore(250, "Maria");
//HighScores.CheckHighscore(315, "Michael");
//HighScores.CheckHighscore(350, "Denis");

//IfElseTernary.Ternary();

/* Udemy Example */

//ConditionalsExercises.NumberValidation();
//ConditionalsExercises.MaximumOfTwo();
//ConditionalsExercises.PotraitOrLandscape();
//ConditionalsExercises.SpeeLimit();

//LoopsExercises.DivisibleCount();
//LoopsExercises.SumOfNumbers(); 
//LoopsExercises.Factorial();
//LoopsExercises.GuessNumber();
//LoopsExercises.MaxOfNumInSeries();

//ArrayExercises.FacebookLikes();
//ArrayExercises.ReverseName();
//ArrayExercises.UniqueandSort();
//ArrayExercises.PrintUnique();
//ArrayExercises.CommaSeparatedNumbers();

//TextExercises.ConsecutiveNumbers();
//var sw=new StopWatch();
//sw.Run();


//var p = new Post { Title = "Test", Description = "This is a new Post", Created = new DateTime(2023, 09, 17) };

//var stack = new StackOverFlowPost();
//stack.Voting(p);

/*LINQ Examples*/

string sentence = "I love cats";
string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };


// 1. Simple Linq Example
var simpleLinq = from s in sentence
                 select s;

Console.WriteLine(string.Join("", simpleLinq));


// 2. Linq Example with Condition
var lessThanFive = from num in numbers
                   where num < 5
                   select num;

Console.WriteLine(string.Join(", ", lessThanFive));

// 3. Linq Example with Multiple Conditions
var lessThanFiveAndGreaterThanTen = from num in numbers
                                    where (num > 5) && (num < 10)
                                    select num;

Console.WriteLine(string.Join(", ", lessThanFiveAndGreaterThanTen));

// 4. Linq Example with Contains

var catsWithA = from cat in catNames
                where cat.Contains("a")
                select cat;

Console.WriteLine(string.Join(", ", catsWithA));

// 5. Linq Example with Multiple Where

var moreSpecificCats = from cat in catNames
                       where cat.Contains("a")
                       where cat.Length > 4
                       select cat;

Console.WriteLine(string.Join(", ", moreSpecificCats));

// 6. Linq Example with Ordering

var orderedNumbers = from num in numbers
                     where (num > 5) && (num < 10)
                     orderby num // optional argument ascending or descending, ascending by default
                     select num;

Console.WriteLine(string.Join(", ", orderedNumbers));

