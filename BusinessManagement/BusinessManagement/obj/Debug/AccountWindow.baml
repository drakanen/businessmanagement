   M S B A M L   `   `   `  ����M  IBusinessManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BusinessManagementBusinessManagement  5   	   #    BusinessManagement.NewAccount   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BusinessManagement     5   	     � Title$  
NewAccount��5   	   $	��300��6   $	��300��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF2E2E2E��6    � Offset$ 1Q�61   � 5      $ 	#FFA6A6A6��6   5      .+�5   
   �� -   5         ��Name$ lblUsername��5      $��Username��6%   $
��Left=�68   $��	36,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lblPassword��5      $��Password��6%   $
��Left=�68   $��	37,36,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ lblFirstname��5      $��
First Name��6&   $
��Left=�6;   $��	36,63,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ lblLastname��5      $��	Last Name��6%   $
��Left=�69   $��	36,91,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ 
lblPositon��5      $��Position��6$   $
��Left=�67   $��
37,117,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ lblDepartment��5      $��
Department��6'   $
��Left=�6<   $��
37,143,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ lblIdnumber��5      $��	ID Number��6%   $
��Left=�69   $��
36,169,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ lblAdmin��5      $%��Admin Account 
(Check for yes)��6"   $
��Left=�6T   $��
37,190,0,0q�6o   $	��Top=�6�   �� 5   
   -	   5         ��Name$ 	chbxAdmin��5      $�� ��6&   $
��Left=�61   $��138,200,0,0q�6L   $	��Top=�6a   �� 5   
   -
   5         ��Name$ txtUsername��5      $
��Left=�6'   $��23��6B   $��
138,12,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��145��6�   G� 5   
   -   5        	 G�Name$	 txtPassword��5      $
��Left=�6+   $��23��6F   $��
138,39,0,0q�6R   $	��Top=�6f   $	��145��6~   
 G� PasswordChar$
 *��6�   �� 5   
   -   5        $ txtFirstname��5      $
��Left=�6(   $��23��6C   $��
138,66,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��145��6�   �� 5   
   -   5        $ txtLastname��5      $
��Left=�6'   $��23��6B   $��
138,94,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��145��6�   �� 5   
   -   5        $ txtPosition��5      $
��Left=�6'   $��23��6B   $��138,120,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��145��6�   �� 5   
   -   5        $ txtDepartment��5      $
��Left=�6)   $��23��6D   $��138,147,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��145��6�   �� 5   
   -   5        $ txtIDNumber��5      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��145��6�   $��137,172,0,0q�6�   �� 5    
   -   5         ��Name$ 
btnConfirm��5       $��Confirm��6%   $
��Left=�67   $��
37,237,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5!   
   -   5        $ 	btnCancel��5!      $��Cancel��6$   $
��Left=�65   $��176,237,0,0q�6P   $	��Top=�6e   $��75��6}   6�   5#      5$      