   M S B A M L   `   `   `  ����B  >Acuario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AcuarioAcuario  5   	   #    Acuario.ControlPiscinaAcuario   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Acuario     5   	     � Title$  ControlPiscinaAcuario��5   	   $	��450��6'   $	��800��64   .��5	      � .+�5
   
   �� $��	0,-10,0,0q�6   $
��Auto��6#   $
��Auto��60   $��/Imagenes/fondito.jpg��6>   $
��Fill=�6]   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagridAcuario��5      $��66,76,39,177q�5         AutoGenerateColumns$ False��5      
�������$��2q�5         
IsReadOnly$
 True��5      ��5      ��  �� Path$ listaControl�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 5         Header$ Nombre Sala��5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� $ nombreDeLaSala�5        5      $	 140 5      $ Temperatura��5       5      �� $ temperatura�5        5      $	 140 5      $ Especie��5       5      �� $ especies�5        5       $	 140 5!      $ Fecha de Revision��5#       5"      �� $ ultimaRevision�5#        5$      $	 140 5%      $ Tratamiento ��5'       5&      �� $ tratamientoRealizado�5'      5)      �� 5*   
   -   5        $��Agregar��5*      $
��Left=�6#   $��
66,296,0,0q�6>   $	��Top=�6R   $��48��6j   $��89��6v   6�   �� 5+   
   -   5        $��	Modificar��5+      $��Center=�6%   $��	0,295,0,0q�6B   $	��Top=�6U   $��49��6m   $��94��6y   	 J� RenderTransformOrigin$	 0.557,0.555&�6�   6�   �� 5,   
   -   5        $��Eliminar��5,      $
��Left=�6$   $��646,291,0,0q�6?   $	��Top=�6T   $��49��6l   $	��100��6x   6�   �� 5-   
   -   5        $
��Left=�5-      $��
66,360,0,0q�6,   $	��Top=�6@   $��53��6X   $	��101��6d   
������ 
������ .��5.      �� $��Imagenes/backwhitee.png��6   67   5/      50      51      