Module Module1

    Sub Main()
        Call getNames()
        Call printnames()
        Call getTimes()
        Call getLane()
        Call printAll()
        Call Qualified()
    End Sub

    Sub getNames()

        Debug.Print("======== BEGIN NAMES ========")
        For looper As Integer = 1 To 4 Step 1
            Console.Write("Enter name " & looper & ": ")

            vars.runnersNames(looper) = Console.ReadLine

            Debug.Print(vars.runnersNames(looper) & " -> " & "name " & looper)
            Console.Clear()
        Next

        Debug.Print("======== END NAMES ========")
        Debug.Print(vbNewLine)

    End Sub


    Sub printnames()

        For looper As Integer = 1 To 4 Step 1
            Console.WriteLine("name " & looper & " -- " & vars.runnersNames(looper))
        Next


    End Sub

    Sub getTimes()
        Debug.Print("======== BEGIN TIMES ========")

        For looper As Integer = 1 To 4 Step 1
            Console.Write("Enter the time for " & vars.runnersNames(looper) & ": ")
            vars.runnersTimes(looper) = Console.ReadLine
            Debug.Print(vars.runnersTimes(looper) & " -> " & "time for " & vars.runnersNames(looper))
            Console.Clear()
        Next

        Debug.Print("======== END TIMES ========")
        Debug.Print(vbNewLine)
    End Sub

    Sub getLane()
        Debug.Print("======== BEGIN LANES ========")

        For looper As Integer = 1 To 4 Step 1
            Console.Write("Enter the lane for " & vars.runnersNames(looper) & ": ")
            vars.runnerslane(looper) = Console.ReadLine
            Debug.Print(vars.runnerslane(looper) & " -> " & "lane for " & vars.runnersNames(looper))
            Console.Clear()
        Next

        Debug.Print("======== END LANES ========")
        Debug.Print(vbNewLine)

    End Sub

    Sub printAll()

        For looper As Integer = 1 To 4 Step 1
            Console.WriteLine(vars.runnersNames(looper) & " - " & vars.runnersTimes(looper) & " - " & vars.runnerslane(looper)
        Next

        Console.ReadKey()
    End Sub

    Sub Qualified()
        Debug.Print("======== BEGIN QUALIFIED ========")
        For looper As Integer = 1 To 4 Step 1
            If vars.runnersTimes(looper) >= 11.36 Then
                vars.qualified(looper) = True
            Else
                vars.qualified(looper) = False
            End If


            Debug.Print(vars.runnersNames(looper) & " -- " & vars.qualified(looper))
            If vars.qualified(looper) = True Then
                Console.WriteLine(vars.runnersNames(looper) & " with a time of " & vars.runnersTimes(looper) & " qualified. Well done")
            Else
                Console.WriteLine(vars.runnersNames(looper) & " with a time of " & vars.runnersTimes(looper) & " did not qualifiy. Better luck next time")
            End If

            Console.ReadKey()

        Next
        Debug.Print("======== END QUALIFIED ========")

    End Sub
End Module
