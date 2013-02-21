Imports System.Text
Imports System.Data
Imports System.Object

Public Class Form4



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        Dim con As New SqlClient.SqlConnection("Server=172.16.2.22;Database=VCMLOG;User ID=vcm;Password=0011708;Trusted_Connection=False;")
        If ComboBox1.Text = "ALL Outages" Then
            Try
                con.Open()

                Dim dateOne As DateTime = DateTimePicker1.Value.Date
                Dim dateTwo As DateTime = DateTimePicker2.Value.Date



                Dim dat As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("Select * FROM VCMLog WHERE dbDate BETWEEN CONVERT(VARCHAR(10),'" & dateOne & "', 103) and CONVERT(VARCHAR(10),'" & DateTimePicker2.Value.Date & "',103)", con)
                Dim dt As New DataSet
                dat.Fill(dt, "VCMLog")






                Dim str As New StringBuilder

                For Each dr As DataRow In dt.Tables("VCMLog").Rows
                    For Each field As Object In dr.ItemArray
                        str.Append(field.ToString & ",")
                    Next
                    str.Replace(",", vbNewLine, str.Length - 1, 1)
                Next



                My.Computer.FileSystem.WriteAllText("C:\temp\OutageReport.csv", str.ToString, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()


            End Try

        End If


        Dim con2 As New SqlClient.SqlConnection("Server=172.16.2.22;Database=VCMLOG;User ID=vcm;Password=0011708;Trusted_Connection=False;")
        If ComboBox1.Text <> "ALL Outages" Then
            Try
                con2.Open()

                Dim dateOne As DateTime = DateTimePicker1.Value.Date
                Dim dateTwo As DateTime = DateTimePicker2.Value.Date



                Dim dat As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("Select * FROM VCMLog WHERE dbOutage like '" & ComboBox1.Text & "' and dbDate BETWEEN CONVERT(VARCHAR(10),'" & dateOne & "', 103) and CONVERT(VARCHAR(10),'" & DateTimePicker2.Value.Date & "',103)", con)
                Dim dt As New DataSet
                dat.Fill(dt, "VCMLog")






                Dim str As New StringBuilder

                For Each dr As DataRow In dt.Tables("VCMLog").Rows
                    For Each field As Object In dr.ItemArray
                        str.Append(field.ToString & ",")
                    Next
                    str.Replace(",", vbNewLine, str.Length - 1, 1)
                Next



                My.Computer.FileSystem.WriteAllText("C:\temp\OutageReport.csv", str.ToString, False)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con2.Close()


            End Try

        End If


        MsgBox("Outage Report has been saved to C:\Temp\OutageReport.csv")


    End Sub

    Private Function NorthwindDataSet() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


