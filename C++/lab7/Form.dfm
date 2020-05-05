object Form1: TForm1
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = 'Hashing'
  ClientHeight = 460
  ClientWidth = 696
  Color = clBtnText
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label2: TLabel
    Left = 248
    Top = 14
    Width = 200
    Height = 23
    Caption = 'Hash displaying field'
    Color = clWhite
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWhite
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentColor = False
    ParentFont = False
  end
  object Panel1: TPanel
    Left = 0
    Top = 347
    Width = 696
    Height = 113
    Align = alBottom
    BevelInner = bvRaised
    BevelKind = bkTile
    BevelOuter = bvNone
    Color = clMoneyGreen
    ParentBackground = False
    TabOrder = 0
    object Label3: TLabel
      Left = 33
      Top = 6
      Width = 168
      Height = 23
      AutoSize = False
      Caption = 'Functions pannel'
      Color = clBlack
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -19
      Font.Name = 'Tahoma'
      Font.Style = [fsBold, fsItalic]
      ParentColor = False
      ParentFont = False
    end
    object Label5: TLabel
      Left = 287
      Top = 42
      Width = 104
      Height = 21
      Caption = 'Find in hash'
      Color = clBlack
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -17
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentColor = False
      ParentFont = False
    end
    object Label6: TLabel
      Left = 418
      Top = 42
      Width = 147
      Height = 21
      Caption = 'Delete from hash'
      Color = clBlack
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -17
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentColor = False
      ParentFont = False
    end
    object Label1: TLabel
      Left = 131
      Top = 42
      Width = 112
      Height = 21
      Caption = 'Set hash size'
      Color = clBlack
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clBlack
      Font.Height = -17
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentColor = False
      ParentFont = False
    end
    object Edit2: TEdit
      Left = 271
      Top = 63
      Width = 136
      Height = 21
      Hint = 'Press ENTER to find item'
      MaxLength = 5
      NumbersOnly = True
      ParentShowHint = False
      ShowHint = True
      TabOrder = 3
      OnKeyPress = Edit2KeyPress
    end
    object Edit3: TEdit
      Left = 423
      Top = 63
      Width = 136
      Height = 21
      Hint = 'Press ENTER to delete item'
      MaxLength = 5
      NumbersOnly = True
      ParentShowHint = False
      ShowHint = True
      TabOrder = 4
      OnKeyPress = Edit3KeyPress
    end
    object Button1: TButton
      Left = 7
      Top = 35
      Width = 89
      Height = 36
      Caption = 'Add items'
      TabOrder = 2
      OnClick = Button1Click
    end
    object Edit1: TEdit
      Left = 119
      Top = 63
      Width = 136
      Height = 21
      MaxLength = 5
      NumbersOnly = True
      ParentShowHint = False
      ShowHint = False
      TabOrder = 0
    end
    object Edit4: TEdit
      Left = 7
      Top = 77
      Width = 89
      Height = 21
      MaxLength = 4
      NumbersOnly = True
      ParentShowHint = False
      ShowHint = True
      TabOrder = 1
      TextHint = 'Num of items'
    end
    object Button2: TButton
      Left = 591
      Top = 51
      Width = 89
      Height = 36
      Caption = 'Task completion button'
      TabOrder = 5
      WordWrap = True
      OnClick = Button2Click
    end
  end
  object Memo2: TMemo
    Left = 0
    Top = 43
    Width = 696
    Height = 283
    Align = alCustom
    ReadOnly = True
    ScrollBars = ssBoth
    TabOrder = 1
  end
end
