   M S B A M L   `   `   `  ����K  GCourseManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CourseManagementCourseManagement  5   	   #    CourseManagement.EditSchedule   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CourseManagement     5   	     � Title$  EditSchedule��5   	   $	��450��6   $	��800��6+   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6   $��TeachingScheduleId��6-   $��5q�6J   6W   �� 5   
   -   5        $��txtTSId��5   /   $��0��6   $��1��6    �� 
IsReadOnly$
 true��6>   $��5q�6P   6]   �� 5   
   $��1��6   $��0��6   $��CourseId��6-   $��5q�6@   6M   �� 5   
   -   5        $��
cbCourseId��5   0   $��1��6   $��1��6    $��5q�6B    �� DisplayMemberPath$ 
CourseCode��6M    �� SelectedValuePath$ CourseId��6l   6�   �� 5   
   $��2��6   $��0��6   $��TeachingDate��6-   $��5q�6D   6Q   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Picker��5   2   $��2��6   $��1��6"   $��5q�6B   6O   �� 5   
   $��3��6   $��0��6   $
��Slot��6-   $��5q�6<   6I   �� 5   
   -   5        $
��Slot��5   /   $��3��6   $��1��6   $��5q�6;   6H   �� 5   
   $��4��6   $��0��6   $��RoomId��6-   $��5q�6>   6K   �� 5    
   -   5        $��RoomId��5    0   $��4��6   $��1��6    $��5q�6>   $ RoomCode��6I   $ RoomId��6f   6�   �� 5!   
   $��5��6   $��0��6   $��Description��6-   $��5q�6C   6P   �� 5"   
   -   5        $��Description��5"   /   $��5��6   $��1��6   $��10,5,0,5q�6B   6V   �� 5#   
   -   5        $��saveEdit��5#   .   $��6��6   $��1��6   $��	Save Edit��6>   $	��100��6R   $��Right=�6^   $��10q�6z   6�   5$      5%      