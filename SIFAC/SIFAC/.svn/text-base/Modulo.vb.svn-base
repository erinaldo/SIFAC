Module Modulo

    '------------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   01 de Noviembre del 2007
    '-- Descripcion             :   Obtine el valor máximo permitido según el tipo de 
    '--                             dato(Byte,Int16,Int32,int64,Decimal,Double)
    '------------------------------------------------------------------------------------------------------------
    ''' <summary>
    '''  Obtine el valor máximo permito según el tipo de dato(Byte,Int16,Int32,int64,Decimal,Double)
    ''' </summary>
    ''' <param name="T_Propiedad">Propiedad a la cual se desea determinar el máximo valor permitido</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerMaxValor(ByRef T_Propiedad As Object) As String
        Dim ValorMax As String
        Try
            ValorMax = ""
            Select Case T_Propiedad.GetType.ToString
                Case "System.Byte"
                    ValorMax = System.Byte.MaxValue

                Case "System.Int16"
                    ValorMax = System.Int16.MaxValue

                Case "System.Int32"
                    ValorMax = System.Int32.MaxValue

                Case "System.Int64"
                    ValorMax = System.Int64.MaxValue

                Case "System.Decimal"
                    ValorMax = System.Decimal.MaxValue

                Case "System.Double"
                    ValorMax = System.Double.MaxValue
            End Select
            Return ValorMax
        Catch ex As Exception
            Throw New Exception("Tipo de propiedad no aplica valor máximo")
        End Try
    End Function


    '------------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor        :   Juan Carlos Herrera Amador
    '-- Fecha de Elaboración    :   01 de Noviembre del 2007
    '-- Descripcion             :   Obtiene el valor máximo permitido para un tipo el tipo de dato Sql(decimal y numeric) según la 
    '--                             precisión(p) y la escala(s)
    '------------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Obtiene el valor máximo permitido para un tipo el tipo de dato Sql(decimal y numeric) según la 
    ''' precisión(p) y la escala(s)
    ''' </summary>
    ''' <param name="p">Precisión </param>
    ''' <param name="s">Escala</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerMaxValor(ByVal p As Short, ByVal s As Short) As String
        Dim i As Short
        Dim ValorMax As String
        Try
            ValorMax = ""
            For i = 1 To p - s
                ValorMax &= "9"
            Next
            ValorMax &= "."
            For i = 1 To s
                ValorMax &= "9"
            Next
            Return ValorMax
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   15 de Noviembre del 2007
    '-- Descripcion         :   Funcion para hacer el Relleno de Ceros a una Cadena de Caracteres.
    '--                     :   Los datos de entrada son la cadena que se desea rellenar y la cantidad de ceros
    '--                     :   de relleno. Devuelve la Cadena de Caracteres rellenada.
    '-------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Relleno de Ceros a una Cadena de Caracteres
    ''' </summary>
    ''' <param name="strValor">Cadena que se desea rellenar</param>
    ''' <param name="intDigito">Cantidad de ceros de relleno</param>
    ''' <param name="Caracter">Caracter con el que se desea rellenar la cadena. Por defecto es 0</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function RellenarConCeros(ByVal strValor As String, ByVal intDigito As Integer, Optional ByVal Caracter As Char = "0"c) As String
        Dim intTope As Integer
        Dim strTemp As String = ""
        Dim i As Integer
        Try
            intTope = intDigito - strValor.Length
            For i = 0 To intTope - 1
                If i = 0 Then
                    strTemp = Caracter
                Else
                    strTemp &= Caracter
                End If
            Next
            strTemp &= strValor
            Return strTemp
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   06 de Diciembre del 2007
    '-- Descripcion         :   Funcion para convertir una cantidad monetaria a letras
    '--                     :   El parametro de Entrada es un numero decimal, lo devuelve con la moneda en 
    '--                     :   cordobas. Evalua la parte decimal y la parte entera y luego las concatena.
    '-------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Convertir una Cantidad Monetaria en Letras... Cordobas por defecto
    ''' </summary>
    ''' <param name="Numero">Numero decimal que se desea convertir.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ConvertirEnLetraLaMoneda(ByVal Numero As Decimal, Optional ByVal Moneda As String = "córdobas") As String
        Dim strNum As String = ""
        Dim strDec As String = ""
        Dim strEnt As String = ""
        Dim valor As String
        Try
            '***************************************
            '-- EVALUAR LOS DECIMALES DE LA CANTIDAD
            '***************************************
            strDec = "centavos "

            '-- Obtener los dos digitos de la derecha de la cantidad que corresponden a los decimales
            valor = Microsoft.VisualBasic.Right(Numero, 2)

            '-- Convertir el numero a letra
            If valor = "00" Then
                strDec = "cero " & strDec
            Else
                strDec = NumeroEnLetra(valor) & strDec
            End If

            '***************************************
            '-- EVALUAR LOS ENTEROS DE LA CANTIDAD
            '***************************************
            strEnt = Moneda & " con"

            '-- Obtener la cantidad entera a evaluar 
            '-- Numero menos los dos digitos decimales y menos el espacio que ocupa el punto decimal
            valor = Mid(Numero, 1, Numero.ToString.Length - 3)

            '-- Llamado de la Funcion
            strEnt = NumeroEnLetra(valor) & strEnt

            '-- RESULTADO DE LA OPERACION
            strNum = strEnt & " " & strDec
            Return strNum
        Catch ex As Exception
            Throw
        End Try
    End Function

    '-------------------------------------------------------------------------------------------------------
    '-- Nombre del Autor    :   Michelle Valezka Reyes Tijerino
    '-- Fecha de Creación   :   06 de Diciembre del 2007
    '-- Descripcion         :   Funcion para convertir una cantidad entera a letras.
    '--                     :   Parametro de Entrada, el numero que se desea convertir en formato STRING
    '--                     :   La conversion iniia de izquierda a derecha tomando cada digito y verificando
    '--                     :   que unidad juega en la tabla de conversion (unidad, decena, centena, mil ...)
    '--                     :   La var blnFin maneja en caso de que se haya introducido un numero multiplo de
    '--                     :   10 como 90,80,30; como se comienza a convertir de izquierda a derecha, es 
    '--                     :   para que corte el ciclo y no busque la unidad cero.
    '-------------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Convertir un numero en letras. Solo enteros
    ''' </summary>
    ''' <param name="Numero">Numero que se desea convertir a letras</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NumeroEnLetra(ByVal Numero As String) As String
        Dim strNum As String = ""
        Dim Longitud As Integer = 0
        Dim blnFin As Boolean = False
        Dim intNumCaracter As Integer = 0
        Dim Digito As Integer = 0
        Try
            '-- Obtener la Longitud del Numero para saber si el digito que se va a evaluar se 
            '-- trata de unidad, decena, centena, mil, millones.
            For Longitud = Len(Numero) To 1 Step -1

                '-- El numero que ocupa en el string el Caracter seleccionado de izquierda a derecha
                intNumCaracter += 1

                '-- Con Mid(Numero, intNumCaracter, 1)), se selecciona el digito que se va a convertir
                Digito = Mid(Numero, intNumCaracter, 1)

                Select Case Longitud
                    Case 1, 4, 7, 10
                        '-- UNIDADES, UNIDADES DE MILES, UNIDADES DE MILLONES, UNIDADES DE MIL MILLONES
                        Select Case Digito
                            Case 1
                                If Not blnFin Then
                                    '-- Si es el primer digito de la expresion o el ultimo
                                    If Longitud = 1 Or Longitud = Len(Numero) Then
                                        '-- Si es para veintiuno
                                        strNum &= "un "
                                    Else
                                        '-- o treinta y uno
                                        strNum &= "uno "
                                    End If
                                End If
                            Case 2
                                If Not blnFin Then
                                    strNum &= "dos "
                                End If
                            Case 3
                                If Not blnFin Then
                                    strNum &= "tres "
                                End If
                            Case 4
                                If Not blnFin Then
                                    strNum &= "cuatro "
                                End If
                            Case 5
                                If Not blnFin Then
                                    strNum &= "cinco "
                                End If
                            Case 6
                                If Not blnFin Then
                                    strNum &= "seis "
                                End If
                            Case 7
                                If Not blnFin Then
                                    strNum &= "siete "
                                End If
                            Case 8
                                If Not blnFin Then
                                    strNum &= "ocho "
                                End If
                            Case 9
                                If Not blnFin Then
                                    strNum &= "nueve "
                                End If
                        End Select
                    Case 2, 5, 8, 11
                        '-- DECENAS, DECENAS DE MILES, DECENAS DE MILLONES, DECENAS DE MIL MILLONES
                        Select Case Digito
                            Case 1
                                '-- Del 11 al 15, cada numero tiene una escritura diferente, del 16 al 19 tiene la base 'dieci'
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "diez "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) = "1" Then
                                    blnFin = True
                                    strNum &= "once "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) = "2" Then
                                    blnFin = True
                                    strNum &= "doce "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) = "3" Then
                                    blnFin = True
                                    strNum &= "trece "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) = "4" Then
                                    blnFin = True
                                    strNum &= "catorce "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) = "5" Then
                                    blnFin = True
                                    strNum &= "quince "
                                End If
                                If Mid(Numero, intNumCaracter + 1, 1) > "5" Then
                                    blnFin = False
                                    strNum &= "dieci"
                                End If
                            Case 2
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "veinte "
                                Else
                                    blnFin = False
                                    strNum &= "veinti"
                                End If
                            Case 3
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "treinta "
                                Else
                                    blnFin = False
                                    strNum &= "treinta y "
                                End If
                            Case 4
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "cuarenta "
                                Else
                                    blnFin = False
                                    strNum &= "cuarenta y "
                                End If
                            Case 5
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "cincuenta "
                                Else
                                    blnFin = False
                                    strNum &= "cincuenta y "
                                End If
                            Case 6
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "sesenta "
                                Else
                                    blnFin = False
                                    strNum &= "sesenta y "
                                End If
                            Case 7
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "setenta "
                                Else
                                    blnFin = False
                                    strNum &= "setenta y "
                                End If
                            Case 8
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "ochenta "
                                Else
                                    blnFin = False
                                    strNum &= "ochenta y "
                                End If
                            Case 9
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" Then
                                    blnFin = True
                                    strNum &= "noventa "
                                Else
                                    blnFin = False
                                    strNum &= "noventa y "
                                End If
                        End Select
                    Case 3, 6, 9, 12
                        '-- CENTENAS, CENTENAS DE MILES, CENTENAS DE MILLONES, CENTENAS DE MIL MILLONES
                        Select Case Digito
                            Case 1
                                '-- Verificar si es cien '100' o ciento '145', '193'
                                If Mid(Numero, intNumCaracter + 1, 1) = "0" And Mid(Numero, intNumCaracter + 2, 1) = "0" Then
                                    strNum &= "cien "
                                Else
                                    strNum &= "ciento "
                                End If
                            Case 2
                                strNum &= "doscientos "
                            Case 3
                                strNum &= "trescientos "
                            Case 4
                                strNum &= "cuatrocientos "
                            Case 5
                                strNum &= "quinientos "
                            Case 6
                                strNum &= "seiscientos "
                            Case 7
                                strNum &= "setecientos "
                            Case 8
                                strNum &= "ochocientos "
                            Case 9
                                strNum &= "novecientos "
                        End Select
                End Select

                '-- Verificar las Milesimas y las Mil Milesimas
                If Longitud = 4 Then
                    '-- Si se trata de una cifra cerrada como un millon, este no se lleva el mi (ej. un millon mil).
                    '-- Se verifican si el numero es mayor de 6 cifras y luego se verifica que las cifras numero 4,5 y 6 sean '0' para omitir el mil
                    If Not Mid(Numero, 6, 1) = "0" And Not Mid(Numero, 5, 1) = "0" And Not Mid(Numero, 4, 1) = "0" Or Not (Mid(Numero, 6, 1) = "0" And Mid(Numero, 5, 1) = "0" And Mid(Numero, 4, 1) = "0" And Len(Numero) <= 6) Then
                        strNum &= "mil "
                    End If
                End If

                If Longitud = 10 Then
                    '-- Si se trata de una cifra cerrada como un millon, este no se lleva el mi (ej. un millon mil).
                    '-- Se verifican si el numero es mayor de 6 cifras y luego se verifica que las cifras numero 4,5 y 6 sean '0' para omitir el mil
                    If Not Mid(Numero, 7, 1) = "0" And Not Mid(Numero, 8, 1) = "0" And Not Mid(Numero, 9, 1) = "0" Or (Mid(Numero, 7, 1) = "0" And Mid(Numero, 8, 1) = "0" And Mid(Numero, 9, 1) = "0" And Len(Numero) <= 12 And Len(Numero) > 6) Then
                        strNum &= "mil "
                    End If
                End If

                '-- Verificar las Millonesimas
                If Longitud = 7 Then
                    '-- Si la longitud es para (siete digitos) == 1000000 == un millon; y el numero es 1
                    If Len(Numero) = 7 And Mid(Numero, 1, 1) = "1" Then
                        strNum &= "millon "
                    Else
                        strNum &= "millones "
                    End If
                End If
            Next
            Return strNum
        Catch ex As Exception
            Throw
        End Try
    End Function

End Module
