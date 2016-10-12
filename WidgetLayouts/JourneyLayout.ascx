<%--Class used to create custom layout widget

If this layout widget is a part of a Sitefinity module,
you can register it in the site's toolbox by adding this to the module's Install/Upgrade method(s):
initializer.Installer
    .Toolbox(CommonToolbox.Layouts)
        .LoadOrAddSection(SectionName)
            .SetTitle(SectionTitle) // When creating a new section
            .SetDescription(SectionDescription) // When creating a new section
            .LoadOrAddWidget<LayoutControl>("JourneyLayout")
                .SetTitle("JourneyLayout")
                .SetDescription("JourneyLayout")
                .LocalizeUsing<ModuleResourceClass>() //Optional
                .SetCssClass(WidgetCssClass) // You can use a css class to add an icon (Optional)
                .SetParameters(new NameValueCollection()
                {
                    { "layoutTemplate", "~/WidgetLayouts/JourneyLayout.ascx" },
                })
            .Done()
        .Done()
    .Done();

You can see also http://www.sitefinity.com/documentation/gettingstarted/creating-custom-sitefinity-layout-widget-controls --%>

<div class="container">
    <div runat="server" class="sf_cols row">
        <div runat="server" class="sf_colsOut col-sm-4 col-md-3">
            <div runat="server" class="sf_colsIn">
            </div>
        </div>
        <div runat="server" class="sf_colsOut col-sm-8 col-md-9">
            <div runat="server" class="sf_colsIn">
            </div>
        </div>
    </div>
</div>

