   M S B A M L   `   `   `  ���� E  AMP3Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MP3Manager
MP3Manager      MP3Manager.ResultsPage   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:MP3Manager       N� 
Background
  ����� N� Title$ ResultsPage��.���� .+��� $��Wyniki wyszukiwania��
���   �$��Roboto)�$��50(� �� TextAlignment$ Center=�$��
0,30, 0, 0q�$
��Wrap=��� -    ��Name$ Filters��$��Center=�$��Center=�$��30��$��80��$��0, 10, 0, 10q�$��30������ $��Filtry��
���   �$��Roboto)�$��15(�� .+��� $��Visible=�.���� -   $��Results��$��
0,10,10,10q�$��Center=�$	��400�� �� View ��  �� AllowsColumnReorder$ False��.P��� $��Nazwa Albumu�� �� Width$	 150�� �� DisplayMemberBinding �� *name+�� $��	Wykonawca��$	 150�� �� *artist+�� $��Rok Wydania��$	 150�� �� *releaseYear+�� $��Data Dodania��$	 150�� �� *date+�� $��Edycja��$	 100�� �� CellTemplate �� .R��� -   $��Usuń z bazy��$��Center=�$��Center=�$��Roboto)�$��12,0,0,0q��� -   $ GoBack��$��Center=�$��Center=�$��30��$��80��$��0, 10, 0, 10q�$��30������ $��Powrót��
���   �$��Roboto)�$��15(�� -   	 �Name$	 FilterListPopup��$��Center=�
 � 	StaysOpen$
 False��$	��215��$	��256��.���� $��1q�
�������._��� .+��� $"��Jak chcesz posortować dane?��$��5q�$��15(�$��Roboto)�$ Center=��� -    ��Name$ SortingOptions�� �� SelectionMode$ Single=�.@��� .��	� -   $��
Albumy A-Z�� 	� 	GroupName$ 	SortGroup��
 � Tag$ 1���� .��	� -   $��
Albumy Z-A��$ 	SortGroup��$ 2���� .��	� -	   $��Wykonawcy A-Z��$ 	SortGroup��$ 3���� .��	� -
   $��Wykonawcy Z-A��$ 	SortGroup��$ 4���� .��	� -   $��Najnowsze wydania��$ 	SortGroup��$ 7���� .��	� -   $��Najstarsze wydania��$ 	SortGroup��$ 8���� .��	� -   $��Dodane najpierw��$ 	SortGroup��$ 5���� .��	� -   $��Dodane ostatnio��$ 	SortGroup��$ 6���� -   $ ErrorOK��$��Anuluj��$��20��$��60��$��15(�$��Roboto)�$��
0, 5, 0, 0q�� -   $	 Confirmation��$��Center=�$
 False��$	��164��$	��256��.���� $��1q�
�������._��� .+��� -    ��Name$ 	PopUpText��$��10q�$	��Top=�$��Center=�$
��Wrap=�$ Center=�$��15(�$��Roboto)���  �� Orientation$ 
Horizontal=�$��Center=�$��5q�.+��� -   $ ConfirmationTrue��$	��Tak��$��20��$��60��$��15(�$��Roboto)�$��
0, 2, 5, 0q��� -   $ ConfirmationFalse��$��Anuluj��$��20��$��60��$��
5, 2, 0, 0q�$��15(�$��Roboto)�