Module Module1

    Sub Main()
        ' sample [game] code
        ' the system picks a random number between 1 and 100, and you have to guess it.
        ' other details to follow
        'Dim dt As Date = Date.Now

        Dim rand As Random = New Random()
        Dim rand1 As Integer = rand.Next(1, 100)
        Dim num As Integer = 1
        Dim guess As Double = 0
        Dim userSurrender As String = "n"
        printStars()
        Console.WriteLine("Hi and Welcome to PT1420")
        printStars()

        Do Until userSurrender = "y" Or userSurrender = "c"
            Call Start(guess)
            Call check(rand1, num, guess, userSurrender)
        Loop

        Console.WriteLine("You surrendered... Wussy!")

    End Sub
    Sub Start(ByRef guess As Double)
        Console.WriteLine("Pick A Number Between 1 And 100.")
        guess = Console.ReadLine()
    End Sub
    Sub check(ByVal rand1 As Integer, ByVal num As Integer, ByVal guess As Double, ByRef userSurrender As String)

        If (guess = rand1) Then
            Console.WriteLine("You have guessed right.")
            userSurrender = "c"
            Call End1()
        ElseIf (guess < rand1) Then
            Console.WriteLine("You're too low...")
            Call surrender(userSurrender)
        ElseIf (guess > rand1) Then
            Console.WriteLine("You're too high...")
            Call surrender(userSurrender)
        End If
    End Sub

    Sub printStars()
        For num1 As Integer = 1 To 24
            Console.Write("*")
        Next
        Console.WriteLine("")
    End Sub
    Sub End1()
        Console.writeline("You won the game.")


        Console.ReadKey()
    End Sub
    Sub surrender(ByRef userSurrender As String)
        Console.WriteLine("Do you surrender?")
        userSurrender = Console.ReadLine()
    End Sub

End Module
