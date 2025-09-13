# VB.NET-Projects

* conditional statements

Conditional statements control the flow of your program based on true/false conditions and they let your program decide which block of code to run.

Statement Type	              Purpose
            
If … Then	                    Simple condition check
If … Then … Else	            Choose between two blocks
If … Else If … Else           Multiple conditions
Select Case	                  Switch-like multiple choice


1. If ... Then Statement

   If condition Then
      'code if condition is true
   End If

Example, Dim age As Integer = 20
         If age>=18 Then
            Console. WriteLine("You are eligible to vote")
         End If
         
2. If .... Then .... Else Statement
   
   If condition Then
    ' Code if True
   Else
    ' Code if False
   End If

Example, Dim age As Integer = 16
         If age >= 18 Then
            Console. WriteLine("You are an adult.")
         Else
            Console. WriteLine("You are not an adult.")
         End If

3. If ... Else If ... Else Statement
   
   If marks >= 90 Then
      Console. WriteLine("Grade A+")
   Else If marks >= 75 Then
      Console. WriteLine("Grade A")
   Else If marks >= 50 Then
      Console. WriteLine("Grade B")
   Else
      Console. WriteLine("Fail")
   End If



4. Select Case Statement

   (same as switch statement which is Easier to read when you have many possible values)
   


    Dim day As Integer = 1
    
    Select Case day
    Case 1
        Console. WriteLine("Sunday")
    Case 2
        Console. WriteLine("Monday")
    Case 3
        Console. WriteLine("Tuesday")
    Case Else
        Console. WriteLine("Invalid day")
    End Select

5. Nested If Statements

   (You can put one If inside another)

   If age >= 18 Then
      If citizenship = "Yes" Then
         Console. WriteLine("Eligible to vote")
      End If
   End If
