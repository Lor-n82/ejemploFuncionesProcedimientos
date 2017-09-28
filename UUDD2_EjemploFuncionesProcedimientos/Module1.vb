Module Module1

    Sub Main()

        'Realizar en un único proyecto los procedimientos y funciones indicados
        '1- Solicitar un número por teclado y mostrar su tabla de multiplicar hasta el número 10. Esta última parte realizarla a través de un procedimiento.
        '2- Solicitar un número por teclado y calcular su valor cuadrado y la raiz cuadrada. Las operaciones matemáticas se deben realizar en funciones aparte.
        '3- Sobrecarga: Realizar un procedimiento para la suma de dos números enteros y sobrecargarlo de la siguiente forma: 
        'Procedimiento con 2 parámetros numéricos que permitan decimales
        'Procedimiento con 1 parámetro numérico y un segundo opcional también numérico
        'Procedimiento con 2 parámetros de tipo entero y un tercer parámetro String. Este procedimiento debe concatenar el String con la suma de los dos números anteriores
        'Igual que el anterior pero el parámetro String debe ser opcional conun valor por defecto

        Dim a, b, opcion, unodos As Integer
        Dim c, d As Double
        Dim e, respuesta As String
        Dim sw As Boolean

        Do
            Console.Write("" & vbNewLine &
                          "          MENU" & vbNewLine &
                          "" & vbNewLine &
                          "1. Tabla de multiplicar de un numero" & vbNewLine &
                          "2. Cuadrado de un numero" & vbNewLine &
                          "3. Raiz cuadrada de un numero" & vbNewLine &
                          "3. Suma de dos numeros enteros" & vbNewLine &
                          "5. Suma de dos numeros decimales" & vbNewLine &
                          "6. Suma un numero entero y un segundo opcional: " & vbNewLine &
                          "7. Suma de dos numeros enteros y mostrar una frase o con frase opcional" & vbNewLine &
                          "" & vbNewLine &
                          "Elige la opcion: "
                          )

            opcion = Console.ReadLine()
            Console.WriteLine("")

            If opcion = 1 Then
                Console.Write("Introduce el numero que desees: ")
                a = Console.ReadLine()
                tablaMultiplicar(a)

            ElseIf opcion = 2 Then
                Console.Write("Introduce el numero que desees: ")
                a = Console.ReadLine()
                Console.WriteLine("El cuadrado de " & a & " es " & cuadrado(a))

            ElseIf opcion = 3 Then
                Console.Write("Introduce el numero que desees: ")
                a = Console.ReadLine()
                Console.WriteLine("la raiz cuadrada de " & a & " es " & raizCuadrada(a))

            ElseIf opcion = 4 Then
                Console.Write("Introduce el primer numero: ")
                a = Console.ReadLine()
                Console.Write("Introduce el segundo numero: ")
                b = Console.ReadLine()

                suma(c, d)

            ElseIf opcion = 5 Then
                Console.Write("Introduce el primer numero: ")
                c = Console.ReadLine()
                Console.Write("Introduce el segundo numero: ")
                d = Console.ReadLine()

                suma(c, d)

            ElseIf opcion = 6 Then
                Console.Write("Introduce el primer numero: ")
                d = Console.ReadLine()
                Console.Write(d)
                Console.Write("Introduce el segundo numero (Pulsa 0 para opcional (20)): ")
                b = Console.ReadLine()

                If b = 0 Then
                    suma(d)
                Else
                    suma(d, b)
                End If


            ElseIf opcion = 7 Then

                Console.Write("Pulsa 1 para normal y 2 para la opcional: ")
                unodos = Console.ReadLine()

                If unodos = 1 Then                                              'Este metodo funciona por defecto

                    Console.Write("Introduce el primer numero: ")
                    a = Console.ReadLine()
                    Console.Write("Introduce el segundo numero: ")
                    b = Console.ReadLine()
                    Console.Write("Introduce una frase, palabra o letra: ")
                    e = Console.ReadLine()

                    suma(a, b, e)
                ElseIf unodos = 2 Then                                          'Para usar esta opcion hay que descomentar el ultimo procedimiento
                    Console.Write("Introduce el primer numero: ")
                    a = Console.ReadLine()
                    Console.Write("Introduce el segundo numero: ")
                    b = Console.ReadLine()
                    Console.Write("Introduce una frase, palabra o letra: ")
                    e = Console.ReadLine()

                    suma(a, b)
                End If

            End If

            Do
                Console.Write("¿Desea continuar?(Si/No): ")
                respuesta = Console.ReadLine.ToLower()
                If respuesta = "si" Then
                    sw = True
                ElseIf respuesta = "no" Then
                    Console.Write("Fin del programa")
                    sw = False
                End If
            Loop While respuesta <> "si" And respuesta <> "no"

        Loop While sw = True

        Console.ReadLine()



    End Sub

    Sub tablaMultiplicar(x As Integer)

        For i = 1 To 10
            Console.WriteLine(x & " x " & i & " = " & x * i)
        Next

    End Sub

    Function cuadrado(x As Integer)
        Return x * x
    End Function

    Function raizCuadrada(x As Integer)
        Return Math.Sqrt(x)
    End Function

    Sub suma(x As Integer, y As Integer)
        Console.WriteLine(x & " + " & y & " = " & x + y)
    End Sub

    Sub suma(x As Double, y As Double)
        Console.WriteLine(x & " + " & y & " = " & x + y)
    End Sub

    Sub suma(x As Double, Optional y As Integer = 20)
        Console.WriteLine(x & " + " & y & " = " & x + y)
    End Sub

    Sub suma(x As Integer, y As Integer, z As String)
        Console.WriteLine(z & " " & x & " + " & y & " = " & x + y)
    End Sub

    'Sub suma(x As Integer, y As Integer, Optional z As String = "Interfaces")
    '    Console.Write(z & " " & x & " + " & y & " = " & x + y)
    'End Sub



End Module
