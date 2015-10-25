Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    'Printing receipts

    Friend WithEvents prntDoc As New System.Drawing.Printing.PrintDocument
    Friend Print_Image As Image
    Declare Auto Function BitBlt Lib "GDI32.DLL" (
    ByVal hdcDest As IntPtr,
        ByVal nXDest As Integer,
        ByVal nYDest As Integer,
        ByVal nWidth As Integer,
        ByVal nHeight As Integer,
       ByVal hdcSrc As IntPtr,
       ByVal nXSrc As Integer,
       ByVal nYSrc As Integer,
       ByVal dwRop As Int32) As Boolean

    'Items on List

    'Item 1
    Private Sub btnItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem1.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 50 'Initiate price
        Dim sProductName As String = "Spaghetti" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item1" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item1")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item1")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item1")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item1")).SubItems(1).Text)
        End If


    End Sub

    'Item 2 
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btnItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem2.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 30 'Initiate price
        Dim sProductName As String = "Burger" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item2" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            'computation, be sure na palitan mo ung item id ah
            ListView1.Items(ListView1.Items.IndexOfKey("item2")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item2")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item2")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item2")).SubItems(1).Text)
        End If
    End Sub

    'Item 3
    Private Sub btnItem3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem3.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 10 'Initiate price
        Dim sProductName As String = "French Fries" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item3" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item3")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item3")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item3")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item3")).SubItems(1).Text)
        End If
    End Sub

    'Item 4
    Private Sub btnItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem4.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Hotdog Sandwich" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item4" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text)
        End If

    End Sub

    'Item 5
    Private Sub btnItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem5.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 5" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item5" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item5")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item5")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item5")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item5")).SubItems(1).Text)
        End If
    End Sub

    'Item 6
    Private Sub btnItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem6.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 6" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item6" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item6")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item6")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item6")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item6")).SubItems(1).Text)
        End If
    End Sub
    'Item 7
    Private Sub btnItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem7.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 7" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item7" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item7")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item7")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item7")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item7")).SubItems(1).Text)
        End If
    End Sub

    'Item 8
    Private Sub btnItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem8.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 8" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item8" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item8")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item8")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item8")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item8")).SubItems(1).Text)
        End If
    End Sub
    'Item 9
    Private Sub btnItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem9.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 9" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item9" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item9")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item9")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item9")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item9")).SubItems(1).Text)
        End If
    End Sub

    'Item 10
    Private Sub btnItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem10.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 10" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item10" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item10")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item10")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item10")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item10")).SubItems(1).Text)
        End If
    End Sub

    'Item 11
    Private Sub btnItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem11.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 11" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item11" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item11")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item11")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item11")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item11")).SubItems(1).Text)
        End If
    End Sub

    'Item 12
    Private Sub btnItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem12.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 12" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item12" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item12")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item12")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item12")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item12")).SubItems(1).Text)
        End If
    End Sub

    'Item 13
    Private Sub btnItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem13.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 13" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item13" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item13")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item13")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item13")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item13")).SubItems(1).Text)
        End If
    End Sub

    'Item 14
    Private Sub btnItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem14.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 14" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item14" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item14")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item14")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item14")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item14")).SubItems(1).Text)
        End If
    End Sub

    'Item 15
    Private Sub btnItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem15.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 15" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item15" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item15")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item15")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item15")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item15")).SubItems(1).Text)
        End If
    End Sub

    'Item 16
    Private Sub btnItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem16.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 1 'Initiate price
        Dim sProductName As String = "Item 16" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "item16" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("item16")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item16")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("item16")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item16")).SubItems(1).Text)
        End If
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        For lCount = ListView1.Items.Count - 1 To 0 Step -1
            If ListView1.Items(lCount).Selected Then
                ListView1.Items(lCount).Remove()

            End If

            Application.DoEvents()

        Next

        'Dim TempQuantity As Integer = 1 'Inititiate quantity
        'Dim Price As Integer = 1 'Initiate price
        'Dim ProductName As String = "Palaka" 'Name ng product
        'Dim BagongList As ListViewItem = New ListViewItem(ProductName)
        'BagongList.Name = "Baglist" 'unique Id importante to

        'If ListView1.SelectedItems.ContainsKey("BagList") = True Then
        '    ListView1.Items.RemoveByKey("BagList")
        'End If

        'If ListView1.Items.ContainsKey(BagongList.Name) = False Then
        '    ListView1.Items.Remove(BagongList)
        'Else
        '    ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text) - 1
        '    ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(2).Text = Price * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("item4")).SubItems(1).Text)
        'End If

        'ListView1.Items.Remove(ListView1.Items.IndexOfKey("item4"))
        'ListView1, items.remove(index#)
    End Sub



    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim dblTotal As Double = 0
        Dim dblTemp As Double

        For Each lvItem As ListViewItem In ListView1.Items
            If Double.TryParse(lvItem.SubItems(2).Text, dblTemp) Then
                dblTotal += dblTemp
            End If
        Next

        txtSubTotal.Text = dblTotal
        txtTax.Text = txtSubTotal.Text * 0.12
        txtNetSales.Text = txtSubTotal.Text - txtTax.Text
        Dim amount As String
        amount = txtAmountTendered.Text
        Console.ReadLine()

        If amount = " " Then
            MessageBox.Show("Please enter amount given")
            txtAmountTendered.Focus()
        End If
        txtChange.Text = amount - txtSubTotal.Text
    End Sub


    Private Sub btnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click

    End Sub


    Private Sub btnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewCustomer.Click
        ListView1.Items.Clear()
        txtSubTotal.Clear()
        txtTax.Clear()
        txtChange.Clear()
        txtNetSales.Clear()
        txtAmountTendered.Clear()
    End Sub


    Private Sub btnPrintReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReceipt.Click
        MakeImage()

    End Sub


    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub MakeImage()
        Dim prnDialog As New PrintDialog
        Application.DoEvents()
        Me.Refresh()
        Application.DoEvents()
        'Get a Graphics Object from the form
        Dim FormG As Graphics = ListView1.CreateGraphics
        'Create a bitmap from that graphics
        Dim i As New Bitmap(ListView1.Width, ListView1.Height, FormG)
        'Create a Graphics object in memory from that bitmap
        Dim memG As Graphics = Graphics.FromImage(i)
        'get the IntPtr's of the graphics
        Dim HDC1 As IntPtr = FormG.GetHdc
        Dim HDC2 As IntPtr = memG.GetHdc
        'get the picture
        BitBlt(HDC2, 0, 0, ListView1.ClientRectangle.Width, ListView1.ClientRectangle.Height, HDC1, 0, 0, 13369376)
        'Clone the bitmap so we can dispose this one
        Me.Print_Image = CType(i.Clone(), Image)
        'Clean Up
        FormG.ReleaseHdc(HDC1)
        memG.ReleaseHdc(HDC2)
        FormG.Dispose()
        memG.Dispose()
        i.Dispose()
        prnDialog.Document = prntDoc
        Dim r As DialogResult = prnDialog.ShowDialog
        If r = DialogResult.OK Then
            prntDoc.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Print_Image, 20, 90)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPdate.ValueChanged

    End Sub

    Dim connSource As String = "Data Source=D:\Documents\School\VB&ASP.net\POS\POS\Database\SalesDB.accdb; Provider=Microsoft.Jet.OLEDB.4.0"
    Dim con As OleDbConnection = New OleDbConnection(connSource)
    Dim cmd As OleDbCommand
    Dim adapted As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    'Form Load Database
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Dim connObject As OleDbConnection = New OleDbConnection(connSource)
        'Dim query As String = "SELECT * FROM Sales"
        'Dim sqlCommandObj As OleDbCommand = New OleDbCommand(query)
        'Dim dataAdaptObj As OleDbDataAdapter = New OleDbDataAdapter(sqlCommandObj)

        'Try
        '    sqlCommandObj.Connection = connObject
        '    connObject.Open()
        '    dataAdaptObj.SelectCommand = sqlCommandObj
        '    Dim dataSet As DataSet = New DataSet()
        '    dataAdaptObj.Fill(dataSet)
        '    'GridView1.DataSource = dataSet
        '    'GridView1.DataBind()
        '    connObject.Close()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Add(ByVal Item As String, ByVal Quantity As String, ByVal Amount As String)
        'SQL start
        Dim sql As String = "INSERT INTO ProductSales(Item, Quantity, Amount) VALUES(@Item, @Quantity, @Amount)"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@Item", colIN)
        cmd.Parameters.AddWithValue("@Quantity", colQnty)
        cmd.Parameters.AddWithValue("@Amount", colAMNT)

        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully added to Sales Database")
                colIN.Text = ""
                colQnty.Text = ""
                colAMNT.Text = ""

            End If
            con.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Sales(ByVal SubTotal As String, ByVal Tax As String, ByVal NetSales As String)
        Dim sql As String = "INSERT INTO Sales(SubTotal, Tax, NetSales) VALUES(@SubTotal, @Tax, @NetSales)"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@SubTotal", txtSubTotal.Text)
        cmd.Parameters.AddWithValue("@Tax", txtTax.Text)
        cmd.Parameters.AddWithValue("@NetSales", txtNetSales.Text)

        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Successfully added to Sales Database")
                txtSubTotal.Text = ""
                txtTax.Text = ""
                txtNetSales.Text = ""

            End If
            con.Close()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnCloseCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseCounter.Click
        Add(colIN.Text, colQnty.Text, colAMNT.Text)
        Sales(txtSubTotal.Text, txtTax.Text, txtNetSales.Text)
        'Dim i, sales As Integer
        'Dim item As String
        'Dim rw As DataRow

        'Add a new row to the Student table.
        'rw = DataSet11.Tables(0).NewRow
        ' sales = InputBox(txtSubTotal.Text)
        'item = InputBox(ListView1.Items.Add())
        'rw.Item("Sales") = sales
        'rw.Item("Item") = item
        'Try
        'DataSet11.Tables(0).Rows.Add(rw)
        'Update the Student table in the testdb database.
        'i = OleDbDataAdapter1.Update(DataSet11)
        'Catch ex As Exception
        ' MessageBox.Show(ex.Message)
        ''End Try
        'Displays number of rows updated. 
        'MessageBox.Show("no of rows updated=" & i)

        ' Dim grossSales As Integer = txtSubTotal.Text
        'Dim tax As Integer = txtTax.Text
        ' Dim netsales As String = txtNetSales.Text


    End Sub

    

End Class
