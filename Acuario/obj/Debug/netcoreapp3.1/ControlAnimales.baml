   M S B A M L   `   `   `  ����B  >Acuario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:AcuarioAcuario  5   	       Acuario.ControlAnimales   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Acuario     5   	     � Title$  ControlAnimales��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� $��	0,-10,0,0q�6   $
��Auto��6#   $
��Auto��60   $��/Imagenes/fondito.jpg��6>   $
��Fill=�6]   �� 5   
   -   5         ��Name$ nombreDeLaSala��5      $
��Left=�6*   $��23��6E   $��
241,39,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��120��6�   ��6�   ��  �� Path$ nombreDeLaSala��� 5   
   -   5        $ temperatura��5      $
��Left=�6'   $��23��6B   $��
241,86,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   ��6�   �� $ temperatura��� 5   
   -   5         ��Name$ especies��5      $
��Left=�6%   $��241,133,0,0q�6@   $	��Top=�6U   $	��200��6m    �� Text 6y   �� $ especies�5      �� 5   
   -   5        $ tratamientoRealizado��5      $
��Left=�60   $��23��6K   $��241,233,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   ��6�   �� $ tratamientoRealizado�(  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ fecha��5      $
��Left=�6$   $��22��6?   $��241,182,0,0q�6K   $	��Top=�6`   $	��120��6x      SelectedDate 6�   �� $ ultimaRevision��� 5   
   -   5        $��Aceptar��5      $
��Left=�6#   $��241,300,0,0q�6>   $	��Top=�6S   $��42��6k   $��92��6w   6�   �� 5   
   -   5        $��Cancelar��5      $
��Left=�6$   $��400,301,0,0q�6?   $	��Top=�6T   $��41��6l   $��90��6x   6�   �� 5   
   $��Nombre de la sala : ��6   $
��Left=�6/   $��
109,39,0,0q�6J   $	��Top=�6^   $��23��6v   $	��127��6�   �� 5   
   $��Tratamiento realizado : ��6   $
��Left=�63   $��109,233,0,0q�6N   $	��Top=�6c   $��29��6{   $	��132��6�   �� 5   
   $��Seleccione una fecha : ��6   $
��Left=�62   $��109,182,0,0q�6M   $	��Top=�6b   $��23��6z   $	��127��6�   �� 5   
   $��Introduzca la especie : ��6   $
��Left=�63   $��109,131,0,0q�6N   $	��Top=�6c   $��30��6{   $	��127��6�   �� 5   
   $��Temperatura : ��6   $
��Left=�6)   $��
109,86,0,0q�6D   $	��Top=�6X   $��30��6p   $	��132��6|   5      5      