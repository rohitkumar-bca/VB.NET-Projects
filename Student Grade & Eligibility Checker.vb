Imports System

Module Program
    Sub Main(args As String())

        Dim rupee As String = ChrW(&H20B9) 'unicode for rupee symbol

        Dim user As String
        Console.WriteLine("Enter your name:")
        user = Console.ReadLine()
        Console.WriteLine(Environment.NewLine)
        Dim currentDateTime As DateTime = DateTime.Now


        Console.WriteLine($"hello {user},On {currentDateTime}  {Environment.NewLine}{Environment.NewLine}Welcome to the Student Grade & Eligibility Checker!".ToUpper())

        Console.WriteLine(Environment.NewLine)

        Dim marks As Integer
        Console.WriteLine("enter your marks:".ToUpper())
        marks = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(Environment.NewLine)


        'code to check pass of fail
        If marks >= 33 And marks <= 100 Then
            Console.WriteLine($"Congratulations!, {user}".ToUpper() + $" You are passed and eligible to sit for the exam {Environment.NewLine}")
        Else
            Console.WriteLine($"better luck next time, {user}".ToUpper() + " You are failed and not eligible to sit for the exam")
        End If




        'code to check grade
        Dim grade As String

        If marks >= 90 And marks <= 100 Then
            grade = "A1"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 80 And marks < 90 Then
            grade = "A2"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 70 And marks < 80 Then
            grade = "B1"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 60 And marks < 70 Then
            grade = "B2"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 50 And marks < 60 Then
            grade = "C1"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 40 And marks < 50 Then
            grade = "C2"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        ElseIf marks >= 33 And marks < 40 Then
            grade = "D"
            Console.WriteLine($"your grade is {grade}".ToUpper())
        Else
            Console.WriteLine("invalid input")
        End If

        Console.WriteLine(Environment.NewLine)


        Dim scholarship As Integer
        If marks >= 90 And marks <= 100 Then
            scholarship = 5000
            Console.WriteLine($"You are eligible for a full scholarship of {scholarship}")
        ElseIf marks >= 80 And marks < 90 Then
            scholarship = 3000
            Console.WriteLine($"You are eligible for a partial scholarship of {scholarship}")
        ElseIf marks >= 70 And marks < 80 Then
            scholarship = 1000
            Console.WriteLine($"You are eligible for a minimal scholarship of {scholarship}")
        Else
            Console.WriteLine("You are not eligible for any scholarship")
        End If


        Console.WriteLine(Environment.NewLine)
        Console.WriteLine("Thank you for using the Student Grade & Eligibility Checker!".ToUpper())
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()




    End Sub
End Module
