Module Program
    Sub Main()
        'prvizadatak()
        'Program traži od korisnika unos n brojeva. Potrebno je brojeve unijeti u niz, te niz ispisati. Voditi
        'računa o validaciji korisnikovih unosa, ukoliko korisnik unese riječ tada se to ne pohranjuje u niz.

        'drugi zadatak()
        ' Program traži od korisnika unos n riječi. Voditi računa o validaciji korisnikovih unosa, ukoliko
        'korisnik unese samo broj tada se to ne pohranjuje u niz. Potrebno je ispisati svaku riječ i broj
        'slova koji sadrži

        'trecizadatak()
        'Potrebno je popuniti niz sa slučajno generiranim brojevima. Od korisnika se traži da unese
        'granicu, nakon čega je potrebno generirati dva nova niza, jedan koji sadržava brojeve manje od
        'granice, i jedan koji sadržava brojeve veće od granice.

        'cetvrtizadatak()
        'Potrebno je generirati niz sa vlastitim izborom vrijednosti. Korisnik unosi indeks i broj
        'elemenata niza, nakon toga potrebno ispisati sve elemente od danog indeksa.

        'petizadatak()
        'Generirati i popuniti niz vrijednostima. Potrebno je ispisati sve duple elemente niza.

        'sestizadatak()
        'Potrebno je popuniti niz slučajno odabranim vrijednostima. Sortirati niz, bez korištenja
        'ugrađenih metoda sortiranja.

        'sedmizadatak()
        'Potrebno je generirati matricu 5x5. Popuniti matricu slučajno generiranim vrijednostima. Ispisati
        'sumu elemenata na dijagonalama matrice. Dijagonala 1 suma {} , Dijagonala 2 suma {}

        'osmizadatak()
        'Napisati program koji će pohranjivati elemente u niz. Traži se od korisnika unos vrijednosti za
        'koju želi provjeru broja ponavljanja u nizu. Ispisati vrijednost i broj ponavljanja.

        'devetizadatak()
        'Ispisati sve elemente niza koji se ne ponavljaju

        'desetizadatak()
        'Potrebno je generirati niz koji sadrži pet elemenata. Svaki element predstavlja dekadsku
        'vrijednost veću od 0. Ispisati sve elemente niza i njihovu pretvorbu u binarni sustav.

        'jedanaestizadatak()
        'Potrebno je generirati matricu 3x3. Matricu popunjava korisnik. Voditi računa o validaciji
        'korisnikovog unosa.Ispisati donje trokutastu matricu (Donja trokutasta matrica je kvadratna
        'matrica kojoj su svi elementi iznad dijagonale jednaki nuli)

        'dvanaestizadatak()
        'Učitati n brojeva i izračunati aritmetičku sredinu parnih brojeva osim onih
        'koji završavaju s 4.

        'trinaestizadatak()
        'Učitati 5 troznamenkastih brojeva. Ispisati broj koji ima najveću
        'znamenku, stotica, desetica ili jedinica.

        'cetrnaestizadatak()
        'Treba prebrojiti koliko brojeva unutar raspona od M do N ima znamenku
        'jedinice vrijednosti 9.

        'petnaestizadatak()
        'Učitati 10 troznamenkastih brojeva i za svaki od učitanih brojeva ispisati
        'aritimetičku sredinu njegovih znamenki.

        'sesnaestizadatak()
        ' Učitavati brojeve dok se ne učita broj 5. Koliki je zbroj učitanih brojeva
        'koji su djeljivi sa 3 ili sa 7?

        'sedamnaestizadatak()
        'Učitavati troznamenkaste brojeve dok je zbroj znamenki paran. Koliko je
        'brojeva učitano?

        'osamnaestizadatak()
        ' Napiši Program koji će unijeti n za dužinu niza. Korisnik unosi u niz n
        'brojeva.Ispisati sve negativne elemente niza.

        'devetnaestizadatak()
        'Napiši program koji će unijeti n za dužinu niza. Korisnik unosi u niz n
        'brojeva.Napraviti drugi niz kojemu će elementi biti kvadrati prvog niza.
        Console.ReadKey()
    End Sub

    Sub prvizadatak()
        Dim niz As Integer()
        Dim n, brojac As Integer
        Dim broj As String

        Console.Write("kOLIKO BROJEVA ŽELITE UNJETI: ")
        n = Console.ReadLine()

        niz = New Integer(n) {}
        Console.WriteLine("Unesite brojeve")

        Do
            broj = Console.ReadLine()
            If IsNumeric(broj) Then
                niz(brojac) = broj
                brojac = brojac + 1
            End If
        Loop While brojac < n

        For i As Integer = 0 To n - 1
            Console.Write(niz(i))
        Next
    End Sub

    Sub drugizadatak()

        Dim niz As String()
        Dim rijec As String
        Dim n1, brojac1 As Integer

        brojac1 = 0
        Console.Write("Koliko riječi želite unijeti?")
        n1 = Console.ReadLine
        niz = New String(n1) {}
        Console.WriteLine("zapocnite unos:")
        Do
            rijec = Console.ReadLine
            If IsNumeric(rijec) Then
                brojac1 = brojac1
            Else
                niz(brojac1) = rijec
                brojac1 = brojac1 + 1

            End If
        Loop While brojac1 < n1
        For i As Integer = 0 To n1 - 1
            Console.Write(niz(i))
            Console.Write(" ")
            Console.Write("Duljina riječi je: {0}", niz(i).Length)
            Console.WriteLine(" ")
        Next
    End Sub

    Sub trecizadatak()

        Dim gornjagranica, donjagranica, unos, glavnagranica, brojac1, brojac2 As Integer
        Dim nasumicniBR As Random = New Random()
        Dim niz, niz1, niz2 As Integer()
        Console.WriteLine("Unesite koliko članova niza želite generirati")
        unos = Console.ReadLine
        niz = New Integer(unos - 1) {}
        niz1 = New Integer(unos - 1) {}
        niz2 = New Integer(unos - 1) {}
        Console.Write("Unesite gornju granicu: ")
        gornjagranica = Console.ReadLine
        Console.Write("Unesite donju granicu: ")
        donjagranica = Console.ReadLine
        Console.WriteLine("Unesite glavnu granicu izmedu dva niza")
        glavnagranica = Console.ReadLine

        For i As Integer = 0 To unos - 1
            niz(i) = nasumicniBR.Next(donjagranica, gornjagranica)
            Console.WriteLine(niz(i))
        Next
        For i As Integer = 0 To unos - 1
            If niz(i) > glavnagranica Then
                niz2(brojac1) = niz(i)
                brojac1 = brojac1 + 1

            Else
                niz1(brojac2) = niz(i)
                brojac2 = brojac2 + 1
            End If
        Next
        Console.WriteLine("")
        For i As Integer = 0 To unos - 1
            Console.Write(niz1(i))
            Console.Write(" ")
        Next
        Console.WriteLine("")
        For i As Integer = 0 To unos - 1
            Console.Write(niz2(i))
            Console.Write(" ")
        Next
    End Sub

    Sub cetvrtizadatak()
        Dim niz As Integer() = New Integer(5) {1, 2, 3, 4, 5, 6}
        Dim indeks, broj As Integer
        Console.WriteLine("Unesite indeks, a zatim broj elemenata:")
        indeks = Console.ReadLine
        broj = Console.ReadLine
        For i As Integer = indeks To (broj + indeks) - 1
            Console.WriteLine(niz(i))
        Next
    End Sub

    Sub petizadatak()
        Dim niz As Integer()
        Dim indeksi, clan As Integer

        Console.WriteLine("Unesite koliko indeksa zelite u svome nizu:")
        indeksi = Console.ReadLine
        niz = New Integer(indeksi) {}
        Console.WriteLine("Unesite clanove:")

        For i As Integer = 0 To indeksi
            niz(i) = Console.ReadLine
        Next
        Console.WriteLine(" ")
        For i As Integer = 0 To indeksi
            For j As Integer = i + 1 To indeksi
                If niz(i) = niz(j) Then
                    Console.Write(niz(i))
                    Console.Write(" ")
                End If
            Next

        Next
    End Sub

    Sub sestizadatak()
        Dim niz As Integer()
        Dim nasumicno As Random = New Random()
        Dim indeksi As Integer
        Console.Write("Unesite koliko zelite indeksa imati u nizu: ")
        indeksi = Console.ReadLine
        niz = New Integer(indeksi) {}
        For i As Integer = 0 To indeksi
            niz(i) = nasumicno.Next(-100, 100)
            Console.Write(niz(i))
            Console.Write(",")
        Next
        Console.WriteLine(" ")
        Console.WriteLine("Sortirani niz:")
        Array.Sort(niz)

        For i As Integer = 0 To indeksi

            Console.Write(niz(i))
            Console.Write(",")
        Next
    End Sub

    Sub sedmizadatak()
        Dim matrica As Integer(,) = New Integer(4, 4) {}
        Dim nasumicno As Random = New Random
        Dim suma1, suma2 As Integer
        For i As Integer = 0 To 4
            For j As Integer = 0 To 4
                matrica(i, j) = nasumicno.Next(0, 10)
                Console.Write(matrica(i, j))
                Console.Write(" ")
            Next
            Console.WriteLine("")
        Next

        For i As Integer = 0 To 4
            suma1 = suma1 + matrica(i, i)
        Next
        Console.WriteLine("Suma1 jednaka je: {0}", suma1)
        For i As Integer = 0 To 4
            suma2 = suma2 + matrica(i, 4 - i)

        Next
        Console.WriteLine("Suma2 jednaka je: {0}", suma2)
    End Sub

    Sub osmizadatak()
        Dim indeks, clan, brojac As Integer
        Dim niz As Integer()
        Console.Write("Unesite ideks niza: ")
        indeks = Console.ReadLine
        niz = New Integer(indeks) {}
        Console.WriteLine("")
        Console.WriteLine("Unesite clanove niza: ")
        For i As Integer = 0 To indeks
            niz(i) = Console.ReadLine
        Next
        Console.WriteLine("")
        Console.Write("Uneiste vrijednost koju želite provjeriti: ")
        clan = Console.ReadLine
        For i As Integer = 0 To indeks
            If clan = niz(i) Then
                brojac = brojac + 1
            End If

        Next

        Console.WriteLine("Broj {0} se ponavlja {1} puta ", clan, brojac)

    End Sub

    Sub devetizadatak()
        Dim indeks1 As Integer
        Dim indikator As Boolean
        Dim niz1 As Integer()
        Console.Write("Unesite indeks niza: ")
        indeks1 = Console.ReadLine
        niz1 = New Integer(indeks1) {}
        Console.WriteLine("")
        Console.WriteLine("Unesite clanove niza: ")
        For i As Integer = 0 To indeks1

            niz1(i) = Console.ReadLine

        Next
        For i As Integer = 0 To indeks1
            indikator = False

            For j As Integer = 0 To indeks1
                If i <> j Then


                    If niz1(i) = niz1(j) Then
                        indikator = True
                    End If
                End If

            Next

            If indikator = False Then
                Console.WriteLine("Broj {0} se ne ponavlja!", niz1(i))
            End If
        Next

    End Sub

    Sub desetizadatak()
        Dim niz2 As Integer() = New Integer(4) {}
        Dim binznam, broj As Integer
        Dim novibr As String
        Console.WriteLine("Unesite članove niza:")
        For i As Integer = 0 To 4
            niz2(i) = Console.ReadLine
        Next
        For i As Integer = 0 To 4
            broj = niz2(i)
            novibr = Nothing
            Do
                binznam = broj Mod 2
                broj = broj \ 2
                novibr = novibr + Convert.ToString(binznam)

            Loop While broj > 0

            Console.WriteLine("{0} clan niza je {1} odnosno {2} u binarnom ", i, niz2(i), StrReverse(novibr))

        Next

        'Dim broj1 As Integer = 169
        'Dim binarni As String
        'Dim znamenke, broj2 As Integer
        'broj2 = broj1
        'Do


        '    znamenke = broj2 Mod 2
        '    broj2 = broj2 \ 2

        '    binarni = binarni + Convert.ToString(znamenke)

        'Loop While broj2 > 0
        'Console.WriteLine(Convert.ToString(binarni))
        'Console.WriteLine(StrReverse(binarni))
    End Sub

    Sub jedanaestizadatak()
        Dim matrica As Integer(,) = New Integer(2, 2) {}
        Dim trokutasta As Boolean = True
        Console.WriteLine("Unesite članove matrice:")
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                matrica(i, j) = Console.ReadLine

            Next
        Next
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                Console.Write(matrica(i, j))
                Console.Write(" ")
            Next
            Console.WriteLine("")
        Next
        For i As Integer = 0 To 2
            For j As Integer = i + 1 To 2
                If matrica(i, j) <> 0 Then

                    trokutasta = False

                End If
            Next

        Next
        If trokutasta = True Then
            Console.WriteLine("Matrica je donja trokutasta")
        Else
            Console.WriteLine("Nije")
        End If
    End Sub

    Sub dvanaestizadatak()
        Dim n, broj, zbroj, brojac As Integer
        Dim arSredina As Decimal
        Console.WriteLine("Unesite n:")
        n = Console.ReadLine()

        For i As Integer = 0 To n
            Console.Write("Unesite brojeve: ")
            broj = Console.ReadLine()
            If (broj Mod 2 = 0) And (broj Mod 10 <> 4) Then
                zbroj += broj
                brojac += 1
            End If

        Next

        arSredina = zbroj / brojac
        Console.WriteLine("Aritmeticka sredina iznosi {0}", arSredina)

    End Sub

    Sub trinaestizadatak()
        Dim max_desetice, max_jedinice, max_stotice, x, broj_s, broj_d, broj_j As Integer
        max_desetice = 0
        max_jedinice = 0
        max_stotice = 0
        For i = 1 To 5
            Console.WriteLine("Unesite broj: ")
            x = Console.ReadLine()
            If (CInt(x / 100) > max_stotice) Then
                max_stotice = CInt(x / 100)
                broj_s = x
            End If
            If (CInt(x / 10) > max_desetice) Then
                max_desetice = CInt(x / 10)
                broj_d = x
            End If
            If ((x Mod 10) > max_jedinice) Then
                max_jedinice = CInt(x Mod 10)
                broj_j = x
            End If
        Next
        Console.WriteLine("Broj koji imaju najvecu znamenku stotica je {0}, desetica {1}, a jedinica {2}", broj_s, broj_d, broj_j)
    End Sub

    Sub cetrnaestizadatak()
        Dim broj, m, n As Integer
        broj = 0
        Console.WriteLine("Unesite m:")
        m = Console.ReadLine()
        Console.WriteLine("Unesite n: ")
        n = Console.ReadLine()
        For i = m To n
            If (i Mod 10 = 9) Then
                broj += 1
            End If
        Next
        Console.WriteLine("Unutar raspona od {0} do {1} ima {2} brojeva kojima je znamenka 9. ", m, n, broj)
    End Sub

    Sub petnaestizadatak()
        Dim x, s As Integer
        Dim arts As Decimal
        For i = 1 To 10
            Console.WriteLine("Unesite broj: ")
            x = Console.ReadLine()
            s = 0
            While (x <> 0)
                s = s + (x Mod 10)
                x = x \ 10
            End While
            arts = s / 3
            Console.WriteLine("Aritmeticka sredina je {0}", arts)
        Next
    End Sub

    Sub sesnaestizadatak()
        Dim s, x As Integer
        s = 0
        Do
            Console.WriteLine("unesite broj: ")
            x = Console.ReadLine()
            If (x Mod 3 = 0 Or x Mod 7 = 0) Then
                s = s + x
            End If
        Loop While (x <> 5)
        Console.WriteLine("zbroj ucitanih brojeva koji su djeljivi sa 3 ili 7 je {0}", s)
    End Sub

    Sub sedamnaestizadatak()
        Dim br, s, x As Integer
        br = 0
        Do
            s = 0
            Console.WriteLine("Unesite broj: ")
            x = Console.ReadLine()
            While (x <> 0)
                s = s + (x Mod 10)
                x = x \ 10
            End While
            br = br + 1
        Loop While (s Mod 2 = 0)
        Console.WriteLine("Ucitano je {0} brojeva", br)


    End Sub

    Sub osamnaestizadatak()
        Dim n As Integer
        Console.WriteLine("Unesite n: ")
        n = Console.ReadLine()
        Dim niz As Integer()
        niz = New Integer(n) {}
        For i = 0 To n - 1
            Console.WriteLine("Unesite {0}.element niza", i + 1)
            niz(i) = Console.ReadLine
        Next
        Console.WriteLine("Negativni elementi niza su: ")
        For i = 0 To n - 1
            If (niz(i) < 0) Then
                Console.WriteLine("{0}", niz(i))
            End If
        Next

    End Sub

    Sub devetnaestizadatak()
        Dim n As Integer
        Dim niz, niz2 As Integer()
        Console.WriteLine("Unesi n: ")
        n = Console.ReadLine
        niz2 = New Integer(n) {}
        niz = New Integer(n) {}
        For i = 0 To n - 1
            Console.WriteLine("Unesite {0}.element niza", i + 1)
            niz(i) = Console.ReadLine
            niz2(i) = niz(i) * niz(i)
        Next
        Console.WriteLine("Kvadratni niz: ")
        For i = 0 To n - 1
            Console.WriteLine("{0}", niz2(i))
        Next

    End Sub
End Module
