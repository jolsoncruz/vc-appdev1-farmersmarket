   M S B A M L   `   `   `  ����H  DFarmersMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FarmersMarketFarmersMarket  5   	       FarmersMarket.Admin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FarmersMarket     5   	     � Title$  Admin��5   	   $	��470��6   $	��800��6$   .��5	      � .+�5
   
   �� -   5         ��Name$ 	lbl_Admin��5
      $"��🧺 Farmers' Market (Admin)��6#   $
��Left=�6H   $��	10,10,0,0q�6c   $	��Top=�6v   $��20(�6�   �� 5   
   -   5         ��Name$ grid_Products��5      $��246,71,26,30q�6v   ��6*   �� *
products+ �� View 5      �� 5      .P�5      �� $��Product Name��6K    �� Width$	 100��6a    �� DisplayMemberBinding 6%   �� *name+6a   �� 5      $��Product SKU��6J   $	 100��6_    6%   �� *sku+6_   �� 5      $��
Stock (kg)��6L   $	 100��6`    6%   �� *stock+6`   �� 5      $��Price (CAD) /kg��6L   $	 100��6e    6%   �� *price+6e   5      5      �� 5   
   -   5        $ lbl_Name��5      $��Product Name:��6"   $
��Left=�6:   $��	10,71,0,0q�6U   $	��Top=�6h   $	��100��6�   $
��Bold"�6�   �� 5   
   -   5        $ lbl_SKU��5      $��Product SKU:��6!   $
��Left=�68   $��
10,143,0,0q�6S   $	��Top=�6g   $	��100��6   $
��Bold"�6�   �� 5   
   -   5        $ 
lbl_Amount��5      $��Amount (kg):��6$   $
��Left=�6;   $��
10,219,0,0q�6V   $	��Top=�6j   $	��100��6�   $
��Bold"�6�   �� 5   
   -   5        $ 	lbl_Price��5      $��Price (CAD) /kg��6#   $
��Left=�6=   $��
10,291,0,0q�6X   $	��Top=�6l   $	��100��6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 
input_Name��5      $
��Left=�6&   $��
15,102,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��211��6�   $��25��6�   $��Center=�6�   ���	#FFECDEDE6�   �� 5   
   -   5        $ 	input_SKU��5      $
��Left=�6%   $��
15,174,0,0q�6@   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��211��6�   $��25��6�   $��Center=�6�   ���	#FFECDEDE6�   �� 5   
   -	   5        $ input_Amount��5      $
��Left=�6(   $��
15,250,0,0q�6C   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��211��6�   $��25��6�   $��Center=�6�   ���	#FFECDEDE6�   �� 5   
   -
   5        $ input_Price��5      $
��Left=�6'   $��
15,322,0,0q�6B   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��211��6�   $��25��6�   $��Center=�6�   ���	#FFECDEDE6�   �� 5   
   -   5         ��Name$ btn_Add��5      $	��Add��6"   $
��Left=�60   $��
15,378,0,0q�6K   $	��Top=�6_   $��56��6w   $��25��6�   6�   �� 5    
   -   5        $ 
btn_Update��5       $��Update��6%   $
��Left=�66   $��
92,378,0,0q�6Q   $	��Top=�6e   $��56��6}   $��25��6�   6�   �� 5!   
   -   5        $ 
btn_Delete��5!      $��Delete��6%   $
��Left=�66   $��170,378,0,0q�6Q   $	��Top=�6f   $��56��6~   $��25��6�   6�   5#      5$      