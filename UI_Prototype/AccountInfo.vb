﻿Public Class AccountInfo

    Private Sub updateEmail(sender As Object, e As EventArgs) Handles email_textBox.TextChanged
        email_textBox.AutoSize = True
        Dim saveChangesButton As New Button
        With saveChangesButton
            .Location = New Point(304, 257)
            .Width = 84
            .Height = 30
            .Text = "Save"
            .Name = "update_button"
            .BackColor = Color.WhiteSmoke
            .ForeColor = Color.Black
            .Font = New Font("DejaVu Sans Serif", 11)
            .Visible = True
        End With
        Me.Controls.Add(saveChangesButton)
    End Sub

    Private Sub goto_MainMenu(sender As Object, e As EventArgs) Handles previous_Button.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class