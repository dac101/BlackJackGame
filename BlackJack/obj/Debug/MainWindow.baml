   M S B A M L   `   `   `  ����D  @BlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlackJack	BlackJack  5   	       BlackJack.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )localclr-namespace:BlackJack     5   	     � Title$  
MainWindow��5   	   $��423.35��6   $	��588��6,   .��5      � $��0,0,0,-1q�6   $
��Left=�6   $	��578��68   $	��393��6D   $	��Top=�6Q   ��5   
   �� 5       �� ImageSource$! Assets/Images/blackjack.png��6   .+�5
   
   �� -   5         ��Name$ Dealbtn��5
      $
��Deal��6#   $
��Left=�62   $��
10,363,0,0q�6M   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5        $ StandBtn��5      $��Stand��6#   $
��Left=�63   $��
90,363,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $ HitBtn��5      $	��Hit��6!   $
��Left=�6/   $��170,363,0,0q�6J   $	��Top=�6_   $��75��6w   6�   � 5   
   -   5         �Name$	 Hit��5      $
��Left=�6   $	��373��67   $��	10,10,0,0q�6D   $	��Top=�6W   $	��558��6o    � RowDefinitions 5      �� 5      $	��69* �6    �� 5      $	��65* �6    .+�5      ]� $
��Left=�6   $	��100��63   ��.  $��
134,81,0,0q�6V   $��2��6j   $	��Top=�6{   $	��100��6�      BlackJack.UICharacter  5      -   5          Name$ Player��5          BlackJack.UICharacter   Loaded$ Player_Loaded��6�   $
��Left=�60   $��
165,46,0,0q�6K   $��1��6_   $	��Top=�6l   $��88��6�   $��90��6�   6�     5      -   5        $ 
CardDealer��5   !   $��0��65   $
��Left=�6B   $��
184,48,0,0q�6]   $	��Top=�6q   $��93��6�   $��90��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.537Q�6*   T� 5      5      5      5      5      5       