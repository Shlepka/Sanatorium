   M S B A M L   `   `   `  ����E  ASanatorium, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Sanatorium.ViewMenuSanatorium.ViewMenu  5   	   (    "Sanatorium.ViewMenu.UserPageWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Sanatorium.ViewMenu     5   	     � Title$<  6Приложение для пользователей��5   
   $	��450��5	   	   $	��700��6   $��12(�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � 
�������.+�5   
   �� $	��450��6   
�������$��15q�63   $��Center=�6?    �� Padding$ 30q�6Z   $	��700��6g    �� CornerRadius$ 30��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      �� .+�5      �� $-��'Кабинет пользователя��6   $��30(�68   $
��Bold"�6F   $��0,0,0,20q�6X   � 5      $��0,0,0,20q�6   .+�5      �� -   5         ��Name$ Button_Patients��5      $
��Left=�66   $��Пациенты��6Q   6d   �� 5      -   5        $ Button_Doctors��5      $��Right=�65   $��
Врачи��6Q   5      �� 5      -   5        	 ��Name$	 listofUsers��5      $��10q�60   ��5      �� 5      .R�5      � .+�5   "   �� $
��Bold"�6C   ��6,   �� *Login+6C   �� 5   "   $	�� , ��6,   �� 5    "   $
��Bold"�6C   ��6,   �� *Email+6C   5!      5"      5$      5%      5&      5'      5(      