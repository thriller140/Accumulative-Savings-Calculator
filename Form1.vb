Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1
    Dim prices(100) As Integer
    Dim incomes(100) As Integer
    Dim pricesval(100) As String
    Dim incomesval(100) As String
    Dim pric_in As Integer = -1
    Dim inc_in As Integer = -1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("This program is used to calculate how much money you can spend so that you can reach your financial goal.")
    End Sub

    Function datenum(diff As DateInterval, secdate As Date, time As Decimal) As Integer
        Dim number As Decimal = 0
        number = DateDiff(diff, Now, secdate) / time
        Return Int(number)
    End Function
    'text file layout template
    'accusave
    'fin goal'
    '#'
    'due date'
    '#'
    'bills'
    '###'
    'miscb'
    '###'
    'income'
    '###'
    'misci'
    '###'
    'pric in'
    '#'
    'inc in'
    '#'
    'end'

    Private Sub readFile(loc As String)
        Dim Reader As New StreamReader(loc, False)
        Dim indexer(8) As String
        Dim ina As Integer = -1
        Dim inb As Integer = -1
        Dim res As Boolean = False
        For Each line As String In File.ReadLines(loc) 'loop through each line
            If line = "accusave" Then
                res = True
            End If
            If res = True Then
                If indexer(0) = "T" Then
                    fin_goal.Value = line
                    indexer(0) = ""
                End If
                If line = "fin goal" Then
                    indexer(0) = "T"
                End If
                If indexer(1) = "T" Then
                    duedate.Value = line
                    indexer(1) = ""
                End If
                If line = "due date" Then
                    indexer(1) = "T"
                End If
                If line = "end" Then
                    Exit For
                End If
                If indexer(7) = "T" Then
                    inc_in = line
                    indexer(7) = ""
                End If
                If line = "inc in" Then
                    indexer(7) = "T"
                End If
                If indexer(6) = "T" Then
                    pric_in = line
                    indexer(6) = ""
                End If
                If indexer(5) = "T" Then
                    If line = "pric in" Then
                        indexer(5) = ""
                        indexer(6) = "T"
                    Else
                        inb = inb + 1
                        incomes(inb) = Int(line.Substring(line.IndexOf("=") + 1))
                        getstorage.Items.Add(line)
                    End If
                End If
                If indexer(4) = "T" Then
                    If line = "misci" Then
                        indexer(4) = ""
                        indexer(5) = "T"
                    Else
                        inb = inb + 1
                        incomesval(inb) = line
                        incomes(inb) = Int(line.Substring(line.IndexOf("=") + 1))
                        incomestorage.Items.Add(line)
                    End If
                End If
                If indexer(3) = "T" Then
                    If line = "income" Then
                        indexer(3) = ""
                        indexer(4) = "T"
                    Else
                        ina = ina + 1
                        prices(ina) = Int(line.Substring(line.IndexOf("=") + 1))
                        miscstorage.Items.Add(line)
                    End If
                End If
                If indexer(2) = "T" Then
                    If line = "miscb" Then
                        indexer(2) = ""
                        indexer(3) = "T"
                    Else
                        ina = ina + 1
                        pricesval(ina) = line
                        prices(ina) = Int(line.Substring(line.IndexOf("=") + 1))
                        billstorage.Items.Add(line)
                    End If
                End If
                If line = "bills" Then
                    indexer(2) = "T"
                End If
            Else
                MsgBox("file is not compatible with this program")
            End If
        Next
        Reader.Close()
    End Sub

    Private Sub writeFile(loc As String)
        Dim Writer As New StreamWriter(loc)
        Dim finalstr As New Text.StringBuilder()
        Dim str As String
        str = finalstr.Append("accusave").Append(vbNewLine).Append("fin goal").Append(vbNewLine).Append(fin_goal.Value).Append(vbNewLine).Append("due date").Append(vbNewLine).Append(duedate.Value).Append(vbNewLine).Append("bills").Append(vbNewLine).ToString()
        For i = 0 To pric_in
            str = str & pricesval(i) & vbNewLine
        Next
        str = str & "miscb" & vbNewLine
        For i = 0 To miscstorage.Items.Count - 1
            str = str & CStr(miscstorage.Items(i)) & vbNewLine
        Next
        str = str & "income" & vbNewLine
        For i = 0 To inc_in
            str = str & incomesval(i) & vbNewLine
        Next
        str = str & "misci" & vbNewLine
        For i = 0 To getstorage.Items.Count - 1
            str = str & CStr(getstorage.Items(i)) & vbNewLine
        Next
        str = str & "pric in" & vbNewLine & pric_in & vbNewLine
        str = str & "inc in" & vbNewLine & inc_in & vbNewLine
        str = str & "end" & vbNewLine
        MsgBox(str)
        Writer.Write(str)
        Writer.Close()
    End Sub

    Private Sub billbtn_Click(sender As Object, e As EventArgs) Handles billbtn.Click
        Dim secondDate As Date = duedate.Value ''#8/12/2015#
        If billstorage.Items.Contains(titlebill.Text & " Pay " & paybill.Value & " Every " & timebill.Value & " " & formatbill.GetItemText(formatbill.SelectedItem)) = True Then
            MsgBox("You already entered in this bill")
        Else
            If formatbill.GetItemText(formatbill.SelectedItem) = "Month(s)" Then
                pric_in = pric_in + 1
                prices(pric_in) = datenum(DateInterval.Month, secondDate, timebill.Value) * paybill.Value
            ElseIf formatbill.GetItemText(formatbill.SelectedItem) = "Year(s)" Then
                pric_in = pric_in + 1
                prices(pric_in) = datenum(DateInterval.Year, secondDate, timebill.Value) * paybill.Value
            ElseIf formatbill.GetItemText(formatbill.SelectedItem) = "Week(s)" Then
                pric_in = pric_in + 1
                prices(pric_in) = datenum(DateInterval.Weekday, secondDate, timebill.Value) * paybill.Value
            End If
            MsgBox("total price = " & prices(pric_in))
            pricesval(pric_in) = titlebill.Text & " Pay " & paybill.Value & " Every " & timebill.Value & " " & formatbill.GetItemText(formatbill.SelectedItem) & " =" & prices(pric_in)
            billstorage.Items.Add(titlebill.Text & " Pay " & paybill.Value & " Every " & timebill.Value & " " & formatbill.GetItemText(formatbill.SelectedItem) & " =" & prices(pric_in))
            ' billstorage.Text &= titlebill.Text & " Pay " & paybill.Value & " Every " & timebill.Value & " " & formatbill.GetItemText(formatbill.SelectedItem) & vbNewLine
        End If
        titlebill.Text = ""
        paybill.Value = 0
        timebill.Value = 0
        formatbill.SelectedIndex = -1
    End Sub

    Private Sub miscbtn_Click(sender As Object, e As EventArgs) Handles miscbtn.Click
        If miscstorage.Items.Contains(titlemisc.Text & " Pay " & paymisc.Value) = True Then
            MsgBox("You already entered in this misc")
        Else
            pric_in = pric_in + 1
            prices(pric_in) = paymisc.Value
            pricesval(pric_in) = titlemisc.Text & " Pay " & paymisc.Value & " =" & prices(pric_in)
            miscstorage.Items.Add(titlemisc.Text & " Pay " & paymisc.Value & " =" & prices(pric_in))
            'miscstorage.Text &= titlemisc.Text & " Pay " & paymisc.Value & vbNewLine
        End If
        titlemisc.Text = ""
        paymisc.Value = 0
    End Sub
    Sub refresh_arr(Optional collection As String = "")
        Dim collect As String
        For i = 0 To pric_in
            If prices(i) <> 0 Then
                collect += pricesval(i) & vbNewLine
            End If
            If incomes(i) <> 0 Then
                collect += incomesval(i) & vbNewLine
            End If
        Next
        MsgBox(collect)
    End Sub
    Private Sub calcsubmit_Click(sender As Object, e As EventArgs) Handles calcsubmit.Click
        refresh_arr()
        Dim total_in As Integer = 0
        Dim total_bill As Integer = 0
        Dim excess As Integer = 0
        Dim msg As String = ""
        For i = 0 To prices.Length - 1
            total_bill += prices(i)
        Next
        For i = 0 To incomes.Length - 1
            total_in += incomes(i)
        Next
        excess = total_in - total_bill
        If (excess - fin_goal.Value) < 0 Then
            msg = "You will save a total of: $" & Str(excess) & vbNewLine & " Which transnaltes to" & vbNewLine & Str(excess - fin_goal.Value) & vbNewLine & "You will not reach your financial goal"
        Else
            msg = "You will save a total of: $" & Str(excess) & vbNewLine & " You wil have a excess of $" & Str(excess - fin_goal.Value) & vbNewLine & "You will reach your financial goal"
        End If
        ''generate word doc template
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add



        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Accumulative Financial Projection"
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "This is a table of what your finances will look like on a weekly basis up to the due date."
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert a 5 x 2 table, fill it with data, and change the column widths.
        Dim loop_num As Integer
        Dim target_num(100) As Integer
        Dim index As Integer = -1
        If datenum(DateInterval.Year, duedate.Value, 1) > 0 Then
            loop_num = 3
            index = index + 1
            target_num(index) = datenum(DateInterval.Year, duedate.Value, 1)
            index = index + 1
            target_num(index) = datenum(DateInterval.Month, duedate.Value, 1)
            index = index + 1
            target_num(index) = datenum(DateInterval.Weekday, duedate.Value, 1)
        ElseIf datenum(DateInterval.Month, duedate.Value, 1) > 0 Then
            loop_num = 2
            index = index + 1
            target_num(index) = datenum(DateInterval.Month, duedate.Value, 1)
            index = index + 1
            target_num(index) = datenum(DateInterval.Weekday, duedate.Value, 1)
        ElseIf datenum(DateInterval.Weekday, duedate.Value, 1) > 0 Then
            loop_num = 1
            index = index + 1
            target_num(index) = datenum(DateInterval.Weekday, duedate.Value, 1)
        End If
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 2, loop_num)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        For r = 1 To 2
            For c = 1 To loop_num
                If r = 1 Then
                    If c = 1 Then
                        oTable.Cell(r, c).Range.Text = "Week"
                    ElseIf c = 2 Then
                        oTable.Cell(r, c).Range.Text = "Month"
                    Else
                        oTable.Cell(r, c).Range.Text = "Year"
                    End If
                Else
                    If loop_num = 1 Then
                        If c = 1 Then
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(0))
                        End If
                    ElseIf loop_num = 2
                        If c = 1 Then
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(1))
                        ElseIf c = 2 Then
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(0))
                        End If
                    ElseIf loop_num = 3 Then
                        If c = 1 Then
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(2))
                        ElseIf c = 2 Then
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(1))
                        ElseIf c = 3
                            oTable.Cell(r, c).Range.Text = "$" & Math.Round(excess / target_num(0))
                        End If
                    End If
                End If
                '' oTable.Cell(r, c).Range.Text += "r" & r & "c" & c
            Next
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)


        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.InsertAfter("THE END.")

    End Sub

    Private Sub incomebtn_Click(sender As Object, e As EventArgs) Handles incomebtn.Click
        Dim secondDate As Date = duedate.Value ''#8/12/2015#
        If incomestorage.Items.Contains(titleincome.Text & " Get " & getincome.Value & " Every " & timeincome.Value & " " & formatincome.GetItemText(formatincome.SelectedItem)) = True Then
            MsgBox("You already entered in this bill")
        Else
            If formatincome.GetItemText(formatincome.SelectedItem) = "Month(s)" Then
                inc_in = inc_in + 1
                incomes(inc_in) = datenum(DateInterval.Month, secondDate, timeincome.Value) * getincome.Value
            ElseIf formatincome.GetItemText(formatincome.SelectedItem) = "Year(s)" Then
                inc_in = inc_in + 1
                incomes(inc_in) = datenum(DateInterval.Year, secondDate, timeincome.Value) * getincome.Value
            ElseIf formatincome.GetItemText(formatincome.SelectedItem) = "Week(s)" Then
                inc_in = inc_in + 1
                incomes(inc_in) = datenum(DateInterval.Weekday, secondDate, timeincome.Value) * getincome.Value
            End If
            MsgBox("total income_price = " & incomes(inc_in))
            incomesval(inc_in) = titleincome.Text & " Get " & getincome.Value & " Every " & timeincome.Value & " " & formatincome.GetItemText(formatincome.SelectedItem) & " =" & incomes(inc_in)
            incomestorage.Items.Add(titleincome.Text & " Get " & getincome.Value & " Every " & timeincome.Value & " " & formatincome.GetItemText(formatincome.SelectedItem) & " =" & incomes(inc_in))
            '  incomestorage.Text &= titleincome.Text & " Get " & getincome.Value & " Every " & timeincome.Value & " " & formatincome.GetItemText(formatincome.SelectedItem) & vbNewLine
        End If
        titleincome.Text = ""
        getincome.Value = 0
        timeincome.Value = 0
        formatincome.SelectedIndex = -1
    End Sub

    Private Sub getbtn_Click(sender As Object, e As EventArgs) Handles getbtn.Click
        If getstorage.Items.Contains(titleget.Text & " Get " & getmisc.Value) = True Then
            MsgBox("You already entered in this misc")
        Else
            inc_in = inc_in + 1
            incomes(inc_in) = getmisc.Value
            incomesval(inc_in) = titleget.Text & " Get " & getmisc.Value & " =" & incomes(inc_in)
            getstorage.Items.Add(titleget.Text & " Get " & getmisc.Value & " =" & incomes(inc_in))
            ' getstorage.Text &= titleget.Text & " Pay " & getmisc.Value & vbNewLine
        End If
        titleget.Text = ""
        getmisc.Value = 0
    End Sub

    Private Sub billstorage_DoubleClick(sender As Object, e As EventArgs) Handles billstorage.DoubleClick
        If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo) = 6 Then '6 is yes 7 is no
            For i = 0 To pric_in
                If pricesval(i) = billstorage.SelectedItem Then
                    prices(i) = 0
                    pricesval(i) = ""
                    Exit For
                End If
            Next
            billstorage.Items.Remove(billstorage.SelectedItem)
        End If
    End Sub

    Private Sub miscstorage_DoubleClick(sender As Object, e As EventArgs) Handles miscstorage.DoubleClick
        If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo) = 6 Then '6 is yes 7 is no
            For i = 0 To pric_in
                If pricesval(i) = miscstorage.SelectedItem Then
                    prices(i) = 0
                    pricesval(i) = ""
                    Exit For
                End If
            Next
            miscstorage.Items.Remove(miscstorage.SelectedItem)
        End If
    End Sub

    Private Sub incomestorage_DoubleClick(sender As Object, e As EventArgs) Handles incomestorage.DoubleClick
        If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo) = 6 Then '6 is yes 7 is no
            For i = 0 To inc_in
                If incomesval(i) = incomestorage.SelectedItem Then
                    incomes(i) = 0
                    incomesval(i) = ""
                    Exit For
                End If
            Next
            incomestorage.Items.Remove(incomestorage.SelectedItem)
        End If
    End Sub

    Private Sub getstorage_DoubleClick(sender As Object, e As EventArgs) Handles getstorage.DoubleClick
        If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo) = 6 Then '6 is yes 7 is no
            For i = 0 To inc_in
                If incomesval(i) = getstorage.SelectedItem Then
                    incomes(i) = 0
                    incomesval(i) = ""
                    Exit For
                End If
            Next
            getstorage.Items.Remove(getstorage.SelectedItem)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click '
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        readFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        writeFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(datenum(DateInterval.Year, duedate.Value, 1))
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Array.Clear(prices, 0, 100)
        Array.Clear(incomes, 0, 100)
        Array.Clear(pricesval, 0, 100)
        Array.Clear(incomesval, 0, 100)
        pric_in = -1
        inc_in = -1
        fin_goal.Value = 0
        duedate.Value = Today
        billstorage.Items.Clear()
        miscstorage.Items.Clear()
        incomestorage.Items.Clear()
        getstorage.Items.Clear()
    End Sub
End Class
