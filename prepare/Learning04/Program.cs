using System;

Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
string assignmentStatement = assignment1.GetSummary();
Console.WriteLine(assignmentStatement);

MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
string mathAssignmentStatement = mathAssignment1.GetHomeworkList();
Console.WriteLine(mathAssignmentStatement);

WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
string writingAssignmentStatement = writingAssignment1.GetWritingInformation();
Console.WriteLine(writingAssignmentStatement);