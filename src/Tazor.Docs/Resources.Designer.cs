﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tazor.Docs {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tazor.Docs.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Alert Type=@AlertType.Info Title=&quot;Test Info Alert&quot;&gt;
        ///    &lt;Content&gt;
        ///        &lt;p class=&quot;leading&quot;&gt;This is an info alert!&lt;/p&gt;
        ///    &lt;/Content&gt;
        ///&lt;/Alert&gt;
        ///
        ///&lt;Alert Type=@AlertType.Success Title=&quot;Test Success Alert&quot;&gt;
        ///    &lt;Content&gt;
        ///        &lt;p class=&quot;leading&quot;&gt;This is a success alert!&lt;/p&gt;
        ///    &lt;/Content&gt;
        ///&lt;/Alert&gt;
        ///
        ///&lt;Alert Type=@AlertType.Warning Title=&quot;Test Warning Alert&quot;&gt;
        ///    &lt;Content&gt;
        ///        &lt;p class=&quot;leading&quot;&gt;This is an alert that is warning you!&lt;/p&gt;
        ///    &lt;/Content&gt;
        ///&lt;/Alert&gt;
        ///
        ///&lt;Alert Type=@AlertType.Error Title=&quot;Test Erro [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_Alerts {
            get {
                return ResourceManager.GetString("Examples_Alerts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div class=&quot;gap-4 flex&quot;&gt;
        ///    &lt;Badge Type=&quot;BadgeType.Info&quot;&gt;Info&lt;/Badge&gt;
        ///    &lt;Badge Type=&quot;BadgeType.Success&quot;&gt;Success&lt;/Badge&gt;
        ///    &lt;Badge Type=&quot;BadgeType.Warning&quot;&gt;Warning&lt;/Badge&gt;
        ///    &lt;Badge Type=&quot;BadgeType.Error&quot;&gt;Error&lt;/Badge&gt;
        ///    &lt;Badge Type=&quot;BadgeType.Custom&quot; CustomClass=&quot;bg-indigo-600 border-indigo-800 text-white&quot;&gt;Custom&lt;/Badge&gt;
        ///&lt;/div&gt;.
        /// </summary>
        public static string Examples_Badges {
            get {
                return ResourceManager.GetString("Examples_Badges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;div class=&quot;grid grid-cols-5 gap-2&quot;&gt;
        ///    @foreach(ButtonType bt in Enum.GetValues(typeof(ButtonType)))
        ///    {
        ///        &lt;Button Type=@bt&gt;@(Enum.GetName&lt;ButtonType&gt;(bt))&lt;/Button&gt;
        ///    }
        ///&lt;/div&gt;.
        /// </summary>
        public static string Examples_Buttons {
            get {
                return ResourceManager.GetString("Examples_Buttons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to @HeroIcons.ArchiveBox(&quot;block&quot;, &quot;w-8 h-8&quot;).
        /// </summary>
        public static string Examples_Content_HeroIcons_Basic {
            get {
                return ResourceManager.GetString("Examples_Content_HeroIcons_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ListView Items=@StringItems /&gt;
        ///@code {
        ///    private IEnumerable&lt;string&gt; StringItems = new string[] {
        ///        &quot;Item 1&quot;,
        ///        &quot;Item 2&quot;,
        ///        &quot;Item 3&quot;,
        ///        &quot;Item 4&quot;,
        ///        &quot;Item 5&quot;
        ///    };
        ///}.
        /// </summary>
        public static string Examples_Data_ListView_Basic {
            get {
                return ResourceManager.GetString("Examples_Data_ListView_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;ListView Items=@People&gt;
        ///    &lt;ItemTemplate&gt;
        ///        &lt;div class=&quot;flex justify-between items-center w-full&quot;&gt;
        ///            &lt;div class=&quot;flex items-center gap-4&quot;&gt;
        ///                &lt;img src=@context.AvatarUrl class=&quot;w-12 h-12 rounded-full&quot; /&gt;
        ///                &lt;div&gt;
        ///                    &lt;span class=&quot;font-semibold&quot;&gt;@context.Name&lt;/span&gt;
        ///                    &lt;span class=&quot;text-sm opacity-50&quot;&gt;@context.Title&lt;/span&gt;
        ///                &lt;/div&gt;
        ///            &lt;/div&gt;
        ///            &lt;div&gt;
        ///                &lt;a href=&quot;#&quot; class=&quot;cursor-pointer&quot;&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_Data_ListView_Templated {
            get {
                return ResourceManager.GetString("Examples_Data_ListView_Templated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;TreeView Items=&quot;@Items&quot; RequestTree=&quot;@RequestTree&quot; /&gt;
        ///@code {
        ///    protected IEnumerable&lt;ITreeItem&gt; Items { get; set; } = Enumerable.Empty&lt;ITreeItem&gt;();
        ///
        ///    protected override void OnInitialized()
        ///    {
        ///        base.OnInitialized();
        ///
        ///        Items = new ITreeItem[]
        ///        {
        ///            new TreeItem{ Title = $&quot;Item 1&quot;, Icon = HeroIcons.Folder() },
        ///            new TreeItem{ Title = $&quot;Item 2&quot;, Icon = HeroIcons.Folder() },
        ///            new TreeItem{ Title = $&quot;Item 3&quot;, Icon = HeroIcons.Folder() },
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_Data_TreeView_Basic {
            get {
                return ResourceManager.GetString("Examples_Data_TreeView_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;DataGrid Items=_invoices Columns=_invoiceColumns /&gt;
        ///
        ///@code {
        ///    private class Invoice
        ///    {
        ///        public int Id { get; set; }
        ///
        ///        public string Customer { get; set; } = null!;
        ///
        ///        public double Amount { get; set; }
        ///
        ///        public bool Paid { get; set; }
        ///    }
        ///
        ///    private IEnumerable&lt;Invoice&gt; _invoices = Enumerable.Empty&lt;Invoice&gt;();
        ///
        ///    private IEnumerable&lt;Column&lt;Invoice&gt;&gt; _invoiceColumns = new[]
        ///    {
        ///        new Column&lt;Invoice&gt; { Title = &quot;Id&quot;, Field = m =&gt; m.Id },
        ///        new Column&lt;Invoic [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_DataGrid {
            get {
                return ResourceManager.GetString("Examples_DataGrid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;select @onchange=HandlePanelPlacementChanged class=@Theme.Current.Forms.SelectInput&gt;
        ///    @foreach(var val in Enum.GetValues(typeof(PanelPlacement)))
        ///    {
        ///        &lt;option selected=@((PanelPlacement)val == _selectedPlacement) value=@val&gt;@Enum.GetName(typeof(PanelPlacement), val)&lt;/option&gt;
        ///    }
        ///&lt;/select&gt;
        ///
        ///&lt;Button Clicked=@(() =&gt; { _isFlyoutOpen = true; StateHasChanged(); })&gt;Open Flyout&lt;/Button&gt;
        ///
        ///&lt;Flyout Placement=_selectedPlacement Title=&quot;Test Flyout&quot; @bind-IsVisible=_isFlyoutOpen&gt;
        ///    &lt;Content&gt;
        ///        &lt;p&gt;T [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_Flyout {
            get {
                return ResourceManager.GetString("Examples_Flyout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h3 class=&quot;font-semibold mb-2 mt-4&quot;&gt;Options&lt;/h3&gt;
        ///&lt;div class=&quot;flex items-center gap-4 mb-4&quot;&gt;
        ///    &lt;p&gt;Allow Multi Open&lt;/p&gt;
        ///    &lt;Switch @bind-IsChecked=_allowMultiOpen /&gt;
        ///&lt;/div&gt;
        ///
        ///&lt;Accordion MultiOpen=@_allowMultiOpen&gt;
        ///    &lt;AccordionFold&gt;
        ///        &lt;Header&gt;Accordion Fold 1&lt;/Header&gt;
        ///        &lt;Content&gt;
        ///            &lt;p&gt;Praesent egestas molestie ligula, ...&lt;/p&gt;
        ///        &lt;/Content&gt;
        ///    &lt;/AccordionFold&gt;
        ///    &lt;AccordionFold&gt;
        ///        &lt;Header&gt;Accordion Fold 2&lt;/Header&gt;
        ///        &lt;Content&gt;
        ///            &lt;p&gt;Praesent egestas mol [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Examples_Layout_Accordion_Basic {
            get {
                return ResourceManager.GetString("Examples_Layout_Accordion_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Breadcrumb Items=&quot;_breadcrumb&quot; /&gt;
        ///
        ///@code {
        ///    private IEnumerable&lt;NavItem&gt; _breadcrumb = new NavItem[]
        ///    {
        ///        new NavItem(&quot;Home&quot;) { Href = &quot;/&quot; },
        ///        new NavItem(&quot;Navigation&quot;),
        ///        new NavItem(&quot;Breadcrumbs&quot;)
        ///    };
        ///}.
        /// </summary>
        public static string Examples_Navigation_Breadcrumb_Basic {
            get {
                return ResourceManager.GetString("Examples_Navigation_Breadcrumb_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Breadcrumb Items=&quot;_breadcrumb&quot;&gt;
        ///    &lt;DelimiterFragment&gt;
        ///        @HeroIcons.AcademicCap()
        ///    &lt;/DelimiterFragment&gt;
        ///&lt;/Breadcrumb&gt;
        ///
        ///@code {
        ///    private IEnumerable&lt;NavItem&gt; _breadcrumb = new NavItem[]
        ///    {
        ///        new NavItem(&quot;Home&quot;) { Href = &quot;/&quot; },
        ///        new NavItem(&quot;Navigation&quot;),
        ///        new NavItem(&quot;Breadcrumbs&quot;)
        ///    };
        ///}.
        /// </summary>
        public static string Examples_Navigation_Breadcrumb_CustomDelimiter {
            get {
                return ResourceManager.GetString("Examples_Navigation_Breadcrumb_CustomDelimiter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;TabNav Items=_exampleNavItems @bind-SelectedItem=_selectedExampleNavItem /&gt;
        ///
        ///@code {
        ///    private NavItem? _selectedExampleNavItem;
        ///    private IEnumerable&lt;NavItem&gt; _exampleNavItems = new[]
        ///    {
        ///        new NavItem(&quot;Tab 1&quot;),
        ///        new NavItem(&quot;Tab 2&quot;),
        ///        new NavItem(&quot;Tab 3&quot;),
        ///        new NavItem(&quot;Tab 4&quot;)
        ///    };
        ///}
        ///.
        /// </summary>
        public static string Examples_Navigation_TabNav_Basic {
            get {
                return ResourceManager.GetString("Examples_Navigation_TabNav_Basic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Pager @bind-CurrentPage=_currentPage NumberOfVisiblePages=&quot;10&quot; Pages=&quot;500&quot; /&gt;
        ///
        ///@code {
        ///    private int _currentPage = 35;
        ///}
        ///.
        /// </summary>
        public static string Examples_Pager {
            get {
                return ResourceManager.GetString("Examples_Pager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Switch @bind-IsChecked=&quot;@IsChecked&quot; /&gt;
        ///&lt;p&gt;Switch Value: @_isSwitched&lt;/p&gt;
        ///
        ///@code {
        ///    private bool _isSwitched = true;
        ///}.
        /// </summary>
        public static string Examples_Switch {
            get {
                return ResourceManager.GetString("Examples_Switch", resourceCulture);
            }
        }
    }
}
