Imports System.Data.SqlClient
Imports System.Text

Public Class AddForm
    Private ReadOnly userID As Integer
    Private ReadOnly dataAccess As DataAccessLayer
    Private FuncCls As New CommonFunctionsCls()

    Public Sub New(authenticatedUserID As Integer)
        InitializeComponent()
        userID = authenticatedUserID
        dataAccess = New DataAccessLayer("Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Get the user inputs from the form
            Dim accountName As String = TextBox1.Text.Trim()
            Dim website As String = TextBox2.Text.Trim()
            Dim username As String = TextBox3.Text.Trim()
            Dim password As String = FuncCls.EncryptPassword(TextBox4.Text.Trim()) ' Encrypt the password
            Dim note As String = TextBox5.Text.Trim()

            ' Validate user inputs (you can add more validation as needed)
            If String.IsNullOrWhiteSpace(accountName) OrElse String.IsNullOrWhiteSpace(username) Then
                MessageBox.Show("Please fill in all required fields.")
                Return
            End If

            ' Create an AccountDetails object with the user inputs
            Dim account As New AccountDetails() With {
                .UserID = userID,
                .AccountName = accountName,
                .Website = website,
                .Username = username,
                .PasswordHash = password,
                .Note = note
            }

            ' Add the account to the database using the data access layer
            dataAccess.AddAccount(account)

            ' Display a success message to the user
            MessageBox.Show("Account added successfully.")

            ' Optionally, clear the form fields after adding the account
            ClearFormFields()
        Catch ex As Exception
            ' Handle any exceptions that occur during account addition
            MessageBox.Show($"Error adding account: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearFormFields()
        ' Clear all text fields in the form
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the AddForm
        Close()
    End Sub

    ' Method to generate a password with specified length and complexity
    Private Function GeneratePassword(length As Integer) As String
        ' Define character sets for each type of character
        Dim uppercaseChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim lowercaseChars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim numericChars As String = "0123456789"
        Dim specialChars As String = "!@#$%^&*()_+-=[]{}|;:,.<>?~/"

        ' Create a StringBuilder to build the password
        Dim passwordBuilder As New StringBuilder()

        ' Randomly choose characters from each character set
        Dim random As New Random()
        For i As Integer = 0 To length - 1
            ' Randomly choose the character set for the current position
            Dim charSetIndex As Integer = random.Next(4)

            ' Choose a random character from the selected character set
            Select Case charSetIndex
                Case 0
                    passwordBuilder.Append(uppercaseChars(random.Next(uppercaseChars.Length)))
                Case 1
                    passwordBuilder.Append(lowercaseChars(random.Next(lowercaseChars.Length)))
                Case 2
                    passwordBuilder.Append(numericChars(random.Next(numericChars.Length)))
                Case 3
                    passwordBuilder.Append(specialChars(random.Next(specialChars.Length)))
            End Select
        Next

        ' Return the generated password
        Return passwordBuilder.ToString()
    End Function
    ' Event handler for Button3 (Generate Password button)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Generate a password with the specified length and complexity
        Dim generatedPassword As String = GeneratePassword(12) ' You can specify the desired length here

        ' Display the generated password in the password textbox
        TextBox4.Text = generatedPassword
    End Sub
End Class
