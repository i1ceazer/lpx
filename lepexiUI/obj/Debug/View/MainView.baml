   M S B A M L   `   `   `  ����C  ?lepexiUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:lepexiUI.ViewlepexiUI.View  5   	   7 clr-namespace:lepexiUI.ViewModellepexiUI.ViewModel  5   	       lepexiUI.View.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:lepexiUI.View     5   	   6	viewModel clr-namespace:lepexiUI.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  MainView��5
   	   $	��700��6   $
��1300��6'    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency .  � DataContext 5      &    lepexiUI.ViewModel.MainViewModel  5   
    � 	Resources 5       �� DataType&    lepexiUI.ViewModel.HomeViewModel   lepexiUI.View.HomeView+   %lepexiUI.ViewModel.SuppliersViewModel!   lepexiUI.View.SuppliersView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      ��  �� CornerRadius$ 12��6   $��1q�5       ��5"   
   �� 5#       �� 
StartPoint$	 0,0&�6"   	 �� EndPoint$		 1,1&�63   .��5$      �    winBorderColor1
 � Color#
 [  6    � Offset$ 0Q�6H   � 5%        winBorderColor2#
 [ 6   $
 0.75Q�6H   � 5&        winBorderColor3#
 [ 6   $ 1Q�6H   5'      ._�5+   
   �  � ColumnDefinitions 5.      �� 50      $	��250 �6#   �� 52      $��* �6#   .+�56      �� $ 	10 0 0 10��6   $��0��57      ��59      �� 5:      $	 0 0&�6*   $	 1 0.7&�6;   .��5;      �   secondaryBackColor1#
 [ 6'   $ 0Q�6T   � 5<        secondaryBackColor2#
 [ 6'   $ 1Q�6T   5=      ._�5@      �� .+�5C      ��  �� Orientation$ 
Horizontal=�6!   $	��100��5D   !   $��	0 25 0 40q�5E   !   $��Center=�5F   !   .+�5G      �� $��/images/IN-2.png��6    $	��100��6:   5J      	� 5M        
menuButton#��[ 6"    
 color1
 � Tag# [ 5N   "    d� 	IsChecked$
 TrueY�5O   "   ��5P   "   �� *ShowHomeViewCommand+.��5Q      �� $ 
Horizontal=�6%   .+�5R      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 5S      $��Главная��6(     menuButtonText#��[ 67   5T      5U      	� 5W      #��[ 6"    
	 color2# [	 5X   "   ��5Y   "   �� *ShowSuppliersViewCommand+.��5Z      �� $ 
Horizontal=�6%   .+�5[        $ 	UserGroup=�6+   #��[ 6<   �� 5\      $��Поставщики��6(   #��[ 6:   5]      5^      	� 5`      #��[ 6"    

 color3# [
 5a   "   .��5b      �� $ 
Horizontal=�6%   .+�5c        $ Truck=�6+   #��[ 68   �� 5d      $��Заказы��6(   #��[ 66   5e      5f      	� 5h      #��[ 6"    
 color4# [ 5i   "   .��5j      �� $ 
Horizontal=�6%   .+�5k        $ CalendarDays=�6+   #��[ 6?   �� 5l      $)��#Календарь остатков��6(   #��[ 6B   5m      5n      5p      5r      �� 5v      $ 	0 10 10 0��6   $��1��5w      ��5y      �� 5z      $	 1 1&�6*   $		 0 0&�6;   .��5{      �   primaryBackColor1#
 [ 6'   $ 0Q�6R   � 5|        primaryBackColor2#
 [ 6'   $ 1Q�6R   5}      ._�5�      �  � RowDefinitions 5�      �� 5�      $��25 �6(   �� 5�      $��35 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ plnContrloBar��5�   !   $��0��5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   
������ $��0 0 5 0q�5�   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !   # [ 5�   !   .��5�        $ Xmark=�6+     controlButtonIcon#��[ 68   5�      �� 5�      -   5        $ btnMaximize��5�   !   #��[ 5�   !    
 color8# [ 5�   !   .��5�        $ Square=�6+   #��[ 69   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��[ 5�   !    
 color6# [ 5�   !   .��5�        $ WindowMinimize=�6'   $��12��6=   #��[ 6H   5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�   %   $��Center=�5�   %   .+�5�        $��20��5�   +   $��20��5�   +     titleColor2   
Foreground# [ 5�   +   $��	35 0 10 0q�5�   +    5�   +   �� *Icon+5�   +   �� 5�      #��[ 5�   (   $��16(�5�   (   $��Montserrat Medium)�5�   (   $��Center=�5�   (   ��5�   (   �� *	Caption+5�   (   5�      �� 5�      $��1��6%   $ 
Horizontal=�5�   %   $��RightToLeft=�5�   %   $��Center=�5�   %   $��0 0 10 0q�5�   %   .+�5�      ��   
iconButton#��[ 6%   # [ 5�   %   .��5�   "     $ 	AngleDown=�6/   $��12��5�   /   $��12��6;     iconButtonIcon#��[ 5�   /   5�      �� 5�        titleColor3#��[ 5�   (   $��Montserrat Light)�5�   (   $��12(�5�   (   $��Center=�5�   (   ��5�   (   �� * CurrentUserAccount.DisplayName+5�   (   A� 5�      $��35��6&   $��35��62   #��[	 5�   &   $��2��5�   &   $��	10 0 10 0q�5�   &   ��5�   "   �� 5�   &    �� ImageSource$! /Images/profile-picture.jpg��61   5�      �� 5�      #��[ 6%   # [
 5�   %   .��5�   "     $ Clock=�6/   #��[ 6<   5�      �� 5�      #��[ 6%   # [ 5�   %   .��5�   "     $ Envelope=�6/   #��[ 6?   5�      �� 5�      #��[ 6%    
 color5# [ 5�   %   .��5�   "     $
 Bell=�6/   #��[ 6;   5�      5�      5�      �� 5�      $��2��5�   %   $��25q�5�   %   ��5�   %   �� *CurrentChildView+5�   %   5�      5�      5�      5      5     