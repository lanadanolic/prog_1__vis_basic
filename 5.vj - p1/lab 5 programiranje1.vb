Module Module1
    Sub Main()
        'Dim niz As Integer() = New Integer(5) {} 'niz je inicijaliziran na defaultne 
        ''vrijednosti Integer tipa (0)
        'niz(0) = 6 ' pohranjujemo vrijednost 6 na prvo mjesto u nizu

        'Dim niz2 As Integer() = New Integer(5) {1, 6, 8, 9, 20, 22} 'niz ima 6 elemenata sa danim 
        ''vrijednostima

        'Console.WriteLine(niz.GetUpperBound(0)) 'ispis gornje granice niza

        'ReDim niz(4) 'broj elemenata niza smanjili za jedan, niz sada sadrži 0 za sve 
        ''elemente
        'ReDim Preserve niz2(4) ' broj elemenata smanjili za jedan, niz sadrži sve 
        ''vrijednosti elemenata do te granice

        'Dim niz3 As Integer() = New Integer(5) {}
        'niz3 = niz.Clone() 'kopirali vrijednosti niza niz u niz2

        'Dim rnd As New Random
        'Dim y As Double
        'y = rnd.NextDouble()
        'Dim nesto As Integer(,,) = New Integer(1, 1, 1) {(1, 1), (1, 1), (1, 1)}
        'For i As Integer = 0 To 1
        '    For i As Integer = 0 To 1
        '        For i As Integer = 0 To 1
        '            Console.writeline(nesto(i, i, i))
        '        Next
        '    Next
        'Next
        'prvizadatak()
        '1. Program traži od korisnika unos n brojeva. Potrebno je brojeve unijeti u niz, te niz ispisati. Voditi 
        'računa o validaciji korisnikovih unosa, ukoliko korisnik unese riječ tada se to ne pohranjuje u niz.

        'drugizadatak()
        '2. Program traži od korisnika unos n riječi. Voditi računa o validaciji korisnikovih unosa, ukoliko 
        'korisnik unese samo broj tada se to ne pohranjuje u niz. Potrebno je ispisati svaku riječ i broj 
        'slova koji sadrži.

        'trecizadatak()
        '3. Potrebno je popuniti niz sa slučajno generiranim brojevima. Od korisnika se traži da unese 
        'granicu, nakon čega je potrebno generirati dva nova niza, jedan koji sadržava brojeve manje od 
        'granice, i jedan koji sadržava brojeve veće od granice.

        'cetvrtizadatak()
        '4. Potrebno je generirati niz sa vlastitim izborom vrijednosti. Korisnik unosi indeks i broj 
        'elemenata niza, nakon toga potrebno ispisati sve elemente od danog indeksa.

        'petizadatak()
        '5. Generirati i popuniti niz vrijednostima. Potrebno je ispisati sve duple elemente niza.

        'sestizadatak()
        '6. Potrebno je popuniti niz slučajno odabranim vrijednostima. Sortirati niz, bez korištenja 
        'ugrađenih metoda sortiranja. quick sort

        'sedmizadatak()
        '7. Potrebno je generirati matricu 5x5. Popuniti matricu slučajno generiranim vrijednostima. Ispisati 
        'sumu elemenata na dijagonalama matrice. Dijagonala 1 suma {} , Dijagonala 2 suma {}

        'osmizadatak()
        '8. Napisati program koji će pohranjivati elemente u niz. Traži se od korisnika unos vrijednosti za 
        ' koju želi provjeru broja ponavljanja u nizu. Ispisati vrijednost i broj ponavljanja.

        'devetizadatak()
        '9. Ispisati sve elemente niza koji se ne ponavljaju.

        'desetizadatak()
        '10. Potrebno je generirati niz koji sadrži pet elemenata. Svaki element predstavlja dekadsku 
        ' vrijednost veću od 0. Ispisati sve elemente niza i njihovu pretvorbu u binarni sustav.

        'jedanaestizadatak()
        '11. Potrebno je generirati matricu 3x3. Matricu popunjava korisnik. Voditi računa o validaciji 
        'korisnikovog unosa.Ispisati donje trokutastu matricu (Donja trokutasta matrica je kvadratna 
        'matrica kojoj su svi elementi iznad dijagonale jednaki nuli)

        'dvanaestizadatak()
        ' Potrebno je popuniti niz slučajno odabranim vrijednostima. Sortirati niz, bez korištenja 
        'ugrađenih metoda sortiranja.
        console.readkey()
    End Sub




    Sub prvizadatak()
    Dim brElmenata As Integer
    Dim niz As Integer()
    Dim broj As String     ' broj se deklarira ka string da bi korisnik mogao unjeti riječ, ako želi

        Console.Write("Unesite koliko brojeva želite unijeti u niz:")
        brElmenata = Console.ReadLine()         'unosi se broj elemenata
        niz = New Integer(brElmenata - 1) {}     'stvara se niz sa broj elemenata-1
    Console.WriteLine("Počnite unositi brojeve u niz:")
    For i As Integer = 0 To (brElmenata - 1)   ' for petlja ide od 0 to brelemenata-1

        broj = Console.ReadLine                 'unosi se broj
        If IsNumeric(broj) Then
            niz(i) = CInt(broj)

        Else
            i = i - 1
        End If

    Next
    Console.Write("Ispis niza:")
    For i As Integer = 0 To brElmenata - 1
        Console.Write(" {0} ", niz(i))
    Next
End Sub

Sub drugizadatak()

    Dim brojElemenata As Integer
    Dim rijec As String
    Dim niz As String()

    Console.Write("Unesite broj elemenata niza: ")
    brojElemenata = Console.ReadLine
    niz = New String(brojElemenata - 1) {}
    Console.WriteLine("")
    Console.WriteLine("Unesite elemente niza (brojevi se ne pohranjuju u niz): ")
    For i As Integer = 0 To brojElemenata - 1
        rijec = Console.ReadLine
        If IsNumeric(rijec) Then
            i = i - 1
        Else

            niz(i) = rijec
        End If
    Next

    For i As Integer = 0 To brojElemenata - 1
        Console.WriteLine(" {0} , broj rijeci broja {1} je {2}", niz(i), niz(i), niz(i).Length)
    Next

    'Dim brojElemenata As Integer
    'Dim rijec As String
    'Dim niz As String()

    'Console.Write("Unesite broj elemenata niza: ")
    'brojElemenata = Console.ReadLine
    'niz = New String(brojElemenata - 1) {}
    'niz(brojElemenata - 1) = "."
    'Console.WriteLine("")
    'Console.WriteLine("Unesite elemente niza do zadnjeg (brojevi se ne pohranjuju u niz): ")
    'For i As Integer = 0 To brojElemenata - 2
    '    rijec = Console.ReadLine
    '    If IsNumeric(rijec) Then
    '        i = i - 1
    '    Else

    '        niz(i) = rijec
    '    End If
    'Next
    'Console.Write("Ispis niza: ")
    'For i As Integer = 0 To brojElemenata - 1
    '    If i = brojElemenata - 1 Then
    '        Console.Write(niz(i))
    '    ElseIf i < brojElemenata - 2 Then
    '        Console.Write(" {0} ", niz(i))
    '    ElseIf i = brojElemenata - 2 Then
    '        Console.Write(niz(i))
    '    End If



    'Next
End Sub

Sub trecizadatak()
    Dim niz As Integer()
    Dim nasumicno As New Random
    Dim nizDown As Integer()
    Dim nizUp As Integer()
    Dim brElemenata As Integer
    Dim brojac1, brojac2 As Integer

    Console.Write("Unesite broj elemenata niza: ")
    brElemenata = Console.ReadLine
    niz = New Integer(brElemenata - 1) {}
    For i As Integer = 0 To brElemenata - 1
        niz(i) = nasumicno.Next(Integer.MinValue, Integer.MaxValue)
    Next
    For i As Integer = 0 To brElemenata - 1
        Console.Write(niz(i))
    Next
    Console.WriteLine("")
    Dim granica As Integer
    Console.Write("Unesite graniu među dva niza: ")
    granica = Console.ReadLine

    For i As Integer = 0 To brElemenata - 1

        If niz(i) > granica And niz(i) <> granica Then
            brojac1 = brojac1 + 1
        ElseIf niz(i) < granica And niz(i) <> granica Then
            brojac2 = brojac2 + 1
        End If
    Next

    nizUp = New Integer(brojac1 - 1) {}
    nizDown = New Integer(brojac2 - 1) {}
    For i As Integer = 0 To brElemenata - 1
        If niz(i) > granica And niz(i) <> granica Then
            Static x As Integer
            For b As Integer = x To brojac1 - 1
                nizUp(b) = niz(i)
                x = x + 1
                Exit For
            Next

        End If

        If niz(i) < granica And niz(i) <> granica Then
            Static y As Integer
            For z As Integer = y To brojac2 - 1
                nizDown(z) = niz(i)
                y = y + 1
                Exit For
            Next
        End If
    Next

    Console.Write("Ispis prvog niza: ")
    For b As Integer = 0 To brojac1 - 1
        Console.Write(" {0} ", nizUp(b))
    Next
    Console.WriteLine("")
    Console.Write("Ispis drugog niza: ")

    For z As Integer = 0 To brojac2 - 1
        Console.Write(" {0} ", nizDown(z))
    Next
End Sub

Sub cetvrtizadatak()
    Dim niz As Integer()
    Dim brojElemenata, brojČlanova, indeks As Integer
    Console.Write("Unesite broj elemenata niza: ")
    brojElemenata = Console.ReadLine
    Console.WriteLine()
    niz = New Integer(brojElemenata - 1) {}
    For i As Integer = 0 To brojElemenata - 1
        niz(i) = Console.ReadLine
    Next

    Console.WriteLine("Unesite indeks ,a potom broj članova koje želite ispisati poslije tog indeksa: ")
    indeks = Console.ReadLine

    brojČlanova = Console.ReadLine
    If indeks > brojElemenata - 1 Then
        Console.WriteLine("uNJELI STE INDEKS KOJI NE POSTOJI U NIZU")
    ElseIf indeks + 1 + brojČlanova > brojElemenata Then
        Console.WriteLine("Nakon indeksa {0} nema toliko članova", indeks)

    Else

        For I As Integer = indeks + 1 To indeks + brojČlanova
            Console.Write(" {0} ", niz(I))
        Next

    End If
End Sub

Sub petizadatak()
    Dim niz As Integer()
    Dim indeks As Integer
    Console.Write("Unesite indeks niza: ")
    indeks = Console.ReadLine
    niz = New Integer(indeks) {}
    Console.WriteLine("Unesite elemente niza: ")
    For i As Integer = 0 To indeks
        niz(i) = Console.ReadLine
    Next

    For i As Integer = 0 To indeks
        For j As Integer = i + 1 To indeks
            If niz(i) = niz(j) Then
                Console.WriteLine(" {0} ", niz(i))
            End If
        Next


    Next

End Sub

Sub sestizadatak()
    Dim nasumicno As New Random
    Dim niz As Integer() = New Integer(8) {}
    For i As Integer = 0 To 7
        niz(i) = nasumicno.Next(0, 10000)

    Next
    Array.Sort(niz)
    For i As Integer = 0 To 7
        Console.WriteLine(niz(i))
    Next
End Sub

Sub sedmizadatak()
    Dim matrica As Integer(,) = New Integer(4, 4) {}
    Dim nasumicno As New Random
    Dim sumaD1, sumaD2, sumaD3, sumaD4, sumaD5, sumad_2, sumad_3, sumad_4, sumad_5 As Integer
    Dim x, y, z, b, c, a, s, d, f, g As Integer
    For j As Integer = 0 To 4
        For i As Integer = 0 To 4
            matrica(j, i) = nasumicno.Next(0, 5)
            Console.Write("  {0}  ", matrica(j, i))
        Next
        Console.WriteLine("")
    Next
    For i As Integer = x To 4
        sumaD1 = matrica(i, i) + sumaD1
        x = x + 1
    Next

    For i As Integer = y To 3
        sumaD2 = matrica(i, i + 1) + sumaD2

        y = y + 1
    Next
    For i As Integer = z To 2
        sumaD3 = matrica(i, i + 2) + sumaD3
        z = z + 1


    Next
    For i As Integer = f To 1
        sumaD4 = matrica(f, f + 3) + sumaD4
        f = f + 1
    Next
    sumaD5 = matrica(0, 4)
    For i As Integer = g To 3
        sumad_2 = matrica(g + 1, g) + sumad_2
        g = g + 1

    Next
    For i As Integer = a To 2
        sumad_3 = matrica(a + 2, a) + sumad_3
        a = a + 1

    Next
    For i As Integer = s To 1
        sumad_4 = matrica(s + 3, s) + sumad_4
        s = s + 1

    Next
    sumad_5 = matrica(4, 0)

    Console.WriteLine("")
    Console.WriteLine("Ispisivanje suma dijagonala od najdonje dijagonale do najgornje:")
    Console.WriteLine("")
    Console.WriteLine(sumad_5)
    Console.WriteLine(sumad_4)
    Console.WriteLine(sumad_3)
    Console.WriteLine(sumad_2)
    Console.WriteLine(sumaD1)
    Console.WriteLine(sumaD2)
    Console.WriteLine(sumaD3)
    Console.WriteLine(sumaD4)
    Console.WriteLine(sumaD5)

End Sub

Sub osmizadatak()
    Dim niz As Integer() = New Integer(50) {}
    Dim nasumicno As New Random
    Dim broj As Integer
    Dim brojac As Integer
    For i As Integer = 0 To 50
        niz(i) = nasumicno.Next(0, 10)
        Console.WriteLine(niz(i))
    Next
    Console.WriteLine("")
    Console.Write("Unesite broj izmedu 0 i 10 koji zelite provjeriti na ponavljanja:")
    broj = Console.ReadLine
    Console.WriteLine("")
    For i As Integer = 0 To 50
        If broj = niz(i) Then
            brojac = brojac + 1
        End If
    Next
    Console.WriteLine("broj {0} se ponavlja {1} puta", broj, brojac)
End Sub

Sub devetizadatak()
    Dim niz As Integer() = New Integer(50) {}
    Dim nasumicno As New Random
    Dim broj As Boolean = False
    For i As Integer = 0 To 20
        niz(i) = nasumicno.Next(0, 1000)
        Console.Write(" {0} ", niz(i))
    Next
    Console.WriteLine("")
    For i As Integer = 0 To 20
        For J As Integer = i + 1 To 20
            If niz(i) = niz(J) Then
                broj = True
            End If
        Next
        If broj = False Then
            Console.WriteLine("broj {0} se ne ponavlja", niz(i))
        End If
    Next
End Sub

Sub desetizadatak()
    Dim niz As Integer() = New Integer(4) {}
    Dim broj As Integer
    Dim bin As Integer
    Dim znamenka As Integer
    Dim binarniNiz As String

    Console.WriteLine("Unesite brojeve veće od nula: ")
    For i As Integer = 0 To 4
        broj = Console.ReadLine
        If broj >= 0 Then
            niz(i) = broj
        End If

    Next

    For i As Integer = 0 To 4
        binarniNiz = 0
        znamenka = 0
        Do
            znamenka = niz(i) Mod 2

            binarniNiz = binarniNiz + CStr(znamenka)
            niz(i) = niz(i) \ 2

        Loop While niz(i) > 0
        znamenka = 0
        binarniNiz = StrReverse(binarniNiz) - CStr(znamenka)        'zašto ovo neradi?
        Console.WriteLine("")
        Console.WriteLine(binarniNiz)
    Next
    Console.ReadKey()


    Dim niz As Integer() = New Integer(4) {}
    Dim broj As Integer
    Dim bin As Integer
    Dim znamenka As Integer
    Dim binarniNiz As String

    Console.WriteLine("Unesite brojeve veće od nula: ")
    For i As Integer = 0 To 4
        broj = Console.ReadLine
        If broj >= 0 Then
            niz(i) = broj
        End If

    Next

    For i As Integer = 0 To 4
        binarniNiz = Nothing
        znamenka = 0
        Do
            znamenka = niz(i) Mod 2

            binarniNiz = binarniNiz + CStr(znamenka)
            niz(i) = niz(i) \ 2

        Loop While niz(i) > 0

        binarniNiz = StrReverse(binarniNiz)
        Console.WriteLine("")
        Console.WriteLine(binarniNiz)
    Next
End Sub

    Sub jedanaestizadatak()
        Dim donjeTrokutasta As Integer(,) = New Integer(4, 4) {}
        Console.WriteLine("Unesite elemente koji su povise glavne dijagonale i na glavnoj dijagolani")
        Console.WriteLine("")
        For i As Integer = 0 To 4
            If i = 0 Then
                For j As Integer = 0 To 4

                    donjeTrokutasta(i, j) = Console.ReadLine

                Next
            End If
            If i = 1 Then
                For j As Integer = 1 To 4
                    donjeTrokutasta(i, j) = Console.ReadLine

                Next
            End If
            If i = 2 Then
                For j As Integer = 2 To 4
                    donjeTrokutasta(i, j) = Console.ReadLine

                Next
            End If
            If i = 3 Then
                For j As Integer = 3 To 4
                    donjeTrokutasta(i, j) = Console.ReadLine

                Next
            End If
            If i = 4 Then
                For j As Integer = 4 To 4
                    donjeTrokutasta(i, j) = Console.ReadLine

                Next
            End If


        Next
        For i As Integer = 0 To 4
            For j As Integer = 0 To 4
                Console.Write(" {0} ",
                              donjeTrokutasta(i, j))
            Next
            Console.WriteLine("")
        Next
        Console.ReadKey()
    End Sub

    Sub dvanaestizadatak()

        Dim nasumicno As New Random
        Dim maks As Integer
        Dim niz As Integer() = New Integer(8) {}

        For i As Integer = 0 To 8
            niz(i) = nasumicno.Next(0, 10000)
            Console.WriteLine(niz(i))
        Next
        For P = 8 To 1 Step -1
            For j = 0 To P - 1
                If niz(j) > niz(j + 1) Then Swap(niz, j)
            Next
        Next
        Console.WriteLine("")

        For i As Integer = 0 To 8
            Console.WriteLine(niz(i))
        Next
        Console.ReadKey()

    End Sub


    Sub Swap(ByVal swaparray As Integer(), ByVal lowerIndex As Integer)
        Dim temp As Integer = swaparray(lowerIndex)
        swaparray(lowerIndex) = swaparray(lowerIndex + 1)
        swaparray(lowerIndex + 1) = temp
    End Sub
   