   M S B A M L   `   `   `  ����N  JServicesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ServicesApplication.View.Pages.User#ServicesApplication.View.Pages.User  5      6    0ServicesApplication.View.Pages.User.UserMainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:ServicesApplication.View.Pages.User     5      -   5          N� Title$  UserMainPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   .+�5   
   � $��0��6   .+�5      �� $��Center=�6   $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $��Поиск:��6   $��14(�5      $��80��5      �� 5      -   5         ��Name$ 	searchTxb��5      $��14(�5      $	��200��5      6&   5      �� 5      $��Center=�6   $��Right=�5      $��0,0,20,0q�5      .+�5       �� -   5         ��Name$ personalCBtn��5       $��Мой аккаунт��5!      $��35��5"      $	��150��5#      6%   5$      5%      � 5'   
   $��1��6   .+�5(      &   System.Windows.Controls.DataGrid  -   5          Name$ dataViewGrid��5(         
IsReadOnly .    AutoGenerateColumns .     Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Услуга��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ServiceName+6Y     5-      $	 Длительность��6)   $
 * 6a    6?   �� *ServiceTiming+6a     5.      $#	 Дата проведения��6)   $
 * 6{    6B   �� *ServiceDate+ �� StringFormat$ 
dd.MM.yyyy��6{     5/      $	 Стоимость��6)   $
 * 6V    6<   �� *Price+6V   51      52      � 54   
   $��2��6   .+�55      �� $��Center=�6   $
��Left=�56      $��20,0,0,0q�57      .+�58      �� -   5        $ backBtn��58      $��
Назад��59      $	��120��5:      $��35��5;      5<      5=      �� 5>      $��Center=�6   $��Center=�5?      $ 
Horizontal=�5@      .+�5A      �� -   5        $ 
dopInfoBtn��5A      $��Подробнее��5B      $	��120��5C      $��35��5D      $��0,0,20,0q�5E      6+   �� 5F      -   5        $ delBtn��5F      $��Записаться��5G      $	��150��5H      $��35��5I      6%   5J      �� 5K      $��Center=�6   $��Right=�5L      $��0,0,20,0q�5M      .+�5N      �� -   5        $ myServiceTxb��5N      $2��,Просмотреть свои записи��5O      $��35��5P      6%   5Q      5R      5S      5T      