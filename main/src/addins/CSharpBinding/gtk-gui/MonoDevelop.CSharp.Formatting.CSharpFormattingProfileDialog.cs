
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Formatting
{
	public partial class CSharpFormattingProfileDialog
	{
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label5;
		private global::Gtk.Entry entryName;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label12;
		private global::Gtk.ComboBox comboboxCategories;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.Notebook notebookCategories;
		private global::Gtk.VBox vbox8;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewIndentOptions;
		private global::Gtk.Label GtkLabel;
		private global::Gtk.Label label8;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeviewBracePositions;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Label label9;
		private global::Gtk.Table table4;
		private global::Gtk.Entry entryAfterUsings;
		private global::Gtk.Entry entryBeforeFirstDeclaration;
		private global::Gtk.Entry entryBeforUsings;
		private global::Gtk.Entry entryBetweenEvents;
		private global::Gtk.Entry entryBetweenFields;
		private global::Gtk.Entry entryBetweenMembers;
		private global::Gtk.Entry entryBetweenTypes;
		private global::Gtk.Label GtkLabel8;
		private global::Gtk.Label GtkLabel9;
		private global::Gtk.Label label1;
		private global::Gtk.Label label15;
		private global::Gtk.Label label16;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
		private global::Gtk.Label label21;
		private global::Gtk.Label label22;
		private global::Gtk.Label label23;
		private global::Gtk.Label label14;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment4;
		private global::Gtk.VPaned vpaned1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TreeView treeviewInsertWhiteSpaceCategory;
		private global::Gtk.ScrolledWindow GtkScrolledWindow3;
		private global::Gtk.TreeView treeviewInsertWhiteSpaceOptions;
		private global::Gtk.Label GtkLabel5;
		private global::Gtk.Label label10;
		private global::Gtk.Frame frame4;
		private global::Gtk.Alignment GtkAlignment5;
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		private global::Gtk.TreeView treeviewNewLines;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.Label label11;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Label label13;
		private global::Gtk.ScrolledWindow scrolledwindow;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog
			this.Name = "MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_Name:");
			this.label5.UseUnderline = true;
			this.hbox3.Add (this.label5);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label5]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.hbox3.Add (this.entryName);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entryName]));
			w3.Position = 1;
			this.vbox5.Add (this.hbox3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("_Category:");
			this.label12.UseUnderline = true;
			this.hbox4.Add (this.label12);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label12]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.comboboxCategories = global::Gtk.ComboBox.NewText ();
			this.comboboxCategories.Name = "comboboxCategories";
			this.hbox4.Add (this.comboboxCategories);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.comboboxCategories]));
			w6.Position = 1;
			this.vbox5.Add (this.hbox4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox4]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 424;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.notebookCategories = new global::Gtk.Notebook ();
			this.notebookCategories.CanFocus = true;
			this.notebookCategories.Name = "notebookCategories";
			this.notebookCategories.CurrentPage = 2;
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewIndentOptions = new global::Gtk.TreeView ();
			this.treeviewIndentOptions.CanFocus = true;
			this.treeviewIndentOptions.Name = "treeviewIndentOptions";
			this.GtkScrolledWindow.Add (this.treeviewIndentOptions);
			this.GtkAlignment2.Add (this.GtkScrolledWindow);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel = new global::Gtk.Label ();
			this.GtkLabel.Name = "GtkLabel";
			this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Indent</b>");
			this.GtkLabel.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel;
			this.vbox8.Add (this.frame1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.frame1]));
			w11.Position = 0;
			this.notebookCategories.Add (this.vbox8);
			// Notebook tab
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebookCategories.SetTabLabel (this.vbox8, this.label8);
			this.label8.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewBracePositions = new global::Gtk.TreeView ();
			this.treeviewBracePositions.CanFocus = true;
			this.treeviewBracePositions.Name = "treeviewBracePositions";
			this.GtkScrolledWindow1.Add (this.treeviewBracePositions);
			this.GtkAlignment3.Add (this.GtkScrolledWindow1);
			this.frame2.Add (this.GtkAlignment3);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Brace positions</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel4;
			this.notebookCategories.Add (this.frame2);
			global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.frame2]));
			w16.Position = 1;
			// Notebook tab
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebookCategories.SetTabLabel (this.frame2, this.label9);
			this.label9.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.table4 = new global::Gtk.Table (((uint)(10)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.entryAfterUsings = new global::Gtk.Entry ();
			this.entryAfterUsings.CanFocus = true;
			this.entryAfterUsings.Name = "entryAfterUsings";
			this.entryAfterUsings.IsEditable = true;
			this.entryAfterUsings.InvisibleChar = '●';
			this.table4.Add (this.entryAfterUsings);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryAfterUsings]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBeforeFirstDeclaration = new global::Gtk.Entry ();
			this.entryBeforeFirstDeclaration.CanFocus = true;
			this.entryBeforeFirstDeclaration.Name = "entryBeforeFirstDeclaration";
			this.entryBeforeFirstDeclaration.IsEditable = true;
			this.entryBeforeFirstDeclaration.InvisibleChar = '●';
			this.table4.Add (this.entryBeforeFirstDeclaration);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBeforeFirstDeclaration]));
			w18.TopAttach = ((uint)(4));
			w18.BottomAttach = ((uint)(5));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(2));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBeforUsings = new global::Gtk.Entry ();
			this.entryBeforUsings.CanFocus = true;
			this.entryBeforUsings.Name = "entryBeforUsings";
			this.entryBeforUsings.IsEditable = true;
			this.entryBeforUsings.InvisibleChar = '●';
			this.table4.Add (this.entryBeforUsings);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBeforUsings]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenEvents = new global::Gtk.Entry ();
			this.entryBetweenEvents.CanFocus = true;
			this.entryBetweenEvents.Name = "entryBetweenEvents";
			this.entryBetweenEvents.IsEditable = true;
			this.entryBetweenEvents.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenEvents);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenEvents]));
			w20.TopAttach = ((uint)(8));
			w20.BottomAttach = ((uint)(9));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenFields = new global::Gtk.Entry ();
			this.entryBetweenFields.CanFocus = true;
			this.entryBetweenFields.Name = "entryBetweenFields";
			this.entryBetweenFields.IsEditable = true;
			this.entryBetweenFields.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenFields);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenFields]));
			w21.TopAttach = ((uint)(7));
			w21.BottomAttach = ((uint)(8));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenMembers = new global::Gtk.Entry ();
			this.entryBetweenMembers.CanFocus = true;
			this.entryBetweenMembers.Name = "entryBetweenMembers";
			this.entryBetweenMembers.IsEditable = true;
			this.entryBetweenMembers.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenMembers);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenMembers]));
			w22.TopAttach = ((uint)(9));
			w22.BottomAttach = ((uint)(10));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenTypes = new global::Gtk.Entry ();
			this.entryBetweenTypes.CanFocus = true;
			this.entryBetweenTypes.Name = "entryBetweenTypes";
			this.entryBetweenTypes.IsEditable = true;
			this.entryBetweenTypes.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenTypes);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenTypes]));
			w23.TopAttach = ((uint)(5));
			w23.BottomAttach = ((uint)(6));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.GtkLabel8 = new global::Gtk.Label ();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.Xalign = 0F;
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in namespaces</b>");
			this.GtkLabel8.UseMarkup = true;
			this.table4.Add (this.GtkLabel8);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table4 [this.GtkLabel8]));
			w24.TopAttach = ((uint)(3));
			w24.BottomAttach = ((uint)(4));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.GtkLabel9 = new global::Gtk.Label ();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.Xalign = 0F;
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in types</b>");
			this.GtkLabel9.UseMarkup = true;
			this.table4.Add (this.GtkLabel9);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4 [this.GtkLabel9]));
			w25.TopAttach = ((uint)(6));
			w25.BottomAttach = ((uint)(7));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in compilation unit</b>");
			this.label1.UseMarkup = true;
			this.table4.Add (this.label1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4 [this.label1]));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Before using declaration:");
			this.table4.Add (this.label15);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table4 [this.label15]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 1F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("After using declaration:");
			this.table4.Add (this.label16);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table4 [this.label16]));
			w28.TopAttach = ((uint)(2));
			w28.BottomAttach = ((uint)(3));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.Xalign = 1F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Between type declarations:");
			this.table4.Add (this.label19);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table4 [this.label19]));
			w29.TopAttach = ((uint)(5));
			w29.BottomAttach = ((uint)(6));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 1F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Before first declaration:");
			this.table4.Add (this.label20);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table4 [this.label20]));
			w30.TopAttach = ((uint)(4));
			w30.BottomAttach = ((uint)(5));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 1F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Between field declarations:");
			this.table4.Add (this.label21);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table4 [this.label21]));
			w31.TopAttach = ((uint)(7));
			w31.BottomAttach = ((uint)(8));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.Xalign = 1F;
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Between other member declarations:");
			this.table4.Add (this.label22);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table4 [this.label22]));
			w32.TopAttach = ((uint)(9));
			w32.BottomAttach = ((uint)(10));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.Xalign = 1F;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Between simple event declarations:");
			this.table4.Add (this.label23);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table4 [this.label23]));
			w33.TopAttach = ((uint)(8));
			w33.BottomAttach = ((uint)(9));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebookCategories.Add (this.table4);
			global::Gtk.Notebook.NotebookChild w34 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.table4]));
			w34.Position = 2;
			// Notebook tab
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("page5");
			this.notebookCategories.SetTabLabel (this.table4, this.label14);
			this.label14.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.vpaned1 = new global::Gtk.VPaned ();
			this.vpaned1.CanFocus = true;
			this.vpaned1.Name = "vpaned1";
			this.vpaned1.Position = 168;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.treeviewInsertWhiteSpaceCategory = new global::Gtk.TreeView ();
			this.treeviewInsertWhiteSpaceCategory.CanFocus = true;
			this.treeviewInsertWhiteSpaceCategory.Name = "treeviewInsertWhiteSpaceCategory";
			this.GtkScrolledWindow2.Add (this.treeviewInsertWhiteSpaceCategory);
			this.vpaned1.Add (this.GtkScrolledWindow2);
			global::Gtk.Paned.PanedChild w36 = ((global::Gtk.Paned.PanedChild)(this.vpaned1 [this.GtkScrolledWindow2]));
			w36.Resize = false;
			// Container child vpaned1.Gtk.Paned+PanedChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.treeviewInsertWhiteSpaceOptions = new global::Gtk.TreeView ();
			this.treeviewInsertWhiteSpaceOptions.CanFocus = true;
			this.treeviewInsertWhiteSpaceOptions.Name = "treeviewInsertWhiteSpaceOptions";
			this.treeviewInsertWhiteSpaceOptions.HeadersVisible = false;
			this.GtkScrolledWindow3.Add (this.treeviewInsertWhiteSpaceOptions);
			this.vpaned1.Add (this.GtkScrolledWindow3);
			this.GtkAlignment4.Add (this.vpaned1);
			this.frame3.Add (this.GtkAlignment4);
			this.GtkLabel5 = new global::Gtk.Label ();
			this.GtkLabel5.Name = "GtkLabel5";
			this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Insert Space</b>");
			this.GtkLabel5.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel5;
			this.notebookCategories.Add (this.frame3);
			global::Gtk.Notebook.NotebookChild w41 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.frame3]));
			w41.Position = 3;
			// Notebook tab
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebookCategories.SetTabLabel (this.frame3, this.label10);
			this.label10.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.treeviewNewLines = new global::Gtk.TreeView ();
			this.treeviewNewLines.CanFocus = true;
			this.treeviewNewLines.Name = "treeviewNewLines";
			this.GtkScrolledWindow4.Add (this.treeviewNewLines);
			this.GtkAlignment5.Add (this.GtkScrolledWindow4);
			this.frame4.Add (this.GtkAlignment5);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>New Lines</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel6;
			this.notebookCategories.Add (this.frame4);
			global::Gtk.Notebook.NotebookChild w45 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.frame4]));
			w45.Position = 4;
			// Notebook tab
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("page4");
			this.notebookCategories.SetTabLabel (this.frame4, this.label11);
			this.label11.ShowAll ();
			this.hpaned1.Add (this.notebookCategories);
			global::Gtk.Paned.PanedChild w46 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.notebookCategories]));
			w46.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview:");
			this.vbox6.Add (this.label13);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label13]));
			w47.Position = 0;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.scrolledwindow = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow.CanFocus = true;
			this.scrolledwindow.Name = "scrolledwindow";
			this.scrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox6.Add (this.scrolledwindow);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.scrolledwindow]));
			w48.Position = 1;
			this.hpaned1.Add (this.vbox6);
			this.vbox5.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hpaned1]));
			w50.Position = 2;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox5]));
			w51.Position = 0;
			// Internal child MonoDevelop.CSharp.Formatting.CSharpFormattingProfileDialog.ActionArea
			global::Gtk.HButtonBox w52 = this.ActionArea;
			w52.Name = "dialog1_ActionArea";
			w52.Spacing = 10;
			w52.BorderWidth = ((uint)(5));
			w52.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w53 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w52 [this.buttonCancel]));
			w53.Expand = false;
			w53.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w54 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w52 [this.buttonOk]));
			w54.Position = 1;
			w54.Expand = false;
			w54.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 880;
			this.DefaultHeight = 551;
			this.label5.MnemonicWidget = this.entryName;
			this.Hide ();
		}
	}
}
