   M S B A M L   `   `   `  ����  GameOfLight    GameOfLight.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          � Title$  
MainWindow��5   	   $	��480��6   $	��640��6)    � WindowStyle$
 None=�6N    � WindowState$ 	Maximized=�6a    J� SnapsToDevicePixels . ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    � MappingMode$ RelativeToBoundingBox=�6/    �� 
StartPoint$ 0.5,0&�6S   .��5      �  � Color$ Black��6    � Offset$ 0Q�6)   � 5	      $ 	#FF5D5D5D��6   $ 1Q�6-   � 5
      $ 	#FFCED7FF��6   5      	 J� Effect	 5      -  'System.Windows.Media.Effects.BlurEffect  5   
   -   5        
WindowBlur��
   Radius$
 0Q�5   )   .��5      �  � RowDefinitions 5   
   �� 5      $	��45* �6   �� 5      $	��14* �6   .+�5   
   � $��1��6   $��4q�6    � ColumnDefinitions 5      �� 5      $	��70* �6#   �� 5      $
��241* �6#   .+�5      �� 
���   � �� RadiusX$ 45��6'    �� RadiusY$ 45��64   $��3��6A   ��5      �� 5      $ 0.5,1&�6*   $ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5      � $ 	#FF183C28��6'   � 5      $ 	#FF8A8D53��6'   $ 1Q�69   5      5!      �� 5"      $��1��6   $��2,0,0,0q�6(   $
 38.5��69   $
 38.5��6H   
���   � �� StrokeDashArray$	 1 0R�6f    . $��3��6�   ��5#      �� 5$       �� ImageSource$" Pictures/untitled9-thumb.jpg��6!    j� Stretch$ UniformToFill=�6L   5(      � 5)      $��1��6    5*      �� 5+      $��4* �6'   �� 5,      $	��95* �6'   �� 5-      $	��95* �6'   �� 5.      $	��95* �6'   �� 5/      $	��95* �6'   �� 50      $	��95* �6'   �� 51      $��5* �6'   .+�53      �� $��Mirror��6   $��1��6*   $��10,25q�6:   $
��Auto��6I   $��Segoe Script)�6V   $��20(�6p   $��Center=�6~   �� 54      $��2��6   $��10,25q�6)   $
��Auto��68   $��Segoe Script)�6E   $��20(�6_   $��Center=�6m   ��55      �� 56      $��One Way Mirror��6    $
��Wrap=�66   58      �� 59      $
��Lens��6   $��3��6(   $��10,25q�68   $
��Auto��6G   $��Segoe Script)�6T   $��20(�6n   $��Center=�6|   �� 5:      $��Curved Lens��6   $��4��6/   $��10,25q�6?   $
��Auto��6N   $��Segoe Script)�6[   $��20(�6u   $��Center=�6�   �� 5;      $��Prism��6   $��5��6)   $��10,25q�69   $
��Auto��6H   $��Segoe Script)�6U   $��20(�6o   $��Center=�6}   5<      5=      5>      5?      