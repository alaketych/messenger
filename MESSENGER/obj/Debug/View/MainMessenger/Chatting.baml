   M S B A M L   `   `   `  ����D  @MESSENGER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MESSENGER.View.MainMessengerMESSENGER.View.MainMessenger  5      +    %MESSENGER.View.MainMessenger.Chatting   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:MESSENGER.View.MainMessenger     5        � 	Resources  5
         
Background �� Color  BackgroundPressed  ChattingButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName��%0  &	        &	 &     &	 L     7   7  �� 5   
   $ #ffefde��6-   6?   �� 5   
   $ #e3e4e9��64   6F   �� 5   
   " ��6'   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ Border��6!   $ 35��61   ���#ffffff._�5      �� $��Center=�6/   $��Center=�6J   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   �� $ Border��6)   8    � ��6y   5      P� 5      	 � ��
 . . �5   "   �� $ Border��6)   8   � ��6�   5      5      5      5       5!      .��5#      � .+�5$   
   � ���#ffffff$��0 0 0 50q�6$   .+�5%      �� $<��6/MESSENGER;component/Resources\Chatting\background.jpg��6   $��
0,10,0,-10q�6T   6j   5&      � 5'   
   $��Bottom=�6   $��70��6*   ���#ffffff.+�5(      �� -   5         ��Name$ 
ClipButton��5(   =   #��[ 6   $��70��6Q   $��70��6]   $
��Left=�6h   $��5 0 0 0q�6�   .��5)      �� $6��0/MESSENGER;component/Resources\chatting\clip.png��6   $��30��6R   $��30��6]   5*      �� 5+      -   5        $ 
SendButton��5+   =   #��[ 6   $��70��6Q   $��70��6]   $��Right=�6h   $��0 0 0 0q�6�   
���������6�   Z� .��5,      �� $6��0/MESSENGER;component/Resources\chatting\send.png��6   $��35��6R   $��35��6]   6k   5-      �� 5.      $��Center=�6   $	��630��67   $��	80,0,75,0q�6C   $��50��6m   ��6V   Z� 50      51      52      53      