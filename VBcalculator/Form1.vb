Public Class Form1
    Dim op As String
    Dim num As Double = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumbers.Text = "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "1"
        Else
            txtNumbers.Text = txtNumbers.Text + "1"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "0"
        Else
            txtNumbers.Text = txtNumbers.Text + "0"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "2"
        Else
            txtNumbers.Text = txtNumbers.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "3"
        Else
            txtNumbers.Text = txtNumbers.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "4"
        Else
            txtNumbers.Text = txtNumbers.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "5"
        Else
            txtNumbers.Text = txtNumbers.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "6"
        Else
            txtNumbers.Text = txtNumbers.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "7"
        Else
            txtNumbers.Text = txtNumbers.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "8"
        Else
            txtNumbers.Text = txtNumbers.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Val(txtNumbers.Text) = 0 Then
            txtNumbers.Text = "9"
        Else
            txtNumbers.Text = txtNumbers.Text + "9"
        End If
    End Sub

    Private Sub btnPeriod_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        If btnPeriod.Enabled = True Then
            txtNumbers.Text += "."
            btnPeriod.Enabled = False
        End If
    End Sub

    'addition 
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnEqual.PerformClick()
        op = "add"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num += Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        btnEqual.PerformClick()
        op = "multiply"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num * Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        btnEqual.PerformClick()
        op = "subtract"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num - Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        btnEqual.PerformClick()
        op = "divide"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num / Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    'equals
    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If op = "add" Then
            txtNumbers.Text = num + Val(txtNumbers.Text)
        ElseIf op = "subtract" Then
            txtNumbers.Text = num - Val(txtNumbers.Text)
        ElseIf op = "divide" Then
            txtNumbers.Text = num / Val(txtNumbers.Text)
        ElseIf op = "multiply" Then
            txtNumbers.Text = num * Val(txtNumbers.Text)
        ElseIf op = "div2" Then
            txtNumbers.Text = num \ Val(txtNumbers.Text)
        ElseIf op = "mod" Then
            txtNumbers.Text = num Mod Val(txtNumbers.Text)
        ElseIf op = "exponent" Then
            txtNumbers.Text = num ^ Val(txtNumbers.Text)
        End If
        op = ""
        num = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumbers.Text = "0"
        op = ""
        num = 0
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnDiv2_Click(sender As Object, e As EventArgs) Handles btnDiv2.Click
        btnEqual.PerformClick()
        op = "div2"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num \ Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        btnEqual.PerformClick()
        op = "mod"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num Mod Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        btnEqual.PerformClick()
        op = "exponent"
        If num = 0 Then
            num = Val(txtNumbers.Text)
        Else
            num = num ^ Val(txtNumbers.Text)
        End If
        txtNumbers.Text = "0"
        btnPeriod.Enabled = True
    End Sub
End Class
