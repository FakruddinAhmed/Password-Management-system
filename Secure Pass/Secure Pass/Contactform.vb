Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml
Public Class Contactform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get current timestamp
        Dim timestamp As DateTime = DateTime.Now

        ' Get user inputs
        Dim username As String = TextBox1.Text.Trim()
        Dim feedbackType As String = ""
        Dim rating As Integer = 0
        Dim feedbackText As String = TextBox2.Text.Trim()

        ' Determine the feedback type based on selected radio button
        If RadioButton1.Checked Then
            feedbackType = "Query"
        ElseIf RadioButton2.Checked Then
            feedbackType = "Report"
        End If

        ' Determine the rating based on selected radio button
        If RadioButton3.Checked Then
            rating = 5
        ElseIf RadioButton4.Checked Then
            rating = 4
        ElseIf RadioButton5.Checked Then
            rating = 3
        ElseIf RadioButton6.Checked Then
            rating = 2
        ElseIf RadioButton7.Checked Then
            rating = 1
        End If

        ' Validate inputs (you can add more validation as needed)
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(feedbackText) OrElse
            String.IsNullOrWhiteSpace(feedbackType) OrElse rating = 0 Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Insert feedback into the database
        Dim connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True"
        Dim query As String = "INSERT INTO Feedback (Username, FeedbackType, Rating, FeedbackText, Timestamp) " &
                          "VALUES (@Username, @FeedbackType, @Rating, @FeedbackText, @Timestamp)"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@FeedbackType", feedbackType)
                    command.Parameters.AddWithValue("@Rating", rating)
                    command.Parameters.AddWithValue("@FeedbackText", feedbackText)
                    command.Parameters.AddWithValue("@Timestamp", timestamp)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Feedback submitted successfully.")
            TextBox1.Clear()
            TextBox2.Clear()

            ' Clear the selection of RadioButtons
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
        Catch ex As Exception
            MessageBox.Show($"Error submitting feedback: {ex.Message}")
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear all the input fields
        TextBox1.Clear()
        TextBox2.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Clear the query/report textbox
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Close the form
        Close()
        Dim loginForm As New Form1
        loginForm.Show()
    End Sub

    Private Sub ExportToExcel()
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            ' Query to select feedback data from the database
            Dim query As String = "SELECT Username, FeedbackType, Rating, FeedbackText, Timestamp FROM Feedback"

            ' DataTable to store the feedback data
            Dim feedbackData As New DataTable()

            ' Connection string to your database
            Dim connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True"

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Load data into the DataTable
                        feedbackData.Load(reader)
                    End Using
                End Using
            End Using

            ' Create Excel package
            Using excelPackage As New ExcelPackage()
                ' Add a new worksheet
                Dim worksheet = excelPackage.Workbook.Worksheets.Add("Feedback")

                ' Write feedback data to worksheet
                worksheet.Cells("A1").LoadFromDataTable(feedbackData, True)

                ' Save Excel package to a file
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
                saveFileDialog.FileName = "FeedbackReport.xlsx"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    excelPackage.SaveAs(New FileInfo(saveFileDialog.FileName))
                    MessageBox.Show("Feedback data exported to Excel successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error exporting feedback data to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ExportToExcel()
    End Sub
End Class

