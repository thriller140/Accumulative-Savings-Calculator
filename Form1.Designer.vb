<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.billbtn = New System.Windows.Forms.Button()
        Me.paybill = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timebill = New System.Windows.Forms.NumericUpDown()
        Me.formatbill = New System.Windows.Forms.ComboBox()
        Me.titlebill = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.titlemisc = New System.Windows.Forms.TextBox()
        Me.paymisc = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.miscbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.calcsubmit = New System.Windows.Forms.Button()
        Me.duedate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fin_goal = New System.Windows.Forms.NumericUpDown()
        Me.titleincome = New System.Windows.Forms.TextBox()
        Me.formatincome = New System.Windows.Forms.ComboBox()
        Me.timeincome = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.getincome = New System.Windows.Forms.NumericUpDown()
        Me.incomebtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.getbtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.titleget = New System.Windows.Forms.TextBox()
        Me.getmisc = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.billstorage = New System.Windows.Forms.ListBox()
        Me.miscstorage = New System.Windows.Forms.ListBox()
        Me.incomestorage = New System.Windows.Forms.ListBox()
        Me.getstorage = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.paybill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timebill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paymisc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fin_goal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeincome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getincome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getmisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accumulative Savings Calculator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 105)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(680, 35)
        Me.LinkLabel1.TabIndex = 81
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "                        Bills                        "
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Pay "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(290, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stored Bills"
        '
        'billbtn
        '
        Me.billbtn.Location = New System.Drawing.Point(294, 183)
        Me.billbtn.Name = "billbtn"
        Me.billbtn.Size = New System.Drawing.Size(88, 23)
        Me.billbtn.TabIndex = 6
        Me.billbtn.Text = "Store Bill"
        Me.billbtn.UseVisualStyleBackColor = True
        '
        'paybill
        '
        Me.paybill.DecimalPlaces = 2
        Me.paybill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paybill.Location = New System.Drawing.Point(200, 142)
        Me.paybill.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.paybill.Name = "paybill"
        Me.paybill.Size = New System.Drawing.Size(120, 38)
        Me.paybill.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Every"
        '
        'timebill
        '
        Me.timebill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timebill.Location = New System.Drawing.Point(416, 142)
        Me.timebill.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.timebill.Name = "timebill"
        Me.timebill.Size = New System.Drawing.Size(83, 38)
        Me.timebill.TabIndex = 4
        '
        'formatbill
        '
        Me.formatbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formatbill.FormattingEnabled = True
        Me.formatbill.Items.AddRange(New Object() {"Week(s)", "Month(s)", "Year(s)"})
        Me.formatbill.Location = New System.Drawing.Point(505, 141)
        Me.formatbill.MaxDropDownItems = 2
        Me.formatbill.Name = "formatbill"
        Me.formatbill.Size = New System.Drawing.Size(121, 39)
        Me.formatbill.TabIndex = 5
        '
        'titlebill
        '
        Me.titlebill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlebill.Location = New System.Drawing.Point(12, 142)
        Me.titlebill.Name = "titlebill"
        Me.titlebill.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.titlebill.Size = New System.Drawing.Size(133, 38)
        Me.titlebill.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(475, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 31)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Due Date:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 350)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(680, 35)
        Me.LinkLabel2.TabIndex = 18
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "                        Misc                        "
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'titlemisc
        '
        Me.titlemisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlemisc.Location = New System.Drawing.Point(186, 394)
        Me.titlemisc.Name = "titlemisc"
        Me.titlemisc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.titlemisc.Size = New System.Drawing.Size(133, 38)
        Me.titlemisc.TabIndex = 7
        '
        'paymisc
        '
        Me.paymisc.DecimalPlaces = 2
        Me.paymisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymisc.Location = New System.Drawing.Point(374, 394)
        Me.paymisc.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.paymisc.Name = "paymisc"
        Me.paymisc.Size = New System.Drawing.Size(120, 38)
        Me.paymisc.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 31)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Pay "
        '
        'miscbtn
        '
        Me.miscbtn.Location = New System.Drawing.Point(294, 438)
        Me.miscbtn.Name = "miscbtn"
        Me.miscbtn.Size = New System.Drawing.Size(88, 23)
        Me.miscbtn.TabIndex = 9
        Me.miscbtn.Text = "Store Misc"
        Me.miscbtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(290, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Stored Misc"
        '
        'calcsubmit
        '
        Me.calcsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcsubmit.Location = New System.Drawing.Point(434, 622)
        Me.calcsubmit.Name = "calcsubmit"
        Me.calcsubmit.Size = New System.Drawing.Size(394, 41)
        Me.calcsubmit.TabIndex = 18
        Me.calcsubmit.Text = "Calculate"
        Me.calcsubmit.UseVisualStyleBackColor = True
        '
        'duedate
        '
        Me.duedate.Location = New System.Drawing.Point(613, 83)
        Me.duedate.Name = "duedate"
        Me.duedate.Size = New System.Drawing.Size(200, 20)
        Me.duedate.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(475, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 31)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Financial Goal: $"
        '
        'fin_goal
        '
        Me.fin_goal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin_goal.Location = New System.Drawing.Point(684, 42)
        Me.fin_goal.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.fin_goal.Name = "fin_goal"
        Me.fin_goal.Size = New System.Drawing.Size(120, 38)
        Me.fin_goal.TabIndex = 0
        '
        'titleincome
        '
        Me.titleincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleincome.Location = New System.Drawing.Point(642, 142)
        Me.titleincome.Name = "titleincome"
        Me.titleincome.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.titleincome.Size = New System.Drawing.Size(133, 38)
        Me.titleincome.TabIndex = 10
        '
        'formatincome
        '
        Me.formatincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formatincome.FormattingEnabled = True
        Me.formatincome.Items.AddRange(New Object() {"Week(s)", "Month(s)", "Year(s)"})
        Me.formatincome.Location = New System.Drawing.Point(1135, 141)
        Me.formatincome.MaxDropDownItems = 2
        Me.formatincome.Name = "formatincome"
        Me.formatincome.Size = New System.Drawing.Size(121, 39)
        Me.formatincome.TabIndex = 13
        '
        'timeincome
        '
        Me.timeincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeincome.Location = New System.Drawing.Point(1046, 142)
        Me.timeincome.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.timeincome.Name = "timeincome"
        Me.timeincome.Size = New System.Drawing.Size(83, 38)
        Me.timeincome.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(956, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 31)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Every"
        '
        'getincome
        '
        Me.getincome.DecimalPlaces = 2
        Me.getincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getincome.Location = New System.Drawing.Point(830, 142)
        Me.getincome.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.getincome.Name = "getincome"
        Me.getincome.Size = New System.Drawing.Size(120, 38)
        Me.getincome.TabIndex = 11
        '
        'incomebtn
        '
        Me.incomebtn.Location = New System.Drawing.Point(924, 183)
        Me.incomebtn.Name = "incomebtn"
        Me.incomebtn.Size = New System.Drawing.Size(88, 23)
        Me.incomebtn.TabIndex = 14
        Me.incomebtn.Text = "Store Income"
        Me.incomebtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(920, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Stored Income"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(770, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 31)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Get"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.Location = New System.Drawing.Point(648, 105)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(680, 35)
        Me.LinkLabel3.TabIndex = 29
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "                        Income                        "
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'getbtn
        '
        Me.getbtn.Location = New System.Drawing.Point(930, 438)
        Me.getbtn.Name = "getbtn"
        Me.getbtn.Size = New System.Drawing.Size(88, 23)
        Me.getbtn.TabIndex = 17
        Me.getbtn.Text = "Store Misc"
        Me.getbtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(926, 464)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 24)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Stored Misc"
        '
        'titleget
        '
        Me.titleget.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleget.Location = New System.Drawing.Point(822, 394)
        Me.titleget.Name = "titleget"
        Me.titleget.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.titleget.Size = New System.Drawing.Size(133, 38)
        Me.titleget.TabIndex = 15
        '
        'getmisc
        '
        Me.getmisc.DecimalPlaces = 2
        Me.getmisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getmisc.Location = New System.Drawing.Point(1010, 394)
        Me.getmisc.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.getmisc.Name = "getmisc"
        Me.getmisc.Size = New System.Drawing.Size(120, 38)
        Me.getmisc.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(950, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 31)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Get"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel4.Location = New System.Drawing.Point(648, 350)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(680, 35)
        Me.LinkLabel4.TabIndex = 38
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "                        Misc                        "
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(632, 109)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(5, 507)
        Me.TableLayoutPanel1.TabIndex = 45
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"haha"})
        Me.ListBox1.Location = New System.Drawing.Point(1046, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 82
        '
        'billstorage
        '
        Me.billstorage.FormattingEnabled = True
        Me.billstorage.Location = New System.Drawing.Point(164, 235)
        Me.billstorage.Name = "billstorage"
        Me.billstorage.Size = New System.Drawing.Size(390, 108)
        Me.billstorage.TabIndex = 83
        '
        'miscstorage
        '
        Me.miscstorage.FormattingEnabled = True
        Me.miscstorage.Location = New System.Drawing.Point(164, 491)
        Me.miscstorage.Name = "miscstorage"
        Me.miscstorage.Size = New System.Drawing.Size(408, 108)
        Me.miscstorage.TabIndex = 84
        '
        'incomestorage
        '
        Me.incomestorage.FormattingEnabled = True
        Me.incomestorage.Location = New System.Drawing.Point(822, 235)
        Me.incomestorage.Name = "incomestorage"
        Me.incomestorage.Size = New System.Drawing.Size(390, 108)
        Me.incomestorage.TabIndex = 85
        '
        'getstorage
        '
        Me.getstorage.FormattingEnabled = True
        Me.getstorage.Location = New System.Drawing.Point(822, 491)
        Me.getstorage.Name = "getstorage"
        Me.getstorage.Size = New System.Drawing.Size(408, 108)
        Me.getstorage.TabIndex = 86
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 24)
        Me.MenuStrip1.TabIndex = 87
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.AddExtension = False
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 669)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.getstorage)
        Me.Controls.Add(Me.incomestorage)
        Me.Controls.Add(Me.miscstorage)
        Me.Controls.Add(Me.billstorage)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.getbtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.titleget)
        Me.Controls.Add(Me.getmisc)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.titleincome)
        Me.Controls.Add(Me.formatincome)
        Me.Controls.Add(Me.timeincome)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.getincome)
        Me.Controls.Add(Me.incomebtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.fin_goal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.duedate)
        Me.Controls.Add(Me.calcsubmit)
        Me.Controls.Add(Me.miscbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.titlemisc)
        Me.Controls.Add(Me.paymisc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titlebill)
        Me.Controls.Add(Me.formatbill)
        Me.Controls.Add(Me.timebill)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.paybill)
        Me.Controls.Add(Me.billbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Accumulative Savings calc"
        CType(Me.paybill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timebill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paymisc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fin_goal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeincome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getincome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getmisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents billbtn As System.Windows.Forms.Button
    Friend WithEvents paybill As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents timebill As System.Windows.Forms.NumericUpDown
    Friend WithEvents formatbill As System.Windows.Forms.ComboBox
    Friend WithEvents titlebill As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents titlemisc As System.Windows.Forms.TextBox
    Friend WithEvents paymisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents miscbtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents calcsubmit As System.Windows.Forms.Button
    Friend WithEvents duedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fin_goal As System.Windows.Forms.NumericUpDown
    Friend WithEvents titleincome As System.Windows.Forms.TextBox
    Friend WithEvents formatincome As System.Windows.Forms.ComboBox
    Friend WithEvents timeincome As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents getincome As System.Windows.Forms.NumericUpDown
    Friend WithEvents incomebtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents getbtn As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents titleget As System.Windows.Forms.TextBox
    Friend WithEvents getmisc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents billstorage As System.Windows.Forms.ListBox
    Friend WithEvents miscstorage As System.Windows.Forms.ListBox
    Friend WithEvents incomestorage As System.Windows.Forms.ListBox
    Friend WithEvents getstorage As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
