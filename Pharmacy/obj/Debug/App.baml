   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PharmacyPharmacy  5      Q-clr-namespace:PharmacyCourseProject.ViewModelPharmacyCourseProject.ViewModel  5          Pharmacy.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:Pharmacy     5      C	viewModel-clr-namespace:PharmacyCourseProject.ViewModel     5        �� 	Resources  5      3   -PharmacyCourseProject.ViewModel.MainViewModel   MainViewModel �� 
TargetType �� Property �� Value �� 
TargetType  ButtonTemplate ��Name ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName  ComboBoxNormalBorderBrush �� Color ! ComboBoxNormalBackgroundBrush # ComboBoxDisabledForegroundBrush # ComboBoxDisabledBackgroundBrush  ComboBoxDisabledBorderBrush   ComboBoxToggleButtonTemplate � ColumnDefinitions �� CornerRadius  ComboBoxFlatStyle �� 	ClickMode d� 	IsChecked �� Path �� RelativeSource �� Mode J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate �� 
IsReadOnly �� 
IsReadOnly � AllowsTransparency �� IsDropDownOpen J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation��%�  &	        'F�      &	 ]    '�� �    '�� c    &	 `    &	 �    &	 �    &	 �    &	 �    &	 �    7  7  7  7  7  7  7  &	 d
    7  7  7    5	   
   6"   �� 5   
   " F�6   .�5      ��  � ��$ 2��60   �� 5       �@��StrokeStartLineCap$ Round=�63   �� 5       �@��StrokeEndLineCap$ Round=�61   �� 5       �@��StrokeLineJoin$ Round=�6/   �� 5       �@��StrokeDashCap$ Round=�6.   �� 5       � ��
 �2�2�6%   5      �� 5   
   " ��6   .R�5      � .+�5      �� $
 rect��6/   ���	#FF6DFF74�� 5      $ Content��6#   $��Center=�64   $��Center=�6Q   5       5      P� 5       �@J�IsMouseOver	 . . �5      �� $

 rect��6    � �� �	#FF6DFF746?   5      P� 5       � ��	 . . �5       �� $

 rect��6-    � �� �	#FF6CE87D6?   5!      5#      �� 5(   
   " ��6   .�5)      ��  � ��$ Console)�6+   �� 5*       � ��$ 15(�6)   5+      �� 5/   
   " ��6   .�50      ��  � �� 51      �� 52      " ��6&   .R�53      � $��Panel��6   .+�54      �� $ ContentSite��6/   $��Center=�55   )   $��Center=�56   )   $��Header��57   )   $
��10,2q�58   )   59       5:      P� 5;       �@��
IsSelected	 . . �5<   "   �� $
 Panel��6)    � ��
 ��·�6R   5=      P� 5>       �@��
IsSelected	 .  . �5?   "   �� $
 Panel��6)    � ��
 �����6R   5@      5B      5D      5E      �� 5I   
   $ #e3e9ef��6<   �� 5J   
   $
 #fff��6@   �� 5K   
   $
 #888��6B   �� 5L   
   $
 #eee��6B   �� 5M   
   $
 #888��6>   �� 5O   
   " d�6   .R�5P      �  5Q      �� 5R      �� 5S      $��20 �6'   .+�5U      �� $��Border��6-   $��2��6   8��  $ 0��5W      $��
1, 1, 1, 1q�6    8�� 5X      �� 5Y      $��ButtonBorder��6P   $��1��6   $��
1, 1, 1, 1q�6)   ���#444$ 
0, 0, 0, 0��5Z      $��
0, 0, 0, 0q�6)   8�� 5[      F� 5]      $��Arrow��6   $��1��6$   =����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	$��Center=�5_      ���#444$��Center=�5`      5a       5b      P� 5c       �@J�IsMouseOver	 . . �5d      �� $
 ButtonBorder��69    � ��
 �����6S   5e      P� 5f       �@d�	IsChecked$
	 TrueY�6<   . �5g      �� $
 ButtonBorder��69    � ��
 �����6S   �� 5h      $
 Arrow��63    � �� �	#FF8D979E6F   5i      P� 5j       � {�	 .  . �5k      �� $
 Border��69   8   � ��6M   �� 5l      $
 ButtonBorder��69   8   � ��6S   �� 5m      $
 ButtonBorder��6;   8   � ��6U   �� 5n      8   � ��6?   �� 5o      $
 Arrow��63    � �� �#9996F   5p      5r      �� 5t   
   " ��6+   .�5u      ��  �@J�SnapsToDevicePixels . 6>   �� 5v       �@�OverridesDefaultStyle . 6G   �� 5w       � ��$
 Auto=�6K   �� 5x       � ��$
 Auto=�6I   �� 5y       � �� . 6>   �� 5z       � ��
 �   �67   �� 5{       �@�FocusVisualStyle 6B   Z� �� 5|       � �� 5}      �� 5~      " ��6&   .R�5      � .+�5�      d� $��ToggleButton��6+   $��2��6?   $ Press=�5�      |�.  8��   5�      �� $ IsDropDownOpen� �� *TemplatedParent+$ TwoWay=�5�      �� 5�      $��ContentSite��6/   $��5, 3, 23, 3q�6B    .  $
��Left=�5�      $��Center=�6:   #��z 5�      #��z 5�      #��z��5�      �� 5�      $��PART_EditableTextBox��6&   $��3, 3, 23, 3q�6B   # z 5�      $y�Hidden=�5�      
������ $
��Left=�5�      $��Center=�61   |�. .��5�   (   ��5�   "   �� 5�   &   " ��66   .R�5�   *   �� $��PART_ContentHost��61   |�.  6I   5�   '   .��5�   4   5�      � 5�      $��Popup��6$   $��Bottom=�61   |�.   . #��z 5�      $��Slide=�5�      .��5�   "   � $��DropDown��6'    . #��z 5�      #��z 5�      .+�5�   &   �� $��DropDownBorder��6-   
�������$��
0, 1, 0, 0q�6V   $ 0��5�      $��1,1,1,1q�6*   8�� 5�      �� 5�   &   $��4q�63    . .��5�   *   �� $ 	Contained=�69   5�   '   5�   #   5�      5�       5�      P� 5�       �@��HasItems	 .  . �5�   "   �� $
 DropDownBorder��6O    � ��$ 95��6k   5�      P� 5�       � {�	 .  . �5�   "   �� 8   � ��6K   5�      P� 5�       �@��
IsGrouping	 . . �5�   "   ��  � �� .  6R   5�      P� 5�       �@��
IsEditable	 . . �5�   "   ��  �@ 	IsTabStop .  6Q   �� 5�   "   $
 PART_EditableTextBox��6I    � y�$ Visible=�6k   �� 5�   "   $
 ContentSite��6I    � y�$ Hidden=�6b   5�      5�      5�      5�      5�      5�      