   M S B A M L   `   `   `  ����  WpfApp2    WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$   Restaurant Bill Calculator��5      $	��491��6(   $
��1325��65   .��5      � $��0,0,0,40q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $��0 0 20 0q�6   .+�5      �� $��Beverage��6   �� 5      -   5        $��cmbBeverage��5      $	��200��6.    �� DisplayMemberPath$ NameAndPrice��6b   5      �� 5      $��0 0 20 0q�6   .+�5      �� $��	Appetizer��6   �� 5      -   5        $��cmbAppetizer��5      $	��200��6/   $ NameAndPrice��6c   5      �� 5      $��0 0 20 0q�6   .+�5      �� $��Main Course��6   �� 5      -   5        $��cmbMainCourse��5      $	��200��60   $ NameAndPrice��6d   5      �� 5      $��0 0 20 0q�6   .+�5      �� $��Dessert��6   �� 5      -   5        $��
cmbDessert��5      $	��200��6-   $ NameAndPrice��6a   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgBill��5      $��1��6!   $��10,10,35,44q�6.      AutoGenerateColumns .  $	��NaN��6_   $	��NaN��6l      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Item+6L     5       $ Price��6%   $	 400 6^    64   �� *Price+	 �� StringFormat$	 C��6^   4  .System.Windows.Controls.DataGridTemplateColumn  5!      $ SizeToCells 6)   
   CellTemplate
 5"      �� 5#      .R�5$      �� -   5        $��Remove��5$   %   66   5%      5'      5)      �� 5*   
   $ 
Horizontal=�6   $��2��6.   $��30,7,942,13q�6;   .+�5+      �� $��	Subtotal:��6   �� 5,      -   5        $��
tbSubtotal��5,      $��$0.00��6*   $��5,0,0,0q�67   �� 5-      $
��Tax:��6   $��10,0,0,0q�6$   �� 5.      -   5        $��tbTax��5.      $��$0.00��6%   $��5,0,0,0q�62   �� 5/      $��Total:��6   $��10,0,0,0q�6&   �� 50      -	   5        $��tbTotal��50      $��$0.00��6'   $��5,0,0,0q�64   51      �� 52   
   $��
0,44,0,-42q�6   $��2��6(   .@�53      �� -
   5         ��Name$ tbStudentName��53      $��Santiago Leal Novoa��6/   �� 54      -   5         ��Name$ imgLogo��54      $7��1\Images\centennialcollege_logo_horizontal_rgb.jpg��6%   $��41��6`   $
��1181��6�    � Cursor$
 Hand��6�   55      �� 56   
   -   5        $��
Clear Bill��56      $��1189,5,54,22q�6&   $��2��6W   57      58      