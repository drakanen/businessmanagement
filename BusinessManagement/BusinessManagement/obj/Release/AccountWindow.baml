   M S B A M L   `   `   `  ���� M  IBusinessManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BusinessManagementBusinessManagement  #    BusinessManagement.NewAccount   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:BusinessManagement       � Title$  New Employee��$	��300��$	��300��.��� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF2E2E2E�� � Offset$ 1Q�� $ 	#FFA6A6A6��.+��� -    ��Name$ lblUsername��$��Username��$
��Left=�$��	36,10,0,0q�$	��Top=��� -   $ lblPassword��$��Password��$
��Left=�$��	37,36,0,0q�$	��Top=��� -   $ lblFirstname��$��
First Name��$
��Left=�$��	36,63,0,0q�$	��Top=��� -   $ lblLastname��$��	Last Name��$
��Left=�$��	36,91,0,0q�$	��Top=��� -   $ 
lblPositon��$��Position��$
��Left=�$��
37,117,0,0q�$	��Top=��� -   $ lblDepartment��$��
Department��$
��Left=�$��
37,143,0,0q�$	��Top=��� -   $ lblIdnumber��$��	ID Number��$
��Left=�$��
36,169,0,0q�$	��Top=��� -   $ lblAdmin��$%��Admin Account 
(Check for yes)��$
��Left=�$��
37,190,0,0q�$	��Top=��� -	    ��Name$ 	chbxAdmin��$�� ��$
��Left=�$��138,200,0,0q�$	��Top=��� -
    ��Name$ txtUsername��$
��Left=�$��23��$��
138,12,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��145��G� -   	 G�Name$	 txtPassword��$
��Left=�$��23��$��
138,39,0,0q�$	��Top=�$	��145��
 G� PasswordChar$
 *���� -   $ txtFirstname��$
��Left=�$��23��$��
138,66,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��145���� -   $ txtLastname��$
��Left=�$��23��$��
138,94,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��145���� -   $ txtPosition��$
��Left=�$��23��$��138,120,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��145���� -   $ txtDepartment��$
��Left=�$��23��$��138,147,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��145���� -   $ txtIDNumber��$
��Left=�$��23��$
 Wrap=�$�� ��$	��Top=�$	��145��$��137,172,0,0q��� -    ��Name$ 
btnConfirm��$��Confirm��$
��Left=�$��
37,237,0,0q�$	��Top=�$��75���� -   $ 	btnCancel��$��Cancel��$
��Left=�$��176,237,0,0q�$	��Top=�$��75��