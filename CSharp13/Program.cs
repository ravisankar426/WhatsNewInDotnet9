

// Params Collections
// IEnumerable<string> temperature=new List<string>(){
//     "77f","80f","75f"
// };
// ReadOnlySpan<string> programmingLanguages= new string[]{
//     "C#","C++","Java","Python"
// };
// ParamsCollections.Concat(temperature);
// ParamsCollections.Concat(programmingLanguages);


//Escape Sequence
//EscapeSequence.Display();

//Lock object
//await LockClass.Run();

//Method Group Natural Type
// var calc=new Calculator();
// Func<int,int,int> addInt=calc.Add;
// Console.WriteLine(addInt(3,4));

// implicit index access
var countdown = new TimerRemaining()
{
    buffer =
    {
        [^1] = 0, // last index 9
        [^2] = 1, // index 8
        [^3] = 2, // index 7
        [^4] = 3, // index 6
        [^5] = 4, // index 5
        [^6] = 5, // index 4
        [^7] = 6, // index 3
        [^8] = 7, // index 2
        [^9] = 8, // index 1
        [^10] = 9 // first index 0
    }
};


// In C# 13 partial properties and indexers are available just like the way we have partial methods.

