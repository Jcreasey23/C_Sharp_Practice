// C# Learning environment
// Author - Josh Creasey
// Date - December 10, 2022

/*
Purpose of files is to explore and advance my skills in C#


Topics Include
    - String Manipulation / Number Manipulation
    - Functions
    - Data Structures
    - Class implementation


*/

///////////////////////////////////////////////////
// Begin Main //
///////////////////////////////////////////////////
int main()
{

    //////////////////////////
    // String Manipulation //
    /////////////////////////
    Console.WriteLine("Hello World!"); // Console.WriteLine acts as cout statements in C++

    string aFriend = "Bill";
    Console.WriteLine(aFriend); // Writes Bill to terminal

    aFriend = "Maria";
    Console.WriteLine(aFriend); // Writes Maria to terminal

    Console.WriteLine("Hello " + aFriend);  // Prints message Hello Friend!
    Console.WriteLine($"Hello {aFriend}");  // Format $"string {string variable}" adds strings with spaces

    string firstFriend = "Maria";
    string secondFriend = "Sage";

    Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
    Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

    string songLyrics = "You say goodbye, I say hello"; // Yay for the Beatles!
    Console.WriteLine(songLyrics.Contains("goodbye"));  // Return Boolean Expression if string contains "goodbye"
    Console.WriteLine(songLyrics.Contains("greetings"));    // Return Boolean Expression if string contains "greetings"


    Console.WriteLine(songLyrics.StartsWith("You"));    // Return Boolean Expression if string starts with you
    Console.WriteLine(songLyrics.StartsWith("goodbye"));    // Return Boolean Expression if string starts with goodbye

    Console.WriteLine(songLyrics.EndsWith("hello"));    // Return Boolean Expression if string ends with hello
    Console.WriteLine(songLyrics.EndsWith("goodbye"));  // Return Boolean Expression if string contains 

    //////////////////////////////
    // End String Manipulation //
    /////////////////////////////



    //////////////////////////
    // Number Manipulation //
    //////////////////////////

    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);   // Write out c to terminal

    // Change value of C using different operations
    c = a - b;  // subtract a and b
    Console.WriteLine(c);   // Write out c to terminal

    c = a * b;  // multiply a and b
    Console.WriteLine(c);   // Write out c to terminal

    c = a / b;  // divide a and b
    Console.WriteLine(c);   // Write out c to terminal

    // Mathematical Functions act as normal //

    // Quotients can also be computed the same way using '%'
    int d = a % b;  // Returns remainder

    // min and max values
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    /////////////
    // doubles 
    ////////////

    a = 5;
    b = 4;
    c = 2;
    d = (a + b) / c;
    Console.WriteLine(d);

    a = 19;
    b = 23;
    c = 8;
    d = (a + b) / c;
    Console.WriteLine(d);


    double maxdoub = double.MaxValue;
    double mindoub = double.MinValue;
    Console.WriteLine($"The range of double is {mindoub} to {maxdoub}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);

    // Decimal acts as floating point numbers in C++

    // Practice
    double radius = 2.50;
    double area = Math.PI * radius * radius;
    Console.WriteLine(area);
}
