   M S B A M L   `   `   `  ????D  @Question1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Question1	Question1  5   	       Question1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Question1     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5         ??Name$ lstItems??5      $??5,5,5,10q?5      $??1??5      $??2??6#    ?? View 5      ?? 5      -   5        grdItems??.P?5      ??  ?? Width$	 200??6%   $
??Name??61    ?? DisplayMemberBinding 6?   ?? *Name+?? 5      $	 100??6%   $??Category??61    6C   ?? *
Category+?? 5      $	 100??6%   $??Price??61    6@   ?? *
PriceTag+5      5      ?? 5    
   $??Chez Pierre Menu??6   $??Center=?6+   $??30(?6H   ?? 5!   
   -   5        $??	lblTotals??5!      $??Totals??6!   $??1??62   $??2??6B   ?? 5$   
   -   5        $??cmbMenuItems??5$      $??0??6'   $??Center=?64   $??Bottom=?6Q   $	??300??6l   $??0,0,0,20q?6x   $??16(?6?   .@?5%      ?? $??Beverage: Soda $1.95??6    ?? 
IsSelected . 6:   ?? 5&      $??Beverage: Tea $1.50??6   ?? 5'      $??Beverage: Coffee $1.25??6   ?? 5(      $#??Beverage: Mineral Water $2.95??6   5)      ?? 5+   
   -   5        $??
btnAddItem??5+      $??Add Item??6=   $??1??6P   $??Center=?6]   $	??250??6x   $??20(?6?   ?? 5,   
   -   5        $??btnRemoveItem??5,      $??Remove Item??6B   $??2??6X   $??Center=?6e   $	??250??6?   $??20(?6?   5.      5/      