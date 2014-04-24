
// This file has been generated by the GUI designer. Do not modify.
namespace CCExtractorTester
{
	public partial class ConfigWindow
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table3;
		private global::Gtk.Button btnCCExtractor;
		private global::Gtk.Button btnDefault;
		private global::Gtk.Button btnReport;
		private global::Gtk.Button btnResult;
		private global::Gtk.Button btnSample;
		private global::Gtk.Label lblCCExtractor;
		private global::Gtk.Label lblDefault;
		private global::Gtk.Label lblReport;
		private global::Gtk.Label lblResults;
		private global::Gtk.Label lblSample;
		private global::Gtk.Entry txtCCExtractor;
		private global::Gtk.Entry txtDefault;
		private global::Gtk.Entry txtReport;
		private global::Gtk.Entry txtResult;
		private global::Gtk.Entry txtSample;
		private global::Gtk.Button btnSave;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget CCExtractorTester.ConfigWindow
			this.Name = "CCExtractorTester.ConfigWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("ConfigWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowShrink = true;
			// Container child CCExtractorTester.ConfigWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.btnCCExtractor = new global::Gtk.Button ();
			this.btnCCExtractor.CanFocus = true;
			this.btnCCExtractor.Name = "btnCCExtractor";
			this.btnCCExtractor.UseUnderline = true;
			this.btnCCExtractor.Label = global::Mono.Unix.Catalog.GetString ("Select file");
			this.table3.Add (this.btnCCExtractor);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table3 [this.btnCCExtractor]));
			w1.TopAttach = ((uint)(3));
			w1.BottomAttach = ((uint)(4));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnDefault = new global::Gtk.Button ();
			this.btnDefault.CanFocus = true;
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.UseUnderline = true;
			this.btnDefault.Label = global::Mono.Unix.Catalog.GetString ("Select file");
			this.table3.Add (this.btnDefault);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3 [this.btnDefault]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnReport = new global::Gtk.Button ();
			this.btnReport.CanFocus = true;
			this.btnReport.Name = "btnReport";
			this.btnReport.UseUnderline = true;
			this.btnReport.Label = global::Mono.Unix.Catalog.GetString ("Select file");
			this.table3.Add (this.btnReport);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3 [this.btnReport]));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnResult = new global::Gtk.Button ();
			this.btnResult.CanFocus = true;
			this.btnResult.Name = "btnResult";
			this.btnResult.UseUnderline = true;
			this.btnResult.Label = global::Mono.Unix.Catalog.GetString ("Select file");
			this.table3.Add (this.btnResult);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.btnResult]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.btnSample = new global::Gtk.Button ();
			this.btnSample.CanFocus = true;
			this.btnSample.Name = "btnSample";
			this.btnSample.UseUnderline = true;
			this.btnSample.Label = global::Mono.Unix.Catalog.GetString ("Select file");
			this.table3.Add (this.btnSample);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.btnSample]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblCCExtractor = new global::Gtk.Label ();
			this.lblCCExtractor.Name = "lblCCExtractor";
			this.lblCCExtractor.LabelProp = global::Mono.Unix.Catalog.GetString ("CCExtractor file");
			this.table3.Add (this.lblCCExtractor);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblCCExtractor]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblDefault = new global::Gtk.Label ();
			this.lblDefault.Name = "lblDefault";
			this.lblDefault.LabelProp = global::Mono.Unix.Catalog.GetString ("Default tests");
			this.table3.Add (this.lblDefault);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblDefault]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblReport = new global::Gtk.Label ();
			this.lblReport.Name = "lblReport";
			this.lblReport.LabelProp = global::Mono.Unix.Catalog.GetString ("Report folder");
			this.table3.Add (this.lblReport);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblReport]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblResults = new global::Gtk.Label ();
			this.lblResults.Name = "lblResults";
			this.lblResults.LabelProp = global::Mono.Unix.Catalog.GetString ("Result folder");
			this.table3.Add (this.lblResults);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblResults]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lblSample = new global::Gtk.Label ();
			this.lblSample.Name = "lblSample";
			this.lblSample.LabelProp = global::Mono.Unix.Catalog.GetString ("Sample folder");
			this.table3.Add (this.lblSample);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table3 [this.lblSample]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtCCExtractor = new global::Gtk.Entry ();
			this.txtCCExtractor.CanFocus = true;
			this.txtCCExtractor.Name = "txtCCExtractor";
			this.txtCCExtractor.IsEditable = false;
			this.txtCCExtractor.InvisibleChar = '●';
			this.table3.Add (this.txtCCExtractor);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.txtCCExtractor]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtDefault = new global::Gtk.Entry ();
			this.txtDefault.CanFocus = true;
			this.txtDefault.Name = "txtDefault";
			this.txtDefault.IsEditable = false;
			this.txtDefault.InvisibleChar = '●';
			this.table3.Add (this.txtDefault);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table3 [this.txtDefault]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtReport = new global::Gtk.Entry ();
			this.txtReport.CanFocus = true;
			this.txtReport.Name = "txtReport";
			this.txtReport.IsEditable = false;
			this.txtReport.InvisibleChar = '●';
			this.table3.Add (this.txtReport);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table3 [this.txtReport]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtResult = new global::Gtk.Entry ();
			this.txtResult.CanFocus = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.IsEditable = false;
			this.txtResult.InvisibleChar = '●';
			this.table3.Add (this.txtResult);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3 [this.txtResult]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.txtSample = new global::Gtk.Entry ();
			this.txtSample.CanFocus = true;
			this.txtSample.Name = "txtSample";
			this.txtSample.IsEditable = false;
			this.txtSample.InvisibleChar = '●';
			this.table3.Add (this.txtSample);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3 [this.txtSample]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table3]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.btnSave = new global::Gtk.Button ();
			this.btnSave.CanFocus = true;
			this.btnSave.Name = "btnSave";
			this.btnSave.UseUnderline = true;
			this.btnSave.Label = global::Mono.Unix.Catalog.GetString ("Save configuration");
			this.vbox3.Add (this.btnSave);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.btnSave]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 242;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnSample.Clicked += new global::System.EventHandler (this.OnBtnSampleClicked);
			this.btnResult.Clicked += new global::System.EventHandler (this.OnBtnResultClicked);
			this.btnReport.Clicked += new global::System.EventHandler (this.OnBtnReportClicked);
			this.btnDefault.Clicked += new global::System.EventHandler (this.OnBtnDefaultClicked);
			this.btnCCExtractor.Clicked += new global::System.EventHandler (this.OnBtnCCExtractorClicked);
			this.btnSave.Clicked += new global::System.EventHandler (this.OnBtnSaveClicked);
		}
	}
}
