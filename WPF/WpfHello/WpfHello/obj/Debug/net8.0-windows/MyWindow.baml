   M S B A M L   `   `   `  ����C  ?WpfHello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfHelloWpfHello  5   	       WpfHello.MyWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (Localclr-namespace:WpfHello     5   	   -   5          � Title$  MyWindow��5   	   $	��450��6   $	��800��6'      gradientStyle#��[  63    � 	Resources 5
       �� MergedDictionaries �� Source �� 
TargetType �� Property �� Value �� 
TargetType � Color	 � Offset
 � LayoutTransform �� Angle �� Triggers P� Property P� Value N� EnterActions ��Name g� Duration �� TargetProperty	 W� To N� ExitActions �� BeginStoryboardName �� Triggers   WpfHello.StudentList  studentCollection#   WpfHello.BoolToBrushConverter  boolToBrushConverter  listBoxTemplate �� Orientation �� Path �� 	Converter�� 5   
    5      �� 5      $ MyDictionary.xaml?�6%   %�  '��       &	 |    &	 �    &	 �    7  �� 5      " ��6   .�5      ��  �@�OverridesDefaultStyle$
 True��66   �� 5       � ��$ 50��6*   �� 5       � ��$ 50��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� ��5   "   
� 5   &   .��5   *   � $
 Blue��67   $	 0Q�6D   � 5   *   $ 
BlueViolet��67   $	 1Q�6J   5   '   
 5    "   �� 5!   &   $ 45Q�66   5#      �� 5%      $��Center=�6/   $��Center=�6L   5&       5'      P� 5(       �@J�IsMouseOver$
 True��6=    5)   "   �� 5*   &   $ 
Storyboard��66   .��5+   *   �� $ 0:0:1D�65   .��5,   .   W� $ FontSize�6>    206c   W� 5-   .   $ Width�6>    1006`   W� 5.   .   $ Height�6>    1006a   5/   +   50   '    52   "   �� 53   &   $ 
Storyboard��65   55      57      59       5:      5a        5b      6      5c      6)   �� 5d      .R�5e      �� $ 
Horizontal=�6   .+�5f      �� $��10��6r   $��10��6~   $��0,0,5,0q�6�   ��6    �� $ 
IsEnrolled�8   6�   �� 5g      ��6    �� $ StudentName�5h      5i      5j      .��5l      � .+�5m   
   �� -   5         ��Name$ button��5m      $��Button��6!   $
��Left=�62   $��70��6M   $��70��6Y   $��206,157,0,0q�6d   $	��Top=�6y     customButtonTemplate#���  6�   �� 5n   
   -   5         ��Name$ textBox��5n      $
��Left=�6#   $��317,157,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $��TextBox��6g   $	��Top=�6v   $��80��6�   $	��120��6�   �� 5o   
   -   5         ��Name$ listBox1��5o      $��60��6$   $
��Left=�60   $��	12,12,0,0q�6K   $	��Top=�6^   $	��250��6v   #��[ 5q      ��5p      ��  �� Source# [ 5q      5s      5t      