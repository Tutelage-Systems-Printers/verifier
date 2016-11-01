Module Engine
    ' Printer Structure
    Public printer As New Printers.PrinterStructure

    ' Events
    Public Event DeviceScanned(ByVal Printer_Structure As Printers.PrinterStructure)
    Public Event Complete()
    Public Event OnError(ByVal Message As String)
    Public Event OnMessage(ByVal Message As String)

    ' Variables
    Public device_ip_address As String
    Public snmp_password As String
    Public snmp_timeout As String

    ' Real Scan Engine
    Dim Scanner As Printers.Scan

    Public Sub Scan()
        printer = New Printers.PrinterStructure

        ' Scan Engine
        Scanner = New Printers.Scan(Net.IPAddress.Parse(device_ip_address.Trim), snmp_password, snmp_timeout)

        ' Scan
        printer = Scanner.collect()
    End Sub

End Module
