// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Create a data source by using a collection initializer.
IEnumerable<Student> students =
[
    new Student(First: "Svetlana", Last: "Omelchenko", ID: 111, Scores: [97, 92, 81, 60]),
    new Student(First: "Claire",   Last: "O'Donnell",  ID: 112, Scores: [75, 84, 91, 39]),
    new Student(First: "Sven",     Last: "Mortensen",  ID: 113, Scores: [88, 94, 65, 91]),
    new Student(First: "Cesar",    Last: "Garcia",     ID: 114, Scores: [97, 89, 85, 82]),
    new Student(First: "Debra",    Last: "Garcia",     ID: 115, Scores: [35, 72, 91, 70]),
    new Student(First: "Fadi",     Last: "Fakhouri",   ID: 116, Scores: [99, 86, 90, 94]),
    new Student(First: "Hanying",  Last: "Feng",       ID: 117, Scores: [93, 92, 80, 87]),
    new Student(First: "Hugo",     Last: "Garcia",     ID: 118, Scores: [92, 90, 83, 78]),

    new Student("Lance",   "Tucker",      119, [68, 79, 88, 92]),
    new Student("Terry",   "Adams",       120, [99, 82, 81, 79]),
    new Student("Eugene",  "Zabokritski", 121, [96, 85, 91, 60]),
    new Student("Michael", "Tucker",      122, [94, 92, 91, 91])
];

IEnumerable<Student> studentWithHighScores = // students.Where(student => student.Scores[0] > 90);
    from student in students
    where student.Scores[0] > 90 && student.Scores[3] < 80
    orderby student.Last descending // descrescente || ascending crescente
    select student;

foreach (var student in studentWithHighScores)
    Console.WriteLine($"{student.First} {student.Last}: {student.Scores[0]}, {student.Scores[3]}");

Console.WriteLine("==================================================================================");

var groupedStudents =
    from student in students
    group student by student.Last[0] into groups
    orderby groups.Key
    select groups;

foreach (var group in groupedStudents)
{
    Console.WriteLine(group.Key);
    foreach (var student in group)
        Console.WriteLine($"{student.First} {student.Last}");
}

var averageScoreClass =
    from student in students
    let totalScore = student.Scores.Average()
    select $"{student.First}, {student.Last} - {totalScore}";

foreach (var student in averageScoreClass)
{
    Console.WriteLine(student);
}

// pegar media da turma toda
var averageScore =
    from student in students
    let totalScoreTwo = student.Scores.Sum()
    select totalScoreTwo;

Console.WriteLine($"Average class score: {averageScore.Average()}");


public record Student(string First, string Last, int ID, int[] Scores);

