Module Program
    Sub Main()
        'prvizadatak()
        'Učitati n brojeva. Izračunati i ispisati njihovu aritmetičku sredinu.
        'drugizadatak()
        'Traži se od korisnika unos n, potrebno je ispisati prikaz na slici koji će sadržavati n redova. 
        '+++++
        '++++
        '+++
        '++
        '+
        'trecizadatak()
        'Učitati n brojeva. Ispisati najmanji i najveći broj od učitanih brojeva.
        'cetvrtizadatak()
        'Potrebno je napraviti piramidu kao na slici za uneseni broj redaka n
        '1
        '23
        '456
        '7 8 9 10
        'petizadatak()
        'Potrebno je unesenom prirodnom broju ispisati vrijednosti pojedinih znamenaka počevši od znamenke
        'najmanje težinske vrijednosti, jednu ispod druge.
        'sestizadatak()
        'Učitavati brojeve dok se upisuju neparni brojevi, izračunati aritmetičku sredinu učitanih brojeva koji su
        'veći od 10, a manji od 50.
        'sedmizadatak()
        'Učitati cijele brojeve dok se učitavaju pozitivni brojevi. Koliko je prostih brojeva učitano?
        'osmizadatak()
        'Učitavati brojeve dok su pozitivni, za svaki od učitanih brojeva ako je paran ispisati njegov korijen, a
        'ako je neparan ispisati njegov kub.
        devetizadatak()
        'Ispisati sve brojeve od m do n čiji je zbroj znamenki djeljiv s odabranim brojem b.


        Console.ReadKey()
    End Sub

    Sub prvizadatak()
        Dim n As Integer
        Dim aritmetickasredina As Decimal
        Dim suma As Integer
        Dim brojac As Integer

        Console.WriteLine(" koliko brojeva mislite unijeti:")
        brojac = Console.ReadLine()
        For i As Integer = 1 To brojac
            n = Console.ReadLine()
            suma = suma + n
        Next

        aritmetickasredina = suma / brojac
        Console.WriteLine(" aritmeticka sredina unesenih vrijednosti je {0}", aritmetickasredina)
    End Sub

    Sub drugizadatak()
        Dim n As Integer

        Console.WriteLine(" unesite koliko redaka zelite da se ispise:")
        n = Console.ReadLine()

        For i As Integer = n To n - 1
            For j As Integer = 1 To i
                Console.Write("+")
            Next
            Console.WriteLine("")
        Next
    End Sub

    Sub trecizadatak()
        Dim n, broj As Integer
        Dim min, max As Integer
        Console.WriteLine(" unesite koliko brojeva zelite unijeti:")
        n = Console.ReadLine()
        Console.WriteLine("unosite brojeve:")
        broj = Console.ReadLine()

        min = broj
        max = broj
        For i As Integer = 1 To n
            broj = Console.ReadLine()
            If broj > max Then
                broj = max
            End If
            If broj < min Then
                broj = min
            End If
        Next
        Console.WriteLine(" najveci broj od unesenih je {0} a najmanji broj je {1}", max, min)
    End Sub

    Sub cetvrtizadatak()
        Dim red, broj, centar As Integer
        Console.WriteLine("Unesite koliko redaka želite")
        red = Console.ReadLine
        broj = 1
        centar = red

        For i As Integer = 1 To red
            For j As Integer = 1 To centar - 1
                Console.Write(" ")
            Next
            For k As Integer = centar To red
                Console.Write("{0} ", broj)
                broj = broj + 1
            Next
            Console.WriteLine("")
            centar = centar - 1
        Next
    End Sub

    Sub petizadatak()
        Dim broj As Integer
        Dim znamenka As Integer

        Console.WriteLine(" unesite neki prirodni broj:")
        broj = Console.ReadLine()

        If broj > 0 Then
            While broj > 0
                znamenka = (broj - (broj \ 10) * 10)
                broj = broj \ 10
                Console.WriteLine(znamenka)
            End While
        Else
            Console.WriteLine(" unijeli ste negativan broj")
        End If
    End Sub

    Sub sestizadatak()
        Dim broj As Integer
        Dim aritmetickasredina As Double
        Dim suma, brojac As Integer

        Console.WriteLine(" unesite nekoliko brojeva, s tim da se ucitavaju samo neparni brojevi:")
        broj = Console.ReadLine
        While broj Mod 2 = 1
            If broj > 10 And broj < 50 Then
                suma = suma + broj
                brojac = brojac + 1
            End If
            broj = Console.ReadLine()
        End While

        aritmetickasredina = suma / brojac
        Console.WriteLine(" aritmeticka sredina neparnih brojeva izmedu 10 i 50 je {0}", aritmetickasredina)
    End Sub

    Sub sedmizadatak()
        Dim broj As Integer
        Dim brojac As Integer
        Dim prost As Boolean

        Console.WriteLine(" unosite pozitivne brojeve, za kraj unosa unesite 0")
        broj = Console.ReadLine()

        While broj > 0
            prost = True
            For i As Integer = 2 To broj - 1
                If broj Mod i = 0 Then
                    prost = False
                End If
            Next
            If prost = True Then
                brojac = brojac + 1
            End If
            broj = Console.ReadLine()
        End While

        Console.WriteLine(" ucitano je {0} prostih brojeva", brojac)
    End Sub

    Sub osmizadatak()
        Dim broj As Integer

        Console.WriteLine(" unosite pozitivne brojeve, za izlaz unesite 0 ili negativnu cijelu vrijednost")
        broj = Console.ReadLine()

        While (broj > 0)
            If (broj Mod 2 = 0) Then
                Console.WriteLine(Math.Sqrt(broj))
            End If
            If (broj Mod 2 = 1) Then
                Console.WriteLine(Math.Pow(broj, 3))
            End If
            broj = Console.ReadLine()
        End While
    End Sub

    Sub devetizadatak()
        Dim m, n, b, z, broj As Integer
        Dim suma As Double
        Console.WriteLine("Unesite broj m , zatim n, zatim b")
        m = Console.ReadLine
        n = Console.ReadLine
        b = Console.ReadLine

        For i As Integer = m To n
            broj = i
            suma = 0
            While broj > 0
                z = (broj - (broj \ 10) * 10)
                suma = suma + z
                broj = broj \ 10
            End While
            If suma Mod b = 0 Then
                Console.WriteLine(i)
            End If
        Next
    End Sub

End Module
