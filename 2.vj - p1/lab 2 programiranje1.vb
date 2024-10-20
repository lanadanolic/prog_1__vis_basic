
Module Program
    Sub Main()
        'prvizadatak()
        'Od korisnika se traži unos 3 broja , potrebno ispisati najveći broj
        'drugizadatak()
        'Potrebno napisati program koji validira korisnikov unos. Korisnik smije upisati samo jedno slovo, za
        'pogrešan unos ispisati grešku.
        'trecizadatak()
        'Program traži od korisnika unos 3 vrijednosti. Potrebno je ispisati koliko je bilo brojcanih vrijednosti, a
        'za unešeni tekstualni tip podataka potrebno je ispisati ukupan brojznakova
        'cetvrtizadatak()
        'Potrebno je napisati program koji će od korisnika tražiti unos veličine stranica trokuta. Provjerom
        'unesenih stranica potrebno je ispisati o kojoj vrsti trokuta se radi.
        'petizadatak()
        'Provjerite jeli unseseni broj djeljiv sa brojem 11,13 ili 7. Ukoliko nije djeljiv ispišite poruku o tome
        '“Broj nije djeljiv”, ukoliko je broj djeljiv ispišite poruku “Broj je djeljiv s brojem {0}
        sestizadatak()
        'Napravite mali kalkulator. Od korisnika se traži da unese dva broja I operator. U ovisnosti koji je
        'Operator odabran korisniku treba izvršiti operaciju te ispisati rezultat. Ukoliko nije unesen valjani
        'Operator treba ispisati prouku o grešci.
        'Koristiti IsNumeric(unos) za provjeru je li unese broj

    End Sub

    Sub prvizadatak()
        Dim broj1 As Integer
        Dim broj2 As Integer
        Dim broj3 As Integer

        Console.WriteLine(" unesite prvi broj:")
        broj1 = Console.ReadLine()
        Console.WriteLine(" unesite drugi broj:")
        broj2 = Console.ReadLine()
        Console.WriteLine(" unesite treci broj:")
        broj3 = Console.ReadLine()

        If (IsNumeric(broj1) And IsNumeric(broj2) And IsNumeric(broj3)) Then
            If CInt(broj1) > CInt(broj2) And CInt(broj1) > CInt(broj3) Then
                Console.WriteLine("Broj 1 je najveći")
            ElseIf CInt(broj2) > CInt(broj1) And CInt(broj2) > CInt(broj3) Then
                Console.WriteLine("Broj 2 je najveći")
            ElseIf CInt(broj3) > CInt(broj2) And CInt(broj3) > CInt(broj1) Then
                Console.WriteLine("Broj 3 je najveći")
            End If
        Else
            Console.WriteLine(" niste unijeli integer cjelobrojnu vrijednost, molim vas pokusajte ponovno")
        End If
    End Sub

    Sub drugizadatak()
        Dim unos As String

        Console.WriteLine(" unesite jedno slovo")
        unos = Console.ReadLine()
        If (IsNumeric(unos)) Then
            Console.WriteLine(" unijeli ste broj umjesto slova")
        ElseIf (unos > 1) Then
            Console.WriteLine(" unijeli ste vise od 1 slova")
        Else
            Console.WriteLine("unijeli ste slovo {0}", unos)
        End If
    End Sub

    Sub trecizadatak()
        Dim prvavrijednost, drugavrijednost, trecavrijednost As String
        Dim brojac As Integer

        Console.WriteLine(" unos vrijednosti (tekstualne ili brojcane)")
        Console.WriteLine("prvi unos:")
        prvavrijednost = Console.ReadLine
        Console.WriteLine("drugi unos:")
        drugavrijednost = Console.ReadLine()
        Console.WriteLine("treci unos")
        trecavrijednost = Console.ReadLine()

        If (IsNumeric(prvavrijednost)) Then
            brojac = brojac + 1
        Else
            Console.WriteLine(" u prvom stringu ima {0} znakova", prvavrijednost.Length)
        End If
        If (IsNumeric(drugavrijednost)) Then
            brojac = brojac + 1
        Else
            Console.WriteLine(" u drugom stringu ima {0} znakova", drugavrijednost.Length)
        End If
        If (IsNumeric(trecavrijednost)) Then
            brojac = brojac + 1
        Else
            Console.WriteLine(" u trecem stringu ima {0} znakova", trecavrijednost.Length)
        End If

        Console.WriteLine(" broj tekstalnih varijabli je {0}", brojac)
    End Sub

    Sub cetvrtizadatak()
        Dim prvastrana As Integer
        Dim drugastrana As Integer
        Dim trecastrana As Integer

        Console.WriteLine(" unesite tri stranice trokuta:")
        prvastrana = Console.ReadLine()
        drugastrana = Console.ReadLine()
        trecastrana = Console.ReadLine()

        If (IsNumeric(prvastrana) And IsNumeric(drugastrana) And IsNumeric(trecastrana)) Then
            If CInt(prvastrana) = CInt(drugastrana) And CInt(trecastrana) = CInt(prvastrana) Then
                Console.WriteLine("Jednakostranican je trokut")
            ElseIf CInt(prvastrana) <> CInt(drugastrana) And CInt(prvastrana) <> CInt(trecastrana) And CInt(drugastrana) <> CInt(trecastrana) Then
                Console.WriteLine("Trokut je raznostranican")
            ElseIf (CInt(prvastrana) <> CInt(drugastrana) And CInt(prvastrana) = CInt(trecastrana)) Or (CInt(prvastrana) <> CInt(trecastrana) And CInt(prvastrana) = CInt(drugastrana)) Or (CInt(trecastrana) = CInt(drugastrana) And CInt(prvastrana) <> CInt(drugastrana)) Then
                Console.WriteLine("Trokut je jednakokracan")
            End If
        End If
    End Sub

    Sub petizadatak()
        Dim broj As Integer
        Dim brojac1 As Integer

        Console.WriteLine("Unesite neki broj")
        broj = Console.ReadLine

        If broj Mod 11 = 0 Then
            Console.WriteLine("broj je djeljiv s brojem 11")
        Else
            brojac1 = brojac1 + 1
        End If
        If broj Mod 13 = 0 Then
            Console.WriteLine("broj je djeljiv s brojem 13")
        Else
            brojac1 = brojac1 + 1
        End If
        If broj Mod 7 = 0 Then
            Console.WriteLine("broj je djeljiv s brojem 7")
        Else
            brojac1 = brojac1 + 1
        End If
        If brojac1 = 3 Then
            Console.WriteLine("broj nije djeljiv")
        End If
    End Sub

    Sub sestizadatak()
        Dim varijabla1, varijabla2 As String
        Dim operato As String

        Console.WriteLine("Unesi 2 varijable zatim operator")
        varijabla1 = Console.ReadLine
        varijabla2 = Console.ReadLine
        operato = Console.ReadLine

        If IsNumeric(varijabla1) And IsNumeric(varijabla2) Then
            If operato = "+" Then
                Console.WriteLine("Zbroj broja {0} i {1} je {2}", varijabla1, varijabla2, CInt(varijabla1) + CInt(varijabla2))
            ElseIf operato = "-" Then
                Console.WriteLine("Razlika broja {0} i {1} je {2}", varijabla1, varijabla2, CInt(varijabla1) - CInt(varijabla2))
            ElseIf operato = "*" Then
                Console.WriteLine("Umnozak broja {0} i {1} je {2}", varijabla1, varijabla2, CInt(varijabla1) * CInt(varijabla2))
            Else
                Console.WriteLine("error, unijeli ste krivi operator")
            End If

        End If
    End Sub
End Module
