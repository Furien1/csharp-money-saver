   M S B A M L   `   `   `  ����E  AMoneySaver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MoneySaver
MoneySaver  5   	       MoneySaver.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MoneySaver     5   	     � Title$  Money Saver��5   	   $	��450��6   $	��800��6*    � 
ResizeMode$ CanMinimize=�66    � SizeToContent$ WidthAndHeight=�6O   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ btn_new��5      $��Új tranzakció��6"   $��1��5      $
��Left=�6!   $��	10,10,0,0q�6<   $��2��5      $	��Top=�6   $	��100��66   5      �� 5    
   $��Megtakarítás:��6   $��2��6(   $
��Left=�68   $��5,6,0,0q�5!      $��2��6!   $	��Top=�6.   �� 5"   
   -   5         ��Name$ lbl_Savings��5"      $��--��6%   $��3��62   $
��Left=�6B   $��5,6,0,0q�5#      $��2��6!   $	��Top=�6.   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ dg_money��5%      $��1��6%   $
��Left=�5&      $��	10,10,0,0q�5'      $��1��6&   $	��Top=�5(      $��4��5)         
IsReadOnly . 	   AutoGenerateColumns	 .  
   Columns
 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$
 Név��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 Name�6C     5.      $ Leírás��6F    6%   �� $ Details�6F     5/      $ Személy��6E    6%   �� $ Person�6E     50      $ Összeg��6D    6%   �� $ Value�6D   52      53      54      