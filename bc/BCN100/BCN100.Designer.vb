﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCN100
    Inherits Base7.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EPanel1 = New Frame7.ePanel()
        Me.g10 = New Frame7.eGrid()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.g10)
        Me.EPanel1.Location = New System.Drawing.Point(4, 4)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(812, 428)
        Me.EPanel1.TabIndex = 2
        Me.EPanel1.Text = "     "
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(2, 23)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(808, 403)
        Me.g10.TabIndex = 2
        '
        'BCN100
        '
        Me.Controls.Add(Me.EPanel1)
        Me.Name = "BCN100"
        Me.Size = New System.Drawing.Size(837, 519)
        Me.Controls.SetChildIndex(Me.EPanel1, 0)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents g10 As Frame7.eGrid

End Class
