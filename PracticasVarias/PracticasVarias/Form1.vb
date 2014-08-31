Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Label1.Text = "Hola Mundo a Todos"





    End Sub

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Me.txtresultado.Text = Convert.ToInt32(Me.txtnum1.Text) + Convert.ToInt32(Me.txtnum2.Text)

    End Sub
End Class
