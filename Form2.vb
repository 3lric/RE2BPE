Public Class Form2
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        dialog1.InitialDirectory = "C:\"
        dialog1.Title = "Select your EXE File"
        dialog1.Filter = "exe Files|*.exe"


        If (dialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim fileName As String = dialog1.FileName
            Dim s As String = System.IO.File.ReadAllText(fileName)
            Dim encoding As New System.Text.ASCIIEncoding()
            Dim b As Byte() = encoding.GetBytes(s)

            For Each singleByte As Byte In b
            Next
        End If
    End Sub
End Class