   M S B A M L   `   `   `  ����H  DFarmersMarket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:FarmersMarketFarmersMarket  5   	       FarmersMarket.Sales   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:FarmersMarket     5   	     � Title$  Sales��5   	   $	��470��6   $	��800��6$   .��5	      � .+�5
   
   �� -   5         ��Name$ 	lbl_Sales��5
      $"��🧺 Farmers' Market (Sales)��6#   $
��Left=�6H   $��	10,10,0,0q�6c   $	��Top=�6v   $��20(�6�   �� 5   
   -   5         ��Name$ grid_Products��5      $��23,71,352,30q�6v   ���	#FFDAF5D0��6*   �� *
products+ �� View 5      �� 5      .P�5      �� $��Product Name��6K    �� Width$	 100��6a    �� DisplayMemberBinding 6%   �� *name+6a   �� 5      $��Product SKU��6I   $	 100��6^    6%   �� *id+6^   �� 5      $��Available (kg)��6L   $	 100��6d    6%   �� *stock+6d   �� 5      $��Price (CAD) /kg��6L   $	 100��6e    6%   �� *price+6e   5      5      �� 5   
   -   5         ��Name$ btn_Add��5      $��+��6"   $
��Left=�6.   $��456,198,0,0q�6I   $	��Top=�6^   $��25��6v   $��25��6�   ���	#FFDAF5D06�   �� 5   
   -   5        $ btn_Min��5      $��-��6"   $
��Left=�6.   $��456,232,0,0q�6I   $	��Top=�6^   $��25��6v   $��25��6�   ���	#FFD0DCF56�   �� 5   
   -   5        $ grid_Basket��5      $��499,71,20,124q�6G   ���	#FFD0DCF5��6(   �� *basket+ 5      �� 5      .P�5      �� $��Product��6K   $	 100��6\    6%   �� *name+6\   �� 5      $��Amount (kg)��6L   $	 100��6a    6%   �� *stock+6a   �� 5      $��Total��6L   $ 60��6[    6%   �� *price+6[   5       5"      �� 5$   
   -   5        $ lbl_GrandTotal��5$      $��Grand Total:��6(   $
��Left=�6?   $��552,354,0,0q�6Z   $	��Top=�6o   $
��Bold"�6�   �� 5%   
   -   5         ��Name$ 	box_Total��5%      $
��Left=�6'   $��26��6B   $��649,354,0,0q�6N   
���   �$	��Top=�6r   $	��100��6�   ���	#FFBCDCA66�   �� 5&   
   -   5        $ btn_Buy��5&      $��🛒 Buy��6"   $
��Left=�63   $��649,389,0,0q�6N   $	��Top=�6c   $��26��6{   $	��100��6�   ���	#FFC7F8F9$
��Bold"�6�   6�   �� 5'   
   -	   5        $ lbl_GrandTotalValue��5'      $�� ��6-   $
��Left=�68   $��649,354,0,0q�6S   $	��Top=�6h    J� RenderTransformOrigin$ 0.526,0.541&�6�   $	��100��6�   5(      5)      