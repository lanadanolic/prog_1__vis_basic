Module module1
    Sub main()
        'prvizadatak()
        'Program traži od korisnika unos 2 broja. Potrebno ispisati sumu i umnožak.
        '„Suma brojeva x i y jednaka je: “
        '„Umnozak brojeva x i y jednak je: “

        'drugizadatak()
        'Potrebno je napisati program koji će ispisati godinu, mjesec i dan za današnji datum.
        '„Godina: 2021 , Mjesec: , Dan: “

        'trecizadatak()
        'Korisnik unosi vrijednost u milimetrima, ispišite vrijednost u cm i km.

        'cetvrtizadatak()
        'Potrebno je ispisati najmanje vrijednosti brojčanih tipova varijabli bez deklaracije varijable

        'petizadatak()
        'Potrebno je kreirati konzolnu aplikaciju za izračun drugog korijena broja. Korisnik preko konzolnog
        'prozora unosi broj i izračunati. Zadatak riješite bez navođenja deklaracije varijable. (Option Explicit
        'naredba s opcijom Off)

        'sestizadatak()
        'Potrebno je napisati program koji traži od korisnika unos baze i eksponenta. Ispisati vrijednost
        'potencije za bilo koji unos. ( Math.Pow() )

        'sedmizadatak()
        'Zamijenite vrijednosti dviju brojčanih varijabli, bez korištenja treće varijable

        'osmizadatak()
        'Program treba ispisati prvi znak i posljednji teksta kojeg je korisnik unio putem konzole

        'devetizadatak()
        'Napisati program koji od korisnika traži unos četveroznamenkastog broja, te kao rezultat ispiše sumu
        'njegovih znamenki.
        Console.ReadKey()
    End Sub

    Sub prvizadatak()
        Dim prvibroj As Integer
        Dim drugibroj As Integer
        Dim suma As Integer
        Dim umnozak As Integer

        Console.WriteLine("Unesite 2 broja:")
        Console.WriteLine("prvi broj:")
        prvibroj = Console.ReadLine()
        Console.WriteLine("drugi broj:")
        drugibroj = Console.ReadLine()

        suma = prvibroj + drugibroj
        umnozak = prvibroj * drugibroj

        Console.WriteLine(" suma brojeva {0} i {1} je {2}, a njihov umnozak je {3}", prvibroj, drugibroj, suma, umnozak)
    End Sub

    Sub drugizadatak()
        Dim vrijeme As Date = Date.Now
        Console.WriteLine(" godina je {0}, mjesec je {1}, dan je {2}", vrijeme.Year, vrijeme.Month, vrijeme.Day)
    End Sub

    Sub trecizadatak()
        Dim milimetri As Integer
        Dim centimetri As Integer
        Dim kilometri As Integer

        Console.WriteLine(" unesite neku vrijednost u milimetrima: ")
        milimetri = Console.ReadLine()

        centimetri = milimetri / 10
        kilometri = milimetri / 1000

        Console.WriteLine(" milimetri: {0}, centimetri:{1}, kilometri:{2}", milimetri, centimetri, kilometri)
    End Sub

    Sub cetvrtizadatak()
        Console.WriteLine(Short.MinValue)
        Console.WriteLine(Integer.MinValue)
        Console.WriteLine(Decimal.MinValue)
        Console.WriteLine(Double.MinValue)
        Console.WriteLine(Short.MinValue)
        'ili console.writeline("najmanja vrijednost koju integer moze primiti je {0}", integer.minvalue)
    End Sub

    Sub petizadatak()
        Dim broj As Integer

        Console.WriteLine(" unesi neki broj:")
        broj = Console.ReadLine()

        Console.WriteLine(" drugi korijen broja {0} je {1}", broj, Math.Sqrt(broj))
    End Sub

    Sub sestizadatak()
        Dim baza As Integer
        Dim eksponent As Integer

        Console.WriteLine(" unesite bazu:")
        baza = Console.ReadLine()
        Console.WriteLine(" unesite eksponent")
        eksponent = Console.ReadLine()

        Console.WriteLine("broj {0} na broj {1} je {2}", baza, eksponent, Math.Pow(baza, eksponent))
    End Sub

    Sub sedmizadatak()
        Dim broj1 As Integer
        Dim broj2 As Integer

        Console.WriteLine(" unesi 2 integer cjelobrojne vrijednosti")
        broj1 = Console.ReadLine()
        broj2 = Console.ReadLine()

        broj1 = broj1 + broj2
        broj2 = broj1 - broj2
        broj1 = broj1 - broj2

        Console.WriteLine(" sada je prvi broj {0}, a drugi broj {1}", broj1, broj2)
    End Sub

    Sub osmizadatak()
        Dim tekst As String

        Console.WriteLine(" unesite neki tekst:")
        tekst = Console.ReadLine()

        Console.WriteLine(" prvi znak teksta je {0}, a zadnji je {1}", tekst.First, tekst.Last)
    End Sub

    Sub devetizadatak()
        Dim suma, broj, prvaznam, drugaznam, trecaznam, cetvrtaznam As Integer

        Console.WriteLine(" unesite neki cetveroznamenkasti broj: ")
        broj = Console.ReadLine()

        prvaznam = broj / 1000
        drugaznam = (broj - prvaznam * 1000) / 100
        trecaznam = (broj - prvaznam * 1000 - drugaznam * 100) / 10
        cetvrtaznam = (broj - prvaznam * 1000 - drugaznam * 100 - trecaznam * 10)

        suma = prvaznam + drugaznam + trecaznam + cetvrtaznam

        Console.WriteLine(" prva znamenka je {0}, druga znamenka je {1}, treca znamenka je {2}, cetvrta znamenka je {3}, a suma je {4}", prvaznam, drugaznam, trecaznam, cetvrtaznam, suma)

    End Sub
End Module