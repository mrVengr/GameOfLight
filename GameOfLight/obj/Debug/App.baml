   M S B A M L   `   `   `  ����  GameOfLight    GameOfLight.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        �� 	Resources  5         GrayBlueGradientBrush �� 
StartPoint �� EndPoint � Color � Offset  GradientBrush  SelectedBrush �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� RadiusX �� RadiusY J� Opacity J� RenderTransformOrigin J� BitmapEffect ��Name �� Triggers P� Property P� Value �� 
TargetName �� Radius :� RoutedEvent ��Name �� 
TargetName �� TargetProperty	 W� By g� Duration �� BeginStoryboardName��%�
  &	        &	 �     &	 �    '�� A    7   7  7  �� 5   
   $	 0,0&�5      $	 1,1&�6   .��5      � $ DarkGray��6   $ 0Q�6,   � 5	      $ #CCCCFF��6   $	 0.5Q�6+   � 5
      $ DarkGray��6   $ 1Q�6,   5      �� 5   
   $	 0,0&�5      $	 1,1&�6   .��5      � $ 
WhiteSmoke��6   $	 0.2Q�6.   � 5      $ Transparent��6   $	 0.4Q�6/   � 5      $ 
WhiteSmoke��6   $	 0.9Q�6.   � 5      $ Transparent��6   $ 1Q�6/   5      �� 5   
   $	 0,0&�5      $	 1,1&�6   .��5      � $ 
WhiteSmoke��6   $	 0.2Q�6.   5      �� 5   
   " ��6   .�5      ��  � ��8   6+   �� 5       � ��$	 150��6&   �� 5       � ��$ 10q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5       � #��z��6   #��z��6?   }�. .+�5!      �� $	 outerRectangle��6(   $��Stretch=�5"   	   $��Stretch=�5#   	   #��z��5$   	   $
 20��5%   	   $ 20��6   $��5��6#   
������ 5&   	   �� 5'      $	 	glassCube��6(   $��Stretch=�6;   $��Stretch=�5(      $��2��5)      $
 10��6   $ 10��6(   $ 0Q�65   8�� $ 0.5,0.5&�5+      ��5,   "   �� 5-   &   $ 0.5,0&�6:   $ 0.5,1&�6M   ��5/   .   � $	 0.0Q�6;   $ 	LightBlue��6H   � 50   .   $	 1.0Q�6;   $
 Gray��6H   52   '   z�54   "   V� 55   &   .~�56   *   �� �� 57   *   58   '    5:   "   �� 5;   &   5=      �� 5?      $	 innerRectangle��6(   $��Stretch=�5@   	   $��Stretch=�5A   	   
������ $��20��5B   	   #��z��5C   	   $
 20��5D   	   $ 20��6   ]� 5E      $��ContentPresenterDockPanel��6(   .+�5F   "   �� $ myContentPresenter��63   $��20q�6O   #��z��5G      
���   �5H      5I      5J       5N      P� 5O       �@J�IsMouseOver . . �5P   "   �� $ outerRectangle��6F   # � ��6b    � ���� 5Q   "   $ 	glassCube��6P    �@J�Opacity$ 1Q�6F   6P   �� 5R   "   $ myContentPresenter��6R    �@J�BitmapEffect 5S   &   �� 5T   *   $ 1Q�6;   5V   #   5W      P� 5Z       �@J�	IsFocused . . �5[   "   �� $ outerRectangle��6E   8   � ��5\      �� 5]   "   $ 	glassCube��6R    �@J�Opacity$	 0.5Q�6F   6R   5^      :� 5b      $ Mouse.MouseEnter��6+   [�5c   "   �� 5d   &   $ mouseEnterBeginStoryboard��66   .��5e   *   �� .��5h   .   W� $ 	glassCube��6>   $V P(Rectangle.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�5i      $	 0.3X�5k      $ 0:0:1.5D�6   5m   +   5n   '   5p      :� 5q      $ Mouse.MouseLeave��6+   [�5r   "   �� 5s   &   $ mouseEnterBeginStoryboard��65   5u      5z      5|      5~      5�      5�      