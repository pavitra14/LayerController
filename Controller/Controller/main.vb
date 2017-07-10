'This is the license server of the procon layer panel, this server recieves the cipered key and plain key, and validates them.
Imports System.IO
Imports System.Net.Sockets.Socket
Imports System
Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Module main
    Dim bytCommand As Byte() = New Byte() {}
    Dim udpClient As New UdpClient
    Dim pRet1 As Integer
    Dim pRet2 As Integer
    Public recievingUDPClient As UdpClient
    Public RemoteIpEndPoint As New System.Net.IPEndPoint(System.Net.IPAddress.Any, 0)
    Public ThreadReceive As System.Threading.Thread
    Dim SocketNO As Integer = 65530
    Dim plainText As String = ""    ' original plaintext
    Dim cipherText As String = ""                 ' encrypted text
    Dim passPhrase As String = "071mVGZ9h2d4Va"        ' can be any string
    Dim initVector As String = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
    Dim rijndaelKey As RijndaelEnhanced = _
        New RijndaelEnhanced(passPhrase, initVector)

    Sub Main()
        Console.WriteLine("Welcome to Xtremis License Validation Server - By Pavitra Behre")
        Console.WriteLine("Starting UDP Listener...")
        recievingUDPClient = New System.Net.Sockets.UdpClient(SocketNO)
        Console.WriteLine("Starting Thread...")
        ThreadReceive = New System.Threading.Thread(AddressOf RecieveMessages)
        ThreadReceive.Start()
        Console.WriteLine("Ready to recieve messages...")
    End Sub
    Sub RecieveMessages()
        Try
            Dim receiveBytes As [Byte]() = recievingUDPClient.Receive(RemoteIpEndPoint)
            Dim BitDet As BitArray
            Dim recievedthings As Array
            Dim jarvis As Array
            Dim key1 As String
            Dim key2 As String
            Dim rtnMsg As String
            Console.WriteLine("Recieving Messages...")
            BitDet = New BitArray(receiveBytes)
            Dim strReturnData As String = System.Text.Encoding.Unicode.GetString(receiveBytes)

            recievedthings = Split(Encoding.ASCII.GetChars(receiveBytes), " ")
            jarvis = recievedthings
            key1 = jarvis(0) 'plain text
            key2 = jarvis(1) 'ciphered key
            Console.WriteLine("Recieved key1 as " & key1 & vbCrLf)
            Console.WriteLine("Recieved key2 as " & key2 & vbCrLf)
            'lets now validate.
            If validateKey(key1, key2) = True Then
                SendData("success")
                Console.WriteLine("Sent success.")
            ElseIf validateKey(key1, key2) = False Then
                SendData("Invalid")
                Console.WriteLine("Sent Invalid")
            End If
            'Restart the listening process
            NewInitialize()

        Catch e As Exception
            Console.WriteLine(e.Message)
            NewInitialize()
        End Try
    End Sub
    Function validateKey(key1 As String, key2 As String) As Boolean
        If key1 = rijndaelKey.Decrypt(key2) Then
            validateKey = True
        Else
            validateKey = False
        End If
    End Function
    Sub NewInitialize()
        ThreadReceive = New System.Threading.Thread(AddressOf RecieveMessages)
        ThreadReceive.Start()
    End Sub
    Sub SendData(data As String)
        Dim ClientIP As IPAddress
        ClientIP = IPAddress.Parse(RemoteIpEndPoint.Address.ToString)
        udpClient.Connect(ClientIP, 3900)
        bytCommand = Encoding.ASCII.GetBytes(data)
        pRet1 = UdpClient.Send(bytCommand, bytCommand.Length)
    End Sub
End Module
