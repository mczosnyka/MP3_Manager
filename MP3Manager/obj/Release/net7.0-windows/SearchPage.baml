   M S B A M L   `   `   `  ���� E  AMP3Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MP3Manager
MP3Manager      MP3Manager.SearchPage   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:MP3Manager       N� Title$  
SearchPage�� N� 
Background
 �����.���� .+��� $$��Wprowadź dane do wyszukiwania��
���   �$��Roboto)�$��50(� �� TextAlignment$ Center=�$��
0,30, 0, 0q�$
��Wrap=�(� $��60��$	��220��.���� $��Podaj nazwę albumu:��$	��128��$
��Left=�$��Roboto)��� -    ��Name$ 	AlbumName��$	��120��$	��400��$��20(�$��0, 0, 0, 10 q�$��Center=�.��(� $��60��$	��220��.���� $��Podaj nazwę artysty:��$	��128��$
��Left=�$��Roboto)��� -   $ 
ArtistName��$	��120��$	��400��$��20(�$��0, 0, 0, 10 q�$��Center=�.��(� $��60��$	��220��.���� $��Wybierz rok wydania:��$	��128��$��Center=�$��Center=�$��Roboto)��� -    ��Name$ ReleaseYears��$��0,1,0,10q�$��25��$��60��$��Center=�$��Center=�$	��220��.@��� -    ��Name$ ReleaseYear_Any�� �� 
IsSelected$
 True��$��Dowolny��(� $��60��$��Center=�$��Center=�$	��400��.���� $��Wybierz miesiąc dodania:��$	��400��$��Center=�$��Roboto)�$��20(��� -   $ Months��$��0,1,0,10q�$��25��$��60��$��Center=�$��Center=�$	��220��.@��� -   $ 	Month_Any��$
 True��$��Dowolny���� -   $ Month_01��$��Styczeń���� -   $ Month_02��$
��Luty���� -	   $ Month_03��$��Marzec���� -
   $ Month_04��$��	Kwiecień���� -   $ Month_05��$	��Maj���� -   $ Month_06��$��Czerwiec���� -   $ Month_07��$��Lipiec���� -   $ Month_08��$��	Sierpień���� -   $ Month_09��$��	Wrzesień���� -   $ Month_10��$��Październik���� -   $ Month_11��$��Listopad���� -   $ Month_12��$��	Grudzień��(� $��60��$��Center=�$��Center=�$	��400��.���� $��Wybierz rok dodania:��$	��400��$��Center=�$��Roboto)�$��20(��� -   $ Years��$��25��$��60��$��Center=�$��Center=�$	��220��.@��� -   $ Year_Any��$
 True��$��Dowolny���� -    ��Name$ SearchAlbum��$��Center=�$��Center=�$��50��$	��120��$��0, 10, 0, 5q����� $��Szukaj��
���   �$��Roboto)�$��15(��� -   $ GoBack��$��Center=�$��Center=�$��30��$��80��$��0, 10, 0, 10q�$��30������ $��Powrót��
���   �$��Roboto)�$��15(�� -    �Name$ 
ErrorPopup��$��Center=�	 � 	StaysOpen$	 False��$��72��$	��256��.���� $��1q�
�������._��� .+��� -   
 ��Name$
 	ErrorText��$��1q�$	��Top=�$��Center=�$
��Wrap=�$ Center=�$��15(�$��Roboto)�$A��;BŁĄD: Żaden album nie pasuje do kryteriów wyszukiwania!����  �� Orientation$ 
Horizontal=�$��Center=�$��5q�.+��� -   $ ErrorOK��$��OK��$��20��$��60��$��15(�$��Roboto)�$��
0, 1, 0, 0q�