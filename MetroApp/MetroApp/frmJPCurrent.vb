Public Class frmJPCurrent
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCurrentStation.Click

    End Sub

    Private Sub cmbCurrent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurrent.SelectedIndexChanged

    End Sub

    Private Sub frmJPCurrent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCurrent.Items.Add("Glenroy")
        cmbCurrent.Items.Add("Broadmeadows")
        cmbCurrent.Items.Add("Flinder street")
    End Sub
End Class