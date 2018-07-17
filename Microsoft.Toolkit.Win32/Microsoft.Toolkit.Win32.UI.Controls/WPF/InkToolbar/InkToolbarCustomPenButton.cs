// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Windows;
using Microsoft.Windows.Interop;

namespace Microsoft.Toolkit.Win32.UI.Controls.WPF
{
    public class InkToolbarCustomPenButton : WindowsXamlHost
    {
        protected global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton UwpControl => this.XamlRoot as global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton;

        public InkToolbarCustomPenButton()
            : this(typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton).FullName)
        {
        }

        // Summary:
        //     Initializes a new instance of the InkToolbarCustomPenButton class.
        public InkToolbarCustomPenButton(string typeName)
            : base(typeName)
        {
        }

        protected override void OnInitialized(EventArgs e)
        {
            // Bind dependency properties across controls
            // properties of FrameworkElement
            Bind(nameof(Style), StyleProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.StyleProperty);
            Bind(nameof(MaxHeight), MaxHeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MaxHeightProperty);
            Bind(nameof(FlowDirection), FlowDirectionProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.FlowDirectionProperty);
            Bind(nameof(Margin), MarginProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MarginProperty);
            Bind(nameof(HorizontalAlignment), HorizontalAlignmentProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.HorizontalAlignmentProperty);
            Bind(nameof(VerticalAlignment), VerticalAlignmentProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.VerticalAlignmentProperty);
            Bind(nameof(MinHeight), MinHeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MinHeightProperty);
            Bind(nameof(Height), HeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.HeightProperty);
            Bind(nameof(MinWidth), MinWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MinWidthProperty);
            Bind(nameof(MaxWidth), MaxWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.MaxWidthProperty);
            Bind(nameof(UseLayoutRounding), UseLayoutRoundingProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.UseLayoutRoundingProperty);
            Bind(nameof(Name), NameProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.NameProperty);
            Bind(nameof(Tag), TagProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.TagProperty);
            Bind(nameof(DataContext), DataContextProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.DataContextProperty);
            Bind(nameof(Width), WidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.WidthProperty);

            // InkToolbarCustomPenButton specific properties
            Bind(nameof(CustomPen), CustomPenProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.CustomPenProperty);
            Bind(nameof(ConfigurationContent), ConfigurationContentProperty, global::Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContentProperty);

            base.OnInitialized(e);
        }

        public static DependencyProperty ConfigurationContentProperty { get; } = DependencyProperty.Register(nameof(ConfigurationContent), typeof(global::Windows.UI.Xaml.UIElement), typeof(InkToolbarCustomPenButton));

        public static DependencyProperty CustomPenProperty { get; } = DependencyProperty.Register(nameof(CustomPen), typeof(global::Windows.UI.Xaml.Controls.InkToolbarCustomPen), typeof(InkToolbarCustomPenButton));

        public global::Windows.UI.Xaml.Controls.InkToolbarCustomPen CustomPen
        {
            get => (global::Windows.UI.Xaml.Controls.InkToolbarCustomPen)GetValue(CustomPenProperty);
            set => SetValue(CustomPenProperty, value);
        }

        public global::Windows.UI.Xaml.UIElement ConfigurationContent
        {
            get => (global::Windows.UI.Xaml.UIElement)GetValue(ConfigurationContentProperty);
            set => SetValue(ConfigurationContentProperty, value);
        }
    }
}