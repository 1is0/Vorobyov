object Form2: TForm2
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsDialog
  Caption = 'Subform'
  ClientHeight = 187
  ClientWidth = 393
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poDesktopCenter
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 91
    Top = 70
    Width = 81
    Height = 13
    Caption = 'Passport number'
  end
  object Label3: TLabel
    Left = 165
    Top = 11
    Width = 63
    Height = 23
    Caption = 'Label3'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
    WordWrap = True
  end
  object Label2: TLabel
    Left = 125
    Top = 101
    Width = 45
    Height = 13
    Caption = 'Full name'
  end
  object Edit1: TEdit
    Left = 180
    Top = 67
    Width = 121
    Height = 21
    MaxLength = 10
    NumbersOnly = True
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 180
    Top = 98
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object Button1: TButton
    Left = 159
    Top = 154
    Width = 75
    Height = 25
    Caption = 'OK'
    TabOrder = 2
    OnClick = Button1Click
  end
end
