Imports System.Text
Imports System.Data
Imports System.Object
Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Cursor = Cursors.WaitCursor

        Dim con As New SqlClient.SqlConnection("Server=172.16.0.130;Database=I3_IC;User ID=renier;Password=v0xc0re;Trusted_Connection=False;Connection Timeout=10000;")

        ' Display the ProgressBar control.
        ProgressBar1.Visible = True
       
        ' Set Maximum to the total number of files to copy.
        ProgressBar1.Maximum = 50
        ' Set the initial value of the ProgressBar.
        ProgressBar1.Value = 0
        

        Try
            con.Open()
            


            Dim dat As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select RecordingFileName from recordingdata inner join RecordingCall on RecordingCall.recordingid = recordingdata.recordingid where ANI LIKE'%" & TextBox1.Text & "%' and (RecordingDate BETWEEN '" & DateTimePicker1.Value & "' AND '" & DateTimePicker2.Value & "')", con)
            dat.SelectCommand.CommandTimeout = 10000
            Dim dt As New DataSet
            dat.Fill(dt, "recordingdata")



            Dim str As New StringBuilder
            str.AppendLine()
            For Each dr As DataRow In dt.Tables("recordingdata").Rows

                For Each field As Object In dr.ItemArray
                    str.Append(field.ToString & ",")
                Next
                str.Replace(",", vbNewLine, str.Length - 1, 1)
            Next


            My.Computer.FileSystem.WriteAllText("C:\CICRecordings\recordings.txt", str.ToString, False)

            Dim dat2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select RecordingDate from recordingdata inner join RecordingCall on RecordingCall.recordingid = recordingdata.recordingid where ANI LIKE'%" & TextBox1.Text & "%' and (RecordingDate BETWEEN '" & DateTimePicker1.Value & "' AND '" & DateTimePicker2.Value & "')", con)
            dat2.SelectCommand.CommandTimeout = 10000
            Dim dt2 As New DataSet
            dat2.Fill(dt2, "RecordingTitle")

            Dim str2 As New StringBuilder
            str2.AppendLine()
            For Each dr As DataRow In dt2.Tables("RecordingTitle").Rows

                For Each field As Object In dr.ItemArray
                    str2.Append(field.ToString & ",")
                    ProgressBar1.Value += 1
                Next
                str2.Replace(",", vbNewLine, str2.Length - 1, 1)
            Next

            My.Computer.FileSystem.WriteAllText("C:\CICRecordings\RecordingTitle.txt", str2.ToString, False)

            

            ' Loop through all files to copy.
            Dim x As Integer
            For x = 1 To str.Length - 1
                ' Copy the file and increment the ProgressBar if successful.
                If dt.Tables.Count = 1 Then
                    ' Perform the increment on the ProgressBar.
                    ProgressBar1.PerformStep()
                End If
            Next x










            Dim wsh
            wsh = CreateObject("WScript.Shell")
            wsh.Run("C:\CICRecordings\decript", 0, 1)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try


        Me.Cursor = Cursors.Default

        MsgBox("The Recordings have been saved")



    End Sub

    Private Function NorthwindDataSet() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Shell("explorer C:\CICRecordings\recordings", vbNormalFocus)

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Cursor = Cursors.WaitCursor

        Dim con As New SqlClient.SqlConnection("Server=172.16.0.130;Database=I3_IC;User ID=renier;Password=v0xc0re;Trusted_Connection=False;Connection Timeout=10000;")



        Try
            con.Open()


            Dim dat2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select CallDirection, LocaluserID, RemoteNumber from CallDetail where LIKE'%" & TextBox1.Text & "%' and (InitiatedDate BETWEEN '" & DateTimePicker1.Value & "' AND '" & DateTimePicker2.Value & "')", con)
            dat2.SelectCommand.CommandTimeout = 10000
            Dim dt2 As New DataSet
            dat2.Fill(dt2, "CallDetail")

            Dim str2 As New StringBuilder
            str2.AppendLine()
            For Each dr2 As DataRow In dt2.Tables("CallDetail").Rows

                For Each field As Object In dr2.ItemArray
                    str2.Append(field.ToString & ",")
                Next
                str2.Replace(",", vbNewLine, str2.Length - 1, 1)
            Next
            My.Computer.FileSystem.WriteAllText("C:\CICRecordings\detail.csv", str2.ToString, False)


        Finally
            con.Close()
        End Try
        Me.Cursor = Cursors.Default

        MsgBox("The Recordings Detail has been saved")

    End Sub
End Class
