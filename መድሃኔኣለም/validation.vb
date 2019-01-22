Public Class validation
    Public Function onlynumbers(ByVal x As String) As Integer
        Dim i, r As Integer
        i = 0
        r = 1
        If x <> "" Then
            Dim arr() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
            While i < arr.Length
                If x.Contains(arr(i)) Then
                    r = 0
                    Exit While
                End If
                i = i + 1
            End While
        Else
            r = 0
        End If
        Return r
    End Function
    Public Function onlychars(ByVal x As String) As Integer
        Dim i, r As Integer
        i = 0
        r = 1
        If x <> "" Then
            Dim arr() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
            While i < arr.Length
                If x.Contains(arr(i)) Then
                    r = 0
                    Exit While
                End If
                i = i + 1
            End While
        Else
            r = 0
        End If

        Return r
    End Function
    Public Function notnull(ByVal x As String) As Integer
        Dim r As Integer
        If x <> "" Then
            r = 1
        Else
            r = 0
        End If
        Return r
    End Function
    Public Function numberplusplus(ByVal x As String) As Integer
        Dim i, r As Integer
        i = 0
        r = 1
        If x <> "" Then
            Dim arr() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "\", "_", "+", "=", "}", "{", "]", "[", "?", ";", ":", "'", "<", ">", ".", ",", "|", "~"}
            While i < arr.Length
                If x.Contains(arr(i)) Then
                    r = 0
                    Exit While
                End If
                i = i + 1
            End While
        Else
            r = 0
        End If
        
        Return r
    End Function
    Public Function onlyalphabets(ByVal x As String) As Integer
        Dim i, r As Integer
        i = 0
        r = 1
        If x <> "" Then
            Dim arr() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "\", "_", "+", "=", "}", "{", "]", "[", "?", ";", ":", "'", "<", ">", ".", ",", "|", "~"}
            While i < arr.Length
                If x.Contains(arr(i)) Then
                    r = 0
                    Exit While
                End If
                i = i + 1
            End While
        Else
            r = 0
        End If

        Return r
    End Function
    Public Function emailcheck(ByVal x As String) As Integer
        Dim r As Integer
        r = 0
        If x <> "" Then
            Dim arr() As String = {"@", "."}
            If x.Contains(arr(0)) And x.Contains(arr(1)) Then
                r = 1
            End If
        Else
            r = 0
        End If
        Return r
    End Function
End Class
