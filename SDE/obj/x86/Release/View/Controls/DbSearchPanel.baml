   M S B A M L   `   `   `  ���� @  <SDE, Version=1.0.3.419, Culture=neutral, PublicKeyToken=null5clr-namespace:SDE.View.ControlsSDE.View.Controls  G CTokeiLibrary, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nullU:clr-namespace:TokeiLibrary.WpfBugFix;assembly=TokeiLibraryTokeiLibrary.WpfBugFix W;clr-namespace:TokeiLibrary.WPF.Styles;assembly=TokeiLibraryTokeiLibrary.WPF.Styles %    SDE.View.Controls.DbSearchPanel   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    >d2http://schemas.microsoft.com/expression/blend/2008    2controlsclr-namespace:SDE.View.Controls    N	wpfBugFix:clr-namespace:TokeiLibrary.WpfBugFix;assembly=TokeiLibrary    Lstyles;clr-namespace:TokeiLibrary.WPF.Styles;assembly=TokeiLibrary    .��� .+��� -   $��_border1��$��0q����#8490A1$��Center=�$��1 1 0 1q�._�� 
������   � ColumnDefinitions  �� �� $
��auto ��� $
��auto �.+�$   SDE.View.Controls.LeftComboBox  -     Name$ 
_cbSubMenu��$��3��$��0��$��Bottom=�.@�.  (TokeiLibrary.WpfBugFix.UnclickableBorder  -     Name$ _unclickableBorder��$��-4, -2, -4, -2q�|�.  $��1q����#9AA6B6 � FocusVisualStyle Z� ����  �� 
StartPoint$	 0,0&� �� EndPoint$	 0,1&�.���  � Offset$ 0Q� � Color$ #DEDEDE��� $	 0.5Q�$ White��._�� -   $��_gridSearchContent��$��2q�����  �� Path$ ActualWidth�	 �� ElementName$	 
_cbSubMenu������ $ ActualWidth�$	 
_cbSubMenu��  �� �� $
��auto ��� �� -   $��_searchTextBox��
 �� AcceptsReturn
 .   �� 
AcceptsTab .  $��3q�$��0q�$��Center=��� -   $��
_labelFind��$��3 0 0 0q�$��Center=�$��	Search...��$��Italic$�
������� J� IsHitTestVisible .  )  #TokeiLibrary.WPF.Styles.FancyButton  -     Name$ _buttonResetSearch��$��1��$��Right=�   	ImagePath$ 	reset.png������ $	 _searchTextBox��$ 
Background��� $��2��$��Right=�
�������$��0q�����  �� Source# Z��._�  -   $ _buttonOpenSubMenu��$��Right=�$ smallArrow.png������ $	 _searchTextBox��$ 
Background����� # Z��