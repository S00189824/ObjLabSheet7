   M S B A M L   `   `   `  ����>  :Ex2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Ex2Ex2  5   	       Ex2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Ex2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��190* �6   �� 5      $
��207* �6   .+�5   
   �� -   5         ��Name$ lxbox��5      $
��Left=�6!   $	��282��6<   $��	47,69,0,0q�6I   $	��Top=�6\   $	��269��6t   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dxdate��5      $
��Left=�6%   $��202.4,229,0,0q�6@   $	��Top=�6W   $��27��6o   $	��135��6{   $��1��6�   �� 5   
   -   5         ��Name$ btn_Addbutton��5      $	��Add��6(   $
��Left=�66   $��262.4,332,0,0q�6Q   $	��Top=�6h   $��75��6�   $��1��6�   �� 5   
   -   5         ��Name$ cbxMemberType��5      $
��Left=�6*   $��202.4,121,0,0q�6E   $	��Top=�6\   $	��135��6t   $��1��6�   �� 5   
   $
��Name��6   $
��Left=�6   $��67.4,177,0,0q�6:   $	��Top=�6P   $��27��6h   $��75��6t   $��1��6   �� 5   
   $��Member Type��6   $
��Left=�6&   $��67.4,121,0,0q�6A   $	��Top=�6W   $��27��6o   $	��108��6{   $��1��6�   �� 5   
   $��Date Joined��6   $
��Left=�6&   $��67.4,228,0,0q�6A   $	��Top=�6W   $��75��6o   $��1��6z   �� 5   
   $��Number of Members��6   $
��Left=�6,   $��67.4,370,0,0q�6G   $	��Top=�6]   $	��123��6u   $��1��6�   �� 5   
   -   5         ��Name$ txblkNumberOfMembers��5      $
��Left=�62   $��234.4,370,0,0q�6M   $
��Wrap=�6d   $	��Top=�6x   $��25��6�   $��50��6�   $��1��6�   �� 5   
   -   5         ��Name$ txbName��5      $��1��6#   $
��Left=�63   $��23��6N   $��203,181,0,0q�6Z    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��134��6�   5      5      