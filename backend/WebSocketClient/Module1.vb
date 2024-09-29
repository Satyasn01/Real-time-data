Imports WebSocket4Net

Module Module1

    Sub Main()
        Dim webSocket As New WebSocket("ws://localhost:4000")
        AddHandler webSocket.Opened, AddressOf WebSocket_Opened
        AddHandler webSocket.MessageReceived, AddressOf WebSocket_MessageReceived
        AddHandler webSocket.Closed, AddressOf WebSocket_Closed
        AddHandler webSocket.Error, AddressOf WebSocket_Error

        webSocket.Open()
        Console.WriteLine("Press any key to send a message...")
        Do While True
            Console.ReadKey(True)
            webSocket.Send("Hello from VB.NET at " & DateTime.Now.ToString())
        Loop
    End Sub

    Private Sub WebSocket_Opened(sender As Object, e As EventArgs)
        Console.WriteLine("Connected to the server.")
    End Sub

    Private Sub WebSocket_MessageReceived(sender As Object, e As MessageReceivedEventArgs)
        Console.WriteLine("Message received from server: " & e.Message)
    End Sub

    Private Sub WebSocket_Closed(sender As Object, e As EventArgs)
        Console.WriteLine("Disconnected from the server.")
    End Sub

    Private Sub WebSocket_Error(sender As Object, e As SuperSocket.ClientEngine.ErrorEventArgs)
        Console.WriteLine("Error: " & e.Exception.Message)
    End Sub

End Module
