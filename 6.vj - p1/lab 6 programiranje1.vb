'Module Module1

''    Sub Main()
''        '        1. Kreirajte jednostavnu konzolnu aplikaciju koja se sastoji od modula Start i Display. Unutar modula 
''        'Display napišite tri procedure od kojih jedna ispisuje pozdrav „Dobro jutro“, druga „Dobar dan“ i treća 
''        '„Dobra večer“ . I proceduru koja će ispisivati trenutni datum i vrijeme. Unutar modula Start izvršite 
''        'pozivanje navedenih procedura.

''        '2. Napišite procedure koje će prema unesenom broju n izračunati opseg tog mnogokuta i središnji kut.
''        '3. Napište funkciju koja će za uneseni broj n, provjeriti je li palindrom. Funkcija treba vraćati true ako je 
''        'broj palindrom inače false.
''        '4. Napišite proceduru koja provjerava je li testirani broj - prosti broj. Unutar Main izvedite ispisivanje 
''        'svih prostih brojeva od 1 do 1000.
''        '5.Nadogradite prethodni zadatak, te napišite funkciju koja kao parametar prima niz, te vraća broj prostih 
''        'brojeva.
''        '6. Napišite metodu za izračun potencije koja kao parametar prima broj i potenciju, potencija treba biti 
''        'opcionalna, te ukoliko korisnik ne unese potenciju, ona je po defaultu 2. Funkcija ne smije vračati 
''        'nikakvu vrijednost. Na poziv funkcije unešeni broj se treba potencirati.
''        '7. . Potrebno je napisati sljedeći program. Proceduru koja popunjava elementa niza sa random 
''        'generiranim vrijednostima. Proceduru Ispis() koja ispisuje elemente niza. Proceduru Duljina() koja vraća 
''        'broj elemenata niza (ne koristiti ugrađene metode). Proceduru Indeks() koja primi kao parametar broj, 
''        'potrebno je vratiti prvi indeks elementa niza koji ima jednaku vrijednost tog broja. Proceduru Izbaci()
''        'koja kao parametar prima poziciju i broj elemenata koje je potrebno izbaciti iz niza.
''        '8. Napišite proceduru koja radi okretanje znamenki broja. Prihvaća samo cjelobrojnu vrijednost za unos. 
''        'Na primjer broj 12345 vraća kao 54321 (ne koristeći već ugrađenu). Napiši drugu proceduru koja vraća 
''        'broj znamenki zadanog broja.
''        '9. Napišite proceduru koja vraća vrijednost n-tog Fibonacci-jevog broja. Fibonacci-jevi brojevi su 
''        'definirani rekurzivno.
''        '10. Napravite proceduru koja računa najveći zajednički djelitelj. Najveći zajednički djelitelj dva cijela 
''        'broja je najveći cijeli broj koji ih dijeli bez ostatka. Procedura prihvaća dvije cjelobrojne vrijednosti te 
''        'vraća njihov zajednički djelitelj. Omogući prekid izvođenja programa ako korisnik za jedan od brojeva 
''        'unese vrijednost 0.
''        '11. Napišite rekurzivnu funkciju za ispis faktorijela.
''        '12. Napišite rekurzivnu funkciju za sumu svih parnih brojeva, u rasponu m,n vrijednosti koje korinsik 
''        'unosi preko konzole
''         13. Napisati proceduru koja u konzoli ispisuje N slučajno generiranih vrijednosti u rasponu između A i
''         B. Brojeve A, B i N unosi korisnik i u proceduru se prosljeđuju putem parametara. Rezultat se
''         ispisuje u konzoli.

''    End Sub





''End Module



''1. Kreirajte jednostavnu konzolnu aplikaciju koja se sastoji od modula Start i Display. Unutar modula 
''Display napišite tri procedure od kojih jedna ispisuje pozdrav „Dobro jutro“, druga „Dobar dan“ i treća 
''„Dobra večer“ . I proceduru koja će ispisivati trenutni datum i vrijeme. Unutar modula Start izvršite 
''pozivanje navedenih procedura.

''Module start
''    Sub main()
''        DobroJutro()
''        dobardan()
''        dobravecer()
''        Console.ReadKey()
''    End Sub

''End Module
''Module display
''    Sub DobroJutro()
''        Console.WriteLine("Dobro jutro")

''    End Sub
''    Sub dobardan()
''        Console.WriteLine("Dobar dan")

''    End Sub

''    Sub dobravecer()
''        Console.WriteLine("Dobra vecer")
''    End Sub

''End Module




Module module1

    '2. Napišite procedure koje će prema unesenom broju n izračunati opseg tog mnogokuta i središnji kut

    Public Sub Main()

        'OpIsred()
        'Console.WriteLine("")
        'Palindrom()
        'Console.WriteLine("")
        'Prosti()
        'Console.WriteLine("")
        'Nadogradnja()
        'Console.WriteLine("")
        'Potencija()
        'Console.WriteLine("")
        'Glavni()
        'Console.WriteLine()
        'okretanje()
        'FibonacijeviBrojevi()
        'Console.WriteLine("")



    End Sub

    Sub OpIsred()
        Console.WriteLine("2. Napišite procedure koje će prema unesenom broju n izračunati opseg tog mnogokuta i središnji kut")
        Console.WriteLine("")

        Dim stranica As Decimal
        Dim brojstranica As Integer
        Console.WriteLine("Unesite duljinu stranice n: ")
        brojstranica = Console.ReadLine
        Console.WriteLine("Unesite broj stranica: ")
        stranica = Console.ReadLine
        Console.WriteLine()
        Opseg_i_SredišnjiKut(stranica, brojstranica)

        Console.ReadKey()
    End Sub
    Sub Opseg_i_SredišnjiKut(ByVal stranica As Integer, ByVal brojstranica As Integer)
        Dim opseg As Decimal
        Dim središnjiKut As Decimal
        opseg = brojstranica * stranica
        središnjiKut = ((brojstranica - 2) * 180) / brojstranica
        Console.WriteLine("Opseg mnogokuta je {0}", opseg)
        Console.WriteLine("Središnji kut mnogokuta je {0}", središnjiKut)




    End Sub

    '3. Napište funkciju koja će za uneseni broj n, provjeriti je li palindrom. Funkcija treba vraćati true ako je 
    '        'broj palindrom inače false.


    Sub Palindrom()

        Console.WriteLine("3. Napište funkciju koja će za uneseni broj n, provjeriti je li palindrom. Funkcija treba vraćati true ako je 
    broj palindrom inače Fals.")
        Console.WriteLine("")

        Dim broj As Integer
        Console.WriteLine("Unesite broj koji se provjerava jeli palindrom:")
        broj = Console.ReadLine
        PalindromProvjera(broj)
        Console.ReadKey()

    End Sub
    Sub PalindromProvjera(ByVal broj As Integer)
        Dim znamenka As Integer
        Dim noviBroj As String = Nothing
        Dim palindrom As Boolean = False
        Do
            znamenka = broj Mod 10
            noviBroj = noviBroj + CStr(znamenka)
            broj = broj \ 10


        Loop While broj > 0
        If noviBroj = StrReverse(noviBroj) Then
            palindrom = True
        End If
        If palindrom Then
            Console.WriteLine("Broj je palindrom")
        Else
            Console.WriteLine("Broj nije palindrom")
        End If



    End Sub



    '4. Napišite proceduru koja provjerava je li testirani broj - prosti broj. Unutar Main izvedite ispisivanje 
    '        'svih prostih brojeva od 1 do 1000.


    Sub Prosti()
        Console.WriteLine("4. Napišite proceduru koja provjerava je li testirani broj - prosti broj. Unutar Main izvedite ispisivanje 
            'svih prostih brojeva od 1 do 1000.")
        Console.WriteLine("")

        ProstiBrojevi()
        Console.ReadKey()
    End Sub
    Sub ProstiBrojevi()


        For i As Integer = 1 To 1000
            Dim prost As Boolean = True
            For j As Integer = 2 To i - 1
                If i Mod j = 0 Then
                    prost = False
                End If
            Next
            If prost Then
                Console.WriteLine("broj {0} je prot", i)
            End If
        Next
    End Sub

    '5.Nadogradite prethodni zadatak, te napišite funkciju koja kao parametar prima niz, te vraća broj prostih 
    ''        'brojeva.

    Sub Nadogradnja()
        Console.WriteLine("5.Nadogradite prethodni zadatak, te napišite funkciju koja kao parametar prima niz, te vraća broj prostih 
                brojeva.")
        Console.WriteLine("")
        Dim niz As Integer() = New Integer(999) {}
        For i As Integer = 1 To 1000
            niz(i - 1) = i
        Next
        ProstiBrojevi1(niz)
        Console.ReadKey()


    End Sub
    Sub ProstiBrojevi1(ByVal niz As Integer())


        Dim brojac As Integer

        For i As Integer = 0 To 999
            Dim prost As Boolean = True
            For j As Integer = 2 To i - 1
                If niz(i) Mod j = 0 Then
                    prost = False
                End If
            Next
            If prost Then
                brojac = brojac + 1

            End If
        Next
        Console.WriteLine("Broj prostih brojeva je {0}", brojac)



    End Sub

    '6. Napišite metodu za izračun potencije koja kao parametar prima broj i potenciju, potencija treba biti 
    '      'opcionalna, te ukoliko korisnik ne unese potenciju, ona je po defaultu 2. Funkcija ne smije vračati 
    '        'nikakvu vrijednost. Na poziv funkcije unešeni broj se treba potencirati.

    Sub Potencija()

        Console.WriteLine("6. Napišite metodu za izračun potencije koja kao parametar prima broj i potenciju, potencija treba biti 
        opcionalna, te ukoliko korisnik ne unese potenciju, ona je po defaultu 2. Funkcija ne smije vračati 
        nikakvu vrijednost.Na poziv funkcije unešeni broj se treba potencirati.")
        Console.WriteLine("")
        Dim broj, potencija As String
        Console.Write("Unesite broj: ")
        broj = Console.ReadLine
        Console.Write("Unesite potenciju: ")
        potencija = Console.ReadLine
        Console.WriteLine(Potenciranje(broj, potencija))
        Console.ReadKey()


    End Sub
    Function Potenciranje(ByVal broj As String, Optional potencija As String = "2") As String
        Dim potenciranBr As String
        Dim nothing1 As String
        If broj <> Nothing Then
            potenciranBr = Math.Pow(CInt(broj), CInt(potencija))
            Return CInt(potenciranBr)
        Else
            nothing1 = "Funkcija nemože vračati nothing"
            Return nothing1

        End If


    End Function


    '7. . Potrebno je napisati sljedeći program. Proceduru koja popunjava elementa niza sa random 
    '       generiranim vrijednostima. Proceduru Ispis() koja ispisuje elemente niza. Proceduru Duljina() koja vraća 
    '       broj elemenata niza (ne koristiti ugrađene metode). Proceduru Indeks() koja primi kao parametar broj, 
    'potrebno je vratiti prvi indeks elementa niza koji ima jednaku vrijednost tog broja. Proceduru Izbaci()
    '     koja kao parametar prima poziciju i broj elemenata koje je potrebno izbaciti iz niza.

    Sub Glavni()


        Dim x As New Random
        Dim y As Integer
        Dim broj As Integer
        Dim pozicija As Integer
        Dim broj1 As Integer
        y = x.Next(1, 10)
        Dim niz As Integer() = New Integer(y) {}
        Popunjavanje(niz)
        Ispis(niz)
        Console.WriteLine("")
        Duljina(niz, y)
        Console.WriteLine("")
        Console.Write("Unesite broj čiji se prvi indeks trazi: ")
        broj = Console.ReadLine
        Indeks(niz, broj)
        Console.WriteLine("")
        Console.WriteLine("Unesite indeks elementa kojeg treba izbacit: ")
        pozicija = Console.ReadLine

        Console.WriteLine("Unesite broj koji zelite izbacit:")
        broj1 = Console.ReadLine
        Izbaci(niz, broj1, pozicija, y)
        Console.ReadKey()
    End Sub
    Sub Popunjavanje(ByVal niz As Integer())

        Dim nasumicno As New Random
        For i As Integer = 0 To niz.Length - 1
            niz(i) = nasumicno.Next(0, 100)

        Next
    End Sub

    Sub Ispis(ByVal niz As Integer())
        Console.WriteLine("Ispis niza")
        Console.WriteLine("")
        For i As Integer = 0 To niz.Length - 1
            Console.WriteLine(niz(i))
        Next

    End Sub


    Sub Duljina(ByVal niz As Integer(), ByVal duljinaN As Integer)
        Dim brojac As Integer
        Do
            brojac = brojac + 1

        Loop While brojac <= duljinaN
        Console.Write("Duljina niza je: {0}", brojac)

    End Sub

    Sub Indeks(ByVal niz As Integer(), BROJ As Integer)
        Dim IND As Boolean = False
        Dim BROJAC As Integer
        For I As Integer = 0 To niz.Length - 1
            If niz(I) = BROJ Then
                IND = True
                Exit For
            End If
            BROJAC = BROJAC + 1
        Next
        If IND = False Then
            Console.WriteLine("Tog broja nema u nizu")
        ElseIf IND Then
            Console.WriteLine("PRVI iNDEKS BROJA {0} JE {1}", BROJ, BROJAC)
        End If

    End Sub

    Sub Izbaci(ByVal niz As Integer(), ByVal broj1 As Integer, ByVal pozicija As Integer, ByVal y As Integer)

        Dim x As Integer
        For i As Integer = x To y
            x = x + 1
            If pozicija <> i Or broj1 <> niz(i) Then

                Console.WriteLine(niz(i))
            ElseIf pozicija = i And broj1 = niz(i) Then

                y = y - 1


            End If




        Next




    End Sub

    '8. Napišite proceduru koja radi okretanje znamenki broja. Prihvaća samo cjelobrojnu vrijednost za unos. 
    ''        'Na primjer broj 12345 vraća kao 54321 (ne koristeći već ugrađenu). Napiši drugu proceduru koja vraća 
    ''        'broj znamenki zadanog broja.

    Sub okretanje()
        Dim broj As Integer
        broj = Console.ReadLine
        okret(broj)
        BrojZnamenki(broj)
        Console.ReadKey()
    End Sub
    Sub okret(ByVal broj As Integer)
        Dim noviBroj As String = ""
        Dim znamenka As Integer
        Do
            znamenka = broj Mod 10
            noviBroj = noviBroj + CStr(znamenka)
            broj = broj \ 10

        Loop While broj > 0
        Console.WriteLine(noviBroj)


    End Sub
    Sub BrojZnamenki(broj)
        Dim brojac As Integer
        Do
            brojac = brojac + 1
            broj = broj \ 10
        Loop While broj > 0
        Console.WriteLine("Broj ima {0} znamenki", brojac)
    End Sub


    ''9. Napišite proceduru koja vraća vrijednost n-tog Fibonacci-jevog broja. Fibonacci-jevi brojevi su 
    ''        'definirani rekurzivno.

    Sub FibonacijeviBrojevi()
        Dim broj As Integer
        broj = Console.ReadLine
        Console.WriteLine(fibonaci(broj))
        Console.ReadKey()

    End Sub
    Function fibonaci(ByVal broj As Integer) As Integer
        If broj = 0 Or broj = 1 Then
            Return 1
        Else
            Return fibonaci(broj - 1) + fibonaci(broj - 2)
        End If

    End Function

    '10. Napravite proceduru koja računa najveći zajednički djelitelj. Najveći zajednički djelitelj dva cijela 
    ''        'broja je najveći cijeli broj koji ih dijeli bez ostatka. Procedura prihvaća dvije cjelobrojne vrijednosti te 
    ''        'vraća njihov zajednički djelitelj. Omogući prekid izvođenja programa ako korisnik za jedan od brojeva 
    ''        'unese vrijednost 0.


    Sub ZajedničkiDjeljitelj()
        Dim broj1, broj2 As Integer
        Console.WriteLine("Unesite dva broja")
        broj1 = Console.ReadLine
        broj2 = Console.ReadLine
        If broj1 = 0 Or broj2 = 0 Then
            Console.WriteLine("Pogrešan unos")
            djelitelj(broj1, broj2)
        End If





    End Sub
    Sub djelitelj(ByVal broj1 As Integer, ByVal broj2 As Integer)
        Dim zajednicki As Integer
        For i As Integer = 0 To broj1 - 1
            If broj1 Mod i = 0 Then
                zajednički1 =
            End If

        Next


    End Sub


    '13. Napisati proceduru koja u konzoli ispisuje N slučajno generiranih vrijednosti u rasponu između A i
    ''         B. Brojeve A, B i N unosi korisnik i u proceduru se prosljeđuju putem parametara. Rezultat se
    ''       ispisuje u konzoli.

    Sub ABN()
        Dim a, b As Integer
        Dim n As New random
        a = Console.readline
        b = Console.readline

    End Sub



End Module