   M S B A M L   `   `   `  ���� M  IBusinessManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BusinessManagementBusinessManagement  #    BusinessManagement.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:BusinessManagement       � Title$  Employee Manager��$	��400��$	��525��.��� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF3A3A3A�� � Offset$
 0.94Q�� $ 	#FFA6A6A6��.+��� -    ��Name$ lblEmployeeInfo��$��Employee Information��$
��Left=�$��
345,10,0,0q�$	��Top=�$	��146���� -    ��Name$ txtFirstname��$
��Left=�$��23��$��
345,41,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtLastname��$
��Left=�$��23��$��
345,69,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtIdnumber��$
��Left=�$��23��$��
345,97,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtPosition��$
��Left=�$��23��$��345,125,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtDepartment��$
��Left=�$��23��$��345,153,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtNumberofwriteups��$
��Left=�$��23��$��345,181,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -   $ txtUsername��$
��Left=�$��23��$��345,209,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -	   $ txtPassword��$
��Left=�$��23��$��345,237,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��160��{�.  �� -
    ��Name$ 
chkbxAdmin��$�� ��$
��Left=�$��345,268,0,0q�$	��Top=�{�.  $��23���� -   $ lblFirstname��$��
First name��$
��Left=�$��
267,39,0,0q�$	��Top=�$��73���� -   $ lblLastname��$��	Last name��$
��Left=�$��
268,67,0,0q�$	��Top=�$��73���� -   $ lblIdnumber��$��	ID Number��$
��Left=�$��
263,95,0,0q�$	��Top=�$��77���� -   $ lblPosition��$��Position��$
��Left=�$��280,123,0,0q�$	��Top=�$��60���� -   $ lblDepartment��$��
Department��$
��Left=�$��258,151,0,0q�$	��Top=�$��82���� -   $ lblWriteups��$��Number of writeups��$
��Left=�$��217,179,0,0q�$	��Top=�$	��123���� -   $ lblUsername��$��Username��$
��Left=�$��269,207,0,0q�$	��Top=�$��72���� -   $ lblPassword��$��Password��$
��Left=�$��272,235,0,0q�$	��Top=�$��69���� -   $ lblAdmin��$��Admin permissions��$
��Left=�$��221,262,0,0q�$	��Top=�$	��119���� -   	 ��Name$	 lstEmployees��$
��Left=�$	��212��$��	10,41,0,0q�$	��Top=�$	��175�����	#FFC7C7C7�� -   $ lblEmployees��$��	Employees��$
��Left=�$��	61,10,0,0q�$	��Top=��� -   
 ��Name$
 btnEdit��$��Edit employee��$
��Left=�$��373,282,0,0q�$	��Top=�$��96���� -   $
 btnAddEmployee��$��Add new employee��$
��Left=�$��355,309,0,0q�$	��Top=�$	��128���� -   $
 btnRemoveEmployee��$��Remove selected employee��$
��Left=�$��337,337,0,0q�$	��Top=�$	��169���� -   $
 	btnSearch��$��Search��$
��Left=�$��
58,319,0,0q�$	��Top=�$��75���� -   $ 	txtSearch��$
��Left=�$��23��$��
37,287,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��120��
��������� -   $ 	lblSearch��$��Search for employee ID��$
��Left=�$��
31,258,0,0q�$	��Top=�
���   �