Imports System

Module Program
    Sub Main(args As String())
        'Dim a As Int32
        'Dim b As Int32
        Dim a As Int32, b As Int32
        a = Console.ReadLine
        b = Console.ReadLine
        'Rombo
        If a > b Then ' preguntas a=b , a>b, a<b, a>=b, a<=b
            'Por el lado del si
            Console.WriteLine("El primer número es mayor")
        Else
            'Por el lado del no
            Console.WriteLine("El segundo número es mayor")
        End If
        'getch();
        Console.ReadKey()
    End Sub
End Module
