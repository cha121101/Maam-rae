Imports System.Data
Imports Npgsql


Public Class Form1

    Dim lv As ListViewItem
    Dim Selected As String

    Private Sub ExecutedNonQuery(query As String)
        openCon()
        cmd = New NpgsqlCommand(query, cn)
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub ClearAllTextbox()
        Me.txtempno.ResetText()
        Me.txtlastname.ResetText()
        Me.txtfirstname.ResetText()
        Me.txtmiddle.ResetText()
        Me.txtaddress.ResetText()
        Me.cmbgender.ResetText()
        Me.txtcontact.ResetText()
        Me.cmbposition.ResetText()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poplistview()
    End Sub

    Private Sub Poplistview()

        ListView1.Clear()

        With ListView1
            .HideSelection = True
            .FullRowSelect = True
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Lastname", 110)
            .Columns.Add("Firstname", 110)
            .Columns.Add("Middlename", 110)
            .Columns.Add("Adress", 150)
            .Columns.Add("Gender", 100)
            .Columns.Add("Contact no.", 110)
            .Columns.Add("Position", 110)
        End With

        openCon()
        sql = "Select * FROM tblempinfo"
        cmd = New NpgsqlCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("empno").ToString)
            lv.SubItems.Add(dr("emplastname"))
            lv.SubItems.Add(dr("empfirstname"))
            lv.SubItems.Add(dr("empmidinitial"))
            lv.SubItems.Add(dr("empaddress"))
            lv.SubItems.Add(dr("empgender"))
            lv.SubItems.Add(dr("empcontact"))
            lv.SubItems.Add(dr("empposition"))
            ListView1.Items.Add(lv)
        Loop
        cn.Close()
    End Sub



    Private Sub btnaddnewemp_Click(sender As Object, e As EventArgs) Handles btnaddnewemp.Click
        If MsgBox("Are you sure to save this record?", (vbQuestion + vbYesNo)) = vbYes Then
            openCon()
            sql = "INSERT INTO tblempinfo (empno, emplastname, empfirstname, empmidinitial, empaddress, empgender, empcontact, empposition) VALUES(" & Me.txtempno.Text & ", '" & (Me.txtlastname.Text) & "','" & (Me.txtfirstname.Text) & "','" & (Me.txtmiddle.Text) & "','" & (Me.txtaddress.Text) & "','" & (Me.cmbgender.Text) & "','" & (Me.txtcontact.Text) & "','" & (Me.cmbposition.Text) & "')"
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()

        End If
        Poplistview()
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1

            Selected = ListView1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tblempinfo where empno = " & Selected & " "
            cmd = New NpgsqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            dr.Read()
            Me.txtempno.Text = dr("empno")
            Me.txtlastname.Text = dr("emplastname")
            Me.txtfirstname.Text = dr("empfirstname")
            Me.txtmiddle.Text = dr("empmidinitial")
            Me.txtaddress.Text = dr("empaddress")
            Me.cmbgender.Text = dr("empgender")
            Me.txtcontact.Text = dr("empcontact")
            Me.cmbposition.Text = dr("empposition")

            cn.Close()
        Next

    End Sub

    Private Sub btnupdateemp_Click(sender As Object, e As EventArgs) Handles btnupdateemp.Click
        If MsgBox("Are you sure to Update this?", (vbQuestion + vbYesNo)) = vbYes Then

            Dim query As String = "UPDATE tblempinfo SET empno = '" & (Me.txtempno.Text) & "', emplastname = '" & (Me.txtlastname.Text) & "', empfirstname = '" & (Me.txtfirstname.Text) & "', empmidinitial = '" & (Me.txtmiddle.Text) & "', empaddress = '" & (Me.txtaddress.Text) & "', empgender = '" & (Me.cmbgender.Text) & "', empcontact = '" & (Me.lblcontact.Text) & "', empposition = '" & (Me.cmbposition.Text) & "' WHERE empno = ' " & (Me.txtempno.Text) & " '"
            ExecutedNonQuery(query)
            ClearAllTextbox()
        End If
        Poplistview()
    End Sub

    Private Sub btndeleteemp_Click(sender As Object, e As EventArgs) Handles btndeleteemp.Click
        If MsgBox("Are you sure to delete this?", (vbQuestion + vbYesNo)) = vbYes Then
            Dim query As String = "DELETE FROM tblempinfo WHERE empno = ' " & (txtempno.Text) & " ' "
            ExecutedNonQuery(query)
            ClearAllTextbox()


        End If
        Poplistview()

    End Sub

    Private Sub cmbposition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbposition.SelectedIndexChanged

    End Sub

    Private Sub cmbcourse_Click(sender As Object, e As EventArgs) Handles lblposition.Click

    End Sub

    Private Sub lvlempno_Click(sender As Object, e As EventArgs) Handles lblempno.Click

    End Sub

    Private Sub contact_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub lblmi_Click(sender As Object, e As EventArgs) Handles lblmi.Click

    End Sub
End Class
