   M S B A M L   `   `   `  ����D  @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt  5          ExpenseIt.ExpenseItHome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ExpenseIt     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ExpenseIt – Home��5      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � Source � XPath  nameItemTemplate �� XPath��%�   &	        &	 N     � 5      $ Data/XMLData.xml?�5      $ Expenses/Persons��5      �� 5      .R�5      �� ��6   �� $ @Name��5      5      ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5    
   �� 5!      �� 5"      $
��Auto �6   �� 5#      �� 5$      $
��Auto �6   .+�5'   
   �� $��1��6     headerTextStyle#��[ 6    .��6I   View Expense Report5)      �� 5*   
   $��1��5+      $��1��5,        listHeaderStyle#��[ 5-      ._�5.      ��   listHeaderTextStyle#��[ 6   .��6A   Names6H   5/      �� 50   
   -   5        $��peopleListBox��51      $��2��52      $��1��53      #��[ 54      ��55      ��  �� Source# [  $ Person���� 57   
   -   5        $��3��58      $��1��59        buttonStyle#��[ 5;      .��62   View5=      5>      5?      