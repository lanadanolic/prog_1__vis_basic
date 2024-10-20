Module Module1

    Sub Main()

        'zadatak1
        'Implementirajte klasu Polygon kojom opisujemo pravilni mnogokut, sa dva privatna
        'polja za opisivanje duljine stranice i broja stranica, te članskom funkcijom za izračun
        'opsega.U Main proceduri kreirati objekt tipa Polygon, te ispisati njegov opseg

        'zadatak2()
        'Implementirajte klasu Account kojom ćete opisati bankovni račun. Treba sadržavati
        'polja za IBAN broj računa (tipa String), stanje (tipa Decimal), vlasnik (tipa String). Svi
        'elementi trebaju biti privatni. Potrebno je kreirati svojstva (properties) IBAN (za
        'dohvaćanje i postavljanje broja računa), Owner (vraća ili postavlja vlasnika), te Balance
        '(samo vraća stanje). Za rad s računima osigurajte dva postupka Deposit i Withdraw.
        'Oba postupka primaju Decimal parametar, kod Withdraw se oduzima stanje na
        'računu, treba voditi računa je li iznos raspoloživ, te ako nije izbacujemo iznimku.
        'Deposit dodaje iznos na račun. U proceduri Main kreirajte račun i obavite nekoliko
        'transakcija da provjerite sve funkcionalnosti

        'zadatak3()
        'Implementirajte klasu Complex s dva polja, za realni i imaginarni dio i konstrukturom
        'koji prima dva parametra (realni i imaginarni dio broja) i koji polja postavlja na zadane
        'vrijednosti. Implementirajte članske funkcije za zbrajanje, oduzimanje, množenje, te
        'kompleksno konjugirani broj. Reimplementirajte (override) člansku funkciju ToString()
        'tako da ispisuje kompleksni broj u obliku „(x, y)“ (gdje su x i y realni, odnosno
        'imaginarni dio). Potom u proceduri Main učitajte 2 kompleksna broja i ispišite
        'rezultate dobivene korištenjem definiranih članskih funkcija.

        'zadatak4()
        'Implementirajte klasu za predstavljanje Zaposlenik. Klasa treba sadržavati polja za
        'ime, prezime i za niz od šest plaća. Implementirati svojstvo (property) koje dohvaća
        'puno ime zaposlenika u obliku “Ime Prezime” (osigurati da početna slova budu velika)
        'i funkciju koja vraća prosjek plaća. U proceduri Main korisnik unosi ime, prezime i 6
        'plaća i od toga kreira objekt koji predstavlja zaposlenika i ispisuje njegove podatke i
        'prosječnu plaću.

        Console.ReadKey()
    End Sub

    'ZADATAK1
    Class polygon
        Private duljinastranice As Integer  'stvaramo 2 varijable duljinastranice i brojstranica unutar klase, private su, uz pomoc public sub new im pridodajemo nova imena i uz pomoc njega te varijable postaju public
        Private brojstranica As Integer

        Function opseg() As Integer 'funkcija koja vraca opseg tj rjesenje u main (ne uzima nis jr se varijable koje koristi nalaze unutar klase u kojoj se nalazi i ta funkcija
            Return brojstranica * brojstranica
        End Function

        Public Sub New(a As Integer, b As Integer) 'uz pomoc njega privatne varijable postaju public
            duljinastranice = a 'pridodajemo tim 2 varijablama nova imena i iz private ih stvaramo u public (da budu vidljivi u mainu)
            brojstranica = b
        End Sub
    End Class
    Sub zadatak1()

        Console.WriteLine("unesite duljinu stranica:") 'korisnik unosi duljinu stranica
        Dim a As Integer = Console.ReadLine()

        Console.WriteLine("unesite broj stranica:")  'korisnik unosi broj stranica
        Dim b As Integer = Console.ReadLine()

        Dim p As polygon = New polygon(a, b) 'pozivamo klasu unutar maina, klasi poligon pridodajemo novo ime u mainu,  saljemo a i b
        Console.WriteLine("opseg mnogokuta je {0}", p.opseg)
    End Sub


    'ZADATAK2
    Class account
        Private IBAN As String     'varijable unutar klase, privatne su, trebamo ih nekako napraviti da budu public
        Private stanje As Decimal = 0.0  'pocetno stanje racuna je 0 sve dok korisnik ne doda neku svotu na taj racun
        Private vlasnik As String

        Public Property IBAN1() As String 'svaki property treba imati neko svoje posebno ime, iban postaje public unutar propertya
            Get
                Return IBAN            'vraca vrijednost ibana, da ju main moze vidjeti
            End Get
            Set(value As String)       'iban postavljamo na neku vrijednost
                IBAN = value
            End Set
        End Property

        Public Property VLASNIK1() As String
            Get
                Return vlasnik
            End Get
            Set(value As String)
                vlasnik = value
            End Set
        End Property

        Public ReadOnly Property STANJE1() As Decimal 'kad je property readonly ne postavlja se set, on samo cita tu trenutnu vrijednost
            Get
                Return stanje 'sd stanje postaje public 'za izracunavanje stanja koristimo deposit i withdraw koji se nalaze unutar iste klase
            End Get
        End Property

        Public Sub deposit(uplata As Decimal)
            stanje = stanje + uplata    'stanje je public za deposit jr se nalaze unutar zajednicke klase
        End Sub
        Public Sub withdraw(isplata As Decimal) 'stanje je public za isplatu jr se nalaze unutar zajednicke klase
            If isplata > stanje Then
                Throw New ArgumentOutOfRangeException("stanje ne moze biti manje od 0") 'hvata iznimke
            End If
            stanje = stanje - isplata
        End Sub
    End Class
    Sub zadatak2()
        Dim account = New account 'pozivamo klasu unutar maina, ne saljemo joj nista jr se sve nalazi u klasi
        Dim iznosuplate As Decimal
        Dim iznosisplate As Decimal

        Console.WriteLine(" unesite ime i prezime vlasnika:")
        account.VLASNIK1 = Console.ReadLine()    'privatna varijabla "vlasnik" unutar klase postaje javna kada koristimo public property i kada u njega saljemo tu varijablu
        Console.WriteLine("unesite br svoga iban racuna: HR(...)")
        account.IBAN1 = Console.ReadLine()

        Console.WriteLine(" vlasnik: {0}, iban: {1}, stanje racuna: {2}", account.VLASNIK1, account.IBAN1, account.STANJE1)

        Console.WriteLine(" koliko zelite uplatiti na svoj racun:")
        iznosuplate = Console.ReadLine()
        account.deposit(iznosuplate)
        Console.WriteLine(" iznos racuna nakon uplate je {0} kn", account.STANJE1)

        Console.WriteLine(" koliko zelite isplatiti iz svog racuna:")
        iznosisplate = Console.ReadLine()
        account.withdraw(iznosisplate)
        Console.WriteLine(" iznos racuna nakon isplate je {0} kn", account.STANJE1)

    End Sub


    'ZADATAK3
    Class complex
        Private realan As Decimal       '2 private varijable unutar klase
        Private imaginarni As Decimal

        Public Sub New(a As Decimal, b As Decimal) 'uz pomoc public sub new, privatne varijable (u ovom slucaju varijabla realni i varijabla imaginarni) postaju public, te se mogu vidjeti u mainu, pridodaju im se nova imena koja ce se koristiti u mainu
            realan = a                              'uz pomoc public sub new, te 2 privatne varijable postaju public i pridodaju im se nova imena za koristenje u mainu
            imaginarni = b
        End Sub

        Public Function zbroj(b As complex) As complex
            Return New complex(realan + b.realan, imaginarni + b.imaginarni)
        End Function

        Public Function razlika(b As complex) As complex
            Return New complex(realan - b.realan, imaginarni - b.imaginarni)
        End Function

        Public Function umnozak(b As complex) As complex
            Return New complex(realan * b.realan, imaginarni * b.imaginarni)
        End Function

        Public Function konjugirani() As complex
            Return New complex(realan, 0 - imaginarni)
        End Function

        Public Overrides Function ToString() As String
            Return $"({realan},{imaginarni})"
        End Function

    End Class

    Sub zadatak3()
        Dim a As complex = New complex(2, 3)
        Dim b As complex = New complex(4, 5)

        Console.WriteLine("Zbroj je {0}", a.zbroj(b))
        Console.WriteLine("razlika je {0}", a.razlika(b))
        Console.WriteLine("umnozak je {0}", a.umnozak(b))
        Console.WriteLine("konjugirani oblik je {0}", a.konjugirani)
        Console.WriteLine("broj: {0}", a.ToString)
    End Sub




    'ZADATAK4
    Class Zaposlenik
        Private ime As String  '3 privatne varijable unutar klase
        Private prezime As String
        Private nizPlaca(5) As Integer

        Public Sub New(x As String, y As String, z() As Integer) 'te sve 3 privatne varijable postaju public uz pomoc public sub maina, priodajemo im nova imena za koristenje u mainu
            nizPlaca = z
            ime = x
            prezime = y
        End Sub

        Public ReadOnly Property ImePrezime() As String 'kada je read only ne koristmo set jer ne postavljamo na nikoju vrijednost
            Get
                Dim s1 As String = ime(0).ToString.ToUpper + ime.Substring(1) 'napisi prvo slovo veliko i onda idi do kraja stringa (vrijedi i za ime i za prezime)
                Dim s2 As String = prezime(0).ToString.ToUpper + prezime.Substring(1)
                Return $"{s1} {s2}"
            End Get
        End Property

        Function prosjekPlaca() As Double
            Dim suma As Integer = 0
            For i = 0 To nizPlaca.Length - 1
                suma += nizPlaca(i)
            Next
            Return (suma / (nizPlaca.Length - 1))
        End Function
    End Class

    Sub zadatak4()
        Dim place() As Integer = {100, 100, 100, 100, 100, 100}
        Dim ana As Zaposlenik = New Zaposlenik("ana", "anic", place)
        Console.WriteLine($"prosjek {ana.ImePrezime}: {ana.prosjekPlaca}")
    End Sub


End Module

