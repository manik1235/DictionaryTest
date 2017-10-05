Public Class Form1

    Dim MyDictionaryStruc As New DictionaryStructure

    Structure DictionaryStructure
        Dim MyDictionary As Dictionary(Of Point, String)
    End Structure



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyDictionaryStruc.MyDictionary.Add(New Point(CInt(TextBox1.Text), CInt(TextBox3.Text)), TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBox4.Text = MyDictionaryStruc.MyDictionary.Item(New Point(CInt(TextBox1.Text), CInt(TextBox3.Text)))
        Catch
            'Stop
        Finally
            'Stop
        End Try
    End Sub
End Class
