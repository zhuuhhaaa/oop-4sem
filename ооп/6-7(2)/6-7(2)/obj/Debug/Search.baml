   M S B A M L   `   `   `  ����A  =6-7(2), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:_6_7_2__6_7_2_  5   	       _6_7_2_.Search   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:_6_7_2_     5   	     � Title$  Search��5   	   $	��450��6   $	��800��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $	��130 �6   6-    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��35 �6   6*   �� 5      $��70 �6   6*   .+�5   
   � $��2��6   $��3��6#      	GridStyle#���   65   6[   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DGClothes��5   �   $��0��6   $��0��6$   $��3��61   $��SemiBold"�6B      CanUserSortColumns . $��Trebuchet MS)�6r   $��15,15,15,42q�6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	_name��,  &System.Windows.Controls.DataGridColumn   CanUserSort .     Header$ Name of product��5   I   	   
FontFamily$	 Trebuchet MS)�6b   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 2* 6�      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6|   ��  �� Path$
 Name�6�     5      -   5        
_count��$ Count��5   5   $	 Trebuchet MS)�6E   $
 * 6~    .  6_   �� $ Count�6�     5      -   5        	_cost�� . $
 Cost��5   G   $	 Trebuchet MS)�6U   $
 * 6�    .  6o   �� $
 Cost�6�     5      -   5        
_matherial�� .  $ 	Matherial��5   M   $	 Trebuchet MS)�6`   $
 2* 6�    .  6z   �� $ 	Matherial�6�   5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $

 0.5* 6*    .   .  6K   �� $ HyperlinkText�   ElementStyle 5      �� 5      .�5      -   5        5      5       5"      5#      5$      