   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	   "    CourseManagement.AddSchedule   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  Add a new Schedule��5   	   $	��450��6$   $	��800��61   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��
Course Id:��6   $��0��6%   $��0��62   $��5q�6B   6O   �� 5   
   -   5        $��cbCourse��5      $��0��6#   $��1��60   $��5q�6@   $	��200��6K    �� DisplayMemberPath$ 
CourseCode��6W    �� SelectedValuePath$ CourseId��6v   $
{�True��6�   6�   �� 5   
   $��Teaching Date:��6   $��1��6)   $��0��66   $��5q�6F   6S   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtPicker��5   2   $��1��6   $��1��6"   $��5q�6D   6T   �� 5   
   $��Slot:��6   $��2��6    $��0��6-   $��5q�6=   6J   �� 5   
   -   5        $��txtSlot��5   /   $��2��6   $��1��6   $��5q�6>   .��6I   6M   �� 5   
   $��Room Id:��6   $��3��6#   $��0��60   $��5q�6@   6M   �� 5   
   -   5        $��cbRoom��5      $��3��6!   $��1��6.   $��5q�6>   $	��200��6I   $ RoomCode��6U   $ RoomId��6r   6�   �� 5   
   $��Description :��6   $��4��6(   $��0��65   $��5q�6E   6R   �� 5   
   -   5        $��txtDescription��5   /   $��4��6   $��1��6   $��5q�6E   6R   �� 5    
   -   5        $��saveAdd��5    /   $��10��6   $��1��6   $��Save Add��6>   $	��100��6Q   $��Right=�6]   $��10q�6y   6�   5!      5"      