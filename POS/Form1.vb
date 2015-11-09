Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    'Items on List

    'Fried Chicken
    Private Sub btnItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem5.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 70 'Initiate price
        Dim sProductName As String = "Fried Chicken" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Fried Chicken" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Fried Chicken")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Fried Chicken")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Fried Chicken")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Fried Chicken")).SubItems(1).Text)
        End If
    End Sub

    'Spaghetti
    Private Sub btnItemSpag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemSpag.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 30 'Initiate price
        Dim sProductName As String = "Spaghetti" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Spaghetti" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            'computation, be sure na palitan mo ung item id ah
            ListView1.Items(ListView1.Items.IndexOfKey("Spaghetti")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Spaghetti")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Spaghetti")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Spaghetti")).SubItems(1).Text)
        End If
    End Sub

    'Burger
    Private Sub btnItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem2.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 30 'Initiate price
        Dim sProductName As String = "Burger" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Burger" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            'computation, be sure na palitan mo ung item id ah
            ListView1.Items(ListView1.Items.IndexOfKey("Burger")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Burger")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Burger")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Burger")).SubItems(1).Text)
        End If
    End Sub

    'Pizza
    Private Sub btnItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem6.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 45 'Initiate price
        Dim sProductName As String = "Pizza" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Pizza" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Pizza")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Pizza")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Pizza")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Pizza")).SubItems(1).Text)
        End If
    End Sub

    'French Fries
    Private Sub btnItem3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem3.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 25 'Initiate price
        Dim sProductName As String = "French Fries" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "French Fries" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("French Fries")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("French Fries")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("French Fries")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("French Fries")).SubItems(1).Text)
        End If
    End Sub

    'Hotdog Sandwich
    Private Sub btnItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem4.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 35 'Initiate price
        Dim sProductName As String = "Hotdog Sandwich" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Hotdog Sandwich" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Hotdog Sandwich")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Hotdog Sandwich")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Hotdog Sandwich")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Hotdog Sandwich")).SubItems(1).Text)
        End If

    End Sub

    'Tuna Sandwich
    Private Sub btnItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem12.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 30 'Initiate price
        Dim sProductName As String = "Tuna Sandwich" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Tuna Sandwich" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Tuna Sandwich")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Tuna Sandwich")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Tuna Sandwich")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Tuna Sandwich")).SubItems(1).Text)
        End If
    End Sub

    'Ham Sandwich
    Private Sub btnItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem9.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 35 'Initiate price
        Dim sProductName As String = "Ham Sandwich" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Ham Sandwich" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Ham Sandwich")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Ham Sandwich")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Ham Sandwich")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Ham Sandwich")).SubItems(1).Text)
        End If
    End Sub

    'Carbonara
    Private Sub btnItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem8.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 35 'Initiate price
        Dim sProductName As String = "Carbonara" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Carbonara" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Carbonara")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Carbonara")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Carbonara")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Carbonara")).SubItems(1).Text)
        End If
    End Sub

    'Palabok
    Private Sub btnItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem11.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 35 'Initiate price
        Dim sProductName As String = "Palabok" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Palabok" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Palabok")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Palabok")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Palabok")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Palabok")).SubItems(1).Text)
        End If
    End Sub

    'Caesar Salad
    Private Sub btnItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem7.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 30 'Initiate price
        Dim sProductName As String = "Caesar Salad" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Caesar Salad" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Caesar Salad")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Caesar Salad")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Caesar Salad")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Caesar Salad")).SubItems(1).Text)
        End If
    End Sub

    'Macaroni Salad
    Private Sub btnItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem10.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 25 'Initiate price
        Dim sProductName As String = "Macaroni Salad" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Macaroni Salad" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Macaroni Salad")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Macaroni Salad")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Macaroni Salad")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Macaroni Salad")).SubItems(1).Text)
        End If
    End Sub

    'Coke
    Private Sub btnItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem13.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 15 'Initiate price
        Dim sProductName As String = "Coke" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Coke" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Coke")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Coke")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Coke")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Coke")).SubItems(1).Text)
        End If
    End Sub

    'Sprite
    Private Sub btnItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem14.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 15 'Initiate price
        Dim sProductName As String = "Sprite" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Sprite" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Sprite")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Sprite")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Sprite")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Sprite")).SubItems(1).Text)
        End If
    End Sub

    'Royal
    Private Sub btnItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem15.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 15 'Initiate price
        Dim sProductName As String = "Royal" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Royal" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Royal")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Royal")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Royal")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Royal")).SubItems(1).Text)
        End If
    End Sub

    'Iced Tea
    Private Sub btnItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem16.Click
        Dim nTempQuantity As Integer = 1 'Inititiate quantity
        Dim nPrice As Integer = 15 'Initiate price
        Dim sProductName As String = "Iced Tea" 'Name ng product
        Dim newList As ListViewItem = New ListViewItem(sProductName)
        newList.Name = "Iced Tea" 'unique Id importante to
        newList.SubItems.Add(nTempQuantity)
        newList.SubItems.Add(nPrice)

        If ListView1.Items.ContainsKey(newList.Name) = False Then
            ListView1.Items.Add(newList)
        Else
            ListView1.Items(ListView1.Items.IndexOfKey("Iced Tea")).SubItems(1).Text = Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Iced Tea")).SubItems(1).Text) + 1
            ListView1.Items(ListView1.Items.IndexOfKey("Iced Tea")).SubItems(2).Text = nPrice * Integer.Parse(ListView1.Items(ListView1.Items.IndexOfKey("Iced Tea")).SubItems(1).Text)
        End If
    End Sub

    Private Sub btnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveItem.Click
        Dim look As Integer = ListView1.FocusedItem.Index
        ListView1.Items.RemoveAt(look)
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

        Try
            If amount <= " " Then
                MsgBox("Please enter amount given")
                txtAmountTendered.Focus()
            End If
            txtChange.Text = amount - txtSubTotal.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
        Form2.Show()
    End Sub


    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        'PrintPreviewDialog1.Show()
    End Sub

    Private Sub Add(ByVal Item As String, ByVal Quantity As String, ByVal Amount As String)

    End Sub

    'Global Declaration
    Dim constring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\School\Thesis\POS\POS\Database\SalesDB.mdb"
    Dim con As OleDbConnection = New OleDbConnection(constring)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    Private Sub Sales(ByVal SubTotal As String, ByVal Tax As String, ByVal NetSales As String)
        'Sql statement
        'Dim sql As String = "INSERT INTO Sales(DatePurchased, TimePurchased, SubTotal, Tax, NetSales) VALUES (@System.DateTime.Now.ToLongDateString, @System.DateTime.Now.ToLongTimeString, @subtotal, @tax, @netsales)"

        Dim sql As String = "INSERT INTO Sales(DatePurchased, TimePurchased, SubTotal, Tax, NetSales) VALUES ('" & System.DateTime.Now.ToLongDateString & "', '" & System.DateTime.Now.ToLongTimeString & "','" & txtSubTotal.Text & "', '" & txtTax.Text & "', '" & txtNetSales.Text & "' )"
        cmd = New OleDbCommand(Sql, con)

        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Sales successfully updated")


                txtSubTotal.Text = ""
                txtTax.Text = ""
                txtNetSales.Text = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub ProductSales()
        Dim lvitem As Object
        Dim iCount As Integer
        Dim iLoop As Integer
        Dim Sql As String
        cmd = New OleDbCommand(Sql, con)

        iCount = ListView1.Items.Count()
        If Not ListView1.Items.Count = 0 Then
            Do Until iLoop = ListView1.Items.Count
                lvitem = ListView1.Items.Item(iLoop)
                With lvitem
                    Sql = "insert into ProductSales(Item,Quantity,Amount) values('" & .SubItems(0).Text & "','" & .SubItems(1).Text & "','" & .SubItems(2).Text & "')"
                End With
                iLoop = iLoop + 1
                lvitem = Nothing
            Loop
        End If
        MessageBox.Show("Record Saved!")

    End Sub
    Private Sub btnCloseCounter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseCounter.Click
        Sales(txtSubTotal.Text, txtTax.Text, txtNetSales.Text)

        ListView1.Items.Clear()
        txtSubTotal.Clear()
        txtTax.Clear()
        txtChange.Clear()
        txtNetSales.Clear()
        txtAmountTendered.Clear()
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tsCalen.Text = System.DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        tsCal.Text = System.DateTime.Now.ToLongDateString
    End Sub
End Class
