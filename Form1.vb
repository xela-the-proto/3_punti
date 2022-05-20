Option Strict Off
Option Explicit On

Public Class frm_perimetro

    Dim x1 As Single
    Dim x2 As Single
    Dim x3 As Single
    Dim y1 As Single
    Dim y2 As Single
    Dim y3 As Single

    Dim lato1, lato2, lato3 As Single

    Dim perimetro As Single

    Public Function LunghezzaLato(ByVal Xa As Single, ByVal Ya As Single, ByVal Xb As Single, ByVal Yb As Single) As Single
        LunghezzaLato = Math.Sqrt((Xa - Xb) ^ 2 + (Ya - Yb) ^ 2)
    End Function

    Private Sub btn_calcola_Click(sender As Object, e As EventArgs) Handles btn_calcola.Click
        x1 = Val(txt_x1.Text)
        y1 = Val(txt_y1.Text)
        x2 = Val(txt_x2.Text)
        y2 = Val(txt_y2.Text)
        x3 = Val(txt_x3.Text)
        y3 = Val(txt_y3.Text)
        lato1 = LunghezzaLato(x1, y1, x2, y2)
        lato2 = LunghezzaLato(x1, y1, x3, y3)
        lato3 = LunghezzaLato(x2, y2, x3, y3)

        perimetro = lato1 + lato2 + lato3

        lbl_risultato.Text = CStr(perimetro)
    End Sub

    Private Sub btn_fine_Click(sender As Object, e As EventArgs) Handles btn_fine.Click
        End
    End Sub
End Class
