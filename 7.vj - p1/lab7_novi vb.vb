Module Module1

    Sub Main()
        'OtezaniProsjeci()

        'DrugiProsjeci()

        'Stack1()

        'sesti()

    End Sub




    'zadatak 1
    Sub OtezaniProsjeci()
        Dim brojOcjena As Integer
        Dim ectsbodovi As Decimal()
        Dim ocjene As Integer()
        Dim broj As Integer
        Dim ects As Decimal
        Console.WriteLine("Unesite broj ocjena")
        brojOcjena = Console.ReadLine
        ectsbodovi = New Decimal(brojOcjena - 1) {}
        ocjene = New Integer(brojOcjena - 1) {}
        Console.WriteLine("")

        For i As Integer = 0 To brojOcjena - 1
            Console.Write("Unesite ocjenu {0}. predmeta: ", i + 1)

            broj = Console.ReadLine
            If broj >= 1 And broj <= 5 Then
                ocjene(i) = broj
            Else
                i = i - 1
                Console.WriteLine("Unijeli ste neispravan broj ocjene")
            End If
            Console.WriteLine("")


        Next
        For i As Integer = 0 To brojOcjena - 1
            Console.WriteLine("Unesite ects bodove {0}. predmeta: ", i + 1)
            ects = Console.ReadLine
            If ects >= 0 And ects <= 10 Then
                ectsbodovi(i) = ects
            Else
                i = i - 1
                Console.WriteLine("Unjeli ste neispravan broj ecst bodova")
            End If
            Console.WriteLine("")

        Next

        Console.WriteLine("Prosjek ocjena je: {0} ", Prosjek(ocjene, ectsbodovi))
        Console.ReadKey()
    End Sub
    Function Prosjek(ByVal ocjene As Integer(), ByVal ectsbodovi As Decimal()) As Decimal
        Dim pr As Integer
        Dim suma, zbrojectsBod As Decimal
        For i As Integer = 0 To ocjene.Length - 1
            suma = ocjene(i) * ectsbodovi(i) + suma
            zbrojectsBod = ectsbodovi(i) + zbrojectsBod

        Next
        pr = suma \ zbrojectsBod
        Return pr

    End Function

    'zadatak 2

    Sub DrugiProsjeci()
        prosjek1(1, 3, 3, 4, 5, 6)
        prosjek1(1.3, 2.3, 4.5)
        Console.ReadKey()






    End Sub
    Sub prosjek1(ParamArray a As Integer())
        Dim rezultat As Integer
        Dim suma As Integer
        For i As Integer = 0 To a.Length - 1
            suma += a(i)
        Next
        rezultat = (suma / a.Length)
        Console.WriteLine(rezultat)
    End Sub
    Sub prosjek1(ParamArray a As Double())
        Dim rezultat As Integer
        Dim suma As Integer

        For i As Integer = 0 To a.Length - 1
            suma += a(i)


        Next
        rezultat = (suma / a.Length)
        Console.WriteLine(rezultat)
    End Sub

    '3. zadatak
    Sub Stack1()
        Dim znak As Char
        Dim stk As Stack = New Stack()
        Console.WriteLine("Unesite broj znakova: ")
        Dim brojZnakova As Integer = Console.ReadLine
        For i As Integer = 0 To brojZnakova - 1
            Console.WriteLine("Unesite znak: ")
            znak = Console.ReadLine()
            stk.Push(znak)
        Next
        For Each a In stk
            Console.WriteLine(a)
        Next
        Console.ReadKey()
    End Sub


    Sub sesti()

        Console.WriteLine(ProvjeriBalansiranostZagrada("[(])"))
        Console.WriteLine(ProvjeriBalansiranostZagrada("[()]{}{[()()]()}"))
    End Sub
    Public Function ProvjeriBalansiranostZagrada(ulazniString As String) As Boolean
        ' Kreiraj stog za pohranu zagrada

        Dim stogZagrada As New Stack()

        ' Prolazi se kroz svaki znak u ulaznom stringu
        For i As Integer = 0 To ulazniString.Length - 1
            ' Ako je trenutni znak lijeva zagrada, stavi ga na stog
            If ulazniString(i) = "(" Or ulazniString(i) = "[" Or ulazniString(i) = "{" Then
                stogZagrada.Push(ulazniString(i))
            Else
                ' Ako je trenutni znak desna zagrada, provjeri je li ona par lijevoj zagradi na vrhu stoga
                If ulazniString(i) = ")" AndAlso stogZagrada.Count > 0 AndAlso stogZagrada.Peek() = "(" Then
                    stogZagrada.Pop()
                ElseIf ulazniString(i) = "]" AndAlso stogZagrada.Count > 0 AndAlso stogZagrada.Peek() = "[" Then
                    stogZagrada.Pop()
                ElseIf ulazniString(i) = "}" AndAlso stogZagrada.Count > 0 AndAlso stogZagrada.Peek() = "{" Then
                    stogZagrada.Pop()
                Else
                    ' Ako nije pronađen par za desnu zagradu, vraća se false
                    Return False
                End If
            End If
        Next
        If (stogZagrada.Count = 0) Then
            Return True
        End If
        ' Ako je stog prazan nakon što se prošlo kroz cijeli string, to znači da su sve zagrade balansirane

    End Function


End Module
