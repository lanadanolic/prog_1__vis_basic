Imports System

Module Program


    '1. Implementirajte strukturu Point koja će se koristiti za opisivanje točke u prostoru).
    'Struktura treba imati tri člana koji predstavljaju x, y i z koordinate točke i trebaju biti
    'realni brojevi. Implementirajte člansku funkciju ToString() tako da ispisuje koordinate
    'u konzoli kao (x,y,z) – zajedno sa zagradama.

    'Structure point
    '    Dim x As Double
    '    Dim y As Double
    '    Dim z As Double
    '    Public Overrides Function ToString() As String
    '        Return $"({x}, {y}, {z})"
    '    End Function
    'End Structure

    'Sub Main()
    '    Dim p As point
    '    p.x = 2
    '    p.y = 3
    '    p.z = 2

    '    Console.WriteLine(p)

    'End Sub





    '2. U strukturi iz prethodnog zadatka kreirati člansku funkciju DistanceTo() koja će primati
    'jedan parametar tipa Point koji će vraćati euklidsku udaljenost između te dvije točke.
    'Testirajte funkciju tako da u Main() proceduri kreirate dvije točke te ispišete njihovu
    'udaljenost korištenjem ove metode.

    'Structure point
    '    Dim x As Double
    '    Dim y As Double
    '    Dim z As Double
    '    Public Overrides Function ToString() As String
    '        Return $"({x}, {y}, {z})"
    '    End Function

    '    Public Function DistanceTo(q As point) As Double
    '        Return Math.Sqrt((x - q.x) ^ 2 + (x - q.y) ^ 2 + (z - q.z) ^ 2)

    '    End Function
    'End Structure

    'Sub Main()
    '    Dim p As point
    '    p.x = 2
    '    p.y = 3
    '    p.z = 2
    '    Dim q As point
    '    q.x = 6
    '    q.y = 8
    '    q.z = 4

    '    Console.WriteLine(p)
    '    Console.WriteLine(q)
    '    Console.WriteLine(p.DistanceTo(q))

    'End Sub

    'ILI
    'Structure pointt
    '    Dim x As Integer
    '    Dim y As Integer
    '    Dim z As Integer

    '    Public Overrides Function ToString() As String
    '        Return String.Format("{0},{1},{2}", x, y, z)
    '    End Function
    '    Public Function distanceto(q As pointt) As Double
    '        Return (Math.Sqrt((q.x - x) ^ 2 + (q.y - y) ^ 2 + (q.z - z) ^ 2))
    '    End Function
    'End Structure
    'Sub prvaidrugavjezba()
    '    Dim point As pointt
    '    point.x = 0
    '    point.y = 0
    '    point.z = 0

    '    Console.WriteLine(" unesite 3 koordinate 1. tocke za opisivanje tocke u prostoru:")
    '    point.x = Console.ReadLine()
    '    point.y = Console.ReadLine()
    '    point.z = Console.ReadLine()

    '    Dim q As pointt
    '    q.x = 0
    '    q.y = 0
    '    q.z = 0

    '    Console.WriteLine(" unesite sada 3 koordinate 2. tocke: ")
    '    q.x = Console.ReadLine()
    '    q.y = Console.ReadLine()
    '    q.z = Console.ReadLine()

    '    Console.WriteLine(point)
    '    Console.WriteLine(q)
    '    Console.WriteLine(point.distanceto(q))  'treba se pozvati uz pomoc pointa jr se poziva unutar strukture


    'End Sub

    '3. Implementirajte strukturu kojom ćete opisati predmet na fakultetu (sadrži naziv
    'predmeta, broj ECTS bodova i ocjenu). Potom implementirajte metodu kojoj će se kao
    'parametar proslijediti niz objekata opisanih implementiranom strukturom, a koja
    'vraća težinski prosjek ocjena. (NAPOMENA: Za računanje težinskog prosjeka možete
    'koristiti implementaciju koju ste napravili na prošlim vježbama, ali je trebate
    'prilagoditi tako da prima parametar kako je navedeno u zadatku).


    'Sub main()
    '    Dim predmet1 As predmet = New predmet("predmet1", 1, 1)
    '    Dim predmet2 As predmet = New predmet("predmet2", 2, 2)
    '    Console.WriteLine(otezaniProsjek(predmet1, predmet2))
    'End Sub

    'Public Structure predmet
    '    Public naziv As String
    '    Public brojECTS As Integer
    '    Public ocjena As Integer
    '    Public Sub New(n As String, ects As Integer, o As Integer)
    '        naziv = n
    '        brojECTS = ects
    '        ocjena = o

    '    End Sub
    'End Structure

    'Function otezaniProsjek(ParamArray predmeti() As predmet) As Double
    '    Dim brojnik, nazivnik As Integer
    '    For j As Integer = 0 To predmeti.Length - 1
    '        brojnik = brojnik + (predmeti(j).ocjena * predmeti(j).brojECTS)
    '    Next
    '    For k As Integer = 0 To predmeti.Length - 1
    '        nazivnik = nazivnik + predmeti(k).brojECTS
    '    Next
    '    Return (brojnik / nazivnik)
    'End Function

    'ILI
    Structure sadrzajpredmetanafakultetu
        Dim nazivpredmeta As String
        Dim brojectsbodova As Double
        Dim ocjena As Integer

        Public Sub parametar(nazivipredmeta As String, brojectsa As Double, ocjene As Integer)
            nazivpredmeta = nazivipredmeta
            brojectsbodova = brojectsa
            ocjena = ocjene
        End Sub


    End Structure
    Public Function tezinskiprosjek(niz() As sadrzajpredmetanafakultetu) As Double
        Dim ukupnaocjena As Integer
        Dim ukupnoectsbodova As Double
        For i As Integer = 0 To niz.Length - 1
            ukupnaocjena = (niz(i).ocjena * niz(i).brojectsbodova) + ukupnaocjena
            ukupnoectsbodova = (niz(i).brojectsbodova) + ukupnoectsbodova
        Next
        Return ukupnaocjena / ukupnoectsbodova
    End Function
    Sub trecavjezba()
        Dim prvipredmet As sadrzajpredmetanafakultetu
        prvipredmet.nazivpredmeta = 0
        prvipredmet.brojectsbodova = 0
        prvipredmet.ocjena = 0

        Console.WriteLine(" unesite naziv prvog predmeta:")
        prvipredmet.nazivpredmeta = Console.ReadLine()
        Console.WriteLine(" unesite broj ects bodova za taj predmet:")
        prvipredmet.brojectsbodova = Console.ReadLine()
        Console.WriteLine(" unesite ocjene za taj predmet:")
        prvipredmet.ocjena = Console.ReadLine()

        Dim drugipredmet As sadrzajpredmetanafakultetu
        drugipredmet.nazivpredmeta = 0
        drugipredmet.brojectsbodova = 0
        drugipredmet.ocjena = 0
        Console.WriteLine(" unesite naziv drugog predmeta:")
        drugipredmet.nazivpredmeta = Console.ReadLine()
        Console.WriteLine(" unesite broj ects bodova za taj predmet:")
        drugipredmet.brojectsbodova = Console.ReadLine()
        Console.WriteLine(" unesite ocjene za taj predmet:")
        drugipredmet.ocjena = Console.ReadLine()

        Dim nizpredmeta As sadrzajpredmetanafakultetu() = New sadrzajpredmetanafakultetu() {}
        nizpredmeta(0) = prvipredmet
        nizpredmeta(1) = drugipredmet

        Console.WriteLine(tezinskiprosjek(nizpredmeta))



    End Sub


    '4. Napišite proceduru koja prima tekst (string), te ga ispisuje obrnutim redoslijedom.
    'Proceduru pozovite iz Main() procedure s tekstom koji je korisnik unio s konzole.


    'Sub Main()
    '    Dim tekst As String
    '    Console.WriteLine("Upisi neki tekst")
    '    tekst = Console.ReadLine()
    '    ObrniSlova(tekst)
    'End Sub

    'Sub ObrniSlova(ByVal tekst As String)
    '    Dim noviString As String
    '    noviString = StrReverse(tekst)
    '    Console.WriteLine(noviString)
    'End Sub




    '5. Napišite funkciju koja prima neki tekst (string) kao ulazni parametar te vraća broj
    'samoglasnika u tom stringu. Potom, putem konzole zatražite od korisnika da unese
    'dva stringa, te za onoga koji ima više znakova ispišite koliko ima samoglasnika.

    'Sub Main()
    '    Dim tekst As String
    '    Console.WriteLine("Upisi neki tekst")
    '    tekst = Console.ReadLine()
    '    Console.WriteLine("Broj samoglasnika u tekstu je {0}", brojSamoglasnika(tekst))
    '    Dim string1, string2 As String
    '    Console.WriteLine("Upisi neki tekst")
    '    string1 = Console.ReadLine()
    '    Console.WriteLine("Upisi neki tekst")
    '    string2 = Console.ReadLine()
    '    If string1 > string2 Then
    '        Console.WriteLine("Broj samoglasnika u vecem tekstu je {0}", brojSamoglasnika(string1))
    '    Else
    '        Console.WriteLine("Broj samoglasnika u vecem tekstu je {0}", brojSamoglasnika(string2))
    '    End If
    'End Sub

    'Function brojSamoglasnika(ByVal tekst As String) As Integer
    '    Dim brojac As Integer
    '    tekst = tekst.ToUpper()
    '    For Each item In tekst
    '        If item = "A" Or item = "E" Or item = "I" Or item = "O" Or item = "U" Then
    '            brojac += 1
    '        End If
    '    Next
    '    Return brojac
    'End Function





    '6. Napišite proceduru koja prima niz stringova, te ih sortira po duljini (od najkraćeg do
    'najdužeg).







    '7. Napišite proceduru koja šifrira dio teksta te ga ispisuje u konzoli. Procedura prima dva
    'argumenta: tekst (string), te riječ ili više njih koji treba šifrirati (kao jedan string).
    'Procedura će uneseni tekst promijeniti tako da svaki znak iz teksta koji je šifriran
    'zamijeni znakom *. Proceduru testirati u Main() gdje korisnik prvo unosi tekst, a potom
    'riječ koju treba šifrirati.

    Sub Main()
        Dim n As Integer
        Console.WriteLine("Upisi koliko ce bit clanova niza")
        n = Console.ReadLine()
        Dim nizStringova As String() = New String(n - 1) {}
        For i = 0 To n - 1
            Console.WriteLine("Upisi neki string")
            nizStringova(i) = Console.ReadLine()
        Next
        sortArray(nizStringova)
    End Sub

    Sub sortArray(ByVal niz As String())
        Dim priv As String
        For i = 0 To niz.Length - 1
            For j = 1 To niz.Length - 1
                If niz(i) > niz(j) Then
                    priv = niz(j)
                    niz(j) = niz(i)
                    niz(i) = priv
                End If
                priv = ""
            Next
        Next
        For i = 0 To niz.Length - 1
            Console.WriteLine(niz(i))
        Next
    End Sub

End Module