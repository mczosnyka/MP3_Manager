   M S B A M L   `   `   `  ���� E  AMP3Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MP3Manager
MP3Manager  "    MP3Manager.AddFromFolderPage   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:MP3Manager       N� Title$  AddFromFolderPage�� N� 
Background
 ����� � 	Resources    styleCalendar �� 
TargetType&   System.Windows.Controls.Calendar �� Property �� Value �� 
TargetType5  /System.Windows.Controls.Primitives.CalendarItem  Name  DatePickerStyle1(  "System.Windows.Controls.DatePicker �� EndPoint	 �� 
StartPoint
 � Color � Offset �� Padding'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� Duration �� 
TargetName	 W� To �� TargetProperty �Name  Key �� Color   Transitions%  System.Windows.VisualTransition   GeneratedDuration	   To	 �� To g� 	BeginTime �� KeyTime �� Value O� KeyTime O� Value � ColumnDefinitions  � RowDefinitions! ��Name" �� CornerRadius# J� Opacity$ J� RenderTransformOrigin% �� Stretch& ��Name  DropDownButtonTemplate:  4System.Windows.Controls.Primitives.DatePickerTextBox'  Name( J� IsHitTestVisible) �� RadiusX* �� RadiusY+ �Name, � AllowsTransparency- � 	StaysOpen. � PlacementTarget/ �� ElementName0 �� Triggers1 �� Value2 �� Binding3 �� Source4 �� 
TargetName5 �� RelativeSource6 �� Mode��%�  &	        &	 y     7  �� "  .���  � �� �� "  .R�(� $	��500��$	��500��.��  $ PART_CalendarItem��#��z��#��z��#��z���� "  .���  � �� �	#FF333333��  �@ IsTodayHighlighted$
 True����  �@ SelectedDateFormat$ Short=���  � ��
 ���� ��  � ��$ 2q���  � �� �� $
 .5,0&�$
	 .5,1&�.��� $
 	#FFA3AEB9��$ 0Q�� $
 	#FF8399A9��$ 0.375Q�� $
 	#FF718597��$ 0.375Q�� $
 	#FF617584��$ 1Q���  � ��$ 1q���  � ��$ Stretch=���  � �� �� "  .R��� #��z��#��z��#��z��# z��   CommonStates��.   
Normal��  Disabled��. �� .��W� $ 0D�$ PART_DisabledVisual�� 1$ Opacity�._�� $ 	PART_Root��#��z��#��z�� ���� DisabledBrush $ 	#A5FFFFFF���� DropDownButtonTemplate " ��.R��    CommonStates��   $ 0D�  $ 0:0:0.1D�$ 	MouseOver��  $ 0:0:0.1D�$ Pressed��.   
Normal��  	MouseOver��. �� .���� $ 0D�$ 
Background�� 	#FF448DCA$1 +(Border.Background).(SolidColorBrush.Color)���  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[3].(GradientStop.Color)�.g��� $ 0��$ 	#7FFFFFFF����  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[2].(GradientStop.Color)�.g��� $ 0��$ 	#CCFFFFFF����  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�.g��� $ 0��$ 	#F2FFFFFF��  Pressed��. �� .����  0$ 00:00:00.001D�$ 
Background��$1 +(Border.Background).(SolidColorBrush.Color)�.g��� $ 0��$ 	#FF448DCA��U�  0$ 00:00:00.001D�$ 	Highlight��$ (UIElement.Opacity)�.\��� $ 0��$ 1Q���  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[1].(GradientStop.Color)�.g��� $ 0��$ 	#EAFFFFFF����  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[2].(GradientStop.Color)�.g��� $ 0��$ 	#C6FFFFFF����  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[3].(GradientStop.Color)�.g��� $ 0��$ 	#6BFFFFFF����  0$ 00:00:00.001D�$ BackgroundGradient��$O I(Border.Background).(GradientBrush.GradientStops)[0].(GradientStop.Color)�.g��� $ 0��$ 	#F4FFFFFF��  Disabled��.+�� ���	#11FFFFFF$��LeftToRight=�$��Center=�$��45��$��Center=�$��45�� �� $	��20* ��� $	��20* ��� $	��20* ��� $	��20* �  �� $	��23* ��� $	��19* ��� $	��19* ��� $	��19* �.+��� $! 	Highlight�����	#FF45D6FA$��1q�$" 0,0,1,1��$��4��$��-1q�$# 0Q�$��4��$��0���� $! 
Background�����	#FF1F3B53���	#FFFFFFFF$��1q�$" .5��$��4��$��0,-1,0,0q�$# 1Q�$��3��$��1���� $! BackgroundGradient�����	#BF000000$��1q�$" .5��$��4��$��0,-1,0,0q�$# 1Q�$��3��$��1������ $
 .7,1&�$
	 .7,0&�.��� $
 	#FFFFFFFF��$ 0Q�� $
 	#F9FFFFFF��$ 0.375Q�� $
 	#E5FFFFFF��$ 0.625Q�� $
 	#C6FFFFFF��$ 1Q��� $��4��$��1��$��1������ $ 0.3,-1.1&�$	 0.46,1.6&�.��� $
 	#FF4084BD��� $
 	#FFAFCFEA��$ 1Q����� $ 0.48,-1&�$	 	0.48,1.25&�.��� $
 	#FF494949��� $
 	#FF9F9F9F��$ 1Q�F� $��0��$��4������p�[� 4ZX�k� @Q�F� 4ZX�k� @џF� {2� �u� {2� �u�  )� �*� &"@pg� �*� &"@� � ��*�"@��� yh���#@h/��@�#@,� j����"@Sn#� l�H@�/"@��� ����k�!@�[� 4ZX�k� @p�� 4ZX�k� @Q�L4ZX�k� @Q�L�:��"@QH � �:��"@�H � ��� �U+� L�� ����E0@�=� ��� �=� ��	�=� �0ݒ� 5N=� ����� �� �b� �� ��� Ӧ� ��� �u"9��Up0@�� "9��Up0@S�n� "9��Up0@�$� Ӹ� ��� H~� �� {�� �\�� �� ��� [�� �� [�� �y�[�� ���I� ��� Ӭ�J"� sc,� ~T�~O0@c,� Ӷ�� c,� @�� �P� � � /�� ��� �� 	���	#FF2F2F2F$��Center=�$��4,3,4,3q�$$ 0.5,0.5&�$��3��$��1��$
% Fill=�$��Center=�A� $��4�����	#FFFFFFFF$��Center=�$��3��$��0��$��Center=�$��3���� $! DisabledVisual�����	#B2FFFFFF$��1q�$" 	0,0,.5,.5��$��4��$# 0Q�$��4��$��0�� �� $��* ��� $
��Auto �.+��� $& PART_Button��$��1��#��z��$|�False��$
��Left=�$��3,0,3,0q�$��0��8��  $	��Top=�$��50��$��50��  $' PART_TextBox��$��0��#|�z|�$��Stretch=�$��0��$��Stretch=�� $ PART_DisabledVisual��$��0��$��2��$( False��$# 0Q�$��0�� �� $��* ��� $
��Auto �.+��� $��0�����	#A5FFFFFF$��0��$) 1��$* 1���� $��1�����	#A5FFFFFF$��18��$��3,0,3,0q�$��0��$) 1��$* 1��$��19��� $+ 
PART_Popup��$
, True��$��Bottom=�$- False��. �� $/ PART_TextBox��0 �� $1 false��2 �� #3 Zr�.a��� $4 PART_TextBox�� �� *
Foreground+5 �� $6 TemplatedParent=� � ��.���� .+��� $-��'Wprowadź datę i ścieżkę do folderu��
���   �$��Roboto)�$��50(�7 �� TextAlignment$7 Center=�$��
0,30, 0, 0q�$
��Wrap=�(� $��60��$	��220��$��Center=�.���� $��Podaj ścieżkę:��$	��128��$
��Left=�$��Roboto)�$��Center=��� -   8 ��Name$
8 Path��$	��120��$	��400��$��20(�$��0, 0, 0, 10 q�$��Center=�.��(� $��60��$	��220��.���� $��Podaj datę dodania:��$	��128��$
��Left=�$��Roboto)�(� $��60��$	��200��.��  -   9  Name$9 
AddingDate��#���  $��40(�
���   �
�������:   CalendarStyle#: [  �� -   $& AddAlbum��$��Center=�$��Center=�$��50��$	��120��$��0, 10, 0, 10q����� $��Dodaj��
���   �$��Roboto)�$��15(��� -   $& GoBack��$��Center=�$��Center=�$��30��$��80��$��0, 10, 0, 10q����� $��Powrót��
���   �$��Roboto)�$��15(�� -   $+ 
ErrorPopup��$��Center=�$- False��$��72��$	��256��.���� $��1q�
�������._��� .+��� -   ; ��Name$; 	ErrorText��$��1q�$	��Top=�$��Center=�$
��Wrap=�$7 Center=�$��15(�$��Roboto)�$9��3BŁĄD: Sprawdź poprawność wprowadzonych danych!���� < �� Orientation$< 
Horizontal=�$��Center=�$��5q�.+��� -   $& ErrorOK��$��OK��$��20��$��60��$��15(�$��Roboto)�$��
0, 1, 0, 0q�� -   $+ UniqErrorPopup��$��Center=�$- False��$��72��$	��256��.���� $��1q�
�������._��� .+��� -	   $; UniqErrorText��$��1q�$	��Top=�$��Center=�$
��Wrap=�$7 Center=�$��15(�$��Roboto)�$=��7BŁĄD: Któryś z albumów już znajduje się w bazie!���� $< 
Horizontal=�$��Center=�$��5q�.+��� -
   $& UniqErrorOK��$��OK��$��20��$��60��$��15(�$��Roboto)�$��
0, 1, 0, 0q�� -   $+ SuccessPopUp��$��Center=�$- False��$��72��$	��256��.���� $��1q�
�������._��� .+��� -   $; Sukces��$��1q�$	��Top=�$��Center=�$
��Wrap=�$7 Center=�$��15(�$��Roboto)�$@��:Udało się! Wszystkie albumy ze ścieżki zostały dodane���� $< 
Horizontal=�$��Center=�$��5q�.+��� -   $& SuccessPopUpOK��$��OK��$��20��$��60��$��15(�$��Roboto)�$��
0, 1, 0, 0q�