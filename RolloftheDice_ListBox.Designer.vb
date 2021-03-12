<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RolloftheDice_ListBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetsTheAmountsToZeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiceOutcomeListBox = New System.Windows.Forms.ListBox()
        Me.LeaveTheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(11, 223)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(139, 66)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&Roll"
        Me.ToolTip1.SetToolTip(Me.RollButton, "Roll dice")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(156, 223)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(139, 66)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clear rolls")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(302, 223)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(139, 66)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Leave program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(450, 24)
        Me.TopMenuStrip.TabIndex = 4
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'RollToolStripMenuItem
        '
        Me.RollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem})
        Me.RollToolStripMenuItem.Name = "RollToolStripMenuItem"
        Me.RollToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.RollToolStripMenuItem.Text = "&Roll"
        '
        'RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem
        '
        Me.RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem.Name = "RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem"
        Me.RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem.Size = New System.Drawing.Size(460, 22)
        Me.RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem.Text = "Rolls two six sided dice 1000 times and displays the output in the text box"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetsTheAmountsToZeroToolStripMenuItem})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ResetsTheAmountsToZeroToolStripMenuItem
        '
        Me.ResetsTheAmountsToZeroToolStripMenuItem.Name = "ResetsTheAmountsToZeroToolStripMenuItem"
        Me.ResetsTheAmountsToZeroToolStripMenuItem.Size = New System.Drawing.Size(300, 22)
        Me.ResetsTheAmountsToZeroToolStripMenuItem.Text = "Resets the amount of recorded rolls to zero"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveTheProgramToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'DiceOutcomeListBox
        '
        Me.DiceOutcomeListBox.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiceOutcomeListBox.FormattingEnabled = True
        Me.DiceOutcomeListBox.ItemHeight = 12
        Me.DiceOutcomeListBox.Location = New System.Drawing.Point(11, 25)
        Me.DiceOutcomeListBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DiceOutcomeListBox.Name = "DiceOutcomeListBox"
        Me.DiceOutcomeListBox.Size = New System.Drawing.Size(430, 172)
        Me.DiceOutcomeListBox.TabIndex = 5
        '
        'LeaveTheProgramToolStripMenuItem
        '
        Me.LeaveTheProgramToolStripMenuItem.Name = "LeaveTheProgramToolStripMenuItem"
        Me.LeaveTheProgramToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LeaveTheProgramToolStripMenuItem.Text = "Leave the program"
        '
        'RolloftheDice_ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 300)
        Me.Controls.Add(Me.DiceOutcomeListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "RolloftheDice_ListBox"
        Me.Text = "Form1"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ExitButton As Button
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollsTwoSixSidedDice1000TimesAndDisplaysTheOutputInTheTextBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetsTheAmountsToZeroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiceOutcomeListBox As ListBox
    Friend WithEvents LeaveTheProgramToolStripMenuItem As ToolStripMenuItem
End Class
