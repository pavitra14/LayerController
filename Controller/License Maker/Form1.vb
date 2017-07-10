Public Class Form1
    Dim plainText As String = ""    ' original plaintext
    Dim cipherText As String = ""                 ' encrypted text
    Dim passPhrase As String = "071mVGZ9h2d4Va"        ' can be any string
    Dim initVector As String = "@1B2c3D4e5F6g7H8" ' must be 16 bytes
    Dim rijndaelKey As RijndaelEnhanced = _
        New RijndaelEnhanced(passPhrase, initVector)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'do nothing as of now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim key As String = txtKey.Text
        'lets encrypt it.
        plainText = key
        cipherText = rijndaelKey.Encrypt(plainText)
        System.IO.File.WriteAllText("License.key", cipherText)
        MsgBox("License.key Generated")
    End Sub
End Class
