<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COGNOMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADINASCITADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATACHIRURGIADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIDEO1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FILEPDF1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOTO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FILEDITESTO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIDEO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FILEPDF2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOTO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FILEDITESTO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataBasePazientiDataSet1 = New WindowsApp1.DataBasePazientiDataSet1()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DataBasePazientiDataSet = New WindowsApp1.DataBasePazientiDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New WindowsApp1.DataBasePazientiDataSetTableAdapters.Table1TableAdapter()
        Me.Table1TableAdapter1 = New WindowsApp1.DataBasePazientiDataSet1TableAdapters.Table1TableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COGNOMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADINASCITADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATACHIRURGIADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VIDEO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBasePazientiDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBasePazientiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(513, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "COGNOME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(372, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(596, 30)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.NOMEDataGridViewTextBoxColumn1, Me.COGNOMEDataGridViewTextBoxColumn1, Me.DATADINASCITADataGridViewTextBoxColumn1, Me.DATACHIRURGIADataGridViewTextBoxColumn1, Me.VIDEO1DataGridViewTextBoxColumn1, Me.FILEPDF1DataGridViewTextBoxColumn, Me.FOTO1DataGridViewTextBoxColumn, Me.FILEDITESTO1DataGridViewTextBoxColumn, Me.VIDEO2DataGridViewTextBoxColumn, Me.FILEPDF2DataGridViewTextBoxColumn, Me.FOTO2DataGridViewTextBoxColumn, Me.FILEDITESTO2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.Location = New System.Drawing.Point(16, 229)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1541, 506)
        Me.DataGridView1.TabIndex = 7
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Width = 50
        '
        'NOMEDataGridViewTextBoxColumn1
        '
        Me.NOMEDataGridViewTextBoxColumn1.DataPropertyName = "NOME"
        Me.NOMEDataGridViewTextBoxColumn1.HeaderText = "NOME"
        Me.NOMEDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.NOMEDataGridViewTextBoxColumn1.Name = "NOMEDataGridViewTextBoxColumn1"
        Me.NOMEDataGridViewTextBoxColumn1.Width = 78
        '
        'COGNOMEDataGridViewTextBoxColumn1
        '
        Me.COGNOMEDataGridViewTextBoxColumn1.DataPropertyName = "COGNOME"
        Me.COGNOMEDataGridViewTextBoxColumn1.HeaderText = "COGNOME"
        Me.COGNOMEDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.COGNOMEDataGridViewTextBoxColumn1.Name = "COGNOMEDataGridViewTextBoxColumn1"
        Me.COGNOMEDataGridViewTextBoxColumn1.Width = 109
        '
        'DATADINASCITADataGridViewTextBoxColumn1
        '
        Me.DATADINASCITADataGridViewTextBoxColumn1.DataPropertyName = "DATA DI NASCITA"
        Me.DATADINASCITADataGridViewTextBoxColumn1.HeaderText = "DATA DI NASCITA"
        Me.DATADINASCITADataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DATADINASCITADataGridViewTextBoxColumn1.Name = "DATADINASCITADataGridViewTextBoxColumn1"
        Me.DATADINASCITADataGridViewTextBoxColumn1.Width = 140
        '
        'DATACHIRURGIADataGridViewTextBoxColumn1
        '
        Me.DATACHIRURGIADataGridViewTextBoxColumn1.DataPropertyName = "DATA CHIRURGIA"
        Me.DATACHIRURGIADataGridViewTextBoxColumn1.HeaderText = "DATA CHIRURGIA"
        Me.DATACHIRURGIADataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DATACHIRURGIADataGridViewTextBoxColumn1.Name = "DATACHIRURGIADataGridViewTextBoxColumn1"
        Me.DATACHIRURGIADataGridViewTextBoxColumn1.Width = 140
        '
        'VIDEO1DataGridViewTextBoxColumn1
        '
        Me.VIDEO1DataGridViewTextBoxColumn1.DataPropertyName = "VIDEO 1"
        Me.VIDEO1DataGridViewTextBoxColumn1.HeaderText = "VIDEO 1"
        Me.VIDEO1DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.VIDEO1DataGridViewTextBoxColumn1.Name = "VIDEO1DataGridViewTextBoxColumn1"
        Me.VIDEO1DataGridViewTextBoxColumn1.Width = 84
        '
        'FILEPDF1DataGridViewTextBoxColumn
        '
        Me.FILEPDF1DataGridViewTextBoxColumn.DataPropertyName = "FILE PDF 1"
        Me.FILEPDF1DataGridViewTextBoxColumn.HeaderText = "FILE PDF 1"
        Me.FILEPDF1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FILEPDF1DataGridViewTextBoxColumn.Name = "FILEPDF1DataGridViewTextBoxColumn"
        Me.FILEPDF1DataGridViewTextBoxColumn.Width = 92
        '
        'FOTO1DataGridViewTextBoxColumn
        '
        Me.FOTO1DataGridViewTextBoxColumn.DataPropertyName = "FOTO 1"
        Me.FOTO1DataGridViewTextBoxColumn.HeaderText = "FOTO 1"
        Me.FOTO1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FOTO1DataGridViewTextBoxColumn.Name = "FOTO1DataGridViewTextBoxColumn"
        Me.FOTO1DataGridViewTextBoxColumn.Width = 82
        '
        'FILEDITESTO1DataGridViewTextBoxColumn
        '
        Me.FILEDITESTO1DataGridViewTextBoxColumn.DataPropertyName = "FILE DI TESTO 1"
        Me.FILEDITESTO1DataGridViewTextBoxColumn.HeaderText = "FILE DI TESTO 1"
        Me.FILEDITESTO1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FILEDITESTO1DataGridViewTextBoxColumn.Name = "FILEDITESTO1DataGridViewTextBoxColumn"
        Me.FILEDITESTO1DataGridViewTextBoxColumn.Width = 122
        '
        'VIDEO2DataGridViewTextBoxColumn
        '
        Me.VIDEO2DataGridViewTextBoxColumn.DataPropertyName = "VIDEO 2"
        Me.VIDEO2DataGridViewTextBoxColumn.HeaderText = "VIDEO 2"
        Me.VIDEO2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VIDEO2DataGridViewTextBoxColumn.Name = "VIDEO2DataGridViewTextBoxColumn"
        Me.VIDEO2DataGridViewTextBoxColumn.Width = 84
        '
        'FILEPDF2DataGridViewTextBoxColumn
        '
        Me.FILEPDF2DataGridViewTextBoxColumn.DataPropertyName = "FILE PDF 2"
        Me.FILEPDF2DataGridViewTextBoxColumn.HeaderText = "FILE PDF 2"
        Me.FILEPDF2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FILEPDF2DataGridViewTextBoxColumn.Name = "FILEPDF2DataGridViewTextBoxColumn"
        Me.FILEPDF2DataGridViewTextBoxColumn.Width = 92
        '
        'FOTO2DataGridViewTextBoxColumn
        '
        Me.FOTO2DataGridViewTextBoxColumn.DataPropertyName = "FOTO 2"
        Me.FOTO2DataGridViewTextBoxColumn.HeaderText = "FOTO 2"
        Me.FOTO2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FOTO2DataGridViewTextBoxColumn.Name = "FOTO2DataGridViewTextBoxColumn"
        Me.FOTO2DataGridViewTextBoxColumn.Width = 82
        '
        'FILEDITESTO2DataGridViewTextBoxColumn
        '
        Me.FILEDITESTO2DataGridViewTextBoxColumn.DataPropertyName = "FILE DI TESTO 2"
        Me.FILEDITESTO2DataGridViewTextBoxColumn.HeaderText = "FILE DI TESTO 2"
        Me.FILEDITESTO2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FILEDITESTO2DataGridViewTextBoxColumn.Name = "FILEDITESTO2DataGridViewTextBoxColumn"
        Me.FILEDITESTO2DataGridViewTextBoxColumn.Width = 122
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.DataBasePazientiDataSet1
        '
        'DataBasePazientiDataSet1
        '
        Me.DataBasePazientiDataSet1.DataSetName = "DataBasePazientiDataSet1"
        Me.DataBasePazientiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(877, 28)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(737, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "DATA DI NASCITA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1019, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DATA CHIRURGIA"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1159, 25)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(119, 22)
        Me.TextBox4.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(232, 187)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(76, 22)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(232, 81)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(76, 22)
        Me.TextBox6.TabIndex = 20
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Lime
        Me.Button8.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(15, 123)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(211, 48)
        Me.Button8.TabIndex = 21
        Me.Button8.Text = "CARICA-SOSTITUISCI FILE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(232, 134)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(76, 22)
        Me.TextBox7.TabIndex = 22
        '
        'DataBasePazientiDataSet
        '
        Me.DataBasePazientiDataSet.DataSetName = "DataBasePazientiDataSet"
        Me.DataBasePazientiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.DataBasePazientiDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NOMEDataGridViewTextBoxColumn
        '
        Me.NOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.HeaderText = "NOME"
        Me.NOMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NOMEDataGridViewTextBoxColumn.Name = "NOMEDataGridViewTextBoxColumn"
        Me.NOMEDataGridViewTextBoxColumn.Width = 78
        '
        'COGNOMEDataGridViewTextBoxColumn
        '
        Me.COGNOMEDataGridViewTextBoxColumn.DataPropertyName = "COGNOME"
        Me.COGNOMEDataGridViewTextBoxColumn.HeaderText = "COGNOME"
        Me.COGNOMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.COGNOMEDataGridViewTextBoxColumn.Name = "COGNOMEDataGridViewTextBoxColumn"
        Me.COGNOMEDataGridViewTextBoxColumn.Width = 109
        '
        'DATADINASCITADataGridViewTextBoxColumn
        '
        Me.DATADINASCITADataGridViewTextBoxColumn.DataPropertyName = "DATA DI NASCITA"
        Me.DATADINASCITADataGridViewTextBoxColumn.HeaderText = "DATA DI NASCITA"
        Me.DATADINASCITADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DATADINASCITADataGridViewTextBoxColumn.Name = "DATADINASCITADataGridViewTextBoxColumn"
        Me.DATADINASCITADataGridViewTextBoxColumn.Width = 140
        '
        'DATACHIRURGIADataGridViewTextBoxColumn
        '
        Me.DATACHIRURGIADataGridViewTextBoxColumn.DataPropertyName = "DATA CHIRURGIA"
        Me.DATACHIRURGIADataGridViewTextBoxColumn.HeaderText = "DATA CHIRURGIA"
        Me.DATACHIRURGIADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DATACHIRURGIADataGridViewTextBoxColumn.Name = "DATACHIRURGIADataGridViewTextBoxColumn"
        Me.DATACHIRURGIADataGridViewTextBoxColumn.Width = 140
        '
        'VIDEO1DataGridViewTextBoxColumn
        '
        Me.VIDEO1DataGridViewTextBoxColumn.DataPropertyName = "VIDEO 1"
        Me.VIDEO1DataGridViewTextBoxColumn.HeaderText = "VIDEO 1"
        Me.VIDEO1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VIDEO1DataGridViewTextBoxColumn.Name = "VIDEO1DataGridViewTextBoxColumn"
        Me.VIDEO1DataGridViewTextBoxColumn.Width = 84
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button12.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = Global.WindowsApp1.My.Resources.Resources.manuscript_g54bd4e01c_640
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(1044, 165)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(235, 57)
        Me.Button12.TabIndex = 26
        Me.Button12.Text = "   SELEZIONA FILE DI TESTO 2"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button11.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Image = Global.WindowsApp1.My.Resources.Resources.camera_gd54b11fa2_640
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(801, 165)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(235, 57)
        Me.Button11.TabIndex = 25
        Me.Button11.Text = "      SELEZIONA FOTO 2"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button10.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = Global.WindowsApp1.My.Resources.Resources.adobe_gb0bd0a83a_640
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(1044, 101)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(235, 57)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "      SELEZIONA FILE PDF 2"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button9.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = Global.WindowsApp1.My.Resources.Resources.vlc_g59abc7217_640
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(801, 101)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(235, 57)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "    SELEZIONA VIDEO 2"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Lime
        Me.Button7.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button7.Image = Global.WindowsApp1.My.Resources.Resources.magnifying_glass_g1569ea611_640
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(15, 71)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(211, 46)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "    CERCA PAZIENTE"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.WindowsApp1.My.Resources.Resources.manuscript_g54bd4e01c_640
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(559, 165)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(235, 57)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "   SELEZIONA FILE DI TESTO 1"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.WindowsApp1.My.Resources.Resources.adobe_gb0bd0a83a_640
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(559, 101)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(235, 57)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "      SELEZIONA FILE PDF 1"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button4.Image = Global.WindowsApp1.My.Resources.Resources.rubbish_ga4b336cdc_640
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(15, 177)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(211, 48)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "   CANCELLA PAZIENTE   ID"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.CausesValidation = False
        Me.Button3.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.WindowsApp1.My.Resources.Resources.camera_gd54b11fa2_640
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(316, 165)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 57)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "      SELEZIONA FOTO 1"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Button2.Image = Global.WindowsApp1.My.Resources.Resources.User
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(15, 17)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 48)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = " SALVA PAZIENTE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApp1.My.Resources.Resources.vlc_g59abc7217_640
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(316, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 57)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "    SELEZIONA VIDEO 1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(258, 30)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(50, 22)
        Me.TextBox8.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "ID"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1756, 750)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBasePazientiDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBasePazientiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents DataBasePazientiDataSet As DataBasePazientiDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As DataBasePazientiDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataBasePazientiDataSet1 As DataBasePazientiDataSet1
    Friend WithEvents Table1BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As DataBasePazientiDataSet1TableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COGNOMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATADINASCITADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATACHIRURGIADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VIDEO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NOMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents COGNOMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATADINASCITADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATACHIRURGIADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VIDEO1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FILEPDF1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FOTO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FILEDITESTO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VIDEO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FILEPDF2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FOTO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FILEDITESTO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label5 As Label
End Class
