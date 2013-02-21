Public Class Form2



    Dim checkcomment As String
    Dim checkboxname As String



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim ConnectionStringToDatabase As String
        ConnectionStringToDatabase = "Server=172.16.2.22;Database=VCMLOG;User ID=vcm;Password=0011708;Trusted_Connection=False;Provider=SQLOLEDB;"

        Dim OLECon As New OleDb.OleDbConnection(ConnectionStringToDatabase)


        Dim strb As System.Text.StringBuilder
        Dim ctr As Control
        Dim a As New System.Text.StringBuilder
        For Each ctr In Me.GroupBox1.Controls
            Dim ctrchk As CheckBox = DirectCast(ctr, CheckBox)
            If ctrchk.Checked Then
                checkcomment = InputBox("Please Add a comment for the " & ctrchk.Text & "")
                checkboxname = ctrchk.Text
                Dim Insertdbdata As String = "INSERT INTO VCMLog (dbDate, dbOutage, dbComment) VALUES ('" & DateTimePicker1.Value.Date & "', '" & checkboxname & "', '" & checkcomment & "')"

                Dim OLECmd As New OleDb.OleDbCommand

                OLECmd.CommandText = Insertdbdata
                OLECmd.Connection = OLECon
                Dim Da As New OleDb.OleDbDataAdapter(OLECmd)
                Dim Dt As New DataTable
                Da.Fill(Dt)

            End If
        Next

        MsgBox("Vox Core Monitoring Outages have been Saved")
        Me.Close()
    End Sub


    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        For Each ctrl As Control In Me.GroupBox1.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = True
            End If
        Next
    End Sub

    Private Sub CheckBox67_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox67.CheckedChanged
        For Each ctrl As Control In Me.GroupBox1.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
        Next
    End Sub
End Class



