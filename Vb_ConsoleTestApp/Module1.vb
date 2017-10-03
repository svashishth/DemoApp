Module Module1

    Sub Main()

        Console.WriteLine("---------")
        Console.WriteLine(Format(DateTime.Now(), "HHmmssms"))
        Console.WriteLine(Mid(Format(DateTime.Now(), "HHmmssms"), 8, 3))

        Console.WriteLine("---------")
        Console.WriteLine(Format(DateTime.Now(), "HHmmssfff"))
        Console.WriteLine(Mid(Format(DateTime.Now(), "HHmmssfff"), 7, 3))

        Console.WriteLine("---------")
        Console.WriteLine(DateTime.Now().Millisecond.ToString())
        'Console.WriteLine(Mid(DateTime.Now().Millisecond, 7, 3))

    End Sub

End Module
