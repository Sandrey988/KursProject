   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Pharmacy.ViewsPharmacy.Views  5          Pharmacy.Views.AdminView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Pharmacy.Views     5      .��5	      �    MainViewModel  � DataContext#  [  6    � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      �� 5      $	��400 �6#   .+�5      �� $��1��6   .@�5      �� ��5      �� 5      $��/Icons/admin_add.png��6    $��32��6>   $��32��6I   .��5      �� $
��Auto=�6#   .��5      �� .+�5      ��  �� 
IsReadOnly . y�6<   �� *%#AdminAddAnnotations.ErrorVisibility+. �5   "   /� .T�5   &   J� .*�60   .*�5   *   �� 
���  ��$
��Bold"�6n   �6.   �� *AdminAddAnnotations.ErrorsAdd+6n   5   '   5    #   5!      �� 5"      $8��2Введите название препарата��6$   �� 5#       �� TextWrapping$
 Wrap=�6S   ��6&   �� *AdminAddAnnotations.AddName+6S   �� 5$      $9��3Фармакологическое действие��6$   �� 5%      $
 Wrap=�6U   ��6&   �� *AdminAddAnnotations.AddEffect+6U   �� 5&      $0��*Показания к применению��6$   �� 5'      $
 Wrap=�6`   ��6&   �� **(AdminAddAnnotations.AddIndicationsForUse+6`   �� 5(      $'��!Способ применения��6$   �� 5)      $
 Wrap=�6`   ��6&   �� **(AdminAddAnnotations.AddModeOfApplication+6`   �� 5*      $'��!Побочные действия��6$   �� 5+      $
 Wrap=�6Z   ��6&   �� *$"AdminAddAnnotations.AddSideEffects+6Z   �� 5,      $&�� Противопоказания��6$   �� 5-      $
 Wrap=�6`   ��6&   �� **(AdminAddAnnotations.AddContraindications+6`   �� 5.      $��Беременность��6$   �� 5/      $
 Wrap=�6X   ��6&   �� *" AdminAddAnnotations.AddPregnancy+6X   �� 50      $=��7Лекарственное взаимодействие��6$   �� 51      $
 Wrap=�6_   ��6&   �� *)'AdminAddAnnotations.AddDrugInteractions+6_   �� 52      $ ��Передозировка��6$   �� 53      $
 Wrap=�6W   ��6&   �� *!AdminAddAnnotations.AddOverdose+6W   �� 54      $��Состав��6$   �� 55      $
 Wrap=�6Z   ��6&   �� *$"AdminAddAnnotations.AddComposition+6Z   �� 56      $-��'Действующее вещество��6$   �� 57      ��6&   �� *(&AdminAddAnnotations.AddActiveSubstance+�� 58      $��Форма выпуска��6$   �� 59      $
 Wrap=�6X   ��6&   �� *" AdminAddAnnotations.AddIssueForm+6X   �� 5:      $%��Условия хранения��6$   �� 5;      $
 Wrap=�6`   ��6&   �� **(AdminAddAnnotations.AddStorageConditions+6`   �� 5<      $#��Условия отпуска��6$   �� 5=        ComboBoxFlatStyle#��[ 5>   '   ��5=   '   �� *%#AdminAddAnnotations.LeaveConditions+ �� Text 5?   '   �� *(&AdminAddAnnotations.AddLeaveConditions+�� 5@      $5��/Фармакологическая группа��6$   �� 5A      #��[ 6'    �� DisplayMemberPath$ PharmacologicalGroup1��5C   '   ��5B   '   �� *PharmacologicalGroup+ 5D   '   �� *-+AdminAddAnnotations.AddPharmacologicalGroup+�� 5F      $��Добавить��6%     ButtonTemplate#��[ 5G   %   $	��200��5I   %   $��30��61   $��10q�6=   $��Console)�6I   ��5H   %   �� *AdminAddAnnotations.Add+5I   I   5K      5L      5M      �� 5N      ��5O      �� 5P      $��/Icons/admin_edit.png��6    $��32��6?   $��32��6J   .��5R      �� $
��Auto=�6#   .��5S      �� .+�5T      ��  . y�6<   �� *)'AdminAddAnnotations.ErrorEditVisibility+. �5U   "   /� .T�5V   &   J� .*�60   .*�5W   *   �� 
���  ��$
��Bold"�6o   �6.   �� * AdminAddAnnotations.ErrorsEdit+6o   5X   '   5Y   #   5Z      �� 5[      $8��2Введите название препарата��6$   �� 5\      #��[ 6)   $
 Name��5^   )   ��5]   )   �� *Medications+ 5_   )   �� *AdminAddAnnotations.EditName+�� 5`      $9��3Фармакологическое действие��6$   �� 5a      $
 Wrap=�6V   ��6&   �� * AdminAddAnnotations.EditEffect+6V   �� 5b      $0��*Показания к применению��6$   �� 5c      $
 Wrap=�6a   ��6&   �� *+)AdminAddAnnotations.EditIndicationsForUse+6a   �� 5d      $'��!Способ применения��6$   �� 5e      $
 Wrap=�6a   ��6&   �� *+)AdminAddAnnotations.EditModeOfApplication+6a   �� 5f      $'��!Побочные действия��6$   �� 5g      $
 Wrap=�6[   ��6&   �� *%#AdminAddAnnotations.EditSideEffects+6[   �� 5h      $&�� Противопоказания��6$   �� 5i      $
 Wrap=�6a   ��6&   �� *+)AdminAddAnnotations.EditContraindications+6a   �� 5j      $��Беременность��6$   �� 5k      $
 Wrap=�6Y   ��6&   �� *#!AdminAddAnnotations.EditPregnancy+6Y   �� 5l      $=��7Лекарственное взаимодействие��6$   �� 5m      $
 Wrap=�6`   ��6&   �� **(AdminAddAnnotations.EditDrugInteractions+6`   �� 5n      $ ��Передозировка��6$   �� 5o      $
 Wrap=�6X   ��6&   �� *" AdminAddAnnotations.EditOverdose+6X   �� 5p      $��Состав��6$   �� 5q      $
 Wrap=�6[   ��6&   �� *%#AdminAddAnnotations.EditComposition+6[   �� 5r      $-��'Действующее вещество��6$   �� 5s      $
 Wrap=�6_   ��6&   �� *)'AdminAddAnnotations.EditActiveSubstance+6_   �� 5t      $��Форма выпуска��6$   �� 5u      $
 Wrap=�6Y   ��6&   �� *#!AdminAddAnnotations.EditIssueForm+6Y   �� 5w      $%��Условия хранения��6$   �� 5x      $
 Wrap=�6a   ��6&   �� *+)AdminAddAnnotations.EditStorageConditions+6a   �� 5y      $#��Условия отпуска��6$   �� 5z      #��[ 5{   '   ��5z   '   �� *%#AdminAddAnnotations.LeaveConditions+ 5|   '   �� *)'AdminAddAnnotations.EditLeaveConditions+�� 5}      $5��/Фармакологическая группа��6$   �� 5~      #��[ 6'   $ PharmacologicalGroup1��5�   '   ��5   '   �� *PharmacologicalGroup+ 5�   '   �� *.,AdminAddAnnotations.EditPharmacologicalGroup+�� 5�      #��[ 5�   %   $	��200��5�   %   $��30��61   $��5q�6=   $��Console)�6H   ��5�   %   �� * AdminAddAnnotations.EditButton+��5�   %   �� *AdminAddAnnotations.Edit+5�   H   �� 5�      $��Отмена��6%   #��[ 5�   %   $��5q�5�   T   $	��200��5�   %   $��30��61   $��Console)�6=   y�5�   %   �� *" AdminAddAnnotations.CancelButton+��5�   %   �� *AdminAddAnnotations.Cancel+5�   =   �� 5�      $��Удалить��6%   #��[ 5�   %   $	��200��5�   %   $��30��61   $��5q�6=   $��Console)�6H   ��5�   %   �� *AdminAddAnnotations.Delete+5�      5�      5�      �� 5�      ��5�      �� 5�      $��/Icons/admin_search.png��6    $��32��6A   $��32��6L   .��5�      �� $
��Auto=�6#   .��5�      �� .+�5�      �� $8��2Введите название препарата��6$   �� 5�      ��6&   �� * AdminAddAnnotations.SearchName+�� 5�      $5��/Фармакологическая группа��6$   �� 5�      #��[ 6'   $ PharmacologicalGroup1��5�   '   ��5�   '   �� *PharmacologicalGroup+ 5�   '   �� *0.AdminAddAnnotations.SearchPharmacologicalGroup+�� 5�      $��
Поиск��6%   #��[ 5�   %   $	��200��5�   %   $��30��61   $��10q�6=   $��Console)�6I   ��5�   %   �� *AdminAddAnnotations.Search+5�      5�      5�      5�      &   System.Windows.Controls.DataGrid  5�      -   5          Name$ dataGrid��5�      $��0��6)      AutoGenerateColumns .  	   
IsReadOnly	 . 
 �� SelectedItem
 69   �� *" AdminAddAnnotations.selectedItem+��6s   �� *AdminAddAnnotations.Med+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$1 +Наименование препарата��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6I      FontSize$ 15Q�6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6S   �� *Name+6l     5�      $5 /Фармакологическая группа��6)   $ * 6K   $ 15Q�6~    6U   �� *PharmacologicalGroup+6~      RowDetailsTemplate 5�      �� 5�      .R�5�      � $	��400��6    ��6-   �� *ActualWidth+ �� ElementName$ dataGrid�� �� Mode$ OneWay=�.+�5�      �� .��5�   "   �� .+�5�      �� $��20(�6=   
��������6$   �� *Name+6K   �� 5�      $8��2Фармaкологическое действие��6$   $
��Bold"�6J   $
��Left=�6\   �� 5�      $
��Wrap=�6N   $��14(�6b   ��6(   �� *PharmachologicEffect+6b   �� 5�      $0��*Показания к применению��6$   $
��Bold"�6F   $
��Left=�6X   �� 5�      $
��Wrap=�6K   $��14(�6_   ��6(   �� *IndicationsForUse+6_   �� 5�      $'��!Способ применения��6$   $
��Bold"�6A   $
��Left=�6S   �� 5�      $
��Wrap=�6K   $��14(�6_   ��6(   �� *ModeOfApplication+6_   �� 5�      $'��!Побочные действия��6$   $
��Bold"�6A   $
��Left=�6S   �� 5�      $
��Wrap=�6E   $��14(�6Y   ��6(   �� *SideEffects+6Y   �� 5�      $&�� Противопоказания��6$   $
��Bold"�6?   $
��Left=�6Q   �� 5�      $
��Wrap=�6K   $��14(�6_   ��6(   �� *Contraindications+6_   �� 5�      $��Беременность��6$   $
��Bold"�6<   $
��Left=�6N   �� 5�      $
��Wrap=�6C   $��14(�6W   ��6(   �� *	Pregnancy+6W   �� 5�      $;��5Лекарсвенное взаимодействие��6$   $
��Bold"�6J   $
��Left=�6\   �� 5�      $
��Wrap=�6J   $��14(�6^   ��6(   �� *DrugInteractions+6^   �� 5�      $ ��Передозировка��6$   $
��Bold"�6<   $
��Left=�6N   �� 5�      $
��Wrap=�6B   $��14(�6V   ��6(   �� *
Overdose+6V   �� 5�      $��Состав��6$   $
��Bold"�65   $
��Left=�6G   �� 5�      $
��Wrap=�6E   $��14(�6Y   ��6(   �� *Composition+6Y   �� 5�      $��Форма выпуска��6$   $
��Bold"�6<   $
��Left=�6N   �� 5�      $
��Wrap=�6C   $��14(�6W   ��6(   �� *	IssueForm+6W   �� 5�      $%��Условия хранения��6$   $
��Bold"�6?   $
��Left=�6Q   �� 5�      $
��Wrap=�6K   $��14(�6_   ��6(   �� *StorageConditions+6_   �� 5�      $#��Условия отпуска��6$   $
��Bold"�6>   $
��Left=�6P   �� 5�      $
��Wrap=�6I   $��14(�6]   ��6(   �� *LeaveConditions+6]   �� 5�      $-��'Действующее вещество��6$   $
��Bold"�6C   $
��Left=�6U   �� 5�      $
��Wrap=�6I   $��14(�6]   ��6(   �� *ActiveSubstance+6]   5�   #   5�      5�      5�      5�      5�      5�      5�      