   M S B A M L   `   `   `  ����M  ISchool Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:School_Application.View.Pages.Teachers&School_Application.View.Pages.Teachers  5      =    7School_Application.View.Pages.Teachers.TeachersMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:School_Application.View.Pages.Teachers     5      -   5          N� Title$#  Список учителей��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��0.1* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� $��Center=�6   $��20,0,0,0q�5      .+�5      �� $��Поиск:��6    $��17(�5       5      5      � 5       $��1��6   .+�5!      �� $��Center=�6   $��0,0,20,0q�5"      .+�5#      �� -   5         ��Name$ 	searchTxb��5#      $��16(�5$      6,   5%      5&      5'      � 5)   
   $��1��6   .+�5*      &   System.Windows.Controls.DataGrid  -   5          Name$ dataView��5*         AutoGenerateColumns .     
IsReadOnly .    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *	Surname+6V     5/      $ Имя��6)   $	 * 6O   
 66   �� *Name+6O     50      $ Отчество��6)   $	 * 6Z   
 6;   �� *
Patronymic+6Z   52      53      � 55   
   $��2��6   .+�56      �� $��Center=�6   $
��Left=�57      $��20,0,0,0q�58      .+�59      �� -   5         ��Name$ backBtn��59      $��
Назад��5:      $	��120��5;      $��35��5<      6%   5=      �� 5>      $��Center=�6   $��Center=�5?       �� Orientation$ 
Horizontal=�5@      .+�5A      �� -   5        $ addBtn��5A      $��Добавить��5B      $	��120��5C      $��35��5D      $��0,0,20,0q�5E      6+   �� 5F      -   5        $ editBtn��5F      $��Изменить��5G      $	��120��5H      $��35��5I      $��0,0,20,0q�5J      6+   �� 5K      -   5        $ 	deleteBtn��5K      $��Удалить��5L      $	��120��5M      $��35��5N      6%   5O      �� 5P      $��Center=�6   $��Right=�5Q      $ 
Horizontal=�5R      $��0,0,20,0q�5S      .+�5T      �� $��Center=�6   $��Печать:��5U      $��15(�5V      $��70��5W      �� 5X      -   5        $ wordBtn��5X      $
��WORD��5Y      $��0,0,10,0q�5Z      6+   �� 5[      -	   5        $ exelBtn��5[      $��Exсel��5\      6)   5]      5^      5_      5`      