Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class Form2

    'STRINGA DI CONNESSIONE AL DATABASE SQL
    Dim con1 As New SqlConnection("Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=")

    'VARIABILI PER LA MEMORIZZAZIONE DEL PERCORSO FILE
    Dim folderPath As String
    Dim fileName As String
    Dim fullPath As String
    Dim fullPath1 As String
    Dim fullPath2 As String
    Dim fullPath3 As String
    Dim fullPath4 As String
    Dim fullPath5 As String
    Dim fullPath6 As String
    Dim fullPath7 As String

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        bind1()
        FilterData("")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click   'PULSANTE PER SELEZIONARE VIDEO 1

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo

            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath = testFile.Name
            fullPath = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click   'PULSANTE PER SALVARE IL PAZIENTE

        Dim command As New SqlCommand("Insert into Table1(ID,NOME,COGNOME,[DATA DI NASCITA],[DATA CHIRURGIA], [VIDEO 1], [FILE PDF 1], [FOTO 1], [FILE DI TESTO 1], [VIDEO 2], [FILE PDF 2], [FOTO 2], [FILE DI TESTO 2])values(@id,@name,@surname,@birth,@surgery,@ALLEGATO1,@ALLEGATO2,@ALLEGATO3,@ALLEGATO4,@ALLEGATO5,@ALLEGATO6,@ALLEGATO7,@ALLEGATO8)", con1)

        If fullPath = Nothing Then  'RIEMPE TUTTI I CAMPI CON UNO SPAZIO PERCHE NON CONSENTIVA DI CARICARE UNA CELLA VUOTA

            fullPath = " "

        End If

        If fullPath1 = Nothing Then

            fullPath1 = " "

        End If

        If fullPath2 = Nothing Then

            fullPath2 = " "

        End If

        If fullPath3 = Nothing Then

            fullPath3 = " "

        End If

        If fullPath4 = Nothing Then

            fullPath4 = " "

        End If

        If fullPath5 = Nothing Then

            fullPath5 = " "

        End If

        If fullPath6 = Nothing Then

            fullPath6 = " "

        End If

        If fullPath7 = Nothing Then

            fullPath7 = " "

        End If

        'INSERIMENTO ALLEGATI E DATI PAZIENTE ALL'INTERNO DEL DATABASE SQL
        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox8.Text
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@surname", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@birth", SqlDbType.NVarChar).Value = TextBox3.Text
        command.Parameters.Add("@surgery", SqlDbType.NVarChar).Value = TextBox4.Text
        command.Parameters.Add("@ALLEGATO1", SqlDbType.NVarChar).Value = fullPath
        command.Parameters.Add("@ALLEGATO2", SqlDbType.NVarChar).Value = fullPath1
        command.Parameters.Add("@ALLEGATO3", SqlDbType.NVarChar).Value = fullPath2
        command.Parameters.Add("@ALLEGATO4", SqlDbType.NVarChar).Value = fullPath3
        command.Parameters.Add("@ALLEGATO5", SqlDbType.NVarChar).Value = fullPath4
        command.Parameters.Add("@ALLEGATO6", SqlDbType.NVarChar).Value = fullPath5
        command.Parameters.Add("@ALLEGATO7", SqlDbType.NVarChar).Value = fullPath6
        command.Parameters.Add("@ALLEGATO8", SqlDbType.NVarChar).Value = fullPath7

        'APERTURA DELLA CONNSESSIONE SE CHIUSA
        If con1.State = ConnectionState.Closed Then

            con1.Open()

        End If


        command.ExecuteNonQuery()
        MessageBox.Show("Paziente Inserito")
        con1.Close()
        bind1()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click   'PULSANTE PER SELEZIONARE FOTO 1

        Dim openfildialog1 As New OpenFileDialog

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath2 = testFile.Name
            fullPath2 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click   'PULSANTE PER CANCELLARE IL PAZIENTE

        Dim command As New SqlCommand("DELETE from Table1 WHERE id=@id", con1)
        command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox5.Text
        con1.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Paziente Cancellato")

        End If

        con1.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click   'PULSANTE PER SELEZIONARE FILE PDF 1

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath1 = testFile.Name
            fullPath1 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click   'PULSANTE PER SELEZIONARE FILE DI TESTO 1

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath3 = testFile.Name
            fullPath3 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click   'PULSANTE PER CERCARE IL PAZIENTE NEL DATABASE

        FilterData(TextBox6.Text)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click   'PULSANTE CARICA-SOSTITUISCI FILE DI UN PAZIENTE

        'CODICE PER CARICARE IL PERCORSO FILE ALL'INTERNO DEL DATABASE
        If fullPath = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [VIDEO 1] = @ALLEGATO1 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO1", SqlDbType.NVarChar).Value = fullPath
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

        If fullPath1 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FILE PDF 1] = @ALLEGATO2 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO2", SqlDbType.NVarChar).Value = fullPath1
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

        If fullPath2 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FOTO 1] = @ALLEGATO3 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO3", SqlDbType.NVarChar).Value = fullPath2
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If



        If fullPath3 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FILE DI TESTO 1] = @ALLEGATO4 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO4", SqlDbType.NVarChar).Value = fullPath3
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

        If fullPath4 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [VIDEO 2] = @ALLEGATO5 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO5", SqlDbType.NVarChar).Value = fullPath4
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

        If fullPath5 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FILE PDF 2] = @ALLEGATO6 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO6", SqlDbType.NVarChar).Value = fullPath5
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

        If fullPath6 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FOTO 2] = @ALLEGATO7 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO7", SqlDbType.NVarChar).Value = fullPath6
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If



        If fullPath7 = My.Computer.FileSystem.CombinePath(folderPath, fileName) Then

            Dim command As New SqlCommand("UPDATE Table1 SET [FILE DI TESTO 2] = @ALLEGATO8 WHERE id = @id", con1)
            command.Parameters.Add("@ALLEGATO8", SqlDbType.NVarChar).Value = fullPath7
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = TextBox7.Text

            con1.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Dati Paziente Aggiornati")

            End If

            con1.Close()

        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click   'PULSANTE PER SELEZIONARE VIDEO 2

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath4 = testFile.Name
            fullPath4 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'PULSANTE PER SELEZIONARE FILE PDF 2

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath5 = testFile.Name
            fullPath5 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click 'PULSANTE PER SELEZIONARE FOTO 2

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath6 = testFile.Name
            fullPath6 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'PULSANTE PER SELEZIONARE FILE DI TESTO 2

        Dim openfildialog1 As New OpenFileDialog

        If openfildialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(openfildialog1.FileName)
            folderPath = testFile.DirectoryName
            fileName = testFile.Name
            fullPath7 = testFile.Name
            fullPath7 = My.Computer.FileSystem.CombinePath(folderPath, fileName)

        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick   'CODICE PER APRIRE I FILE SALVATI CON DOPPIO CLICK

        Dim i As String = DataGridView1.CurrentCell.Value
        Dim file As New Process
        Dim file1 As New ProcessStartInfo(i)
        file.StartInfo = file1
        file.Start()

    End Sub

    Private Sub bind1() 'INTERFACCIA TRA SOFTWARE E DATABASE SQL

        Dim command As New SqlCommand("Select * from Table1 order by id desc", con1)
        Dim adapter As New SqlDataAdapter(command)
        Dim Table As New DataTable()

        adapter.Fill(Table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 90
        DataGridView1.DataSource = Table

    End Sub

    Public Sub FilterData(valueToSearch As String)  'INTERFACCIA TRA SOFTWARE E DATABASE SQL

        Dim searchQuery As String = "SELECT * FROM Table1 WHERE CONCAT(ID, NOME, COGNOME, [DATA DI NASCITA], [DATA CHIRURGIA], [VIDEO 1], [FILE PDF 1], [FOTO 1], [FILE DI TESTO 1], [VIDEO 2], [FILE PDF 2], [FOTO 2], [FILE DI TESTO 2]) like '%" & TextBox6.Text & "%'"
        Dim command As New SqlCommand(searchQuery, con1)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

End Class
