   M S B A M L   `   `   `  ����N  JServicesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ServicesApplication.View.Pages.Admin$ServicesApplication.View.Pages.Admin  5      8    2ServicesApplication.View.Pages.Admin.AdminMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:ServicesApplication.View.Pages.Admin     5      -   5          N� Title$  AdminMainPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $��Поиск:��6   $��14(�5      $��80��5      �� 5      -   5         ��Name$ 	searchTxb��5      $��14(�5      $	��200��5      6&   5      5      � 5   
   $��1��6   .+�5       &   System.Windows.Controls.DataGrid  -   5          Name$ dataViewGrid��5          
IsReadOnly .    AutoGenerateColumns .     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Услуга��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6Y   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *ServiceName+6Y     5%      $ Длительность��6)   $	 * 6a   
 6?   �� *ServiceTiming+6a     5&      $# Дата проведения��6)   $	 * 6{   
 6B   �� *ServiceDate+ �� StringFormat$ 
dd.MM.yyyy��6{     5'      $ Стоимость��6)   $	 * 6V   
 6<   �� *Price+6V   5)      5*      � 5,   
   $��2��6   .+�5-      �� $��Center=�6   $
��Left=�5.      $��20,0,0,0q�5/      .+�50      �� -   5         ��Name$ backBtn��50      $��
Назад��51      $	��120��52      $��35��53      54      55      �� 56      $��Center=�6   $��Center=�57      $ 
Horizontal=�58      .+�59      �� -   5        $ addBtn��59      $��Добавить��5:      $	��120��5;      $��35��5<      $��0,0,20,0q�5=      6+   �� 5>      -   5        $ editBtn��5>      $ ��Редактировать��5?      $	��150��5@      $��35��5A      $��0,0,20,0q�5B      6+   �� 5C      -   5        $ 	deleteBtn��5C      $��Удалить��5D      $	��120��5E      $��35��5F      6%   5G      �� 5H      $��Center=�6   $��Right=�5I      $��0,0,20,0q�5J      .+�5K      �� -   5        $ viewZBtn��5K      $)��#Просмотреть записи��5L      $��35��5M      6%   5N      5O      5P      5Q      