   M S B A M L   `   `   `  ����L  HPaperRockScissors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PaperRockScissorsPaperRockScissors  5   	   "    PaperRockScissors.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:PaperRockScissors     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ StylesDictionary.xaml?�6%   %    5      .��5      � .+�5   
   �� $	��150��6   $��Rounds: ��6!   $��40(�61   $��Center=�5      $��Center=�6-   $��312,-1,330,355q�5      �� 5   
   $��1��6   $��1��6!   $��40(�6*   $��462,5,304,361q�68   $��26��6O   $��53��6Z   $��Center=�5      $��Center=�6+   �� 5   
   -   5         ��Name$ imaeg1Border��5      $��1q�6'   
���   �$��150,93,500,176q�5   %   ._�5      �� -   5         ��Name$ playerMoveImage��5      $��Images/rock.png��6-   5      �� 5   
   -   5        $ imaeg2Border��5      $��1q�6'   
���   �$��500,93,150,176q�5   %   ._�5       �� -   5        $ enemyMoveImage��5       $��Images/rpaper.png��6,   5!      �� 5#   
   $��Choose your weapon��6   $��50��6.   $	��200��6:   $��20(�6F   $��Center=�5$      $��Center=�64   $��300,275,300,94q�5%      �� 5'   
   -   5        $ 
paperImage��5'      $��75��6$   $��75��6/   $��Images/paper.png��6;   $��272,325,444,19q�5(      5)      �� 5*   
   -   5        $ 	rockImage��5*      $��75��6#   $��75��6.   $��Images/rock.png��6:   $��361,325,356,19q�5+      6(   �� 5,   
   -   5        $ scissorsImage��5,      $��75��6'   $��75��62   $��Images/scissors.png��6>   $��451,325,266,19q�5-      6(   %   PaperRockScissors.ResultsWindow  5.   
   -   5          Name$ 
playerWins��5.      $��10,143,682,176q�5/         PointsContent$ 0��66      WhosePointsContent$ 	Your wins��50      	   WhosePointsFontSize$	 20��51        52   
   -	   5        $ 	enemyWins��52      $��682,143,10,176q�53      $ 0��66   $ 
Enemy wins��54      $	 17��55      56      57      