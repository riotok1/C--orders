   M S B A M L   `   `   `  ����M  ISchool Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:School_Application.View.Pages.Students&School_Application.View.Pages.Students  5      =    7School_Application.View.Pages.Students.StudentsMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:School_Application.View.Pages.Students     5      -   5          N� Title$#  Список учеников��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��0.1* �6#   �� 5      $��* �6#   .+�5      � $��0��6   .+�5      �� $��Center=�6   $��20,0,0,0q�5      .+�5      �� $��Поиск:��6    $��17(�5       5      5      � 5       $��1��6   .+�5!      �� $��Center=�6   $
��Left=�5"      $��20,0,0,0q�5#      .+�5$      �� -   5         ��Name$ 	searchTxb��5$      $	��700��5%      $��16(�5&      6,   5'      5(      5)      � 5+   
   $��1��6   .+�5,      &   System.Windows.Controls.DataGrid  -   5          Name$ dataView��5,         AutoGenerateColumns .     
IsReadOnly .    Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *	Surname+6V     51      $ Имя��6)   $	 * 6O   
 66   �� *Name+6O     52      $ Отчество��6)   $	 * 6Z   
 6;   �� *
Patronymic+6Z     53      $ 
Класс��6)   $	 * 6^   
 68   �� *Class.ClassNumber+6^     54      $ 
Буква��6)   $	 * 6Y   
 68   �� *Class.Letter+6Y   56      57      � 59   
   $��2��6   .+�5:      �� $��Center=�6   $
��Left=�5;      $��20,0,0,0q�5<      .+�5=      �� -   5         ��Name$ backBtn��5=      $��
Назад��5>      $	��120��5?      $��35��5@      6%   5A      �� 5B      $��Center=�6   $��Center=�5C       �� Orientation$ 
Horizontal=�5D      .+�5E      �� -   5        $ addBtn��5E      $��Добавить��5F      $	��120��5G      $��35��5H      $��0,0,20,0q�5I      6+   �� 5J      -   5        $ editBtn��5J      $��Изменить��5K      $	��120��5L      $��35��5M      $��0,0,20,0q�5N      6+   �� 5O      -   5        $ 	deleteBtn��5O      $��Удалить��5P      $	��120��5Q      $��35��5R      6%   5S      �� 5T      $��Center=�6   $��Right=�5U      $ 
Horizontal=�5V      $��0,0,20,0q�5W      .+�5X      �� $��Center=�6   $��Печать:��5Y      $��15(�5Z      $��70��5[      �� 5\      -   5        $ wordBtn��5\      $
��WORD��5]      $��0,0,10,0q�5^      6+   �� 5_      -	   5        $ excelBtn��5_      $��Excel��5`      5a      5b      5c      5d      5e      