   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5      !    ExpenseIt.ExpenseReportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ExpenseIt - View Expense��5      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      typeItemTemplate �� XPath  amountItemTemplate��%�   &	        &	 I     �� 5      .R�5      �� ��6   �� $ @ExpenseType��5      �� 5      .R�5      �� ��6   �� $ @ExpenseAmount��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      .+�5$   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   Expense Report For:5&      � 5'   
   $��1��5(      $��1��5)      $��10q�5*       5+      �� 5,      �� 5-       5/      �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      .+�55      �� $��0��56      $��0��57      $��2��58       �� Orientation$ 
Horizontal=�59      .+�5:      ��   
labelStyle#��[ 6   .��6<   Name:6C   �� 5;      #��[ 68   ��6   �� $ @Name��68   5<      �� 5>      $��1��5?      $��0��5@      $��2��5A      $ 
Horizontal=�5B      .+�5C      �� #��[ 6   .��6<   Department:6I   �� 5D      #��[ 6>   ��6   �� $ @Department��6>   5E      � 5F      $��2��5G      $��0��5H      $��2��5I      $
��Left=�5J      $	��Top=�5K      .+�5M      &   System.Windows.Controls.DataGrid     AutoGenerateColumns .    columnHeaderStyle   ColumnHeaderStyle# [ 5O      	   RowHeaderWidth$	 0Q�5Q      ��5P      �� $ Expense��
   Columns
 5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn   Header$ ExpenseType��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� $ @ExpenseType��6T     5T      $ Amount��6V    6-   �� $ @ExpenseAmount��6V   5V      5W      5X      5Z      5[      