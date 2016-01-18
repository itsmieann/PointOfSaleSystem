Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblSubtotal.Text = Form1.txtSubTotal.Text
        lblTax.Text = Form1.txtTax.Text
        lblNetsales.Text = Form1.txtNetSales.Text
        lblAmountTendered.Text = Form1.txtAmountTendered.Text
        lblChange.Text = Form1.txtChange.Text

        lblDate.Text = System.DateTime.Now.ToLongDateString
        lblTime.Text = System.DateTime.Now.ToString("hh:mm:ss tt")


        For Each lvi As ListViewItem In Form1.ListView1.Items
            Dim newLvi As ListViewItem = lvi.Clone()
            For Each lvsi As ListViewItem.ListViewSubItem In lvi.SubItems
                newLvi.SubItems.Add(New ListViewItem.ListViewSubItem(newLvi, lvsi.Text))
            Next
            ListView1.Items.Add(newLvi)
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        Button1.Visible = True

    End Sub

End Class