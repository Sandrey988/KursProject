   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Pharmacy.ViewsPharmacy.Views  5          Pharmacy.Views.SearchView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Pharmacy.Views     5      $	��600��5      $	��800��6   .��5	      �    MainViewModel  � DataContext#  [  6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   �� $��1��6     6%   �� *+)Search.SelectedListResultItem.Medications+y�6g   �� *Search.DrugInfo+ �� Source# [  .+�5      �� $��20(�6-   
��������6   �� *Name+6;   �� 5      $8��2Фармaкологическое действие��6   $
��Bold"�6:   $
��Left=�6L   �� 5      $
��Wrap=�6>   $��14(�6R   ��6   �� *PharmachologicEffect+6R   �� 5      $0��*Показания к применению��6   $
��Bold"�66   $
��Left=�6H   �� 5      $
��Wrap=�6;   $��14(�6O   ��6   �� *IndicationsForUse+6O   �� 5      $'��!Способ применения��6   $
��Bold"�61   $
��Left=�6C   �� 5      $
��Wrap=�6;   $��14(�6O   ��6   �� *ModeOfApplication+6O   �� 5      $'��!Побочные действия��6   $
��Bold"�61   $
��Left=�6C   �� 5      $
��Wrap=�65   $��14(�6I   ��6   �� *SideEffects+6I   �� 5      $&�� Противопоказания��6   $
��Bold"�6/   $
��Left=�6A   �� 5      $
��Wrap=�6;   $��14(�6O   ��6   �� *Contraindications+6O   �� 5      $��Беременность��6   $
��Bold"�6,   $
��Left=�6>   �� 5      $
��Wrap=�63   $��14(�6G   ��6   �� *	Pregnancy+6G   �� 5      $;��5Лекарсвенное взаимодействие��6   $
��Bold"�6:   $
��Left=�6L   �� 5       $
��Wrap=�6:   $��14(�6N   ��6   �� *DrugInteractions+6N   �� 5!      $ ��Передозировка��6   $
��Bold"�6,   $
��Left=�6>   �� 5"      $
��Wrap=�62   $��14(�6F   ��6   �� *
Overdose+6F   �� 5#      $��Состав��6   $
��Bold"�6%   $
��Left=�67   �� 5$      $
��Wrap=�65   $��14(�6I   ��6   �� *Composition+6I   �� 5%      $-��'Действующее вещество��6   $
��Bold"�63   $
��Left=�6E   �� 5&      $
��Wrap=�69   $��14(�6M   ��6   �� *ActiveSubstance+6M   5'      �� 5)   
   $��1��6   $��	0,150,0,0q�6%   y�68   �� *Search.SearchPanel+.+�5*      �� $4��.Выберите критерий поиска��6   $��20(�67   
����  �6F   �� 5+        ComboBoxFlatStyle#��[ 6   $��30��5,      $��15(�5/      ��5-      �� *Search.SearchComboBoxItems+ �� Text 5.      �� *Search.SelectedString+5/      �� 50      $��0,5,0,5q�51      $��30��6(   $��15(�53      y�50      �� *Search.SearchQueryVisibility+��52      �� *Search.StringQuery+53      ]� 54      $��5q�6   $��Center=�6$   y�55      �� *Search.RangeTextboxVisibility+.+�56      �� $
��от��6   �� 57      $��30��6   $	��100��6&   ��62   �� *Search.From+�� 58      $
��до��6   �� 59      $��30��6   $	��100��6&   ��62   �� *	Search.To+5:      �� 5;        ButtonTemplate#��[ 6   $��
Поиск��5<      $��Center=�6%   $��30��5>      $	��150��5?      $��5q�6!   $��15(�6,   ��5=      �� *Search.Search_+5?   ,   5@      �� 5B   
   $��1��6   $��	0,150,0,0q�6%   y�68   �� *Search.SearchErrorVisibility+.+�5C      �� $��/Icons/404.jpg��6   5D      �� 5F   
   $��	0,150,0,0q�6D   $��1��6W   y�6   �� *Search.SearchResultList+.+�5H      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .   �� SelectedItem 6F   �� *Search.SelectedListResultItem+��6}   �� *Search.SearchListResult+   Columns 5I      0  *System.Windows.Controls.DataGridTextColumn  5J      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.7* 6d   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6?   �� *Medications.Name+6d     5K      $  Производитель��6)   $
	 0.8* 6g   
 6@   �� *Producers.FirmName+6g     5L      $ Цена��6)   $
	 0.4* 6i   
 67   �� *Cost+ �� StringFormat$ {0} руб.��6i     5M      $ Количество��6)   $
	 0.6* 6o   
 6=   �� *Count+$ 	{0} шт.��6o     5N      $. (Скидка для льготников��6)   $
	 0.9* 6�   
 6H   �� *Discount.Discount1+$ {0} %��6�   5P      ]� 5R      .+�5S      �� $	��150��6   $��30��6%   $/��)Просмотреть аннотацию��6\   $
��Left=�6|   #��[ 6�   $��5q�6�   ��61   �� *Search.OnListItemClick+6�   �� 5T      $	��150��6   $��30��6%   $��Забрать все��6U   $��Right=�6k   #��[ 6�   $��5q�6�   ��61   �� *Search.GetDrugs+6�   5U      5W      �� 5Y   
   #��[ 6    K� ZIndex$ 6��6k   $��40��6�   $��40��6�   $��2��6�   $��Right=�6�   $	��Top=�6�   $��10q�6�   y�6=   �� *Search.BackVisibility+��6|   �� *Search.Back+��5Z      �� 5[      $��/Icons/back.png��6   5^      5`      5a      