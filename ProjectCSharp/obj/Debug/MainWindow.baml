   M S B A M L   `   `   `  ????H  DProjectCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjectCSharpProjectCSharp  5   	       ProjectCSharp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjectCSharp     5   	     ? Title$  
MainWindow??5   	   $	??496??6   $	??796??6)    ? 
ResizeMode$ CanResizeWithGrip=?65   .??5
      ?  J? RenderTransformOrigin$ 1.026,0.643&?6   ??5   
   ?? 5       ?? EndPoint$ 1.5,0&?6"    ?? 
StartPoint$ 1,1.5&?63    ? SpreadMethod$	 Pad=?6F   .??5      ?  ? Color$ Black??6    ? Offset$ 1Q?6-   ? 5      $ 	#FFF5E8E8??6   5       ? ColumnDefinitions 5   
   ?? 5      $??2* ?6   6,   ?? 5      $??3* ?6   6,   	 ? RowDefinitions	 5   
   ?? 5      $??* ?6   6)   ?? 5      $??6* ?6   6*   .+?5    
   ?? $	??Top=?6   $??0??6-   $??0??6=   $??3??6J   $??68??6^   .+?5!      ?? $!??Inventory Management System??6   $??Center=?6:   $??35??6_   $$??Bahnschrift SemiBold Condensed)?6k   $??24(?6?   $
??Bold"?6?   $??Italic$?6?   ???	#FF941C1C
???????$ 0.498,-1.644&?6?   ?? 5"      $??Manage Products??6   $??Center=?6.   $??33??6R   $$??Bahnschrift SemiBold Condensed)?6^   $??18(?6?   $??Italic$?6?   ???	#FF941C1C
???????6?   5#      ?? 5%   
   $??1??6   
 ?? Orientation$
 Vertical=?6"   $??Center=?69   $	??Top=?6V   .+?5)      ?? $
 Vertical=?6   $??10q?61   .+?5*      ?? $??
Product ID??6   $
??Left=?60   $??0 0 10 0q?6K   ?? 5+      -   5         ??Name$	 PID??5+      ???	#FFB71900$	??150??6?   $??15??6K   5,      ?? 5.      $
 Vertical=?6   $??10q?61   .+?5/      ?? $
??Name??6   $
??Left=?6*   $??0 0 10 0q?6E   ?? 50      -   5        $ PName??50      ???	#FFB71900$	??150??6A   $??15??6M   51      ?? 53      $
 Vertical=?6   $??10q?61   .+?54      ?? $??Description??6   $
??Left=?61   $??0 0 10 0q?6L   ?? 55      -   5        $ PDesc??55      ???	#FFB71900$	??150??6A   $??15??6M   56      ?? 58      $
 Vertical=?6   $??10q?62   .+?59      ?? $??Quantity??6   $
??Left=?6.   $??0 0 10 0q?6I   ?? 5:      -   5        $ 	PQuantity??5:      ???	#FFB71900$	??150??6E   $??15??6Q   5;      ?? 5=      $
 Vertical=?6   $??10q?61   .+?5>      ?? $??Price??6   $
??Left=?6+   $??0 0 10 0q?6F   ?? 5?      -   5        $ PPrice??5?      ???	#FFB71900$	??150??6B   $??15??6N   ?? 5@      -   5         ??Name$ Category??5@      $
??Left=?6-   $??0 15 0 0q?6H   $	??150??6[   $??15??6g   5A      ?? 5C      $
 
Horizontal=?6   $??Center=?62   .+?5E      ?? $	??Add??6   $??Center=?6#   $	??Top=?6A   ???	#FF941C1C
???????$ 0.109,0.561&?6?   $ ??Barlow Condensed ExtraBold)?6?   $??46??6?   $??18??6?    ?? Left$	 110??6?   
 ?? Top$	 254??6?   ?? 5F      $
??Edit??6   $
??Left=?6$   $	??Top=?6?   ???	#FF941C1C$ 0.109,0.561&?6n   
???????$ ??Barlow Condensed ExtraBold)?6?   $??48??6?   $??18??6?   $ 38??6?   $	 254??6?   ?? 5G      $??Delete??6   $
??Left=?6&   $	??Top=?6A   ???	#FF941C1C
???????$ 0.109,0.561&?6?   $ ??Barlow Condensed ExtraBold)?6?   $??50??6?   $??18??6?   $	 179??6?   $	 254??6?   5H      ?? 5J      $
??Home??6   $??Center=?6$   $
??0 10q?6A   ???	#FF941C1C
???????$ ??Barlow Condensed ExtraBold)?6{   $??83??6?   $??17??6?   5O      ?? 5Q   
   $??1??6   $??1??6"   $
 Vertical=?62   $	??Top=?6I   .+?5R      ?? -   5         ??Name$ ProductList_Label??5R      $??Center=?63   $??Products List??6P   $??17??6e   ???	#FF040F6B$
??Bold"?6?   $??Bahnschrift Condensed)?6?   $??90??6?   $??18(?6?   ?? 5T      $
 
Horizontal=?6   $??Center=?62   .+?5U      ?? -   5        $ Category_Search??5U      $??Center=?64   $
??0 20q?6Q   $	??150??6_   $??15??6k   ?? 5V      $??Search??6   $??Center=?6*   ???	#FF941C1C
???????$ ??Barlow Condensed ExtraBold)?6r   $??48??6?   $??19??6?   ?? 5W      $??Refresh??6   $??Center=?6+   ???	#FF941C1C
???????$ ??Barlow Condensed ExtraBold)?6r   $??48??6?   $??19??6?   5X      ?? 5Z      .+?5[      &   System.Windows.Controls.DataGrid  -	   5          Name$ ProductsGrid??5[   (   $	??300??6   $??Barlow Condensed Black)?6>   $??10(?6b   ???	#FFF56A40 J? OpacityMask 5\      ?? 5]      $ 0.5,1&?6.   $ 0.5,0&?6?   .??5^      ? $ Black??6+   ? 5_      $ White??6+   $ 1Q?69   5`      ??5b      ?? 5c      $ 0.5,1&?6.   $ 0.5,0&?6?   .??5d      ? $ 	#FFFF9999??6+   ? 5e      $ White??6+   $ 1Q?69   5f      5h      5i      5j      5?      5?      