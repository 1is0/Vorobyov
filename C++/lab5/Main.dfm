object Form1: TForm1
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = 'Queues'
  ClientHeight = 443
  ClientWidth = 645
  Color = clSilver
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 282
    Top = 6
    Width = 80
    Height = 19
    Caption = 'Queue #1'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 282
    Top = 156
    Width = 80
    Height = 19
    Caption = 'Queue #2'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -16
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object ListBox1: TListBox
    Left = 62
    Top = 26
    Width = 520
    Height = 115
    BevelKind = bkSoft
    BevelOuter = bvRaised
    Columns = 10
    ItemHeight = 13
    TabOrder = 1
  end
  object ListBox2: TListBox
    Left = 62
    Top = 176
    Width = 520
    Height = 115
    BevelKind = bkSoft
    BevelOuter = bvRaised
    Columns = 10
    ItemHeight = 13
    TabOrder = 2
  end
  object Panel1: TPanel
    Left = 6
    Top = 304
    Width = 633
    Height = 131
    BevelInner = bvRaised
    BevelKind = bkTile
    BevelOuter = bvLowered
    Color = clGradientActiveCaption
    ParentBackground = False
    TabOrder = 0
    object Label4: TLabel
      Left = 256
      Top = 24
      Width = 116
      Height = 29
      Caption = 'Functions'
      Font.Charset = DEFAULT_CHARSET
      Font.Color = clWindowText
      Font.Height = -24
      Font.Name = 'Tahoma'
      Font.Style = [fsBold]
      ParentFont = False
    end
    object Button1: TButton
      Left = 63
      Top = 78
      Width = 95
      Height = 33
      Caption = 'Pop from Queue #1'
      TabOrder = 1
      WordWrap = True
      OnClick = Button1Click
    end
    object Button2: TButton
      Left = 471
      Top = 78
      Width = 95
      Height = 33
      Caption = 'Pop from Queue #2'
      TabOrder = 3
      WordWrap = True
      OnClick = Button2Click
    end
    object Button3: TButton
      Left = 63
      Top = 24
      Width = 95
      Height = 33
      Caption = 'Push to Queue #1'
      TabOrder = 0
      WordWrap = True
      OnClick = Button3Click
    end
    object Button4: TButton
      Left = 471
      Top = 24
      Width = 95
      Height = 33
      Caption = 'Push to Queue #2'
      TabOrder = 2
      WordWrap = True
      OnClick = Button4Click
    end
    object Button5: TButton
      Left = 267
      Top = 70
      Width = 95
      Height = 33
      Caption = 'Modify queue #2'
      TabOrder = 4
      WordWrap = True
      OnClick = Button5Click
    end
  end
end
