Imports System.Text

Public Class LCDSmartie
    Public Function function1(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo ErrH

        If param1 = "about" Or param2 = "about" Then
            Return "  function 1 returns 1/0"

        Else

            Dim out As String = GetSetting("Activity Indicator", "Smartie", "Activity", "")
            Return out
        End If

        Exit Function
ErrH:

        Return ""
    End Function


    Public Function function2(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo ErrH

        If param1 = "about" Or param2 = "about" Then
            Return "  function 2 returns parameters 1/2"

        Else

            Dim out As String = GetSetting("Activity Indicator", "Smartie", "Activity", "")
            If out = 0 Then
                Return param1
            Else
                Return param2
            End If

        End If

        Exit Function
ErrH:

        Return ""

    End Function

    Public Function function3(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo ErrH

        If param1 = "about" Or param2 = "about" Then
            Return "  function 3 returns last line"

        Else



            Dim customChar = ""
            Dim charCall = ""

            If param2 = "\" Then
                If param1 = 2 Then
                    customChar = "$CustomChar(2,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(1)"
                ElseIf param1 = 3 Then
                    customChar = "$CustomChar(3,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(2)"
                ElseIf param1 = 4 Then
                    customChar = "$CustomChar(4,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(3)"
                ElseIf param1 = 5 Then
                    customChar = "$CustomChar(5,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(4)"
                ElseIf param1 = 6 Then
                    customChar = "$CustomChar(6,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(5)"
                ElseIf param1 = 7 Then
                    customChar = "$CustomChar(7,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(6)"
                ElseIf param1 = 8 Then
                    customChar = "$CustomChar(8,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(7)"
                Else
                    customChar = "$CustomChar(1,0,16,8,4,2,1,0,0)"
                    charCall = "$Chr(0)"

                End If

            End If


            Dim out As String = GetSetting("Activity Indicator", "Smartie", "ExtremeLine", "")
            out = Replace(out, vbTab, "")
            If param2 = "\" Then
                Return customChar & Replace(Trim(out), "\", charCall)
            Else
                Return Trim(out)
            End If




            Return out
        End If

        Exit Function
ErrH:

        Return ""


    End Function


    Public Function function4(ByVal param1 As String, ByVal param2 As String) As String
        On Error GoTo ErrH

        If param1 = "about" Or param2 = "about" Then
            Return "  function 4 returns drive letter when activity takes place"

        Else


            Dim out As String = GetSetting("Activity Indicator", "Smartie", "Detailed", " ")

            Return out

        End If

        Exit Function
ErrH:

        Return ""


    End Function

    Public Function function19(ByVal param1 As String, ByVal param2 As String) As String
        Return "What are looking here? This s not a real function "
    End Function



    Public Function function20(ByVal param1 As String, ByVal param2 As String) As String
        If param1 = "about" Or param2 = "about" Then
            Return "  Developer: Nikos Georgousis " 'credits 

        Else
            Return " actind.dll version 2.1 by Limbo. Use with activity indicator hdd utility " ' about

        End If

    End Function


    Public Function GetMinRefreshInterval() As Integer

        Return 20 ' refresh interval

    End Function


    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("Activity Indicator plugin for LCD Smartie")
        demolist.AppendLine("This pluging gets information from activity indicator hdd utility and displays them on the LCD Smartie")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine(">>>  Returns 1 or 0 depending on the drive status <<<")
        demolist.AppendLine("------ Function2 ------")
        demolist.AppendLine(">>>  Retunrs param1 or param2 depending on the drive status   <<<")
        demolist.AppendLine("$dll(actind,2,C,c)")
        demolist.AppendLine("------ Function3 ------")
        demolist.AppendLine(">>>  Returns last line path changed  <<<")
        demolist.AppendLine("$dll(actind,3,,)")
        demolist.AppendLine("$dll(actind,3,,)")
        demolist.AppendLine("A special function is available here when LCD Screen displays dollar sign instead of backslash.")
        demolist.AppendLine("The user can pass teh number of custom characted to use and the backslash as parameters ")
        demolist.AppendLine("e.g $dll(actind,3,8,\)")
        demolist.AppendLine("or $dll(actind,3,7,\)")
        demolist.AppendLine("to get the lines corrected by using the custom characters function. ")
        demolist.AppendLine("------ Function4 ------")
        demolist.AppendLine(">>>  Returns drive letter of the drive changed <<<")
        demolist.AppendLine("$dll(actind,4, , ) ")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine(">>>  Rertuns credits<<<")
        demolist.AppendLine("$dll(actind,20,about , ) ")
        demolist.AppendLine("$dll(actind,20,, ) ")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("> Activity Indicator Page")
        demolist.AppendLine("https://sourceforge.net/projects/activityindicat/")
        demolist.AppendLine("")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function

    Public Function SmartieInfo()
        Return "Developer: Nikos Georgousis (limbo)" & vbNewLine & "Version: 2.1 "
    End Function


End Class
