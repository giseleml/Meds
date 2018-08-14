<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblNegativo = New System.Windows.Forms.Label()
        Me.lblPositivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataForm2 = New System.Windows.Forms.DateTimePicker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnAtualizar = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.Disposição = New System.Windows.Forms.CheckBox()
        Me.BomHumor = New System.Windows.Forms.CheckBox()
        Me.Foco = New System.Windows.Forms.CheckBox()
        Me.SonoBom = New System.Windows.Forms.CheckBox()
        Me.MenosAnsie = New System.Windows.Forms.CheckBox()
        Me.MenosDepre = New System.Windows.Forms.CheckBox()
        Me.PensaPositv = New System.Windows.Forms.CheckBox()
        Me.Dor = New System.Windows.Forms.CheckBox()
        Me.Fraqueza = New System.Windows.Forms.CheckBox()
        Me.Tontura = New System.Windows.Forms.CheckBox()
        Me.Enjoo = New System.Windows.Forms.CheckBox()
        Me.SonoRuim = New System.Windows.Forms.CheckBox()
        Me.Vertigem = New System.Windows.Forms.CheckBox()
        Me.Insonia = New System.Windows.Forms.CheckBox()
        Me.MalHumor = New System.Windows.Forms.CheckBox()
        Me.Ansiedade = New System.Windows.Forms.CheckBox()
        Me.Depre = New System.Windows.Forms.CheckBox()
        Me.PensaNeg = New System.Windows.Forms.CheckBox()
        Me.txtRem = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNegativo
        '
        Me.lblNegativo.AutoSize = True
        Me.lblNegativo.BackColor = System.Drawing.Color.Transparent
        Me.lblNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblNegativo.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 9.75!)
        Me.lblNegativo.ForeColor = System.Drawing.Color.Transparent
        Me.lblNegativo.Location = New System.Drawing.Point(366, 250)
        Me.lblNegativo.Name = "lblNegativo"
        Me.lblNegativo.Size = New System.Drawing.Size(181, 24)
        Me.lblNegativo.TabIndex = 0
        Me.lblNegativo.Text = "Efeitos Negativos"
        '
        'lblPositivo
        '
        Me.lblPositivo.AutoSize = True
        Me.lblPositivo.BackColor = System.Drawing.Color.Transparent
        Me.lblPositivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPositivo.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 9.75!)
        Me.lblPositivo.ForeColor = System.Drawing.Color.Transparent
        Me.lblPositivo.Location = New System.Drawing.Point(51, 250)
        Me.lblPositivo.Name = "lblPositivo"
        Me.lblPositivo.Size = New System.Drawing.Size(177, 24)
        Me.lblPositivo.TabIndex = 1
        Me.lblPositivo.Text = "Efeitos Positivos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(63, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Remédio:"
        '
        'DataForm2
        '
        Me.DataForm2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataForm2.Location = New System.Drawing.Point(161, 89)
        Me.DataForm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataForm2.Name = "DataForm2"
        Me.DataForm2.Size = New System.Drawing.Size(200, 20)
        Me.DataForm2.TabIndex = 8
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Black
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnAdd.Location = New System.Drawing.Point(81, 126)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(101, 32)
        Me.BtnAdd.TabIndex = 17
        Me.BtnAdd.Text = "Adicionar"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.BackColor = System.Drawing.Color.Black
        Me.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAtualizar.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtualizar.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnAtualizar.Location = New System.Drawing.Point(295, 126)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(101, 32)
        Me.BtnAtualizar.TabIndex = 18
        Me.BtnAtualizar.Text = "Salvar"
        Me.BtnAtualizar.UseVisualStyleBackColor = False
        '
        'BtnDel
        '
        Me.BtnDel.BackColor = System.Drawing.Color.Black
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnDel.Location = New System.Drawing.Point(188, 126)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(101, 32)
        Me.BtnDel.TabIndex = 19
        Me.BtnDel.Text = "Deletar"
        Me.BtnDel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("KG Summer Sunshine Blackout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(103, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Data:"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(380, 74)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(47, 35)
        Me.BtnPesquisar.TabIndex = 21
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'Disposição
        '
        Me.Disposição.AutoSize = True
        Me.Disposição.BackColor = System.Drawing.Color.Transparent
        Me.Disposição.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disposição.ForeColor = System.Drawing.Color.Transparent
        Me.Disposição.Location = New System.Drawing.Point(55, 277)
        Me.Disposição.Name = "Disposição"
        Me.Disposição.Size = New System.Drawing.Size(97, 22)
        Me.Disposição.TabIndex = 22
        Me.Disposição.Text = "Disposição"
        Me.Disposição.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Disposição.UseVisualStyleBackColor = False
        '
        'BomHumor
        '
        Me.BomHumor.AutoSize = True
        Me.BomHumor.BackColor = System.Drawing.Color.Transparent
        Me.BomHumor.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BomHumor.ForeColor = System.Drawing.Color.Transparent
        Me.BomHumor.Location = New System.Drawing.Point(55, 300)
        Me.BomHumor.Name = "BomHumor"
        Me.BomHumor.Size = New System.Drawing.Size(105, 22)
        Me.BomHumor.TabIndex = 23
        Me.BomHumor.Text = "Bom Humor"
        Me.BomHumor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BomHumor.UseVisualStyleBackColor = False
        '
        'Foco
        '
        Me.Foco.AutoSize = True
        Me.Foco.BackColor = System.Drawing.Color.Transparent
        Me.Foco.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Foco.ForeColor = System.Drawing.Color.Transparent
        Me.Foco.Location = New System.Drawing.Point(55, 323)
        Me.Foco.Name = "Foco"
        Me.Foco.Size = New System.Drawing.Size(196, 22)
        Me.Foco.TabIndex = 24
        Me.Foco.Text = "Melhora na Atenção/Foco"
        Me.Foco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Foco.UseVisualStyleBackColor = False
        '
        'SonoBom
        '
        Me.SonoBom.AutoSize = True
        Me.SonoBom.BackColor = System.Drawing.Color.Transparent
        Me.SonoBom.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SonoBom.ForeColor = System.Drawing.Color.Transparent
        Me.SonoBom.Location = New System.Drawing.Point(55, 346)
        Me.SonoBom.Name = "SonoBom"
        Me.SonoBom.Size = New System.Drawing.Size(127, 22)
        Me.SonoBom.TabIndex = 25
        Me.SonoBom.Text = "Sono Tranquilo"
        Me.SonoBom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SonoBom.UseVisualStyleBackColor = False
        '
        'MenosAnsie
        '
        Me.MenosAnsie.AutoSize = True
        Me.MenosAnsie.BackColor = System.Drawing.Color.Transparent
        Me.MenosAnsie.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenosAnsie.ForeColor = System.Drawing.Color.Transparent
        Me.MenosAnsie.Location = New System.Drawing.Point(55, 369)
        Me.MenosAnsie.Name = "MenosAnsie"
        Me.MenosAnsie.Size = New System.Drawing.Size(196, 22)
        Me.MenosAnsie.TabIndex = 26
        Me.MenosAnsie.Text = "Diminuição da Ansiedade"
        Me.MenosAnsie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenosAnsie.UseVisualStyleBackColor = False
        '
        'MenosDepre
        '
        Me.MenosDepre.AutoSize = True
        Me.MenosDepre.BackColor = System.Drawing.Color.Transparent
        Me.MenosDepre.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenosDepre.ForeColor = System.Drawing.Color.Transparent
        Me.MenosDepre.Location = New System.Drawing.Point(55, 392)
        Me.MenosDepre.Name = "MenosDepre"
        Me.MenosDepre.Size = New System.Drawing.Size(196, 22)
        Me.MenosDepre.TabIndex = 27
        Me.MenosDepre.Text = "Diminuição da Depressão"
        Me.MenosDepre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MenosDepre.UseVisualStyleBackColor = False
        '
        'PensaPositv
        '
        Me.PensaPositv.AutoSize = True
        Me.PensaPositv.BackColor = System.Drawing.Color.Transparent
        Me.PensaPositv.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PensaPositv.ForeColor = System.Drawing.Color.Transparent
        Me.PensaPositv.Location = New System.Drawing.Point(55, 415)
        Me.PensaPositv.Name = "PensaPositv"
        Me.PensaPositv.Size = New System.Drawing.Size(178, 22)
        Me.PensaPositv.TabIndex = 28
        Me.PensaPositv.Text = "Pensamentos Positivos"
        Me.PensaPositv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PensaPositv.UseVisualStyleBackColor = False
        '
        'Dor
        '
        Me.Dor.AutoSize = True
        Me.Dor.BackColor = System.Drawing.Color.Transparent
        Me.Dor.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dor.ForeColor = System.Drawing.Color.Transparent
        Me.Dor.Location = New System.Drawing.Point(370, 277)
        Me.Dor.Name = "Dor"
        Me.Dor.Size = New System.Drawing.Size(121, 22)
        Me.Dor.TabIndex = 29
        Me.Dor.Text = "Dor de Cabeça"
        Me.Dor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Dor.UseVisualStyleBackColor = False
        '
        'Fraqueza
        '
        Me.Fraqueza.AutoSize = True
        Me.Fraqueza.BackColor = System.Drawing.Color.Transparent
        Me.Fraqueza.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fraqueza.ForeColor = System.Drawing.Color.Transparent
        Me.Fraqueza.Location = New System.Drawing.Point(370, 300)
        Me.Fraqueza.Name = "Fraqueza"
        Me.Fraqueza.Size = New System.Drawing.Size(87, 22)
        Me.Fraqueza.TabIndex = 30
        Me.Fraqueza.Text = "Fraqueza"
        Me.Fraqueza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Fraqueza.UseVisualStyleBackColor = False
        '
        'Tontura
        '
        Me.Tontura.AutoSize = True
        Me.Tontura.BackColor = System.Drawing.Color.Transparent
        Me.Tontura.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tontura.ForeColor = System.Drawing.Color.Transparent
        Me.Tontura.Location = New System.Drawing.Point(370, 323)
        Me.Tontura.Name = "Tontura"
        Me.Tontura.Size = New System.Drawing.Size(80, 22)
        Me.Tontura.TabIndex = 31
        Me.Tontura.Text = "Tontura"
        Me.Tontura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Tontura.UseVisualStyleBackColor = False
        '
        'Enjoo
        '
        Me.Enjoo.AutoSize = True
        Me.Enjoo.BackColor = System.Drawing.Color.Transparent
        Me.Enjoo.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enjoo.ForeColor = System.Drawing.Color.Transparent
        Me.Enjoo.Location = New System.Drawing.Point(370, 346)
        Me.Enjoo.Name = "Enjoo"
        Me.Enjoo.Size = New System.Drawing.Size(62, 22)
        Me.Enjoo.TabIndex = 32
        Me.Enjoo.Text = "Enjôo"
        Me.Enjoo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Enjoo.UseVisualStyleBackColor = False
        '
        'SonoRuim
        '
        Me.SonoRuim.AutoSize = True
        Me.SonoRuim.BackColor = System.Drawing.Color.Transparent
        Me.SonoRuim.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SonoRuim.ForeColor = System.Drawing.Color.Transparent
        Me.SonoRuim.Location = New System.Drawing.Point(370, 394)
        Me.SonoRuim.Name = "SonoRuim"
        Me.SonoRuim.Size = New System.Drawing.Size(134, 22)
        Me.SonoRuim.TabIndex = 33
        Me.SonoRuim.Text = "Sono Perturbado"
        Me.SonoRuim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SonoRuim.UseVisualStyleBackColor = False
        '
        'Vertigem
        '
        Me.Vertigem.AutoSize = True
        Me.Vertigem.BackColor = System.Drawing.Color.Transparent
        Me.Vertigem.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vertigem.ForeColor = System.Drawing.Color.Transparent
        Me.Vertigem.Location = New System.Drawing.Point(370, 369)
        Me.Vertigem.Name = "Vertigem"
        Me.Vertigem.Size = New System.Drawing.Size(88, 22)
        Me.Vertigem.TabIndex = 34
        Me.Vertigem.Text = "Vertigem"
        Me.Vertigem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Vertigem.UseVisualStyleBackColor = False
        '
        'Insonia
        '
        Me.Insonia.AutoSize = True
        Me.Insonia.BackColor = System.Drawing.Color.Transparent
        Me.Insonia.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insonia.ForeColor = System.Drawing.Color.Transparent
        Me.Insonia.Location = New System.Drawing.Point(370, 417)
        Me.Insonia.Name = "Insonia"
        Me.Insonia.Size = New System.Drawing.Size(77, 22)
        Me.Insonia.TabIndex = 35
        Me.Insonia.Text = "Insônia"
        Me.Insonia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Insonia.UseVisualStyleBackColor = False
        '
        'MalHumor
        '
        Me.MalHumor.AutoSize = True
        Me.MalHumor.BackColor = System.Drawing.Color.Transparent
        Me.MalHumor.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MalHumor.ForeColor = System.Drawing.Color.Transparent
        Me.MalHumor.Location = New System.Drawing.Point(497, 277)
        Me.MalHumor.Name = "MalHumor"
        Me.MalHumor.Size = New System.Drawing.Size(100, 22)
        Me.MalHumor.TabIndex = 36
        Me.MalHumor.Text = "Mal Humor"
        Me.MalHumor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MalHumor.UseVisualStyleBackColor = False
        '
        'Ansiedade
        '
        Me.Ansiedade.AutoSize = True
        Me.Ansiedade.BackColor = System.Drawing.Color.Transparent
        Me.Ansiedade.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ansiedade.ForeColor = System.Drawing.Color.Transparent
        Me.Ansiedade.Location = New System.Drawing.Point(497, 300)
        Me.Ansiedade.Name = "Ansiedade"
        Me.Ansiedade.Size = New System.Drawing.Size(95, 22)
        Me.Ansiedade.TabIndex = 37
        Me.Ansiedade.Text = "Ansiedade"
        Me.Ansiedade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ansiedade.UseVisualStyleBackColor = False
        '
        'Depre
        '
        Me.Depre.AutoSize = True
        Me.Depre.BackColor = System.Drawing.Color.Transparent
        Me.Depre.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Depre.ForeColor = System.Drawing.Color.Transparent
        Me.Depre.Location = New System.Drawing.Point(497, 323)
        Me.Depre.Name = "Depre"
        Me.Depre.Size = New System.Drawing.Size(95, 22)
        Me.Depre.TabIndex = 38
        Me.Depre.Text = "Depressão"
        Me.Depre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Depre.UseVisualStyleBackColor = False
        '
        'PensaNeg
        '
        Me.PensaNeg.AutoSize = True
        Me.PensaNeg.BackColor = System.Drawing.Color.Transparent
        Me.PensaNeg.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PensaNeg.ForeColor = System.Drawing.Color.Transparent
        Me.PensaNeg.Location = New System.Drawing.Point(497, 346)
        Me.PensaNeg.Name = "PensaNeg"
        Me.PensaNeg.Size = New System.Drawing.Size(184, 22)
        Me.PensaNeg.TabIndex = 39
        Me.PensaNeg.Text = "Pensamentos Negativos"
        Me.PensaNeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PensaNeg.UseVisualStyleBackColor = False
        '
        'txtRem
        '
        Me.txtRem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtRem.FormattingEnabled = True
        Me.txtRem.Location = New System.Drawing.Point(161, 61)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(200, 21)
        Me.txtRem.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(701, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(247, 137)
        Me.DataGridView1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(158, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Adicione ou Selecione um Remédio"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblEmail.Location = New System.Drawing.Point(812, 490)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(210, 20)
        Me.lblEmail.TabIndex = 43
        Me.lblEmail.Text = "giselemaraleo@gmail.com"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 519)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtRem)
        Me.Controls.Add(Me.PensaNeg)
        Me.Controls.Add(Me.Depre)
        Me.Controls.Add(Me.Ansiedade)
        Me.Controls.Add(Me.MalHumor)
        Me.Controls.Add(Me.Insonia)
        Me.Controls.Add(Me.Vertigem)
        Me.Controls.Add(Me.SonoRuim)
        Me.Controls.Add(Me.Enjoo)
        Me.Controls.Add(Me.Tontura)
        Me.Controls.Add(Me.Fraqueza)
        Me.Controls.Add(Me.Dor)
        Me.Controls.Add(Me.PensaPositv)
        Me.Controls.Add(Me.MenosDepre)
        Me.Controls.Add(Me.MenosAnsie)
        Me.Controls.Add(Me.SonoBom)
        Me.Controls.Add(Me.Foco)
        Me.Controls.Add(Me.BomHumor)
        Me.Controls.Add(Me.Disposição)
        Me.Controls.Add(Me.BtnPesquisar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAtualizar)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataForm2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPositivo)
        Me.Controls.Add(Me.lblNegativo)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meds"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNegativo As Label
    Friend WithEvents lblPositivo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataForm2 As DateTimePicker
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnAtualizar As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents Disposição As CheckBox
    Friend WithEvents BomHumor As CheckBox
    Friend WithEvents Foco As CheckBox
    Friend WithEvents SonoBom As CheckBox
    Friend WithEvents MenosAnsie As CheckBox
    Friend WithEvents MenosDepre As CheckBox
    Friend WithEvents PensaPositv As CheckBox
    Friend WithEvents Dor As CheckBox
    Friend WithEvents Fraqueza As CheckBox
    Friend WithEvents Tontura As CheckBox
    Friend WithEvents Enjoo As CheckBox
    Friend WithEvents SonoRuim As CheckBox
    Friend WithEvents Vertigem As CheckBox
    Friend WithEvents Insonia As CheckBox
    Friend WithEvents MalHumor As CheckBox
    Friend WithEvents Ansiedade As CheckBox
    Friend WithEvents Depre As CheckBox
    Friend WithEvents PensaNeg As CheckBox
    Friend WithEvents txtRem As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmail As Label
End Class
