object Form1: TForm1
  Left = 343
  Top = 154
  Margins.Bottom = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = 'Trees'
  ClientHeight = 833
  ClientWidth = 1073
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesigned
  PixelsPerInch = 96
  TextHeight = 13
  object TreeView1: TTreeView
    Left = 0
    Top = 57
    Width = 249
    Height = 776
    Align = alLeft
    BevelInner = bvNone
    BevelOuter = bvRaised
    BevelKind = bkTile
    Indent = 19
    ReadOnly = True
    TabOrder = 2
  end
  object StringGrid1: TStringGrid
    Left = 248
    Top = 57
    Width = 826
    Height = 320
    Align = alCustom
    BevelInner = bvNone
    BevelKind = bkTile
    BevelOuter = bvRaised
    Color = clBtnFace
    ColCount = 2
    DefaultColWidth = 408
    FixedCols = 0
    RowCount = 2
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goEditing, goTabs, goFixedColClick]
    ParentFont = False
    ScrollBars = ssVertical
    TabOrder = 3
    RowHeights = (
      24
      24)
  end
  object Panel1: TPanel
    Left = 0
    Top = 0
    Width = 1073
    Height = 57
    Align = alTop
    BevelKind = bkTile
    Color = clGradientInactiveCaption
    ParentBackground = False
    TabOrder = 1
    ExplicitWidth = 1074
    object Label3: TLabel
      Left = 520
      Top = 120
      Width = 31
      Height = 13
      Caption = 'Label3'
    end
    object Label2: TLabel
      Left = 658
      Top = 16
      Width = 57
      Height = 25
      Caption = 'Table'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -21
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label1: TLabel
      Left = 74
      Top = 16
      Width = 101
      Height = 25
      Caption = 'Tree view'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -21
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
  end
  object Panel2: TPanel
    Left = 248
    Top = 712
    Width = 826
    Height = 121
    Margins.Left = 0
    Margins.Right = 0
    Margins.Bottom = 0
    Align = alCustom
    Alignment = taRightJustify
    BevelKind = bkTile
    Color = clGradientActiveCaption
    ParentBackground = False
    TabOrder = 0
    object Label4: TLabel
      Left = 28
      Top = 24
      Width = 185
      Height = 25
      AutoSize = False
      Caption = 'Functions pannel'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -21
      Font.Name = 'Tahoma'
      Font.Style = [fsBold, fsItalic]
      ParentFont = False
    end
    object Label5: TLabel
      Left = 290
      Top = 12
      Width = 151
      Height = 17
      AutoSize = False
      Caption = 'Number of leaves:'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Label6: TLabel
      Left = 523
      Top = 12
      Width = 151
      Height = 17
      AutoSize = False
      Caption = 'Rows control:'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -16
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Button2: TButton
      Left = 159
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Balance a tree'
      TabOrder = 1
      WordWrap = True
      OnClick = Button2Click
    end
    object Button1: TButton
      Left = 28
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Form new tree with table data'
      TabOrder = 0
      WordWrap = True
      OnClick = Button1Click
    end
    object Button3: TButton
      Left = 290
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Add new item'
      TabOrder = 2
      WordWrap = True
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 421
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Find data by key'
      TabOrder = 3
      WordWrap = True
      OnClick = Button4Click
    end
    object Button5: TButton
      Left = 552
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Delete data by key'
      TabOrder = 4
      WordWrap = True
      OnClick = Button5Click
    end
    object Button6: TButton
      Left = 684
      Top = 66
      Width = 100
      Height = 45
      Caption = 'Print data by type'
      TabOrder = 5
      WordWrap = True
      OnClick = Button6Click
    end
    object ComboBox1: TComboBox
      Left = 664
      Top = 39
      Width = 145
      Height = 21
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -11
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
      TabOrder = 6
      Text = 'Printing types...'
      Items.Strings = (
        'Pre-order'
        'Post-order'
        'In-order')
    end
    object Edit1: TEdit
      Left = 305
      Top = 35
      Width = 121
      Height = 21
      ReadOnly = True
      TabOrder = 7
    end
    object Button8: TButton
      Left = 531
      Top = 35
      Width = 25
      Height = 25
      Caption = '+'
      TabOrder = 8
      WordWrap = True
      OnClick = Button8Click
    end
    object Button7: TButton
      Left = 594
      Top = 35
      Width = 25
      Height = 25
      Caption = '-'
      TabOrder = 9
      WordWrap = True
      OnClick = Button7Click
    end
  end
  object Memo1: TMemo
    Left = 248
    Top = 376
    Width = 826
    Height = 337
    Margins.Left = 0
    Margins.Top = 0
    Margins.Right = 0
    Margins.Bottom = 0
    Align = alCustom
    BevelInner = bvNone
    BevelKind = bkTile
    BevelOuter = bvRaised
    ReadOnly = True
    TabOrder = 4
  end
end
