Imports Microsoft.WindowsMobile.Telephony.Phone

Public Class Form1

    Enum RFComm_PortFlags
        RFCOMM_PORT_FLAGS_REMOTE_DCB = 1
        RFCOMM_PORT_FLAGS_KEEP_DCD = 2
        RFCOMM_PORT_FLAGS_AUTHENTICATE = 4
        RFCOMM_PORT_FLAGS_ENCRYPT = 8
    End Enum

    Structure BT_ADDR
        Dim pbt_addr As Long
        Dim BT_ADDR
    End Structure

    Structure PORTEMUPortParams
        Dim Channel As Integer
        Dim Local As Boolean
        Dim Device As BT_ADDR
        Dim MTU As Integer
        Dim MinMTU As Integer
        Dim MaxMTU As Integer
        Dim SendQuota As Integer
        Dim RecvQuota As Integer
        Dim UIDService As Guid
        Dim PortFlags As RFComm_PortFlags
    End Structure

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PortParameters As New PORTEMUPortParams
        Dim Channel As Integer = 0 'IOCTL_BLUETOOTH_GET_RFCOMM_CHANNEL() ' Select appropriate channel

        PortParameters.Local = True
        PortParameters.Channel = Channel & 255

    End Sub
End Class
