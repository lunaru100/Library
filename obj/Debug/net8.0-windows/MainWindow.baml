   M S B A M L   `   `   `  ����M  IWolska_BookManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Wolska_BookManagerWolska_BookManager  5   	   #    Wolska_BookManager.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Wolska_BookManager     5   	     � Title$  Book Manager��5   	   $	��450��6   $	��800��6+   
������� � 	Resources 5
         PrimaryColor  SecondaryColor  	TextColor  PrimaryBrush �� Color  SecondaryBrush  	TextBrush&   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader:  4System.Windows.Controls.Primitives.DataGridRowHeader��%0  &	        &	      &	 >     &	 ]     7   &	 u     7  &	 �     7  '  �     7  7  7  7  '  �    7  '  l    ��5   
   #A8BA9A��6.   ��5   
   #ACE894��60   ��5   
   #4A314D��6+   �� 5   
   8   6/   �� 5   
   8   61   �� 5   
   8   6,   �� 5   
   "  6   .�5      ��  � ��8   6+   �� 5       � ��
 �����6+   �� 5       � ��8  6,   �� 5       � ��$ 0q�60   �� 5       �@ RowBackground8  6.   �� 5        �@ AlternatingRowBackground8  69   5      �� 5   
   "  6   .�5      ��  � ��
 �����6+   �� 5       � ��8   6+   �� 5       � ��$
 Bold"�6+   �� 5        � ��$ 5q�6(   5!      �� 5#   
   "  6   .�5$      ��  � ��
 �����6+   5%      5&      .��5'      �  � RowDefinitions 5(   
   �� 5)      $
��Auto �6   �� 5*      $��* �6   .+�5,   
   o� $��0��6   .@�5-      m� $
��Plik��6   .@�5.      m� -   5        $��Eksportuj do TXT��5.      65   m� 5/      -   5        $��Eksportuj do CSV��5/      65   50      51        52   
   -   5          Name$ bookDataGrid��52      $��1��6)      AutoGenerateColumns$ False��67   $��10,10,10,50q�6S   	   
IsReadOnly$
	 True��6h   
   Columns
 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Autor��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Author+  55      $ Tytuł��6%    64   �� *Title+  56      $ Gatunek��6%    66   �� *Genre+  57      $	 Typ��6%    62   �� *Type+  58      $ Rok wydania��6%    6:   �� *Year+  59      $ Liczba tomów��6%    6;   �� *Volume+5;      c� 5=   
   $��30��6   $��Bottom=�6   $��2��69   .@�5>      �� -   5        $��Dodaj książkę��5>      6-   �� 5?      -   5        $��Edytuj książkę��5?      6.   �� 5@      -   5        $��Usuń książkę��5@      6,   5A      5B      5C      