Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new DataTable.
        Dim table As New DataTable()

        ' Define columns.
        table.Columns.Add("ID", GetType(Integer))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Age", GetType(Integer))

        ' Add rows.
        table.Rows.Add(1, "John Doe", 30)
        table.Rows.Add(2, "Jane Smith", 25)
        table.Rows.Add(3, "Sam Brown", 28)

        ' Bind the DataTable to the DataGridView.
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle cell click events here if needed.
    End Sub
End Class
