// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ILAsmBinding {
    
    public partial class CompilerParametersPanelWidget {
        
        private Gtk.VBox vbox1;
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label86;
        
        private Gtk.HBox hbox57;
        
        private Gtk.ComboBox compileTargetCombo;
        
        private Gtk.CheckButton checkbuttonIncludeDebugInfo;
        
        private Gtk.Label GtkLabel1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ILAsmBinding.CompilerParametersPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "ILAsmBinding.CompilerParametersPanelWidget";
            // Container child ILAsmBinding.CompilerParametersPanelWidget.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            this.GtkAlignment.LeftPadding = ((uint)(12));
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label86 = new Gtk.Label();
            this.label86.Name = "label86";
            this.label86.Xalign = 0F;
            this.label86.LabelProp = Mono.Unix.Catalog.GetString("Compile _Target:");
            this.label86.UseUnderline = true;
            this.hbox1.Add(this.label86);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.label86]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.hbox57 = new Gtk.HBox();
            this.hbox57.Name = "hbox57";
            // Container child hbox57.Gtk.Box+BoxChild
            this.compileTargetCombo = new Gtk.ComboBox();
            this.compileTargetCombo.Name = "compileTargetCombo";
            this.hbox57.Add(this.compileTargetCombo);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox57[this.compileTargetCombo]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            this.hbox1.Add(this.hbox57);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.hbox57]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.checkbuttonIncludeDebugInfo = new Gtk.CheckButton();
            this.checkbuttonIncludeDebugInfo.CanFocus = true;
            this.checkbuttonIncludeDebugInfo.Name = "checkbuttonIncludeDebugInfo";
            this.checkbuttonIncludeDebugInfo.Label = Mono.Unix.Catalog.GetString("Include debug information");
            this.checkbuttonIncludeDebugInfo.DrawIndicator = true;
            this.checkbuttonIncludeDebugInfo.UseUnderline = true;
            this.vbox3.Add(this.checkbuttonIncludeDebugInfo);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.checkbuttonIncludeDebugInfo]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            this.GtkAlignment.Add(this.vbox3);
            this.frame1.Add(this.GtkAlignment);
            this.GtkLabel1 = new Gtk.Label();
            this.GtkLabel1.Name = "GtkLabel1";
            this.GtkLabel1.LabelProp = Mono.Unix.Catalog.GetString("<b>Code Generation</b>");
            this.GtkLabel1.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel1;
            this.vbox1.Add(this.frame1);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
            w8.Position = 0;
            w8.Expand = false;
            w8.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
        }
    }
}